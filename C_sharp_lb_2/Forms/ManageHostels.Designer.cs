namespace C_sharp_lb_2.Forms
{
    partial class ManageHostels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageHostels));
            this.label1 = new System.Windows.Forms.Label();
            this.pb_2 = new System.Windows.Forms.PictureBox();
            this.tb_studNumber = new System.Windows.Forms.TextBox();
            this.lb_hostelID = new System.Windows.Forms.Label();
            this.pb_1 = new System.Windows.Forms.PictureBox();
            this.tb_hostelID = new System.Windows.Forms.TextBox();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.bt_addStudents = new System.Windows.Forms.Button();
            this.bt_delStudents = new System.Windows.Forms.Button();
            this.bt_showInfo = new System.Windows.Forms.Button();
            this.bt_addCanteen = new System.Windows.Forms.Button();
            this.gb_studNumber = new System.Windows.Forms.GroupBox();
            this.gb_roomNumber = new System.Windows.Forms.GroupBox();
            this.tb_roomNumber = new System.Windows.Forms.TextBox();
            this.pb_3 = new System.Windows.Forms.PictureBox();
            this.bt_delRooms = new System.Windows.Forms.Button();
            this.bt_addRooms = new System.Windows.Forms.Button();
            this.gb_stuffNumber = new System.Windows.Forms.GroupBox();
            this.tb_stuffNumber = new System.Windows.Forms.TextBox();
            this.pb_4 = new System.Windows.Forms.PictureBox();
            this.bt_delStuff = new System.Windows.Forms.Button();
            this.bt_addStuff = new System.Windows.Forms.Button();
            this.rb_year = new System.Windows.Forms.RadioButton();
            this.gb_calcProfits = new System.Windows.Forms.GroupBox();
            this.bt_calcProfit = new System.Windows.Forms.Button();
            this.rb_month = new System.Windows.Forms.RadioButton();
            this.rb_6month = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pb_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_1)).BeginInit();
            this.gb_studNumber.SuspendLayout();
            this.gb_roomNumber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_3)).BeginInit();
            this.gb_stuffNumber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_4)).BeginInit();
            this.gb_calcProfits.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1131, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Управління гуртожитками";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_2
            // 
            this.pb_2.Image = global::C_sharp_lb_2.Properties.Resources.PicDislike;
            this.pb_2.Location = new System.Drawing.Point(11, 33);
            this.pb_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_2.Name = "pb_2";
            this.pb_2.Size = new System.Drawing.Size(65, 65);
            this.pb_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_2.TabIndex = 13;
            this.pb_2.TabStop = false;
            // 
            // tb_studNumber
            // 
            this.tb_studNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_studNumber.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_studNumber.Location = new System.Drawing.Point(84, 33);
            this.tb_studNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_studNumber.Multiline = true;
            this.tb_studNumber.Name = "tb_studNumber";
            this.tb_studNumber.Size = new System.Drawing.Size(400, 65);
            this.tb_studNumber.TabIndex = 12;
            this.tb_studNumber.TextChanged += new System.EventHandler(this.tb_studNumber_TextChanged);
            // 
            // lb_hostelID
            // 
            this.lb_hostelID.AutoSize = true;
            this.lb_hostelID.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_hostelID.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_hostelID.Location = new System.Drawing.Point(24, 47);
            this.lb_hostelID.Name = "lb_hostelID";
            this.lb_hostelID.Size = new System.Drawing.Size(228, 28);
            this.lb_hostelID.TabIndex = 11;
            this.lb_hostelID.Text = "Номер гуртожитку";
            // 
            // pb_1
            // 
            this.pb_1.Image = global::C_sharp_lb_2.Properties.Resources.PicDislike;
            this.pb_1.Location = new System.Drawing.Point(24, 83);
            this.pb_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_1.Name = "pb_1";
            this.pb_1.Size = new System.Drawing.Size(65, 65);
            this.pb_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_1.TabIndex = 10;
            this.pb_1.TabStop = false;
            // 
            // tb_hostelID
            // 
            this.tb_hostelID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_hostelID.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_hostelID.Location = new System.Drawing.Point(97, 83);
            this.tb_hostelID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_hostelID.Multiline = true;
            this.tb_hostelID.Name = "tb_hostelID";
            this.tb_hostelID.Size = new System.Drawing.Size(400, 65);
            this.tb_hostelID.TabIndex = 9;
            this.tb_hostelID.TextChanged += new System.EventHandler(this.tb_hostelID_TextChanged);
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Cancel.FlatAppearance.BorderSize = 0;
            this.bt_Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.bt_Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.bt_Cancel.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_Cancel.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_Cancel.Location = new System.Drawing.Point(681, 556);
            this.bt_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(280, 60);
            this.bt_Cancel.TabIndex = 16;
            this.bt_Cancel.Text = "Відміна";
            this.bt_Cancel.UseVisualStyleBackColor = false;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // bt_addStudents
            // 
            this.bt_addStudents.BackColor = System.Drawing.Color.LimeGreen;
            this.bt_addStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_addStudents.FlatAppearance.BorderSize = 0;
            this.bt_addStudents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.bt_addStudents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_addStudents.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_addStudents.Location = new System.Drawing.Point(514, 33);
            this.bt_addStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_addStudents.Name = "bt_addStudents";
            this.bt_addStudents.Size = new System.Drawing.Size(280, 60);
            this.bt_addStudents.TabIndex = 15;
            this.bt_addStudents.Text = "Додати студентів";
            this.bt_addStudents.UseVisualStyleBackColor = false;
            this.bt_addStudents.Click += new System.EventHandler(this.bt_addStudents_Click);
            // 
            // bt_delStudents
            // 
            this.bt_delStudents.BackColor = System.Drawing.Color.Tomato;
            this.bt_delStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_delStudents.FlatAppearance.BorderSize = 0;
            this.bt_delStudents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.bt_delStudents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.bt_delStudents.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_delStudents.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_delStudents.Location = new System.Drawing.Point(811, 33);
            this.bt_delStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_delStudents.Name = "bt_delStudents";
            this.bt_delStudents.Size = new System.Drawing.Size(280, 60);
            this.bt_delStudents.TabIndex = 17;
            this.bt_delStudents.Text = "Видалити студентів";
            this.bt_delStudents.UseVisualStyleBackColor = false;
            this.bt_delStudents.Click += new System.EventHandler(this.bt_delStudents_Click);
            // 
            // bt_showInfo
            // 
            this.bt_showInfo.BackColor = System.Drawing.Color.Yellow;
            this.bt_showInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_showInfo.FlatAppearance.BorderSize = 0;
            this.bt_showInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.bt_showInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_showInfo.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_showInfo.Location = new System.Drawing.Point(527, 83);
            this.bt_showInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_showInfo.Name = "bt_showInfo";
            this.bt_showInfo.Size = new System.Drawing.Size(280, 60);
            this.bt_showInfo.TabIndex = 23;
            this.bt_showInfo.Text = "Вивести інформацію";
            this.bt_showInfo.UseVisualStyleBackColor = false;
            this.bt_showInfo.Click += new System.EventHandler(this.bt_showInfo_Click);
            // 
            // bt_addCanteen
            // 
            this.bt_addCanteen.BackColor = System.Drawing.Color.Yellow;
            this.bt_addCanteen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_addCanteen.FlatAppearance.BorderSize = 0;
            this.bt_addCanteen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.bt_addCanteen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_addCanteen.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_addCanteen.Location = new System.Drawing.Point(824, 83);
            this.bt_addCanteen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_addCanteen.Name = "bt_addCanteen";
            this.bt_addCanteen.Size = new System.Drawing.Size(280, 60);
            this.bt_addCanteen.TabIndex = 24;
            this.bt_addCanteen.Text = "Додати їдальню";
            this.bt_addCanteen.UseVisualStyleBackColor = false;
            this.bt_addCanteen.Click += new System.EventHandler(this.bt_addCanteen_Click);
            // 
            // gb_studNumber
            // 
            this.gb_studNumber.Controls.Add(this.tb_studNumber);
            this.gb_studNumber.Controls.Add(this.pb_2);
            this.gb_studNumber.Controls.Add(this.bt_delStudents);
            this.gb_studNumber.Controls.Add(this.bt_addStudents);
            this.gb_studNumber.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_studNumber.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gb_studNumber.Location = new System.Drawing.Point(13, 171);
            this.gb_studNumber.Name = "gb_studNumber";
            this.gb_studNumber.Size = new System.Drawing.Size(1106, 116);
            this.gb_studNumber.TabIndex = 25;
            this.gb_studNumber.TabStop = false;
            this.gb_studNumber.Text = "Кількість студентів";
            // 
            // gb_roomNumber
            // 
            this.gb_roomNumber.Controls.Add(this.tb_roomNumber);
            this.gb_roomNumber.Controls.Add(this.pb_3);
            this.gb_roomNumber.Controls.Add(this.bt_delRooms);
            this.gb_roomNumber.Controls.Add(this.bt_addRooms);
            this.gb_roomNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_roomNumber.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_roomNumber.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gb_roomNumber.Location = new System.Drawing.Point(13, 293);
            this.gb_roomNumber.Name = "gb_roomNumber";
            this.gb_roomNumber.Size = new System.Drawing.Size(1106, 116);
            this.gb_roomNumber.TabIndex = 26;
            this.gb_roomNumber.TabStop = false;
            this.gb_roomNumber.Text = "Кількість кімнат";
            // 
            // tb_roomNumber
            // 
            this.tb_roomNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_roomNumber.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_roomNumber.Location = new System.Drawing.Point(84, 33);
            this.tb_roomNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_roomNumber.Multiline = true;
            this.tb_roomNumber.Name = "tb_roomNumber";
            this.tb_roomNumber.Size = new System.Drawing.Size(400, 65);
            this.tb_roomNumber.TabIndex = 12;
            this.tb_roomNumber.TextChanged += new System.EventHandler(this.tb_roomNumber_TextChanged);
            // 
            // pb_3
            // 
            this.pb_3.Image = global::C_sharp_lb_2.Properties.Resources.PicDislike;
            this.pb_3.Location = new System.Drawing.Point(11, 33);
            this.pb_3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_3.Name = "pb_3";
            this.pb_3.Size = new System.Drawing.Size(65, 65);
            this.pb_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_3.TabIndex = 13;
            this.pb_3.TabStop = false;
            // 
            // bt_delRooms
            // 
            this.bt_delRooms.BackColor = System.Drawing.Color.Tomato;
            this.bt_delRooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_delRooms.FlatAppearance.BorderSize = 0;
            this.bt_delRooms.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.bt_delRooms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.bt_delRooms.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_delRooms.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_delRooms.Location = new System.Drawing.Point(811, 33);
            this.bt_delRooms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_delRooms.Name = "bt_delRooms";
            this.bt_delRooms.Size = new System.Drawing.Size(280, 60);
            this.bt_delRooms.TabIndex = 17;
            this.bt_delRooms.Text = "Видалити кімнати";
            this.bt_delRooms.UseVisualStyleBackColor = false;
            this.bt_delRooms.Click += new System.EventHandler(this.bt_delRooms_Click);
            // 
            // bt_addRooms
            // 
            this.bt_addRooms.BackColor = System.Drawing.Color.LimeGreen;
            this.bt_addRooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_addRooms.FlatAppearance.BorderSize = 0;
            this.bt_addRooms.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.bt_addRooms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_addRooms.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_addRooms.Location = new System.Drawing.Point(514, 33);
            this.bt_addRooms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_addRooms.Name = "bt_addRooms";
            this.bt_addRooms.Size = new System.Drawing.Size(280, 60);
            this.bt_addRooms.TabIndex = 15;
            this.bt_addRooms.Text = "Додати кімнати";
            this.bt_addRooms.UseVisualStyleBackColor = false;
            this.bt_addRooms.Click += new System.EventHandler(this.bt_addRooms_Click);
            // 
            // gb_stuffNumber
            // 
            this.gb_stuffNumber.Controls.Add(this.tb_stuffNumber);
            this.gb_stuffNumber.Controls.Add(this.pb_4);
            this.gb_stuffNumber.Controls.Add(this.bt_delStuff);
            this.gb_stuffNumber.Controls.Add(this.bt_addStuff);
            this.gb_stuffNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_stuffNumber.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_stuffNumber.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gb_stuffNumber.Location = new System.Drawing.Point(13, 415);
            this.gb_stuffNumber.Name = "gb_stuffNumber";
            this.gb_stuffNumber.Size = new System.Drawing.Size(1106, 116);
            this.gb_stuffNumber.TabIndex = 27;
            this.gb_stuffNumber.TabStop = false;
            this.gb_stuffNumber.Text = "Кількість робітників";
            // 
            // tb_stuffNumber
            // 
            this.tb_stuffNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_stuffNumber.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_stuffNumber.Location = new System.Drawing.Point(84, 33);
            this.tb_stuffNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_stuffNumber.Multiline = true;
            this.tb_stuffNumber.Name = "tb_stuffNumber";
            this.tb_stuffNumber.Size = new System.Drawing.Size(400, 65);
            this.tb_stuffNumber.TabIndex = 12;
            this.tb_stuffNumber.TextChanged += new System.EventHandler(this.tb_stuffNumber_TextChanged);
            // 
            // pb_4
            // 
            this.pb_4.Image = global::C_sharp_lb_2.Properties.Resources.PicDislike;
            this.pb_4.Location = new System.Drawing.Point(11, 33);
            this.pb_4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_4.Name = "pb_4";
            this.pb_4.Size = new System.Drawing.Size(65, 65);
            this.pb_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_4.TabIndex = 13;
            this.pb_4.TabStop = false;
            // 
            // bt_delStuff
            // 
            this.bt_delStuff.BackColor = System.Drawing.Color.Tomato;
            this.bt_delStuff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_delStuff.FlatAppearance.BorderSize = 0;
            this.bt_delStuff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.bt_delStuff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.bt_delStuff.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_delStuff.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_delStuff.Location = new System.Drawing.Point(811, 33);
            this.bt_delStuff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_delStuff.Name = "bt_delStuff";
            this.bt_delStuff.Size = new System.Drawing.Size(280, 60);
            this.bt_delStuff.TabIndex = 17;
            this.bt_delStuff.Text = "Видалити робітників";
            this.bt_delStuff.UseVisualStyleBackColor = false;
            this.bt_delStuff.Click += new System.EventHandler(this.bt_delStuff_Click);
            // 
            // bt_addStuff
            // 
            this.bt_addStuff.BackColor = System.Drawing.Color.LimeGreen;
            this.bt_addStuff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_addStuff.FlatAppearance.BorderSize = 0;
            this.bt_addStuff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.bt_addStuff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_addStuff.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_addStuff.Location = new System.Drawing.Point(514, 33);
            this.bt_addStuff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_addStuff.Name = "bt_addStuff";
            this.bt_addStuff.Size = new System.Drawing.Size(280, 60);
            this.bt_addStuff.TabIndex = 15;
            this.bt_addStuff.Text = "Додати робітників";
            this.bt_addStuff.UseVisualStyleBackColor = false;
            this.bt_addStuff.Click += new System.EventHandler(this.bt_addStuff_Click);
            // 
            // rb_year
            // 
            this.rb_year.AutoSize = true;
            this.rb_year.Location = new System.Drawing.Point(12, 34);
            this.rb_year.Name = "rb_year";
            this.rb_year.Size = new System.Drawing.Size(64, 32);
            this.rb_year.TabIndex = 28;
            this.rb_year.TabStop = true;
            this.rb_year.Text = "Рік";
            this.rb_year.UseVisualStyleBackColor = true;
            // 
            // gb_calcProfits
            // 
            this.gb_calcProfits.BackColor = System.Drawing.Color.Khaki;
            this.gb_calcProfits.Controls.Add(this.bt_calcProfit);
            this.gb_calcProfits.Controls.Add(this.rb_month);
            this.gb_calcProfits.Controls.Add(this.rb_6month);
            this.gb_calcProfits.Controls.Add(this.rb_year);
            this.gb_calcProfits.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_calcProfits.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gb_calcProfits.Location = new System.Drawing.Point(12, 537);
            this.gb_calcProfits.Name = "gb_calcProfits";
            this.gb_calcProfits.Size = new System.Drawing.Size(530, 82);
            this.gb_calcProfits.TabIndex = 29;
            this.gb_calcProfits.TabStop = false;
            this.gb_calcProfits.Text = "Порахувати доходи";
            // 
            // bt_calcProfit
            // 
            this.bt_calcProfit.BackColor = System.Drawing.Color.DarkKhaki;
            this.bt_calcProfit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_calcProfit.FlatAppearance.BorderSize = 0;
            this.bt_calcProfit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.bt_calcProfit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_calcProfit.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_calcProfit.Location = new System.Drawing.Point(320, 27);
            this.bt_calcProfit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_calcProfit.Name = "bt_calcProfit";
            this.bt_calcProfit.Size = new System.Drawing.Size(200, 45);
            this.bt_calcProfit.TabIndex = 31;
            this.bt_calcProfit.Text = "Порахувати";
            this.bt_calcProfit.UseVisualStyleBackColor = false;
            this.bt_calcProfit.Click += new System.EventHandler(this.bt_calcProfit_Click);
            // 
            // rb_month
            // 
            this.rb_month.AutoSize = true;
            this.rb_month.Location = new System.Drawing.Point(208, 34);
            this.rb_month.Name = "rb_month";
            this.rb_month.Size = new System.Drawing.Size(106, 32);
            this.rb_month.TabIndex = 30;
            this.rb_month.TabStop = true;
            this.rb_month.Text = "Місяць";
            this.rb_month.UseVisualStyleBackColor = true;
            // 
            // rb_6month
            // 
            this.rb_6month.AutoSize = true;
            this.rb_6month.Location = new System.Drawing.Point(85, 34);
            this.rb_6month.Name = "rb_6month";
            this.rb_6month.Size = new System.Drawing.Size(117, 32);
            this.rb_6month.TabIndex = 29;
            this.rb_6month.TabStop = true;
            this.rb_6month.Text = "Півроку";
            this.rb_6month.UseVisualStyleBackColor = true;
            // 
            // ManageHostels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1131, 632);
            this.Controls.Add(this.gb_calcProfits);
            this.Controls.Add(this.gb_stuffNumber);
            this.Controls.Add(this.gb_roomNumber);
            this.Controls.Add(this.gb_studNumber);
            this.Controls.Add(this.bt_addCanteen);
            this.Controls.Add(this.bt_showInfo);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.lb_hostelID);
            this.Controls.Add(this.pb_1);
            this.Controls.Add(this.tb_hostelID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1151, 675);
            this.MinimumSize = new System.Drawing.Size(1151, 675);
            this.Name = "ManageHostels";
            this.Text = "ManageStudents";
            this.Load += new System.EventHandler(this.ManageHostels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_1)).EndInit();
            this.gb_studNumber.ResumeLayout(false);
            this.gb_studNumber.PerformLayout();
            this.gb_roomNumber.ResumeLayout(false);
            this.gb_roomNumber.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_3)).EndInit();
            this.gb_stuffNumber.ResumeLayout(false);
            this.gb_stuffNumber.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_4)).EndInit();
            this.gb_calcProfits.ResumeLayout(false);
            this.gb_calcProfits.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private PictureBox pb_2;
        private TextBox tb_studNumber;
        private Label lb_hostelID;
        private PictureBox pb_1;
        private TextBox tb_hostelID;
        private Button bt_Cancel;
        private Button bt_addStudents;
        private Button bt_delStudents;
        private Button bt_showInfo;
        private Button bt_addCanteen;
        private GroupBox gb_studNumber;
        private GroupBox gb_roomNumber;
        private TextBox tb_roomNumber;
        private PictureBox pb_3;
        private Button bt_delRooms;
        private Button bt_addRooms;
        private GroupBox gb_stuffNumber;
        private TextBox tb_stuffNumber;
        private PictureBox pb_4;
        private Button bt_delStuff;
        private Button bt_addStuff;
        private RadioButton radioButton1;
        private GroupBox gb_calcProfits;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton rb_year;
        private Button bt_calcProfit;
        private RadioButton rb_month;
        private RadioButton rb_6month;
    }
}