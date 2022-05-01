using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employeeBonus
{
    public partial class Form1 : Form
    {
        public static int currentID = 0;
        public static double hourBonus = 500;
        public static double salaryBonus;
        public static string query;
        public static string searchInput;
        public static string[] splitSearch = null;
        DataBase db = new DataBase();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchInput = textBox1.Text;
        }
        private void search_Click(object sender, EventArgs e)
        {
            splitSearch = searchInput.Split();
            if (splitSearch.Length > 1)
                query = String.Format("SELECT * FROM employees.employees WHERE lname = \"{0}\" AND fname = \"{1}\" AND mname = \"{2}\"", splitSearch[0], splitSearch[1], splitSearch[2] );
            else
                query = "SELECT * FROM employees WHERE id = " + searchInput;
            Update(query);
        }
        public void Update(string query)
        {
            fio.Text = null;
            dolzhnost.Text = null;
            bonusValue.Text = null;
            MySqlCommand command = new MySqlCommand(query, db.GetConnection());
            db.OpenConnection();
            MySqlDataReader dataReader = null;
            try
            {
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    for (int i = 0; i < 4; i++)
                    {
                        fio.Text += dataReader.GetValue(i).ToString();
                        fio.Text += " ";
                    }
                    dolzhnost.Text = dataReader.GetValue(4).ToString();
                    salaryBonus = (Convert.ToDouble(dataReader.GetValue(5)) * hourBonus + Convert.ToDouble(dataReader.GetValue(7)) * (Convert.ToDouble(dataReader.GetValue(6)) / 100))- Convert.ToDouble(dataReader.GetValue(7));
                    bonusValue.Text = salaryBonus.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (dataReader != null && !dataReader.IsClosed)
                    dataReader.Close();
            }
        }

        private void previous_Click(object sender, EventArgs e)
        {
            if (currentID > 1)
            {
                currentID--;
                query = "SELECT * FROM employees WHERE id = " + currentID;
                Update(query);
            }
            else
            {
                Form errorMessage = new Form();
                errorMessage.Text = "ВНИМАНИЕ";
                errorMessage.ShowDialog();
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            int maxId = 0;
            MySqlCommand command = new MySqlCommand("SELECT MAX(id) FROM employees", db.GetConnection());
            db.OpenConnection();
            MySqlDataReader dataReader = null;
            try
            {
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    maxId = Convert.ToInt32(dataReader.GetValue(0));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (dataReader != null && !dataReader.IsClosed)
                    dataReader.Close();
            }
            
            if (currentID < maxId)
            {
                currentID++;
                query = "SELECT * FROM employees WHERE id = " + currentID;
                Update(query);
            }
            else
            {
                Form errorMessage = new Form();
                errorMessage.Text = "ВНИМАНИЕ";
                errorMessage.ShowDialog();
            }
        }
    }
    public class DataBase
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=employees");
        public void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
        }
        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }
        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }

}
