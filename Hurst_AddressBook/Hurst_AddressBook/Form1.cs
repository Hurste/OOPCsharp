using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hurst_AddressBook
{
    public partial class Form1 : Form
    {
        String sql = "SELECT * FROM ContactsDB";
        String connectionString = ConfigurationManager.ConnectionStrings["Hurst_AddressBook.Properties.Settings.AddressBookConnectionString"].ConnectionString;
        SqlConnection connection;
        SqlDataAdapter adapter;

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBoxLastName_Selected(object sender, EventArgs e)
        {
            string query = "SELECT * FROM ContactsDB WHERE LastName = '" + cboxLastName.Text + "' ;";

            using (connection = new SqlConnection(connectionString))
            using (adapter = new SqlDataAdapter(query, connection))
            {
                DataTable contactTable = new DataTable();
                adapter.Fill(contactTable);
                List<string> contacts = new List<string>();
                try
                {
                    connection.Open();

                    foreach (DataRow contact in contactTable.Rows)
                    {
                        contacts.Add(contact["LastName"].ToString());
                        contacts.Add(contact["FirstName"].ToString());
                        contacts.Add(contact["Address"].ToString());
                        contacts.Add(contact["City"].ToString());
                        contacts.Add(contact["State"].ToString());
                        contacts.Add(contact["Zip"].ToString());
                        contacts.Add(contact["PhoneNumber"].ToString()); 
                        contacts.Add(contact["Email"].ToString());
                    }
                   
                    listBoxContactInfo.DataSource = contacts;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error!!!!");
                }                      
            }         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComboBoxFill();
        }

        public void ComboBoxFill()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))

            {   try
                {
                    String cmbFill = "SELECT LastName FROM ContactsDB";
                    SqlDataAdapter da = new SqlDataAdapter(cmbFill, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "lNames");

                    cboxLastName.DisplayMember = "LastName";
                    cboxLastName.ValueMember = "LastName";
                    cboxLastName.DataSource = ds.Tables["lNames"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured!");
                }
                
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello and Welcome to Eli's Address Book. See all my friends..." + "\n\nElijah Hurst \nProf: Mike Hunsicker \nITDEV - 115 Intermediate OOP \nAssignment 9" + "\n" + System.DateTime.Today.ToShortDateString());
        }
    }
}

    

