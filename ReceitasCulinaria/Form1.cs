using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace ReceitasCulinaria
{
    public partial class Form1 : Form
    {

        public const string FILENAME = "./saveRecipies.txt";

        BindingList<Recipie> recipies;
        BindingList<Recipie> recipiesFiltered;
        BindingList<Ingridients> ingridients;
        BindingList<Ingridients> ingridientsDetails;

        Guid? selectedId;        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            var content = JsonConvert.DeserializeObject<List<Recipie>>(readFromFile());

            // prepare data biding and tables
            if (content != null) recipies = new BindingList<Recipie>(content);
            else recipies = new BindingList<Recipie>();

            ingridients = new BindingList<Ingridients>();

            recipiesTable.DataSource = recipies;
            ingridientTable.DataSource = ingridients;

            //Custom properties and need options
            recipiesTable.Columns["Id"].Visible = false;
            ingridients.Add(new Ingridients { Nome = "", Quanitidade = 0, Unidade = "" });
        }

        private void save_Click(object sender, EventArgs e)
        {
            var item = new Recipie
            {
                Id = Guid.NewGuid(),
                Nome = NomeBox.Text,
                Tempo = string.IsNullOrEmpty(timeBox.Text) ? 0 : int.Parse(timeBox.Text),
                Dificuldade = dificultyBox.Text,
                Pessoas = string.IsNullOrEmpty(personsBox.Text) ? 0 : int.Parse(personsBox.Text),
                Categoria = categoryBox.Text,
                Descricao = descriptionBox.Text,
                Ingredientes = ingridients.ToList(),
            };

            if (selectedId != null)
            {
                var index = recipies.ToList().FindIndex(x => x.Id == selectedId);
                recipies[index] = item;
            }
            else
            {
                recipies.Add(item);
            }

            CleanSelectedPanel();
        }

        private void recipiesTable_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) => SelectItem(e.RowIndex);

        private void recipiesTable_RowHeaderMouseDoubleClick(object sender, DataGridViewCellEventArgs e) => SelectItem(e.RowIndex);

        public void SelectItem(int rowIndex)
        {
            var id = (Guid)recipiesTable.Rows[rowIndex].Cells[0].Value;

            setSelectedPanel(recipies.Where(x => x.Id == id).FirstOrDefault());

        }

        public void setSelectedPanel(Recipie item)
        {
            if (item != null)
            {
                selectedId = item.Id;

                NomeBox.Text = item.Nome;
                timeBox.Text = item.Tempo.ToString();
                dificultyBox.Text = item.Dificuldade.ToString();
                categoryBox.Text = item.Categoria;
                descriptionBox.Text = item.Descricao;

                //new binding
                ingridientsDetails = new BindingList<Ingridients>(item.Ingredientes);
                detailsIngridientsTable.DataSource = ingridientsDetails;


            }
        }

        private void ClearSelected_Click(object sender, EventArgs e) => CleanSelectedPanel();

        public void CleanSelectedPanel()
        {
            NomeBox.Text = "";
            timeBox.Text = "";
            dificultyBox.Text = "";
            categoryBox.Text = "";
            descriptionBox.Text = "";
            personsBox.Text = "";
            ingridients.Clear();

            //details
            ingridientsDetails = null;
            detailsIngridientsTable.DataSource = null;
            selectedId = null;
        }



        private void Delete_Click(object sender, EventArgs e)
        {
            if (selectedId != null)
            {
                recipies.Remove(recipies.Where(x => x.Id == selectedId).FirstOrDefault());
                CleanSelectedPanel();
            }
        }

        private void OnClose(object sender, FormClosingEventArgs e) => printIntoFile();

        private void Filter_Click(object sender, EventArgs e)
        {

            var filtered = recipies.ToList().Where(x => !string.IsNullOrEmpty(FilterCategoryBox.Text) ? x.Categoria.Equals(FilterCategoryBox.Text) : true &&
            !string.IsNullOrEmpty(FilterTimeBox.Text) && int.Parse(FilterTimeBox.Text) != 0 ? x.Tempo.Equals(int.Parse(FilterTimeBox.Text)) : true &&
            !string.IsNullOrEmpty(FilterDificultyBox.Text) && int.Parse(FilterDificultyBox.Text) != 0 ? x.Dificuldade.Equals(int.Parse(FilterDificultyBox.Text)) : true
            ).ToList();

            recipiesFiltered = new BindingList<Recipie>(filtered);

            recipiesTable.DataSource = recipiesFiltered;
        }


        public void printIntoFile()
        {
            FileStream fileStream = new FileStream(FILENAME, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fileStream);
            
            var jsonContent = JsonConvert.SerializeObject(recipies);
            writer.Write(jsonContent);

            writer.Close();
            fileStream.Close();
        }


        public string readFromFile()
        {
            FileStream fileStream = new FileStream(FILENAME, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(fileStream);
            string content = reader.ReadToEnd();

            reader.Close();
            fileStream.Close();

            return content;
        }

        private void CleanFilters_Click(object sender, EventArgs e)
        {
            recipiesFiltered = null;
            recipiesTable.DataSource = recipies;
        }
    }
}
