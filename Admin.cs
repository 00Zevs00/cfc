using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Курсова12
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
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

        private void Dobavut_Click(object sender, EventArgs e)
        {
            //провірка кількості рядків
            if (Vuvod_BD.SelectedRows.Count != 1)
            {
                MessageBox.Show("Виберіть 1 рядок!", "ERROR");
                return;
            }

            //вибираєм рядок
            int index = Vuvod_BD.SelectedRows[0].Index;

            //Перевірка даних
            if (Vuvod_BD.Rows[index].Cells[0].Value == null ||
                Vuvod_BD.Rows[index].Cells[1].Value == null ||
                Vuvod_BD.Rows[index].Cells[2].Value == null ||
                Vuvod_BD.Rows[index].Cells[3].Value == null)
            {
                MessageBox.Show("Не всі дані введені", "ERROR");
                return;
            }

            //зчитування даних
            string id = Vuvod_BD.Rows[index].Cells[0].Value.ToString();
            string name = Vuvod_BD.Rows[index].Cells[1].Value.ToString();
            string stan = Vuvod_BD.Rows[index].Cells[2].Value.ToString();
            string cina = Vuvod_BD.Rows[index].Cells[3].Value.ToString();

            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=Workers.mdb";//строка соеденения
            OleDbConnection dbConnection = new OleDbConnection(connectionString);//создаем соеденение

            //Выполянем запрос к БД
            dbConnection.Open();//открываем соеденение
            string query = "INSERT INTO Worker VALUES (" + id + ", '" + name + "', " + stan + ", " + cina + ")";//строка запроса
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);//команда

            //Выполняем запрос
            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
            else
                MessageBox.Show("Данные добавлены!", "Внимание!");

            //Закрываем соеденение с БД
            dbConnection.Close();

        }

        Point lastPoint;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
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

        private void Dobavut_MouseEnter(object sender, EventArgs e)
        {
            Dobavut.ForeColor = Color.DarkBlue;
        }

        private void Dobavut_MouseLeav(object sender, EventArgs e)
        {
            Dobavut.ForeColor = Color.DarkGreen;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            //перевірка вибраних рядків
            if (Vuvod_BD.SelectedRows.Count != 1)
            {
                MessageBox.Show("Виберіть один рядок", "УВАГА");
                return;
            }


            int index = Vuvod_BD.SelectedRows[0].Index;

            //перевірка даних в базі
            if (Vuvod_BD.Rows[index].Cells[0].Value == null)
            {
                MessageBox.Show("Не все введене", "АХТУНГ");
                return;
            }


            string id = Vuvod_BD.Rows[index].Cells[0].Value.ToString();


            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=Workers.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);


            dbConnection.Open();
            string query = "DELETE FROM Worker WHERE id = " + id;
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);


            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("ERROR");
            else
            {
                MessageBox.Show("Dані видалені", "УВАГА");
                //видалення даних
                Vuvod_BD.Rows.RemoveAt(index);
            }


            dbConnection.Close();
        }

        private void Delete_MouseEnter(object sender, EventArgs e)
        {
           Delete.ForeColor = Color.Red;
        }

        private void Delete_MouseLeave(object sender, EventArgs e)
        {
            Delete.ForeColor = Color.DarkGray;
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
