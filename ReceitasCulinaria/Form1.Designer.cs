namespace ReceitasCulinaria
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NomeBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.dificultyBox = new System.Windows.Forms.NumericUpDown();
            this.recipiesTable = new System.Windows.Forms.DataGridView();
            this.save = new System.Windows.Forms.Button();
            this.timeBox = new System.Windows.Forms.NumericUpDown();
            this.personsBox = new System.Windows.Forms.NumericUpDown();
            this.Delete = new System.Windows.Forms.Button();
            this.FilterDificultyBox = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.FilterTimeBox = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.FilterCategoryBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.detailsIngridientsTable = new System.Windows.Forms.DataGridView();
            this.ingridientTable = new System.Windows.Forms.DataGridView();
            this.Ingredientes = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dificultyBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipiesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilterDificultyBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilterTimeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsIngridientsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingridientTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pessoas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Grau de dificuldade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tempo de preparação";
            // 
            // NomeBox
            // 
            this.NomeBox.Location = new System.Drawing.Point(11, 45);
            this.NomeBox.Margin = new System.Windows.Forms.Padding(2);
            this.NomeBox.Name = "NomeBox";
            this.NomeBox.Size = new System.Drawing.Size(92, 20);
            this.NomeBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Categoria";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(11, 177);
            this.descriptionBox.Margin = new System.Windows.Forms.Padding(2);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(225, 110);
            this.descriptionBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 162);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Descrição";
            // 
            // categoryBox
            // 
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Items.AddRange(new object[] {
            "Carne",
            "Peixe",
            "Marisco",
            "Sobremesas",
            "Pastelaria"});
            this.categoryBox.Location = new System.Drawing.Point(127, 92);
            this.categoryBox.Margin = new System.Windows.Forms.Padding(2);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(92, 21);
            this.categoryBox.TabIndex = 13;
            // 
            // dificultyBox
            // 
            this.dificultyBox.Location = new System.Drawing.Point(11, 93);
            this.dificultyBox.Margin = new System.Windows.Forms.Padding(2);
            this.dificultyBox.Name = "dificultyBox";
            this.dificultyBox.Size = new System.Drawing.Size(92, 20);
            this.dificultyBox.TabIndex = 14;
            // 
            // recipiesTable
            // 
            this.recipiesTable.AllowUserToAddRows = false;
            this.recipiesTable.AllowUserToDeleteRows = false;
            this.recipiesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recipiesTable.Location = new System.Drawing.Point(270, 141);
            this.recipiesTable.Margin = new System.Windows.Forms.Padding(2);
            this.recipiesTable.Name = "recipiesTable";
            this.recipiesTable.ReadOnly = true;
            this.recipiesTable.RowHeadersWidth = 51;
            this.recipiesTable.RowTemplate.Height = 24;
            this.recipiesTable.Size = new System.Drawing.Size(516, 389);
            this.recipiesTable.TabIndex = 15;
            this.recipiesTable.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.recipiesTable_RowHeaderMouseDoubleClick);
            this.recipiesTable.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.recipiesTable_RowHeaderMouseDoubleClick);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(118, 488);
            this.save.Margin = new System.Windows.Forms.Padding(2);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(56, 19);
            this.save.TabIndex = 16;
            this.save.Text = "Gravar";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // timeBox
            // 
            this.timeBox.Location = new System.Drawing.Point(127, 46);
            this.timeBox.Margin = new System.Windows.Forms.Padding(2);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(92, 20);
            this.timeBox.TabIndex = 17;
            // 
            // personsBox
            // 
            this.personsBox.Location = new System.Drawing.Point(12, 140);
            this.personsBox.Margin = new System.Windows.Forms.Padding(2);
            this.personsBox.Name = "personsBox";
            this.personsBox.Size = new System.Drawing.Size(92, 20);
            this.personsBox.TabIndex = 18;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(180, 488);
            this.Delete.Margin = new System.Windows.Forms.Padding(2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(56, 19);
            this.Delete.TabIndex = 19;
            this.Delete.Text = "Eliminar";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // FilterDificultyBox
            // 
            this.FilterDificultyBox.Location = new System.Drawing.Point(270, 45);
            this.FilterDificultyBox.Margin = new System.Windows.Forms.Padding(2);
            this.FilterDificultyBox.Name = "FilterDificultyBox";
            this.FilterDificultyBox.Size = new System.Drawing.Size(120, 20);
            this.FilterDificultyBox.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(266, 27);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Grau de dificuldade";
            // 
            // FilterTimeBox
            // 
            this.FilterTimeBox.Location = new System.Drawing.Point(466, 45);
            this.FilterTimeBox.Margin = new System.Windows.Forms.Padding(2);
            this.FilterTimeBox.Name = "FilterTimeBox";
            this.FilterTimeBox.Size = new System.Drawing.Size(120, 20);
            this.FilterTimeBox.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(463, 26);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Tempo de preparação";
            // 
            // FilterCategoryBox
            // 
            this.FilterCategoryBox.FormattingEnabled = true;
            this.FilterCategoryBox.Items.AddRange(new object[] {
            "Carne",
            "Peixe",
            "Marisco",
            "Sobremesas",
            "Pastelaria"});
            this.FilterCategoryBox.Location = new System.Drawing.Point(665, 44);
            this.FilterCategoryBox.Margin = new System.Windows.Forms.Padding(2);
            this.FilterCategoryBox.Name = "FilterCategoryBox";
            this.FilterCategoryBox.Size = new System.Drawing.Size(121, 21);
            this.FilterCategoryBox.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(663, 24);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Categoria";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(666, 94);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 27;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Filter_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(730, 94);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 19);
            this.button2.TabIndex = 28;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CleanFilters_Click);
            // 
            // detailsIngridientsTable
            // 
            this.detailsIngridientsTable.AllowUserToAddRows = false;
            this.detailsIngridientsTable.AllowUserToDeleteRows = false;
            this.detailsIngridientsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailsIngridientsTable.Location = new System.Drawing.Point(791, 142);
            this.detailsIngridientsTable.Name = "detailsIngridientsTable";
            this.detailsIngridientsTable.ReadOnly = true;
            this.detailsIngridientsTable.Size = new System.Drawing.Size(220, 228);
            this.detailsIngridientsTable.TabIndex = 29;
            // 
            // ingridientTable
            // 
            this.ingridientTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ingridientTable.Location = new System.Drawing.Point(9, 323);
            this.ingridientTable.Name = "ingridientTable";
            this.ingridientTable.Size = new System.Drawing.Size(227, 137);
            this.ingridientTable.TabIndex = 30;
            // 
            // Ingredientes
            // 
            this.Ingredientes.AutoSize = true;
            this.Ingredientes.Location = new System.Drawing.Point(8, 307);
            this.Ingredientes.Name = "Ingredientes";
            this.Ingredientes.Size = new System.Drawing.Size(65, 13);
            this.Ingredientes.TabIndex = 31;
            this.Ingredientes.Text = "Ingredientes";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(11, 488);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 19);
            this.button3.TabIndex = 32;
            this.button3.Text = "Limpar Seleção";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ClearSelected_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(270, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Tabela de Receitas";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(788, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Detalhes (Ingredientes)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 540);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Ingredientes);
            this.Controls.Add(this.ingridientTable);
            this.Controls.Add(this.detailsIngridientsTable);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.FilterTimeBox);
            this.Controls.Add(this.FilterCategoryBox);
            this.Controls.Add(this.FilterDificultyBox);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.personsBox);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.save);
            this.Controls.Add(this.recipiesTable);
            this.Controls.Add(this.dificultyBox);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NomeBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClose);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dificultyBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipiesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilterDificultyBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilterTimeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsIngridientsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingridientTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NomeBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.NumericUpDown dificultyBox;
        private System.Windows.Forms.DataGridView recipiesTable;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.NumericUpDown timeBox;
        private System.Windows.Forms.NumericUpDown personsBox;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.NumericUpDown FilterDificultyBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown FilterTimeBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox FilterCategoryBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView detailsIngridientsTable;
        private System.Windows.Forms.DataGridView ingridientTable;
        private System.Windows.Forms.Label Ingredientes;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
    }
}

