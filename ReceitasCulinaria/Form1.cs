using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace ReceitasCulinaria
{
    public partial class Form1 : Form
    {

        BindingList<Recipie> recipies;
        Guid selectedId;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            recipies = new BindingList<Recipie>();
            recipiesTable.DataSource = recipies;
            recipiesTable.Columns["Id"].Visible = false;
        }

        private void Filtros_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void recipiesTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void recipiesTable_RowsAdded(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            try
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
                    Ingredientes = ""
                };
                recipies.Add(item);

                CleanSelectedPanel();
            }
            catch (Exception ex)
            {
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void recipiesTable_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

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
            }
        }

        public void CleanSelectedPanel()
        {

            NomeBox.Text = "";
            timeBox.Text = "";
            dificultyBox.Text = "";
            categoryBox.Text = "";
            descriptionBox.Text = "";

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (selectedId != null)
            {
                recipies.Remove(recipies.Where(x => x.Id == selectedId).FirstOrDefault());
                CleanSelectedPanel();
            }
        }
    }
}
