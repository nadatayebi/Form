using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private int value;
        public Form1()
        {
            InitializeComponent();
        }


        ////Pour Access----  using System.Data.OleDb;
        //OleDbConnection AccesConnection = new OleDbConnection();
        //OleDbDataAdapter AccesAdapter = new OleDbDataAdapter();
        //String AccesChaineConnection = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=|DataDirectory|\\BDAcces.mdb;Persist Security Info=True";

        ////Pour SQL Server----using System.Data.SqlClient;
        //SqlConnection SQLserverConnection = new SqlConnection();
        //SqlDataAdapter SQLserverAdapter = new SqlDataAdapter();
        //String SQLserverChaineConnection = "Data Source=.\\SQLEXPRESS;Initial Catalog=BdSQLserver;Integrated Security=True";

        ////Pour MySQL-----using MySql.Data.MySqlClient;
        //MySqlConnection MySQLConnection = new MySqlConnection();
        //MySqlDataAdapter MySQLAdapter = new MySqlDataAdapter();
        //String MySQLChaineConnection = "server=localhost; user id=root;password= ;database=BdMySQL";

        ////Pour Oracle---------using System.Data.OracleClient;
        //OracleConnection OracleConnection = new OracleConnection();
        //OracleDataAdapter OracleAdapter = new OracleDataAdapter();
        //String OracleChaineConnection = "Data Source=BdOracle;User Id=hr;Password=hr";//;DBA Privilege=SYSDBA



        static string chaine = @"Data Source=DESKTOP-RVGEFLO;Initial Catalog=Demo;Integrated Security=True";
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSelect.Enabled = true;
            btnConf.Enabled = false;
            btnCancel.Enabled = false;
            btnDelete.Enabled = false;
            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            idBox.Enabled = false;
            nameBox.Enabled = false;
            autorBox.Enabled = false;
            priceBox.Enabled = false;
            comboBox1.Enabled = true;
        }
        int clik = 0;

        private void btnInsert_Click(object sender, EventArgs e)
        {
            clik++;
            value = 1;
            cnx.Open();
            cmd.Connection = cnx;

            cnx.Close();
            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnConf.Enabled = true;
            btnCancel.Enabled = true;
            btnSelect.Enabled = false;
            idBox.Enabled = true;
            nameBox.Enabled = true;
            autorBox.Enabled = true;
            priceBox.Enabled = true;
            nameBox.Clear();
            idBox.Clear();
            autorBox.Clear();
            priceBox.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            value = 2;
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();
            }
            cnx.Open();
            cmd.Connection = cnx;

            cnx.Close();
            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnConf.Enabled = true;
            btnCancel.Enabled = true;
            btnSelect.Enabled = false;
            idBox.Enabled = true;
            nameBox.Enabled = true;
            autorBox.Enabled = true;
            priceBox.Enabled = true;
            nameBox.Clear();
            idBox.Clear();
            autorBox.Clear();
            priceBox.Clear();
        }
        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            value = 3;
            cnx.Open();
            cmd.Connection = cnx;

            cnx.Close();
            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnConf.Enabled = true;
            btnCancel.Enabled = true;
            btnSelect.Enabled = false;
            idBox.Enabled = true;
            nameBox.Enabled = true;
            autorBox.Enabled = true;
            priceBox.Enabled = true;
            nameBox.Clear();
            idBox.Clear();
            autorBox.Clear();
            priceBox.Clear();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();
            }
            cnx.Open();
            cmd.CommandText = "select * from Books";
            cmd.Connection = cnx;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            comboBox1.DataSource = dt;
            btnSelect.Enabled = false;
            btnInsert.Enabled = true;
            btnUpdate.Enabled = true;
            btnConf.Enabled = false;
            btnCancel.Enabled = false;
            btnDelete.Enabled = true;
            idBox.Enabled = true;
            nameBox.Enabled = true;
            autorBox.Enabled = true;
            priceBox.Enabled = true;
            comboBox1.Enabled = true;
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "ID";
            idBox.DataBindings.Clear();
            nameBox.DataBindings.Clear();
            autorBox.DataBindings.Clear();
            priceBox.DataBindings.Clear();
            idBox.DataBindings.Add("text", comboBox1.DataSource, "ID");
            nameBox.DataBindings.Add("text", comboBox1.DataSource, "name"); ;
            autorBox.DataBindings.Add("text", comboBox1.DataSource, "autor");
           
            cnx.Close(); 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConf_Click(object sender, EventArgs e)
        {

           if (value == 1)
            {
                cnx.Open();
                cmd.Connection = cnx;
                if (idBox.Text == "" || nameBox.Text == ""  || autorBox.Text == "" ||priceBox.Text == "")
                { MessageBox.Show("try to fill all the outputs"); }
                
          
                    else
                    {
                        cmd.CommandText = "INSERT INTO Books VALUES(" + this.idBox.Text.Trim() + ", '" + this.nameBox.Text.Trim().ToUpper()
                        + "','" + this.autorBox.Text.Trim().ToLower() + "'," + this.priceBox.Text.Trim() + ")";
                    int b= cmd.ExecuteNonQuery();
                    MessageBox.Show(b + " lignes has affected");
                    Enable();
                }
                }
                else if (value == 2)
                {
                    if (idBox.Text == "" || nameBox.Text == "" || autorBox.Text == "" || priceBox.Text == "")
                    { MessageBox.Show("try t fill all the output"); }
                    else
                    {
                        cnx.Open();
                        cmd.Connection = cnx;
                    cmd.CommandText = "Update Books set name='" + nameBox.Text + "',and set autor='" + autorBox.Text + "',and price='" + priceBox.Text + "'" +
                   " where ID =" + idBox.Text  ;  
                    int b=cmd.ExecuteNonQuery();
                    MessageBox.Show(b + " has been affected");
                    Enable();
                    cnx.Close();
                    }
                }
                else if (value == 3)
            {
                if (idBox.Text == "" || nameBox.Text == "" || autorBox.Text == "" || priceBox.Text == "")
                { MessageBox.Show("try t fill all the output"); }
                else
                    {
                        cnx.Open();
                        cmd.Connection = cnx;
                        cmd.CommandText = "delete from Books where ID='" + idBox.Text + "' ";
                        int b= cmd.ExecuteNonQuery();
                    MessageBox.Show(b + " has been deleted");
                    Enable();
                        cnx.Close();
                    }
                }
           void Enable()
            {
                btnSelect.Enabled = false;
                btnInsert.Enabled = true;
                btnUpdate.Enabled = true;
                btnConf.Enabled = false;
                btnCancel.Enabled = false;
                btnDelete.Enabled = true;
                idBox.Enabled = true;
                nameBox.Enabled = true;
                autorBox.Enabled = true;
                priceBox.Enabled = true;
                comboBox1.Enabled = true;

            }


            }

        private void price_Click(object sender, EventArgs e)
        {

        }
    }
    }

