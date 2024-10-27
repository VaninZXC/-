using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ВанинБД
{
    public partial class AboutAllForm : Form
    {
        //подключение в базе данных
        private string continiesString = "Data Source=VANIN\\VANIN; Initial Catalog = Restaran;Integrated Security=True;Encrypt = false";
        //Конструктор класса
        public AboutAllForm()
        {
            InitializeComponent();
            LoadRestaran();
            ComboRest();
        }
        #region - RestaurantEvent  
        //Метод для реализации Таблицы "Растараны"
        private void LoadRestaran()
        {
            using (SqlConnection connection = new SqlConnection(continiesString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Restaurants", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewRestaran.DataSource = dt;
            }
        }

        private void ComboRest()
        {
            using (SqlConnection connection = new SqlConnection(continiesString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT RestaurantID, Name FROM Restaurants", connection);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    comboBoxRestaurant.Items.Add(new { Value = read["RestaurantID"], Text = read["Name"] });
                }
                comboBoxRestaurant.DisplayMember = "Text";
                comboBoxRestaurant.ValueMember = "Value";
            }
        }
        //Метод для реализации Таблицы "Задачи"
        private void LoadEmployee()
        {
            if (comboBoxRestaurant.SelectedItem == null) return;

            var RestaurantID = ((dynamic)comboBoxRestaurant.SelectedItem).Value;

            using (SqlConnection connection = new SqlConnection(continiesString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Employee WHERE RestaurantID = @RestaurantID", connection);
                cmd.Parameters.AddWithValue("@RestaurantID", RestaurantID);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewEmployee.DataSource = table;

            }
        }
        //Вызывает таблицу Проектов
        private void button1_Click(object sender, EventArgs e)
        {
            groupBoxEmployee.Size = new Size(1, 1);
            groupBoxEmployee.Location = new Point(826, 301);
            groupBoxRestaran.Size = new Size(586, 435);
            groupBoxRestaran.Location = new Point(202, 12);
        }
        //Добавляет Рестаран в таблицу
        private void buttonAddProjects_Click(object sender, EventArgs e)
        {
            string RestName = this.textBoxRestName.Text;
            string RestStatus = this.textBoxRestLocation.Text;
            string RestPhone = this.textBoxRestPhon.Text;
            string RestEmail = this.textBoxRestEmail.Text;
            string RestHours = this.textBoxRestHours.Text;
            using (SqlConnection connection = new SqlConnection(continiesString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand
                    ("INSERT INTO Restaurants (Name, Location, Phone, Email, OpeningHours) " +
                    "VALUES (@ProjectName, @Location, @Phone, @Email, @OpeningHours)", connection);
                command.Parameters.AddWithValue("@ProjectName", RestName);
                command.Parameters.AddWithValue("@Location", RestStatus);
                command.Parameters.AddWithValue("@Phone", RestPhone);
                command.Parameters.AddWithValue("@Email", RestEmail);
                command.Parameters.AddWithValue("@OpeningHours", RestHours);
                command.ExecuteNonQuery();
                LoadRestaran();
            }
        }
        //Изменяет Рестаран в таблице
        private void buttonEditProjects_Click(object sender, EventArgs e)
        {
            if (dataGridViewRestaran.SelectedRows.Count > 0)
            {
                int RestaurantID = (int)dataGridViewRestaran.SelectedRows[0].Cells["RestaurantID"].Value;
                string RestName = this.textBoxRestName.Text;
                string RestLoc = this.textBoxRestLocation.Text;
                string RestPhone = this.textBoxRestPhon.Text;
                string RestEmail = this.textBoxRestEmail.Text;
                string RestOpenTime = this.textBoxRestHours.Text;
                using (SqlConnection connection = new SqlConnection(continiesString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand
                        ("UPDATE Restaurants SET Name = @Name, Location = @Location, Phone = @Phone ,Email = @Email, " +
                        "OpeningHours = @OpeningHours " +
                        "WHERE RestaurantID = @RestaurantID;", connection);
                    cmd.Parameters.AddWithValue("@Name", RestName);
                    cmd.Parameters.AddWithValue("@Location", RestLoc);
                    cmd.Parameters.AddWithValue("@Phone", RestPhone);
                    cmd.Parameters.AddWithValue("@Email", RestEmail);
                    cmd.Parameters.AddWithValue("@OpeningHours", RestOpenTime);
                    cmd.Parameters.AddWithValue("@RestaurantID", RestaurantID);
                    cmd.ExecuteNonQuery();
                    LoadRestaran();
                }
            }
        }
        //Удаляет Рестаран из таблицы
        private void buttonDeleteProjects_Click(object sender, EventArgs e)
        {
            if (dataGridViewRestaran.SelectedRows.Count > 0)
            {
                int RestaurantID = (int)dataGridViewRestaran.SelectedRows[0].Cells["RestaurantID"].Value;
                using (SqlConnection connection = new SqlConnection(continiesString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Restaurants WHERE RestaurantID = @RestaurantID", connection);
                    cmd.Parameters.AddWithValue("@RestaurantID", RestaurantID);
                    cmd.ExecuteNonQuery();
                    LoadRestaran();
                }
            }
        }
        //Выбирает в Датагридвью полную строку данных
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewRestaran.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewRestaran.SelectedRows[0];
                textBoxRestName.Text = row.Cells["Name"].Value.ToString();
                textBoxRestLocation.Text = row.Cells["Location"].Value.ToString();
                textBoxRestEmail.Text = row.Cells["Email"].Value.ToString();
                textBoxRestPhon.Text = row.Cells["Phone"].Value.ToString();
                textBoxRestHours.Text = row.Cells["OpeningHours"].Value.ToString();
            }
        }
        #endregion
        #region - EmployeeEvent
        //Показывает панель Задач(таблицы)
        private void button2_Click(object sender, EventArgs e)
        {
            groupBoxRestaran.Size = new Size(1, 1);
            groupBoxRestaran.Location = new Point(826, 301);
            groupBoxEmployee.Size = new Size(586, 435);
            groupBoxEmployee.Location = new Point(202, 12);
        }
        //Добавляет задачу(строку) в базу данных
        private void buttonTasksAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxRestaurant.SelectedItem == null)
            {
                MessageBox.Show("Выберите проект и пользьвоталеля, иначе убью");
                return;
            };

            var selectedProjectID = ((dynamic)comboBoxRestaurant.SelectedItem).Value;


            using (SqlConnection connection = new SqlConnection(continiesString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand
                    ("INSERT INTO Tasks(TaskName, Description, UserID ,ProjectID, Status)" +
                    " VALUES (@TaskName, @Description,@AssignedTo,@ProjectID, @Status)", connection);
                cmd.Parameters.AddWithValue("@TaskName", textBoxEmployeeName.Text);
                cmd.Parameters.AddWithValue("@Description", textBoxEmployeePosition.Text);
                cmd.Parameters.AddWithValue("@ProjectID", selectedProjectID);
                cmd.Parameters.AddWithValue("@Status", textBoxEmployeeDataToJob.Text);
                cmd.Parameters.AddWithValue("@CreatedAt", DateTime.Now);
                //cmd.Parameters.AddWithValue("@UpdatedAt", selectedTimeID);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Задача выполнена!");
                LoadEmployee();
            }
        }
        //Изменяет в базе данных Задачу(строку)
        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployee.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите задачу для редактирования, иначе убью");
                return;
            }

            if (dataGridViewEmployee.SelectedRows.Count > 0)
            {
                int taskid = Convert.ToInt32(dataGridViewEmployee.SelectedRows[0].Cells["TaskId"].Value);
                //string selectedProjectID = ((dynamic)comboBoxpProjects.SelectedItem).Value ;
                //string selectedUserID = ((dynamic)comboBoxUsers.SelectedItem).Value;
                using (SqlConnection connection = new SqlConnection(continiesString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand
                        ("UPDATE Tasks SET TaskName = @TaskName, Status = @Status,Description = @Description," +
                        "AssignedTo = @AssignedTo,ProjectID = @ProjectID  WHERE TaskId = @TaskID;", connection);
                    cmd.Parameters.AddWithValue("@TaskName", textBoxEmployeeName.Text);
                    cmd.Parameters.AddWithValue("@Description", textBoxEmployeePosition.Text);
                    cmd.Parameters.AddWithValue("@ProjectID", ((dynamic)comboBoxRestaurant.SelectedItem).Value);
                    cmd.Parameters.AddWithValue("@Status", textBoxEmployeeDataToJob.Text);
                    cmd.Parameters.AddWithValue("TaskID", taskid);
                    LoadEmployee();
                }

            }
        }
        //Удаляет из базы данных Задачу(строку)
        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployee.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите задачу для удаления, иначе убью");
                return;
            }

            var selectedRow = dataGridViewEmployee.SelectedRows[0];
            int taskID = (int)selectedRow.Cells["TaskID"].Value;

            var result = MessageBox.Show("Удалить?", "Удаление", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(continiesString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Tasks Where TaskID = @TaskID", connection);
                    cmd.Parameters.AddWithValue("@TaskID", taskID);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Удалено");
                    LoadEmployee();
                }
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridViewEmployee_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewEmployee.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewEmployee.SelectedRows[0];
                comboBoxRestaurant.Text = row.Cells["RestaurantID"].Value.ToString();
                textBoxEmployeeName.Text = row.Cells["Name"].Value.ToString();
                textBoxEmployeePosition.Text = row.Cells["Position"].Value.ToString();
                textBoxEmployeeDataToJob.Text = row.Cells["HireData"].Value.ToString();
                textBoxEmployeeSalary.Text = row.Cells["Salary"].Value.ToString();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxRestaurant_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRestaran(); 
        }
        #endregion
    }
}
