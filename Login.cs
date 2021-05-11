using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсова12
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
            
            this.textBox2.AutoSize = false;
            this.textBox2.Size = new Size(this.textBox2.Size.Width, 36);
        }

        Point lastPoint;
               

       

        private void Log_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Vhid_MouseEnter(object sender, EventArgs e)
        {
            Vhid.ForeColor = Color.Red;
        }

        private void Vhid_MouseLeave(object sender, EventArgs e)
        {
            Vhid.ForeColor = Color.Green;
        }

        private void Exit_MouseEnter(object sender, EventArgs e)
        {
            Exit.ForeColor = Color.CadetBlue;
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            Exit.ForeColor = Color.DarkBlue;
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Vhid_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Admin")
            {
                if (textBox2.Text == "12345")
                {
                    this.Hide();
                    Admin admin = new Admin();
                    admin.Show();
                }
            }

            else
            {
                MessageBox.Show("Не коректный логен или пароль", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
    
}
