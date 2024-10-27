namespace ВанинБД
{
    partial class AboutAllForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRest = new System.Windows.Forms.Button();
            this.buttonEmployees = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.dataGridViewRestaran = new System.Windows.Forms.DataGridView();
            this.groupBoxRestaran = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxRestHours = new System.Windows.Forms.TextBox();
            this.textBoxRestEmail = new System.Windows.Forms.TextBox();
            this.textBoxRestPhon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDeleteProjects = new System.Windows.Forms.Button();
            this.textBoxRestLocation = new System.Windows.Forms.TextBox();
            this.textBoxRestName = new System.Windows.Forms.TextBox();
            this.buttonEditProjects = new System.Windows.Forms.Button();
            this.buttonAddProjects = new System.Windows.Forms.Button();
            this.groupBoxEmployee = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEmployeeDataToJob = new System.Windows.Forms.TextBox();
            this.buttonDeletTask = new System.Windows.Forms.Button();
            this.buttonEditTask = new System.Windows.Forms.Button();
            this.buttonTasksAdd = new System.Windows.Forms.Button();
            this.textBoxEmployeePosition = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeName = new System.Windows.Forms.TextBox();
            this.comboBoxRestaurant = new System.Windows.Forms.ComboBox();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.textBoxEmployeeSalary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRestaran)).BeginInit();
            this.groupBoxRestaran.SuspendLayout();
            this.groupBoxEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRest
            // 
            this.buttonRest.BackColor = System.Drawing.SystemColors.Control;
            this.buttonRest.Location = new System.Drawing.Point(440, 596);
            this.buttonRest.Name = "buttonRest";
            this.buttonRest.Size = new System.Drawing.Size(156, 41);
            this.buttonRest.TabIndex = 0;
            this.buttonRest.Text = "Рестараны";
            this.buttonRest.UseVisualStyleBackColor = false;
            this.buttonRest.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonEmployees
            // 
            this.buttonEmployees.BackColor = System.Drawing.SystemColors.Control;
            this.buttonEmployees.Location = new System.Drawing.Point(288, 596);
            this.buttonEmployees.Name = "buttonEmployees";
            this.buttonEmployees.Size = new System.Drawing.Size(156, 44);
            this.buttonEmployees.TabIndex = 1;
            this.buttonEmployees.Text = "Сотрудники";
            this.buttonEmployees.UseVisualStyleBackColor = false;
            this.buttonEmployees.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.SystemColors.Control;
            this.buttonMenu.Location = new System.Drawing.Point(593, 596);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(156, 38);
            this.buttonMenu.TabIndex = 2;
            this.buttonMenu.Text = "Меню";
            this.buttonMenu.UseVisualStyleBackColor = false;
            // 
            // dataGridViewRestaran
            // 
            this.dataGridViewRestaran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRestaran.Location = new System.Drawing.Point(6, 12);
            this.dataGridViewRestaran.Name = "dataGridViewRestaran";
            this.dataGridViewRestaran.Size = new System.Drawing.Size(593, 572);
            this.dataGridViewRestaran.TabIndex = 3;
            this.dataGridViewRestaran.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // groupBoxRestaran
            // 
            this.groupBoxRestaran.BackColor = System.Drawing.Color.Bisque;
            this.groupBoxRestaran.Controls.Add(this.label10);
            this.groupBoxRestaran.Controls.Add(this.label9);
            this.groupBoxRestaran.Controls.Add(this.label8);
            this.groupBoxRestaran.Controls.Add(this.textBoxRestHours);
            this.groupBoxRestaran.Controls.Add(this.textBoxRestEmail);
            this.groupBoxRestaran.Controls.Add(this.textBoxRestPhon);
            this.groupBoxRestaran.Controls.Add(this.label2);
            this.groupBoxRestaran.Controls.Add(this.label1);
            this.groupBoxRestaran.Controls.Add(this.buttonDeleteProjects);
            this.groupBoxRestaran.Controls.Add(this.textBoxRestLocation);
            this.groupBoxRestaran.Controls.Add(this.textBoxRestName);
            this.groupBoxRestaran.Controls.Add(this.buttonEditProjects);
            this.groupBoxRestaran.Controls.Add(this.buttonAddProjects);
            this.groupBoxRestaran.Controls.Add(this.dataGridViewRestaran);
            this.groupBoxRestaran.Location = new System.Drawing.Point(0, 0);
            this.groupBoxRestaran.Name = "groupBoxRestaran";
            this.groupBoxRestaran.Size = new System.Drawing.Size(1, 1);
            this.groupBoxRestaran.TabIndex = 4;
            this.groupBoxRestaran.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(605, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Часы Работы";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(605, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Почта";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(605, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Телефон";
            // 
            // textBoxRestHours
            // 
            this.textBoxRestHours.Location = new System.Drawing.Point(605, 190);
            this.textBoxRestHours.Name = "textBoxRestHours";
            this.textBoxRestHours.Size = new System.Drawing.Size(131, 20);
            this.textBoxRestHours.TabIndex = 14;
            // 
            // textBoxRestEmail
            // 
            this.textBoxRestEmail.Location = new System.Drawing.Point(605, 152);
            this.textBoxRestEmail.Name = "textBoxRestEmail";
            this.textBoxRestEmail.Size = new System.Drawing.Size(131, 20);
            this.textBoxRestEmail.TabIndex = 13;
            // 
            // textBoxRestPhon
            // 
            this.textBoxRestPhon.Location = new System.Drawing.Point(605, 111);
            this.textBoxRestPhon.Name = "textBoxRestPhon";
            this.textBoxRestPhon.Size = new System.Drawing.Size(131, 20);
            this.textBoxRestPhon.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(602, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Адрес Рестарана";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(602, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Имя Рестарана";
            // 
            // buttonDeleteProjects
            // 
            this.buttonDeleteProjects.Location = new System.Drawing.Point(605, 373);
            this.buttonDeleteProjects.Name = "buttonDeleteProjects";
            this.buttonDeleteProjects.Size = new System.Drawing.Size(138, 77);
            this.buttonDeleteProjects.TabIndex = 9;
            this.buttonDeleteProjects.Text = "Снести";
            this.buttonDeleteProjects.UseVisualStyleBackColor = true;
            this.buttonDeleteProjects.Click += new System.EventHandler(this.buttonDeleteProjects_Click);
            // 
            // textBoxRestLocation
            // 
            this.textBoxRestLocation.Location = new System.Drawing.Point(605, 72);
            this.textBoxRestLocation.Name = "textBoxRestLocation";
            this.textBoxRestLocation.Size = new System.Drawing.Size(131, 20);
            this.textBoxRestLocation.TabIndex = 7;
            // 
            // textBoxRestName
            // 
            this.textBoxRestName.Location = new System.Drawing.Point(605, 31);
            this.textBoxRestName.Name = "textBoxRestName";
            this.textBoxRestName.Size = new System.Drawing.Size(131, 20);
            this.textBoxRestName.TabIndex = 6;
            // 
            // buttonEditProjects
            // 
            this.buttonEditProjects.Location = new System.Drawing.Point(605, 292);
            this.buttonEditProjects.Name = "buttonEditProjects";
            this.buttonEditProjects.Size = new System.Drawing.Size(138, 71);
            this.buttonEditProjects.TabIndex = 5;
            this.buttonEditProjects.Text = "Изменить";
            this.buttonEditProjects.UseVisualStyleBackColor = true;
            this.buttonEditProjects.Click += new System.EventHandler(this.buttonEditProjects_Click);
            // 
            // buttonAddProjects
            // 
            this.buttonAddProjects.Location = new System.Drawing.Point(605, 215);
            this.buttonAddProjects.Name = "buttonAddProjects";
            this.buttonAddProjects.Size = new System.Drawing.Size(138, 71);
            this.buttonAddProjects.TabIndex = 4;
            this.buttonAddProjects.Text = "Добавить";
            this.buttonAddProjects.UseVisualStyleBackColor = true;
            this.buttonAddProjects.Click += new System.EventHandler(this.buttonAddProjects_Click);
            // 
            // groupBoxEmployee
            // 
            this.groupBoxEmployee.BackColor = System.Drawing.Color.Moccasin;
            this.groupBoxEmployee.Controls.Add(this.label4);
            this.groupBoxEmployee.Controls.Add(this.textBoxEmployeeSalary);
            this.groupBoxEmployee.Controls.Add(this.label7);
            this.groupBoxEmployee.Controls.Add(this.label6);
            this.groupBoxEmployee.Controls.Add(this.label5);
            this.groupBoxEmployee.Controls.Add(this.label3);
            this.groupBoxEmployee.Controls.Add(this.textBoxEmployeeDataToJob);
            this.groupBoxEmployee.Controls.Add(this.buttonDeletTask);
            this.groupBoxEmployee.Controls.Add(this.buttonEditTask);
            this.groupBoxEmployee.Controls.Add(this.buttonTasksAdd);
            this.groupBoxEmployee.Controls.Add(this.textBoxEmployeePosition);
            this.groupBoxEmployee.Controls.Add(this.textBoxEmployeeName);
            this.groupBoxEmployee.Controls.Add(this.comboBoxRestaurant);
            this.groupBoxEmployee.Controls.Add(this.dataGridViewEmployee);
            this.groupBoxEmployee.Location = new System.Drawing.Point(-3, 0);
            this.groupBoxEmployee.Name = "groupBoxEmployee";
            this.groupBoxEmployee.Size = new System.Drawing.Size(573, 450);
            this.groupBoxEmployee.TabIndex = 7;
            this.groupBoxEmployee.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(395, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Дата присоединения на работу";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(399, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Позиция сотрудника";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Имя Сотрудника";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Рестараны";
            // 
            // textBoxEmployeeDataToJob
            // 
            this.textBoxEmployeeDataToJob.Location = new System.Drawing.Point(398, 138);
            this.textBoxEmployeeDataToJob.Name = "textBoxEmployeeDataToJob";
            this.textBoxEmployeeDataToJob.Size = new System.Drawing.Size(157, 20);
            this.textBoxEmployeeDataToJob.TabIndex = 9;
            // 
            // buttonDeletTask
            // 
            this.buttonDeletTask.Location = new System.Drawing.Point(398, 271);
            this.buttonDeletTask.Name = "buttonDeletTask";
            this.buttonDeletTask.Size = new System.Drawing.Size(157, 41);
            this.buttonDeletTask.TabIndex = 8;
            this.buttonDeletTask.Text = "Удалить";
            this.buttonDeletTask.UseVisualStyleBackColor = true;
            this.buttonDeletTask.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonEditTask
            // 
            this.buttonEditTask.Location = new System.Drawing.Point(398, 234);
            this.buttonEditTask.Name = "buttonEditTask";
            this.buttonEditTask.Size = new System.Drawing.Size(157, 38);
            this.buttonEditTask.TabIndex = 7;
            this.buttonEditTask.Text = "Изменить";
            this.buttonEditTask.UseVisualStyleBackColor = true;
            this.buttonEditTask.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonTasksAdd
            // 
            this.buttonTasksAdd.Location = new System.Drawing.Point(398, 201);
            this.buttonTasksAdd.Name = "buttonTasksAdd";
            this.buttonTasksAdd.Size = new System.Drawing.Size(157, 34);
            this.buttonTasksAdd.TabIndex = 6;
            this.buttonTasksAdd.Text = "Добавить";
            this.buttonTasksAdd.UseVisualStyleBackColor = true;
            this.buttonTasksAdd.Click += new System.EventHandler(this.buttonTasksAdd_Click);
            // 
            // textBoxEmployeePosition
            // 
            this.textBoxEmployeePosition.Location = new System.Drawing.Point(398, 98);
            this.textBoxEmployeePosition.Name = "textBoxEmployeePosition";
            this.textBoxEmployeePosition.Size = new System.Drawing.Size(157, 20);
            this.textBoxEmployeePosition.TabIndex = 4;
            // 
            // textBoxEmployeeName
            // 
            this.textBoxEmployeeName.Location = new System.Drawing.Point(398, 58);
            this.textBoxEmployeeName.Name = "textBoxEmployeeName";
            this.textBoxEmployeeName.Size = new System.Drawing.Size(157, 20);
            this.textBoxEmployeeName.TabIndex = 3;
            // 
            // comboBoxRestaurant
            // 
            this.comboBoxRestaurant.FormattingEnabled = true;
            this.comboBoxRestaurant.Location = new System.Drawing.Point(399, 19);
            this.comboBoxRestaurant.Name = "comboBoxRestaurant";
            this.comboBoxRestaurant.Size = new System.Drawing.Size(157, 21);
            this.comboBoxRestaurant.TabIndex = 1;
            this.comboBoxRestaurant.SelectedIndexChanged += new System.EventHandler(this.comboBoxRestaurant_SelectedIndexChanged);
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(7, 20);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.Size = new System.Drawing.Size(385, 399);
            this.dataGridViewEmployee.TabIndex = 0;
            this.dataGridViewEmployee.SelectionChanged += new System.EventHandler(this.dataGridViewEmployee_SelectionChanged);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DarkRed;
            this.button7.Location = new System.Drawing.Point(-3, 596);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(156, 38);
            this.button7.TabIndex = 5;
            this.button7.Text = "Выйти из аккаунта";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DarkRed;
            this.button8.Location = new System.Drawing.Point(137, 596);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(155, 38);
            this.button8.TabIndex = 6;
            this.button8.Text = "Закрыть приложение";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // textBoxEmployeeSalary
            // 
            this.textBoxEmployeeSalary.Location = new System.Drawing.Point(398, 175);
            this.textBoxEmployeeSalary.Name = "textBoxEmployeeSalary";
            this.textBoxEmployeeSalary.Size = new System.Drawing.Size(157, 20);
            this.textBoxEmployeeSalary.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Зарплата";
            // 
            // AboutAllForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(747, 631);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.groupBoxEmployee);
            this.Controls.Add(this.groupBoxRestaran);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonEmployees);
            this.Controls.Add(this.buttonRest);
            this.Name = "AboutAllForm";
            this.Text = "AboutAllForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRestaran)).EndInit();
            this.groupBoxRestaran.ResumeLayout(false);
            this.groupBoxRestaran.PerformLayout();
            this.groupBoxEmployee.ResumeLayout(false);
            this.groupBoxEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRest;
        private System.Windows.Forms.Button buttonEmployees;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.DataGridView dataGridViewRestaran;
        private System.Windows.Forms.GroupBox groupBoxRestaran;
        private System.Windows.Forms.TextBox textBoxRestLocation;
        private System.Windows.Forms.TextBox textBoxRestName;
        private System.Windows.Forms.Button buttonEditProjects;
        private System.Windows.Forms.Button buttonAddProjects;
        private System.Windows.Forms.Button buttonDeleteProjects;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.GroupBox groupBoxEmployee;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.ComboBox comboBoxRestaurant;
        private System.Windows.Forms.Button buttonDeletTask;
        private System.Windows.Forms.Button buttonEditTask;
        private System.Windows.Forms.Button buttonTasksAdd;
        private System.Windows.Forms.TextBox textBoxEmployeePosition;
        private System.Windows.Forms.TextBox textBoxEmployeeName;
        private System.Windows.Forms.TextBox textBoxEmployeeDataToJob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxRestEmail;
        private System.Windows.Forms.TextBox textBoxRestPhon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxRestHours;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEmployeeSalary;
    }
}