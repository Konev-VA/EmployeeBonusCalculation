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
        public static int currentID;
        public static string query;
        public static string searchInput;
        public static float hourMultiplier;
        DataBase db = new DataBase();

        public Form1()
        {
            InitializeComponent();
            currentID = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchInput = textBox1.Text;
        }
        private void search_Click(object sender, EventArgs e)
        {
            query = "SELECT * FROM employees WHERE id = " + searchInput;
            Update(query, db);
        }
        public void Update(string query, DataBase db)
        {
            fio.Text = null;
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
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (dataReader != null && !dataReader.IsClosed)
                {
                    dataReader.Close();
                }
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
