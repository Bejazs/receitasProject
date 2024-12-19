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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dificultyBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipiesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pessoas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Grau de dificuldade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tempo de preparação";
            // 
            // NomeBox
            // 
            this.NomeBox.Location = new System.Drawing.Point(15, 55);
            this.NomeBox.Name = "NomeBox";
            this.NomeBox.Size = new System.Drawing.Size(121, 22);
            this.NomeBox.TabIndex = 4;
            this.NomeBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Categoria";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(15, 218);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(275, 135);
            this.descriptionBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
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
            this.categoryBox.Location = new System.Drawing.Point(169, 113);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(121, 24);
            this.categoryBox.TabIndex = 13;
            // 
            // dificultyBox
            // 
            this.dificultyBox.Location = new System.Drawing.Point(12, 115);
            this.dificultyBox.Name = "dificultyBox";
            this.dificultyBox.Size = new System.Drawing.Size(123, 22);
            this.dificultyBox.TabIndex = 14;
            // 
            // recipiesTable
            // 
            this.recipiesTable.AllowUserToAddRows = false;
            this.recipiesTable.AllowUserToDeleteRows = false;
            this.recipiesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recipiesTable.Location = new System.Drawing.Point(360, 174);
            this.recipiesTable.Name = "recipiesTable";
            this.recipiesTable.ReadOnly = true;
            this.recipiesTable.RowHeadersWidth = 51;
            this.recipiesTable.RowTemplate.Height = 24;
            this.recipiesTable.Size = new System.Drawing.Size(982, 479);
            this.recipiesTable.TabIndex = 15;
            this.recipiesTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.recipiesTable_CellContentClick_1);
            this.recipiesTable.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.recipiesTable_RowHeaderMouseDoubleClick);
            this.recipiesTable.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.recipiesTable_RowHeaderMouseDoubleClick);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(132, 385);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 16;
            this.save.Text = "Gravar";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // timeBox
            // 
            this.timeBox.Location = new System.Drawing.Point(169, 56);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(123, 22);
            this.timeBox.TabIndex = 17;
            // 
            // personsBox
            // 
            this.personsBox.Location = new System.Drawing.Point(12, 174);
            this.personsBox.Name = "personsBox";
            this.personsBox.Size = new System.Drawing.Size(123, 22);
            this.personsBox.TabIndex = 18;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(215, 385);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 19;
            this.Delete.Text = "Eliminar";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(993, 53);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(123, 22);
            this.numericUpDown1.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(990, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Grau de dificuldade";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(993, 110);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(123, 22);
            this.numericUpDown2.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(990, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Tempo de preparação";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Carne",
            "Peixe",
            "Marisco",
            "Sobremesas",
            "Pastelaria"});
            this.comboBox1.Location = new System.Drawing.Point(1182, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1179, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "Categoria";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1182, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1267, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "Filtrar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 665);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.numericUpDown1);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dificultyBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipiesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

