
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEmplyee
{
    public partial class Employee : Form
    {

        private static string dbCommand = "";
        private static BindingSource bindingSrc;
        private static string dbPath = Application.StartupPath + "\\" + "data_table.db;";
        private static string conString = "Data source=" + dbPath + ";Version=3;New=False;Compress=True;";
        private static SQLiteConnection connection = new SQLiteConnection(conString);
        private static SQLiteCommand command = new SQLiteCommand("", connection);
        private static string sql;



        public Employee()
        {
            InitializeComponent();
            this.autoIDTextBox.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            home obj = new home();
            obj.Show();
            this.Hide();
        }


        private void displayPosition()
        {
            positionLabel.Text = "Position :" + Convert.ToString(bindingSrc.Position + 1) + "/" + bindingSrc.Count.ToString();
        }
        private void UpdateDataBiding(SQLiteCommand cmd = null)
        {
            try
            {
                TextBox tb;
                foreach (Control c in groupBox2.Controls)
                {
                    if (c.GetType() == typeof(TextBox))
                    {
                        tb = (TextBox)c;
                        tb.DataBindings.Clear();
                        tb.Text = "";
                    }
                }
                dbCommand = "SELECT";
                sql = "SELECT * FROM employees ORDER BY AutoID ASC ; ";
                if (cmd == null)
                {
                    command.CommandText = sql;
                }
                else
                {
                    command = cmd;

                }
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                DataSet dataSt = new DataSet();
                adapter.Fill(dataSt, "employees");
                bindingSrc = new BindingSource();
                bindingSrc.DataSource = dataSt.Tables["employees"];
                //simple Data Binding
                autoIDTextBox.DataBindings.Add("Text", bindingSrc, "AutoID");
                NomTextBox.DataBindings.Add("Text", bindingSrc, "Nom");
                prenomTextBox.DataBindings.Add("Text", bindingSrc, "Prenom");
                DepartementTextBox.DataBindings.Add("Text", bindingSrc, "Departement");
                EmailTextBox.DataBindings.Add("Text", bindingSrc, "Email");
                phoneTextBox.DataBindings.Add("Text", bindingSrc, "Phone");
                SalaireTextBox.DataBindings.Add("Text", bindingSrc, "Salaire");

                dataGridView1.Enabled = true;
                dataGridView1.DataSource = bindingSrc;

                dataGridView1.AutoResizeColumns((DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                dataGridView1.Columns[0].Width = 70;//autoId column



                displayPosition();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Binding Error :" + ex.Message.ToString(), "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                //MessageBox.Show("the connection is :" + connection.State.ToString());
            }
        }

        private void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                //MessageBox.Show("the connection is :" + connection.State.ToString());
            }
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            openConnection();
            closeConnection();
            UpdateDataBiding();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bindingSrc.MoveFirst();
            displayPosition();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bindingSrc.MovePrevious();
            displayPosition();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bindingSrc.MoveNext();
            displayPosition();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            bindingSrc.MoveLast();
            displayPosition();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                displayPosition();

            }
            catch (Exception) { }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }

        private void rafBtn_Click(object sender, EventArgs e)
        {
            if (AddBtn.Text.Equals("Cancel"))
            {
                return;
            }
            UpdateDataBiding() ;    
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (AddBtn.Text == "Add New")
                {
                    AddBtn.Text = "Cancel";
                    positionLabel.Text = "Position:0/0";
                    dataGridView1.Enabled = false;
                }
                else
                {
                    AddBtn.Text = "Add New";
                    UpdateDataBiding();
                    return;
                }
                TextBox txt;
                foreach (Control c in groupBox1.Controls)
                {
                    if (c.GetType() == typeof(TextBox))
                    {
                        txt = (TextBox)c;
                        txt.DataBindings.Clear();
                        txt.Text = "";
                        if (txt.Name.Equals("NomTextBox"))
                        {
                            if (txt.CanFocus)
                            {
                                txt.Focus();
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void addCmdParameters()
        {
            command.Parameters.Clear();
            command.CommandText = sql;
            command.Parameters.AddWithValue("Nom", NomTextBox.Text.Trim());
            command.Parameters.AddWithValue("Prenom", prenomTextBox.Text.Trim());
            command.Parameters.AddWithValue("Departement", DepartementTextBox.Text.Trim());
            command.Parameters.AddWithValue("Email", EmailTextBox.Text.Trim());
            command.Parameters.AddWithValue("Phone", phoneTextBox.Text.Trim());
            command.Parameters.AddWithValue("Salaire", SalaireTextBox.Text.Trim());
            if (dbCommand.ToUpper() == "UPDATE")
            {
                command.Parameters.AddWithValue("AutoID", autoIDTextBox.Text.Trim());
            }
        }
        private void EnrBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NomTextBox.Text.Trim()) || string.IsNullOrEmpty(prenomTextBox.Text.Trim())
                || string.IsNullOrEmpty(DepartementTextBox.Text.Trim()) || string.IsNullOrEmpty(EmailTextBox.Text.Trim())
                || string.IsNullOrEmpty(SalaireTextBox.Text.Trim()))
            {
                MessageBox.Show("please fill in the required.", "Add New Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            openConnection();
            try
            {
                if (AddBtn.Text == "Add New")
                {
                    if (autoIDTextBox.Text.Trim() == "" || string.IsNullOrEmpty(autoIDTextBox.Text.Trim()))
                    {
                        MessageBox.Show("please select an item.");
                        return;
                    }
                    if (MessageBox.Show("ID:" + autoIDTextBox.Text.Trim() + "--DO you want to update the selected record?", "Visual C# and SQLite(UPDATE):"
                        , MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    {
                        return;
                    }
                    dbCommand = "UPDATE";
                    sql = "UPDATE employees SET Nom=@Nom,Prenom=@Prenom,Departement=@Departement,Email=@Email,Salaire=@Salaire,Phone=@Phone WHERE AutoID=@AutoID";
                    addCmdParameters();
                }
                else if (AddBtn.Text.Equals("Cancel"))
                {
                    DialogResult result;
                    result = MessageBox.Show("Do you want to ass a new employee record?(Y/N)", "Visual C# and SQLite (INSER)", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        dbCommand = "INSERT";
                        sql = "INSERT INTO employees(Nom,Prenom,Departement,Email,Salaire,Phone) " + "VALUES(@Nom,@Prenom,@Departement,@Email,@Salaire,@Phone)";
                        addCmdParameters();

                    }
                }

                int execteResult = command.ExecuteNonQuery();
                if (execteResult == -1)
                {
                    MessageBox.Show("DATA WAS not saved!", "fail to save data.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    MessageBox.Show("your Sql" + dbCommand + "Query has been executed successfully", "VISUAL C# and SQLite DATABASE(SAVE)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateDataBiding();
                    AddBtn.Text = "ADD New";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error :" + ex.Message.ToString(), "SAVE DATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                dbCommand = "";
                closeConnection();
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (AddBtn.Text == "Cancel")
            {
                return;
            }
            if (autoIDTextBox.Text.Trim() == "" ||
                string.IsNullOrEmpty(autoIDTextBox.Text.Trim()))
            {
                MessageBox.Show("PLEASE SELECT AN ITEM FROM THE LIST", "DELETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            openConnection();
            try
            {
                if (MessageBox.Show("ID:" + autoIDTextBox.Text.Trim() + "Do you want to delete  the selected record?", "DELETE"
                    , MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }
                dbCommand = "Delete";
                sql = "DELETE FROM employees WHERE AutoID=@AutoID";
                command.Parameters.Clear();
                command.CommandText = sql;
                command.Parameters.AddWithValue("AutoID", autoIDTextBox.Text.Trim());
                int executResult = command.ExecuteNonQuery();
                if (executResult == 1)
                {
                    MessageBox.Show("Your SQL" + dbCommand + "Query has been execute successfully", "DELETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateDataBiding();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message.ToString(), "error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                closeConnection();
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (AddBtn.Text == "Cancel")
            {
                return;
            }
            openConnection();
            try
            {
                if (string.IsNullOrEmpty(KeywordTextBox.Text.Trim())) {  
                    UpdateDataBiding() ;
                    return;
                }
                sql = "SELECT * FROM employees WHERE Nom LIKE @Keyword2 ORDER BY AutoID ASC";

                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                command.Parameters.Clear();

                string keyword = string.Format("%{0}%", KeywordTextBox.Text);
                command.Parameters.AddWithValue("Keyword2",KeywordTextBox.Text);

                UpdateDataBiding(command);


            }
            catch (Exception ex)
            {
                MessageBox.Show("search error:" + ex.Message.ToString(), "error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }finally { 
                closeConnection();
                KeywordTextBox.Focus();
            }
          
        }
    }
}


