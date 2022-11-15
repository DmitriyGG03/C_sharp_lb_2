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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.bt_CreateHostel = new System.Windows.Forms.Button();
            this.Main_label1 = new System.Windows.Forms.Label();
            this.topPanel1 = new System.Windows.Forms.Panel();
            this.bt_hostelManager = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
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
            this.bt_CreateHostel.Size = new System.Drawing.Size(310, 45);
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
            this.Main_label1.Location = new System.Drawing.Point(98, 9);
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
            this.topPanel1.Size = new System.Drawing.Size(330, 62);
            this.topPanel1.TabIndex = 2;
            // 
            // bt_hostelManager
            // 
            this.bt_hostelManager.BackColor = System.Drawing.Color.LimeGreen;
            this.bt_hostelManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_hostelManager.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bt_hostelManager.Font = new System.Drawing.Font("Segoe UI Emoji", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_hostelManager.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_hostelManager.Location = new System.Drawing.Point(10, 115);
            this.bt_hostelManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_hostelManager.Name = "bt_hostelManager";
            this.bt_hostelManager.Size = new System.Drawing.Size(310, 45);
            this.bt_hostelManager.TabIndex = 3;
            this.bt_hostelManager.Text = "Управління гуртожитками";
            this.bt_hostelManager.UseVisualStyleBackColor = false;
            this.bt_hostelManager.Click += new System.EventHandler(this.bt_hostelManager_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.BackColor = System.Drawing.Color.ForestGreen;
            this.bt_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_exit.Font = new System.Drawing.Font("Segoe UI Emoji", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_exit.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_exit.Location = new System.Drawing.Point(10, 176);
            this.bt_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(310, 45);
            this.bt_exit.TabIndex = 8;
            this.bt_exit.Text = "Вийти";
            this.bt_exit.UseVisualStyleBackColor = false;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(330, 232);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_hostelManager);
            this.Controls.Add(this.topPanel1);
            this.Controls.Add(this.bt_CreateHostel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(346, 271);
            this.MinimumSize = new System.Drawing.Size(346, 271);
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
        private Button bt_hostelManager;
        private Button bt_exit;
    }
}