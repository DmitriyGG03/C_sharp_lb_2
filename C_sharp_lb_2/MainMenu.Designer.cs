namespace C_sharp_lb_2
{
    partial class MainMenu
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
            this.bt_CreateHostel = new System.Windows.Forms.Button();
            this.Main_label1 = new System.Windows.Forms.Label();
            this.topPanel1 = new System.Windows.Forms.Panel();
            this.bt_addStudents = new System.Windows.Forms.Button();
            this.bt_delStudents = new System.Windows.Forms.Button();
            this.bt_hostelInfo = new System.Windows.Forms.Button();
            this.bt_rooms = new System.Windows.Forms.Button();
            this.bt_addCanteen = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.bt_profitInfo = new System.Windows.Forms.Button();
            this.topPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_CreateHostel
            // 
            this.bt_CreateHostel.BackColor = System.Drawing.Color.LimeGreen;
            this.bt_CreateHostel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_CreateHostel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bt_CreateHostel.Font = new System.Drawing.Font("Segoe UI Emoji", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_CreateHostel.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_CreateHostel.Location = new System.Drawing.Point(10, 66);
            this.bt_CreateHostel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_CreateHostel.Name = "bt_CreateHostel";
            this.bt_CreateHostel.Size = new System.Drawing.Size(462, 42);
            this.bt_CreateHostel.TabIndex = 0;
            this.bt_CreateHostel.Text = "Створити новий гуртожиток";
            this.bt_CreateHostel.UseVisualStyleBackColor = false;
            this.bt_CreateHostel.Click += new System.EventHandler(this.bt_CreateHostel_Click);
            // 
            // Main_label1
            // 
            this.Main_label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Main_label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Main_label1.Font = new System.Drawing.Font("Segoe UI Emoji", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Main_label1.ForeColor = System.Drawing.Color.Green;
            this.Main_label1.Location = new System.Drawing.Point(175, 9);
            this.Main_label1.Name = "Main_label1";
            this.Main_label1.Size = new System.Drawing.Size(129, 47);
            this.Main_label1.TabIndex = 1;
            this.Main_label1.Text = "Меню";
            // 
            // topPanel1
            // 
            this.topPanel1.BackColor = System.Drawing.Color.LightGreen;
            this.topPanel1.Controls.Add(this.Main_label1);
            this.topPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel1.Location = new System.Drawing.Point(0, 0);
            this.topPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topPanel1.Name = "topPanel1";
            this.topPanel1.Size = new System.Drawing.Size(484, 62);
            this.topPanel1.TabIndex = 2;
            // 
            // bt_addStudents
            // 
            this.bt_addStudents.BackColor = System.Drawing.Color.LimeGreen;
            this.bt_addStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_addStudents.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bt_addStudents.Font = new System.Drawing.Font("Segoe UI Emoji", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_addStudents.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_addStudents.Location = new System.Drawing.Point(10, 112);
            this.bt_addStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_addStudents.Name = "bt_addStudents";
            this.bt_addStudents.Size = new System.Drawing.Size(462, 42);
            this.bt_addStudents.TabIndex = 3;
            this.bt_addStudents.Text = "Додати студентів до гуртожитку";
            this.bt_addStudents.UseVisualStyleBackColor = false;
            // 
            // bt_delStudents
            // 
            this.bt_delStudents.BackColor = System.Drawing.Color.LimeGreen;
            this.bt_delStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_delStudents.Font = new System.Drawing.Font("Segoe UI Emoji", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_delStudents.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_delStudents.Location = new System.Drawing.Point(10, 158);
            this.bt_delStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_delStudents.Name = "bt_delStudents";
            this.bt_delStudents.Size = new System.Drawing.Size(462, 42);
            this.bt_delStudents.TabIndex = 4;
            this.bt_delStudents.Text = "Видалити студентів з гуртожитку";
            this.bt_delStudents.UseVisualStyleBackColor = false;
            // 
            // bt_hostelInfo
            // 
            this.bt_hostelInfo.BackColor = System.Drawing.Color.LimeGreen;
            this.bt_hostelInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_hostelInfo.Font = new System.Drawing.Font("Segoe UI Emoji", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_hostelInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_hostelInfo.Location = new System.Drawing.Point(10, 204);
            this.bt_hostelInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_hostelInfo.Name = "bt_hostelInfo";
            this.bt_hostelInfo.Size = new System.Drawing.Size(462, 42);
            this.bt_hostelInfo.TabIndex = 5;
            this.bt_hostelInfo.Text = "Вивести інформацію про гуртожиток";
            this.bt_hostelInfo.UseVisualStyleBackColor = false;
            // 
            // bt_rooms
            // 
            this.bt_rooms.BackColor = System.Drawing.Color.LimeGreen;
            this.bt_rooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_rooms.Font = new System.Drawing.Font("Segoe UI Emoji", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_rooms.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_rooms.Location = new System.Drawing.Point(10, 250);
            this.bt_rooms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_rooms.Name = "bt_rooms";
            this.bt_rooms.Size = new System.Drawing.Size(462, 42);
            this.bt_rooms.TabIndex = 6;
            this.bt_rooms.Text = "Змінити кількість кімнат в гуртожитку";
            this.bt_rooms.UseVisualStyleBackColor = false;
            // 
            // bt_addCanteen
            // 
            this.bt_addCanteen.BackColor = System.Drawing.Color.LimeGreen;
            this.bt_addCanteen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_addCanteen.Font = new System.Drawing.Font("Segoe UI Emoji", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_addCanteen.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_addCanteen.Location = new System.Drawing.Point(10, 296);
            this.bt_addCanteen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_addCanteen.Name = "bt_addCanteen";
            this.bt_addCanteen.Size = new System.Drawing.Size(462, 42);
            this.bt_addCanteen.TabIndex = 7;
            this.bt_addCanteen.Text = "Додати їдальню до гуртожитку";
            this.bt_addCanteen.UseVisualStyleBackColor = false;
            this.bt_addCanteen.Click += new System.EventHandler(this.bt_addCanteen_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.BackColor = System.Drawing.Color.ForestGreen;
            this.bt_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_exit.Font = new System.Drawing.Font("Segoe UI Emoji", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_exit.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_exit.Location = new System.Drawing.Point(10, 388);
            this.bt_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(462, 42);
            this.bt_exit.TabIndex = 8;
            this.bt_exit.Text = "Вийти";
            this.bt_exit.UseVisualStyleBackColor = false;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // bt_profitInfo
            // 
            this.bt_profitInfo.BackColor = System.Drawing.Color.LimeGreen;
            this.bt_profitInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_profitInfo.Font = new System.Drawing.Font("Segoe UI Emoji", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_profitInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_profitInfo.Location = new System.Drawing.Point(10, 342);
            this.bt_profitInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_profitInfo.Name = "bt_profitInfo";
            this.bt_profitInfo.Size = new System.Drawing.Size(462, 42);
            this.bt_profitInfo.TabIndex = 9;
            this.bt_profitInfo.Text = "Вивести інформацію про доходи за період";
            this.bt_profitInfo.UseVisualStyleBackColor = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(484, 439);
            this.Controls.Add(this.bt_profitInfo);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_addCanteen);
            this.Controls.Add(this.bt_rooms);
            this.Controls.Add(this.bt_hostelInfo);
            this.Controls.Add(this.bt_delStudents);
            this.Controls.Add(this.bt_addStudents);
            this.Controls.Add(this.topPanel1);
            this.Controls.Add(this.bt_CreateHostel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 478);
            this.MinimumSize = new System.Drawing.Size(500, 478);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Студентський кампус";
            this.topPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button bt_CreateHostel;
        private Label Main_label1;
        private Panel topPanel1;
        private Button bt_addStudents;
        private Button bt_delStudents;
        private Button bt_hostelInfo;
        private Button bt_rooms;
        private Button bt_addCanteen;
        private Button bt_exit;
        private Button bt_profitInfo;
    }
}