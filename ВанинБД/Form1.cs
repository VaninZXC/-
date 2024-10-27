using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ВанинБД
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=VANIN\\VANIN; Initial Catalog = Restaran;Integrated Security=True;Encrypt = false";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = this.textBox1.Text;
            string password = this.textBox2.Text;
            if (ValidUser(username, password))
            {
                AboutAllForm form = new AboutAllForm();
                form.FormClosed += FormShow;
                this.Hide();
                form.Show();
            }
            else
            {
                MessageBox.Show("Не верный логин или пароль", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormShow(object sender, FormClosedEventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            this.Show();
        }

        private bool ValidUser(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                string con = "SELECT COUNT(1) FROM Customers WHERE Name = @Name AND Password = @Password";
                using (SqlCommand cmd = new SqlCommand(con, connection))
                {
                    cmd.Parameters.AddWithValue("@Name", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count == 1)
                    {
                        return true;
                    }
                    else if (count == 0)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }

            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            string username = this.textBox3.Text;
            string password = this.textBox4.Text;
            string email = this.textBox5.Text;
            if (RegUsers(username, password, email) == true)
            {
                MessageBox.Show("reg", "ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("существует такой пользователь", "ok", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool RegUsers(string username, string password, string email)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                PoolCount.GetCount();
                string con = "INSERT INTO Customers (Name, Password, Email) VALUES (@Username, @Password, @Email)";
                using (SqlCommand cmd = new SqlCommand(con, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Email", email);
                    if (ValidUser(username, password) == false)
                    {
                        cmd.ExecuteNonQuery();
                        return (true);
                    }
                    else
                    {
                        return (false);
                    }
                }

            }
    }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            groupBoxReg.Visible = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            button2.Enabled = true;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            button1.Enabled = false;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            groupBoxReg.Visible = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            button2.Enabled = false;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            button1.Enabled = true;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.AliceBlue;
            label3.Font = new Font(label3.Font.Name, label3.Font.SizeInPoints, FontStyle.Underline);
        }

        

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Aqua;
            label3.Font = new Font(label3.Font.Name, label3.Font.SizeInPoints, FontStyle.Regular);
        }

        private void groupBoxReg_Enter(object sender, EventArgs e)
        {

        }
    }
}
