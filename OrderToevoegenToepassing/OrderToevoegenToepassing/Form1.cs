using System;
using System.Collections.Generic;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderToevoegenToepassing
{
    public partial class Form1 : Form
    {
        ConnectionStringSettingsCollection connectionStringSettings = new ConnectionStringSettingsCollection();

        MySqlCommand mySqlComm;
        MySqlConnection mySqlConn;

        List<string> klanten = new List<string>();
        List<string> producten = new List<string>();

        List<int> klantIDs = new List<int>();
        List<int> productIDs = new List<int>();

        string mySqlConnStr;

        Form2 orderForm = new Form2();

        public Form1()
        {
            InitializeComponent();
            connectionStringSettings = GetConnectionStrings();
            UpdateConnectionsComboBox(DatabasesComboBox, connectionStringSettings);
            mySqlConnStr = DatabasesComboBox.SelectedValue.ToString();
        }
        private void UpdateConnectionsComboBox(ComboBox cb, ConnectionStringSettingsCollection cssc)
        {
            Dictionary<string, string> csd = new Dictionary<string, string>();

            if (cssc != null)
            {
                foreach (ConnectionStringSettings cs in cssc)
                {
                    csd.Add(cs.Name, cs.ConnectionString);
                }

                cb.DataSource = new BindingSource(csd, null);
                cb.DisplayMember = "Key";
                cb.ValueMember = "Value";
            }
            else
            {
                cb.Enabled = false;
            }
        }
        private ConnectionStringSettingsCollection GetConnectionStrings()
        {
            ConnectionStringSettingsCollection settings = new ConnectionStringSettingsCollection();

            try
            {
                settings = ConfigurationManager.ConnectionStrings;
            }
            catch (ConfigurationErrorsException err)
            {
                MessageBox.Show(err.Message, "Configuratie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return settings;
        }
        private void DatabasesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mySqlConnStr = DatabasesComboBox.SelectedValue.ToString();
            String[] strlist = mySqlConnStr.Split(';');
            string str = string.Empty;

            foreach (String s in strlist)
            {
                if (!s.Contains("password"))
                {
                    str += s + " , ";
                }
            }

        }
        private MySqlConnection OpenMySQLverbinding(string connectieString)
        {
            MySqlConnection mijnVerbinding = null;

            try
            {
                mijnVerbinding = new MySqlConnection(connectieString);

                try
                {
                    mijnVerbinding.Open();
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Fout bij het maken van verbinding met database", "MySQL Connectie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (mijnVerbinding != null)
                    {
                        mijnVerbinding.Dispose();
                    }
                }
            }
            catch (ArgumentException err)
            {
                MessageBox.Show(err.Message, "SQL-verbinding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (mijnVerbinding != null)
                {
                    mijnVerbinding.Dispose();
                }
            }

            return mijnVerbinding;
        }
        private void LaadKlanten()
        {
            
            
                using (mySqlConn = OpenMySQLverbinding(mySqlConnStr))
                {
                    if (mySqlConn.State == ConnectionState.Open)
                    {
                        mySqlComm = new MySqlCommand();
                        mySqlComm.Connection = mySqlConn;
                        mySqlComm.CommandText = "select * from klanten;";
                        mySqlComm.CommandType = CommandType.Text;

                        using (MySqlDataReader mySqlDr = mySqlComm.ExecuteReader())
                        {
                            while (mySqlDr.Read())
                            {
                            klantIDs.Add(Convert.ToInt32(mySqlDr[0].ToString()));
                            klanten.Add(mySqlDr[1].ToString().Trim());
                         
                            }
                        orderForm.VulKlantenComboBox(klanten);
                         mySqlDr.Close();
                        }

                        mySqlConn.Close();
                    }
                    else
                    {

                    }
                }
            
            
        }
        private void LaadProducten()
        {
           
            try
            {
                using (mySqlConn = OpenMySQLverbinding(mySqlConnStr))
                {
                    if (mySqlConn.State == ConnectionState.Open)
                    {
                        mySqlComm = new MySqlCommand();
                        mySqlComm.Connection = mySqlConn;
                        mySqlComm.CommandText = "select * from producten;";
                        mySqlComm.CommandType = CommandType.Text;

                        using (MySqlDataReader mySqlDr = mySqlComm.ExecuteReader())
                        {
                            while (mySqlDr.Read())
                            {
                                productIDs.Add(Convert.ToInt32(mySqlDr[0].ToString()));
                                producten.Add(mySqlDr[1].ToString().Trim());
                            }

                            orderForm.VulProductenComboBox(producten);
                            mySqlDr.Close();
                        }

                        mySqlConn.Close();
                    }
                    else
                    {
                        MessageBox.Show("GEEN VERBINDING MET DATABASE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex is NullReferenceException || ex is MySqlException)
                {
                    MessageBox.Show(ex.Message, "MySQL Connectie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else throw;
            }
        }
        private void OrderToevoegenBtn_Click(object sender, EventArgs e)
        {
            LaadKlanten();
            LaadProducten();

            if (orderForm.ShowDialog() == DialogResult.OK)
            {
                orderForm.Close();
                VoegOrderToeAanDatabase();
            }
        }
        private void VoegOrderToeAanDatabase()
        {
            DateTime today = DateTime.Now;
            
            try
                {
                    using (mySqlConn = OpenMySQLverbinding(mySqlConnStr))
                    {
                        if (mySqlConn.State == ConnectionState.Open)
                        {
                            mySqlComm = new MySqlCommand();
                            mySqlComm.Connection = mySqlConn;
                            mySqlComm.Parameters.AddWithValue("bestelDatum", today.ToString("yyyy-MM-dd H:mm:ss"));
                            mySqlComm.Parameters.AddWithValue("klantID", (klantIDs[klanten.IndexOf(orderForm.klantNaam)]));
                            mySqlComm.Parameters.AddWithValue("productID", (productIDs[producten.IndexOf(orderForm.productNaam)]));
                            mySqlComm.Parameters.AddWithValue("bestelhoeveelheid", orderForm.productAantal);
                            mySqlComm.CommandText = "INSERT INTO bestelling(besteldatum, klantID, productID, bestelhoeveelheid) VALUES(@bestelDatum, @klantID, @productID, @bestelhoeveelheid)";
                            mySqlComm.CommandType = CommandType.Text;

                            try
                            {
                                mySqlComm.ExecuteNonQuery();
                                MessageBox.Show("BESTELLING IS TOEGEVOEGD", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (MySqlException)
                            {
                                MessageBox.Show("Fout bij schrijven naar database", "MySQL Connectie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            mySqlConn.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    if (ex is NullReferenceException || ex is MySqlException)
                    {
                        MessageBox.Show(ex.Message, "MySQL Connectie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else throw;
                }
        }
    }
}
