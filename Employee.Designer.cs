namespace GestionEmplyee
{
    partial class Employee
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
            panel1 = new Panel();
            button1 = new Button();
            groupBox1 = new GroupBox();
            rafBtn = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            DelBtn = new Button();
            AddBtn = new Button();
            EnrBtn = new Button();
            label7 = new Label();
            SalaireTextBox = new TextBox();
            label6 = new Label();
            phoneTextBox = new TextBox();
            label5 = new Label();
            EmailTextBox = new TextBox();
            label4 = new Label();
            DepartementTextBox = new TextBox();
            prenomTextBox = new TextBox();
            NomTextBox = new TextBox();
            autoIDTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            statusStrip1 = new StatusStrip();
            positionLabel = new ToolStripStatusLabel();
            KeywordTextBox = new TextBox();
            search = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumOrchid;
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(717, 47);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(663, 3);
            button1.Name = "button1";
            button1.Size = new Size(42, 35);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rafBtn);
            groupBox1.Controls.Add(button10);
            groupBox1.Controls.Add(button9);
            groupBox1.Controls.Add(button8);
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(DelBtn);
            groupBox1.Controls.Add(AddBtn);
            groupBox1.Controls.Add(EnrBtn);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(SalaireTextBox);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(phoneTextBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(EmailTextBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(DepartementTextBox);
            groupBox1.Controls.Add(prenomTextBox);
            groupBox1.Controls.Add(NomTextBox);
            groupBox1.Controls.Add(autoIDTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(661, 209);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // rafBtn
            // 
            rafBtn.Location = new Point(499, 119);
            rafBtn.Name = "rafBtn";
            rafBtn.Size = new Size(156, 23);
            rafBtn.TabIndex = 24;
            rafBtn.Text = "Rafraîchir";
            rafBtn.UseVisualStyleBackColor = true;
            rafBtn.Click += rafBtn_Click;
            // 
            // button10
            // 
            button10.Location = new Point(499, 90);
            button10.Name = "button10";
            button10.Size = new Size(156, 23);
            button10.TabIndex = 23;
            button10.Text = "menu";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.Location = new Point(580, 180);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 22;
            button9.Text = ">|";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Location = new Point(499, 180);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 21;
            button8.Text = ">";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(421, 180);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 20;
            button7.Text = "<";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(340, 180);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 19;
            button6.Text = "|<";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(580, 56);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 18;
            button5.Text = "Exit";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // DelBtn
            // 
            DelBtn.Location = new Point(499, 56);
            DelBtn.Name = "DelBtn";
            DelBtn.Size = new Size(75, 23);
            DelBtn.TabIndex = 17;
            DelBtn.Text = "Supprimer";
            DelBtn.UseVisualStyleBackColor = true;
            DelBtn.Click += DelBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.RosyBrown;
            AddBtn.Location = new Point(580, 24);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(75, 23);
            AddBtn.TabIndex = 16;
            AddBtn.Text = "Ajouter";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // EnrBtn
            // 
            EnrBtn.Location = new Point(499, 24);
            EnrBtn.Name = "EnrBtn";
            EnrBtn.Size = new Size(75, 23);
            EnrBtn.TabIndex = 15;
            EnrBtn.Text = "Enregistrer";
            EnrBtn.UseVisualStyleBackColor = true;
            EnrBtn.Click += EnrBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 145);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 14;
            label7.Text = "Salaire";
            // 
            // SalaireTextBox
            // 
            SalaireTextBox.Location = new Point(6, 168);
            SalaireTextBox.Name = "SalaireTextBox";
            SalaireTextBox.Size = new Size(100, 23);
            SalaireTextBox.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(249, 90);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 12;
            label6.Text = "Phone";
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(249, 115);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(112, 23);
            phoneTextBox.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(123, 90);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 10;
            label5.Text = "Email";
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(123, 115);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(112, 23);
            EmailTextBox.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 90);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 8;
            label4.Text = "Departement";
            // 
            // DepartementTextBox
            // 
            DepartementTextBox.Location = new Point(6, 115);
            DepartementTextBox.Name = "DepartementTextBox";
            DepartementTextBox.Size = new Size(100, 23);
            DepartementTextBox.TabIndex = 7;
            // 
            // prenomTextBox
            // 
            prenomTextBox.Location = new Point(249, 56);
            prenomTextBox.Name = "prenomTextBox";
            prenomTextBox.Size = new Size(112, 23);
            prenomTextBox.TabIndex = 6;
            // 
            // NomTextBox
            // 
            NomTextBox.Location = new Point(123, 56);
            NomTextBox.Name = "NomTextBox";
            NomTextBox.Size = new Size(112, 23);
            NomTextBox.TabIndex = 4;
            // 
            // autoIDTextBox
            // 
            autoIDTextBox.Location = new Point(6, 56);
            autoIDTextBox.Name = "autoIDTextBox";
            autoIDTextBox.Size = new Size(100, 23);
            autoIDTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(249, 32);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 2;
            label3.Text = "Prenom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 32);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 1;
            label2.Text = "Nom";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 32);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "AutoID";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(12, 312);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(661, 249);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(655, 227);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { positionLabel });
            statusStrip1.Location = new Point(0, 573);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(717, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // positionLabel
            // 
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new Size(70, 17);
            positionLabel.Text = "Position:0/0";
            // 
            // KeywordTextBox
            // 
            KeywordTextBox.Location = new Point(20, 283);
            KeywordTextBox.Name = "KeywordTextBox";
            KeywordTextBox.Size = new Size(514, 23);
            KeywordTextBox.TabIndex = 4;
            // 
            // search
            // 
            search.Location = new Point(551, 282);
            search.Name = "search";
            search.Size = new Size(75, 23);
            search.TabIndex = 5;
            search.Text = "Recherche";
            search.UseVisualStyleBackColor = true;
            search.Click += search_Click;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 595);
            Controls.Add(search);
            Controls.Add(KeywordTextBox);
            Controls.Add(statusStrip1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Employee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee";
            Load += Employee_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel positionLabel;
        private TextBox NomTextBox;
        private TextBox autoIDTextBox;
        private Label label3;
        private Label label2;
        private Label label6;
        private TextBox phoneTextBox;
        private Label label5;
        private TextBox EmailTextBox;
        private Label label4;
        private TextBox DepartementTextBox;
        private TextBox prenomTextBox;
        private Label label7;
        private TextBox SalaireTextBox;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button DelBtn;
        private Button AddBtn;
        private Button EnrBtn;
        private DataGridView dataGridView1;
        private Button rafBtn;
        private TextBox KeywordTextBox;
        private Button search;
    }
}