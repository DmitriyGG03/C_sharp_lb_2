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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.topPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_CreateHostel
            // 
            this.bt_CreateHostel.BackColor = System.Drawing.Color.SandyBrown;
            this.bt_CreateHostel.Location = new System.Drawing.Point(12, 88);
            this.bt_CreateHostel.Name = "bt_CreateHostel";
            this.bt_CreateHostel.Size = new System.Drawing.Size(458, 56);
            this.bt_CreateHostel.TabIndex = 0;
            this.bt_CreateHostel.Text = "Створити новий гуртожиток";
            this.bt_CreateHostel.UseVisualStyleBackColor = false;
            // 
            // Main_label1
            // 
            this.Main_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Main_label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Main_label1.Font = new System.Drawing.Font("Segoe UI Emoji", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Main_label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Main_label1.Location = new System.Drawing.Point(158, 9);
            this.Main_label1.Name = "Main_label1";
            this.Main_label1.Size = new System.Drawing.Size(163, 63);
            this.Main_label1.TabIndex = 1;
            this.Main_label1.Text = "Меню";
            // 
            // topPanel1
            // 
            this.topPanel1.BackColor = System.Drawing.Color.Chocolate;
            this.topPanel1.Controls.Add(this.Main_label1);
            this.topPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel1.Location = new System.Drawing.Point(0, 0);
            this.topPanel1.Name = "topPanel1";
            this.topPanel1.Size = new System.Drawing.Size(482, 82);
            this.topPanel1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(458, 56);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 212);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(458, 56);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 274);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(458, 56);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 336);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(458, 56);
            this.button5.TabIndex = 6;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 398);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(458, 56);
            this.button6.TabIndex = 7;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 460);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(458, 56);
            this.button7.TabIndex = 8;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(482, 553);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.topPanel1);
            this.Controls.Add(this.bt_CreateHostel);
            this.Name = "MainMenu";
            this.Text = "Студентський кампус";
            this.topPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button bt_CreateHostel;
        private Label Main_label1;
        private Panel topPanel1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}