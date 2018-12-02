namespace UchetPO
{
    partial class Account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account));
            this.SaveChanges = new System.Windows.Forms.Button();
            this.Changes = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MobilBox = new System.Windows.Forms.MaskedTextBox();
            this.NumLabel = new System.Windows.Forms.Label();
            this.MobilePictureBox = new System.Windows.Forms.PictureBox();
            this.Line5 = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.NameImageBox = new System.Windows.Forms.PictureBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.PromptPass = new System.Windows.Forms.PictureBox();
            this.KeyBox = new System.Windows.Forms.PictureBox();
            this.EmailBox = new System.Windows.Forms.PictureBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.Line2 = new System.Windows.Forms.Label();
            this.Line4 = new System.Windows.Forms.Label();
            this.LoginBox = new System.Windows.Forms.Label();
            this.Switcher = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MobilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PromptPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KeyBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveChanges
            // 
            this.SaveChanges.Dock = System.Windows.Forms.DockStyle.Right;
            this.SaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveChanges.ForeColor = System.Drawing.Color.White;
            this.SaveChanges.Location = new System.Drawing.Point(651, 0);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(108, 39);
            this.SaveChanges.TabIndex = 33;
            this.SaveChanges.Text = "Сохранить";
            this.SaveChanges.UseVisualStyleBackColor = true;
            this.SaveChanges.Visible = false;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // Changes
            // 
            this.Changes.Dock = System.Windows.Forms.DockStyle.Right;
            this.Changes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Changes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Changes.ForeColor = System.Drawing.Color.White;
            this.Changes.Location = new System.Drawing.Point(548, 0);
            this.Changes.Name = "Changes";
            this.Changes.Size = new System.Drawing.Size(103, 39);
            this.Changes.TabIndex = 32;
            this.Changes.Text = "Изменить";
            this.Changes.UseVisualStyleBackColor = true;
            this.Changes.Click += new System.EventHandler(this.ChangesCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Changes);
            this.panel1.Controls.Add(this.SaveChanges);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 501);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 39);
            this.panel1.TabIndex = 34;
            // 
            // MobilBox
            // 
            this.MobilBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.MobilBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MobilBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MobilBox.ForeColor = System.Drawing.Color.White;
            this.MobilBox.Location = new System.Drawing.Point(144, 323);
            this.MobilBox.Mask = "+7 (999) 999-99-99";
            this.MobilBox.Name = "MobilBox";
            this.MobilBox.Size = new System.Drawing.Size(219, 26);
            this.MobilBox.TabIndex = 54;
            // 
            // NumLabel
            // 
            this.NumLabel.AutoSize = true;
            this.NumLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumLabel.ForeColor = System.Drawing.Color.White;
            this.NumLabel.Location = new System.Drawing.Point(94, 359);
            this.NumLabel.Name = "NumLabel";
            this.NumLabel.Size = new System.Drawing.Size(145, 17);
            this.NumLabel.TabIndex = 53;
            this.NumLabel.Text = "Ваш номер телефона";
            // 
            // MobilePictureBox
            // 
            this.MobilePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("MobilePictureBox.Image")));
            this.MobilePictureBox.Location = new System.Drawing.Point(100, 312);
            this.MobilePictureBox.Name = "MobilePictureBox";
            this.MobilePictureBox.Size = new System.Drawing.Size(39, 38);
            this.MobilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MobilePictureBox.TabIndex = 52;
            this.MobilePictureBox.TabStop = false;
            // 
            // Line5
            // 
            this.Line5.AutoSize = true;
            this.Line5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Line5.ForeColor = System.Drawing.Color.White;
            this.Line5.Location = new System.Drawing.Point(94, 331);
            this.Line5.Name = "Line5";
            this.Line5.Size = new System.Drawing.Size(274, 24);
            this.Line5.TabIndex = 51;
            this.Line5.Text = "________________________";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.ForeColor = System.Drawing.Color.White;
            this.NameLabel.Location = new System.Drawing.Point(94, 286);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(69, 17);
            this.NameLabel.TabIndex = 50;
            this.NameLabel.Text = "Ваше имя";
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassLabel.ForeColor = System.Drawing.Color.White;
            this.PassLabel.Location = new System.Drawing.Point(151, 206);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(129, 17);
            this.PassLabel.TabIndex = 48;
            this.PassLabel.Text = "Не изменить пароль";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailLabel.ForeColor = System.Drawing.Color.White;
            this.EmailLabel.Location = new System.Drawing.Point(94, 125);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(130, 17);
            this.EmailLabel.TabIndex = 47;
            this.EmailLabel.Text = "Ваш E-mail или логин";
            // 
            // NameImageBox
            // 
            this.NameImageBox.Image = ((System.Drawing.Image)(resources.GetObject("NameImageBox.Image")));
            this.NameImageBox.Location = new System.Drawing.Point(100, 241);
            this.NameImageBox.Name = "NameImageBox";
            this.NameImageBox.Size = new System.Drawing.Size(39, 38);
            this.NameImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NameImageBox.TabIndex = 46;
            this.NameImageBox.TabStop = false;
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameBox.ForeColor = System.Drawing.Color.White;
            this.NameBox.Location = new System.Drawing.Point(144, 252);
            this.NameBox.MaxLength = 64;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(219, 26);
            this.NameBox.TabIndex = 44;
            this.NameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameBox_KeyPress);
            // 
            // PromptPass
            // 
            this.PromptPass.Image = ((System.Drawing.Image)(resources.GetObject("PromptPass.Image")));
            this.PromptPass.Location = new System.Drawing.Point(338, 170);
            this.PromptPass.Name = "PromptPass";
            this.PromptPass.Size = new System.Drawing.Size(25, 25);
            this.PromptPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PromptPass.TabIndex = 40;
            this.PromptPass.TabStop = false;
            this.PromptPass.Click += new System.EventHandler(this.PromptPass_Click);
            // 
            // KeyBox
            // 
            this.KeyBox.Image = ((System.Drawing.Image)(resources.GetObject("KeyBox.Image")));
            this.KeyBox.Location = new System.Drawing.Point(100, 157);
            this.KeyBox.Name = "KeyBox";
            this.KeyBox.Size = new System.Drawing.Size(39, 38);
            this.KeyBox.TabIndex = 39;
            this.KeyBox.TabStop = false;
            // 
            // EmailBox
            // 
            this.EmailBox.Image = ((System.Drawing.Image)(resources.GetObject("EmailBox.Image")));
            this.EmailBox.Location = new System.Drawing.Point(100, 79);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(39, 38);
            this.EmailBox.TabIndex = 38;
            this.EmailBox.TabStop = false;
            // 
            // PasswordBox
            // 
            this.PasswordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.PasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordBox.Enabled = false;
            this.PasswordBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordBox.ForeColor = System.Drawing.Color.White;
            this.PasswordBox.Location = new System.Drawing.Point(144, 168);
            this.PasswordBox.MaxLength = 63;
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '•';
            this.PasswordBox.Size = new System.Drawing.Size(188, 26);
            this.PasswordBox.TabIndex = 35;
            // 
            // Line2
            // 
            this.Line2.AutoSize = true;
            this.Line2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Line2.ForeColor = System.Drawing.Color.White;
            this.Line2.Location = new System.Drawing.Point(94, 176);
            this.Line2.Name = "Line2";
            this.Line2.Size = new System.Drawing.Size(274, 24);
            this.Line2.TabIndex = 36;
            this.Line2.Text = "________________________";
            // 
            // Line4
            // 
            this.Line4.AutoSize = true;
            this.Line4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Line4.ForeColor = System.Drawing.Color.White;
            this.Line4.Location = new System.Drawing.Point(94, 260);
            this.Line4.Name = "Line4";
            this.Line4.Size = new System.Drawing.Size(274, 24);
            this.Line4.TabIndex = 45;
            this.Line4.Text = "________________________";
            // 
            // LoginBox
            // 
            this.LoginBox.AutoSize = true;
            this.LoginBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginBox.ForeColor = System.Drawing.Color.White;
            this.LoginBox.Location = new System.Drawing.Point(149, 87);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(0, 25);
            this.LoginBox.TabIndex = 55;
            // 
            // Switcher
            // 
            this.Switcher.BackColor = System.Drawing.Color.Transparent;
            this.Switcher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Switcher.BackgroundImage")));
            this.Switcher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Switcher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Switcher.Location = new System.Drawing.Point(100, 203);
            this.Switcher.Name = "Switcher";
            this.Switcher.OffColor = System.Drawing.Color.Gray;
            this.Switcher.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.Switcher.Size = new System.Drawing.Size(35, 20);
            this.Switcher.TabIndex = 56;
            this.Switcher.Value = false;
            this.Switcher.OnValueChange += new System.EventHandler(this.Switcher_OnValueChange);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(759, 540);
            this.Controls.Add(this.Switcher);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.MobilBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NumLabel);
            this.Controls.Add(this.MobilePictureBox);
            this.Controls.Add(this.Line5);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.NameImageBox);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.KeyBox);
            this.Controls.Add(this.PromptPass);
            this.Controls.Add(this.Line4);
            this.Controls.Add(this.Line2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Account";
            this.Text = "Account";
            this.Load += new System.EventHandler(this.Account_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MobilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PromptPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KeyBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SaveChanges;
        private System.Windows.Forms.Button Changes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox MobilBox;
        private System.Windows.Forms.Label NumLabel;
        private System.Windows.Forms.PictureBox MobilePictureBox;
        private System.Windows.Forms.Label Line5;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.PictureBox NameImageBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.PictureBox PromptPass;
        private System.Windows.Forms.PictureBox KeyBox;
        private System.Windows.Forms.PictureBox EmailBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label Line2;
        private System.Windows.Forms.Label Line4;
        private System.Windows.Forms.Label LoginBox;
        private Bunifu.Framework.UI.BunifuiOSSwitch Switcher;
    }
}