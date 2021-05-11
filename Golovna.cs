using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Курсова12
{
    public partial class Golovna : Form
    {
        public Golovna()
        {
            InitializeComponent();
        }

        private void LoginADM_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void LoginADM_MouseEnter(object sender, EventArgs e)
        {
            LoginADM.ForeColor = Color.Green;
        }

        private void LoginADM_MouseLeave(object sender, EventArgs e)
        {
            LoginADM.ForeColor = Color.Blue;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exit_MouseEnter(object sender, EventArgs e)
        {
            Exit.ForeColor = Color.Red;
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            Exit.ForeColor = Color.Green;
        }

        private void BD_Click(object sender, EventArgs e)
        {


            //Створюється з'єднання
            string connection = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=Workers.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connection);

            //звернення до бази
            dbConnection.Open();//відкривається з'єднання 
            string query = "SELECT * FROM Worker";//рядок запиту
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
            OleDbDataReader dbReader = dbCommand.ExecuteReader();

            //перевірка даних
            if (dbReader.HasRows == false)
            {
                MessageBox.Show("Дані не знайдені!", "ERROR");
            }
            else
            {

                while (dbReader.Read())
                {
                    //Выводим данные
                    Vuvod_BD.Rows.Add(dbReader["id"], dbReader["name"], dbReader["stan"], dbReader["cina"]);
                }
            }

            //Закрываем соеденение с БД
            dbReader.Close();
            dbConnection.Close();
        }

        private void BD_MouseEnter(object sender, EventArgs e)
        {
            BD.ForeColor = Color.Green;
        }

        private void BD_MouseLeave(object sender, EventArgs e)
        {
            BD.ForeColor = Color.Red;
        }

        Point lastPoint;
        private void Golovna_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Golovna_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
    
}
