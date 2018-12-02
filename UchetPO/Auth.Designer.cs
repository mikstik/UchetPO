namespace UchetPO
{
    partial class Auth
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auth));
            this.AuthPanel = new System.Windows.Forms.Panel();
            this.Setting = new System.Windows.Forms.Button();
            this.RememberLabel = new System.Windows.Forms.Label();
            this.RememberUser = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.Facebook = new System.Windows.Forms.Button();
            this.Google = new System.Windows.Forms.Button();
            this.VK = new System.Windows.Forms.Button();
            this.ChangeEnter = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.PromptPass = new System.Windows.Forms.PictureBox();
            this.KeyBox = new System.Windows.Forms.PictureBox();
            this.EmailBox = new System.Windows.Forms.PictureBox();
            this.Registration = new System.Windows.Forms.Button();
            this.EnterApp = new System.Windows.Forms.Button();
            this.TypeLogo = new System.Windows.Forms.PictureBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.LabelEnter = new System.Windows.Forms.Label();
            this.LabelAuth = new System.Windows.Forms.Label();
            this.Line1 = new System.Windows.Forms.Label();
            this.Line2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SettingPanel = new System.Windows.Forms.Panel();
            this.Switcher = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.AcceptCatalog = new System.Windows.Forms.Button();
            this.Auto = new System.Windows.Forms.Button();
            this.Sqllabel = new System.Windows.Forms.Label();
            this.SQLBox = new System.Windows.Forms.TextBox();
            this.ChangeServer = new System.Windows.Forms.Label();
            this.DataBase = new System.Windows.Forms.PictureBox();
            this.Accept = new System.Windows.Forms.Button();
            this.ServersList = new System.Windows.Forms.ComboBox();
            this.GetServerList = new System.Windows.Forms.Button();
            this.SettingsLabel = new System.Windows.Forms.Label();
            this.ServerBox = new System.Windows.Forms.TextBox();
            this.Line3 = new System.Windows.Forms.Label();
            this.Line4 = new System.Windows.Forms.Label();
            this.AuthPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PromptPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KeyBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypeLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SettingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataBase)).BeginInit();
            this.SuspendLayout();
            // 
            // AuthPanel
            // 
            this.AuthPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.AuthPanel.Controls.Add(this.Setting);
            this.AuthPanel.Controls.Add(this.RememberLabel);
            this.AuthPanel.Controls.Add(this.RememberUser);
            this.AuthPanel.Controls.Add(this.Facebook);
            this.AuthPanel.Controls.Add(this.Google);
            this.AuthPanel.Controls.Add(this.VK);
            this.AuthPanel.Controls.Add(this.ChangeEnter);
            this.AuthPanel.Controls.Add(this.ExitButton);
            this.AuthPanel.Controls.Add(this.PromptPass);
            this.AuthPanel.Controls.Add(this.KeyBox);
            this.AuthPanel.Controls.Add(this.EmailBox);
            this.AuthPanel.Controls.Add(this.Registration);
            this.AuthPanel.Controls.Add(this.EnterApp);
            this.AuthPanel.Controls.Add(this.TypeLogo);
            this.AuthPanel.Controls.Add(this.PasswordBox);
            this.AuthPanel.Controls.Add(this.LoginBox);
            this.AuthPanel.Controls.Add(this.LabelEnter);
            this.AuthPanel.Controls.Add(this.LabelAuth);
            this.AuthPanel.Controls.Add(this.Line1);
            this.AuthPanel.Controls.Add(this.Line2);
            this.AuthPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.AuthPanel.Location = new System.Drawing.Point(420, 0);
            this.AuthPanel.Name = "AuthPanel";
            this.AuthPanel.Size = new System.Drawing.Size(390, 435);
            this.AuthPanel.TabIndex = 1;
            // 
            // Setting
            // 
            this.Setting.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Setting.FlatAppearance.BorderSize = 0;
            this.Setting.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Setting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Setting.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Setting.ForeColor = System.Drawing.Color.White;
            this.Setting.Image = ((System.Drawing.Image)(resources.GetObject("Setting.Image")));
            this.Setting.Location = new System.Drawing.Point(349, 396);
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(41, 38);
            this.Setting.TabIndex = 28;
            this.Setting.UseVisualStyleBackColor = true;
            this.Setting.Click += new System.EventHandler(this.Setting_Click);
            // 
            // RememberLabel
            // 
            this.RememberLabel.AutoSize = true;
            this.RememberLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RememberLabel.ForeColor = System.Drawing.Color.White;
            this.RememberLabel.Location = new System.Drawing.Point(115, 280);
            this.RememberLabel.Name = "RememberLabel";
            this.RememberLabel.Size = new System.Drawing.Size(134, 20);
            this.RememberLabel.TabIndex = 21;
            this.RememberLabel.Text = "Запомнить меня";
            // 
            // RememberUser
            // 
            this.RememberUser.BackColor = System.Drawing.Color.Transparent;
            this.RememberUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RememberUser.BackgroundImage")));
            this.RememberUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RememberUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RememberUser.Location = new System.Drawing.Point(70, 280);
            this.RememberUser.Name = "RememberUser";
            this.RememberUser.OffColor = System.Drawing.Color.Gray;
            this.RememberUser.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.RememberUser.Size = new System.Drawing.Size(35, 20);
            this.RememberUser.TabIndex = 20;
            this.RememberUser.Value = false;
            // 
            // Facebook
            // 
            this.Facebook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Facebook.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Facebook.FlatAppearance.BorderSize = 0;
            this.Facebook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.Facebook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.Facebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Facebook.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Facebook.ForeColor = System.Drawing.Color.Black;
            this.Facebook.Image = ((System.Drawing.Image)(resources.GetObject("Facebook.Image")));
            this.Facebook.Location = new System.Drawing.Point(70, 481);
            this.Facebook.Name = "Facebook";
            this.Facebook.Size = new System.Drawing.Size(65, 65);
            this.Facebook.TabIndex = 18;
            this.Facebook.UseVisualStyleBackColor = false;
            // 
            // Google
            // 
            this.Google.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Google.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Google.FlatAppearance.BorderSize = 0;
            this.Google.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(78)))), ((int)(((byte)(65)))));
            this.Google.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(78)))), ((int)(((byte)(65)))));
            this.Google.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Google.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Google.ForeColor = System.Drawing.Color.Black;
            this.Google.Image = ((System.Drawing.Image)(resources.GetObject("Google.Image")));
            this.Google.Location = new System.Drawing.Point(170, 481);
            this.Google.Name = "Google";
            this.Google.Size = new System.Drawing.Size(65, 65);
            this.Google.TabIndex = 17;
            this.Google.UseVisualStyleBackColor = false;
            // 
            // VK
            // 
            this.VK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.VK.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.VK.FlatAppearance.BorderSize = 0;
            this.VK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.VK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.VK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VK.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VK.ForeColor = System.Drawing.Color.Black;
            this.VK.Image = ((System.Drawing.Image)(resources.GetObject("VK.Image")));
            this.VK.Location = new System.Drawing.Point(270, 481);
            this.VK.Name = "VK";
            this.VK.Size = new System.Drawing.Size(65, 65);
            this.VK.TabIndex = 16;
            this.VK.UseVisualStyleBackColor = false;
            // 
            // ChangeEnter
            // 
            this.ChangeEnter.AutoSize = true;
            this.ChangeEnter.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeEnter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ChangeEnter.Location = new System.Drawing.Point(45, 435);
            this.ChangeEnter.Name = "ChangeEnter";
            this.ChangeEnter.Size = new System.Drawing.Size(321, 28);
            this.ChangeEnter.TabIndex = 15;
            this.ChangeEnter.Text = "Войдите через соц. сети:";
            // 
            // ExitButton
            // 
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.Location = new System.Drawing.Point(358, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(32, 32);
            this.ExitButton.TabIndex = 14;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // PromptPass
            // 
            this.PromptPass.Image = ((System.Drawing.Image)(resources.GetObject("PromptPass.Image")));
            this.PromptPass.Location = new System.Drawing.Point(309, 234);
            this.PromptPass.Name = "PromptPass";
            this.PromptPass.Size = new System.Drawing.Size(25, 25);
            this.PromptPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PromptPass.TabIndex = 13;
            this.PromptPass.TabStop = false;
            this.PromptPass.Click += new System.EventHandler(this.PromptPass_Click);
            // 
            // KeyBox
            // 
            this.KeyBox.Image = ((System.Drawing.Image)(resources.GetObject("KeyBox.Image")));
            this.KeyBox.Location = new System.Drawing.Point(70, 220);
            this.KeyBox.Name = "KeyBox";
            this.KeyBox.Size = new System.Drawing.Size(39, 38);
            this.KeyBox.TabIndex = 12;
            this.KeyBox.TabStop = false;
            // 
            // EmailBox
            // 
            this.EmailBox.Image = ((System.Drawing.Image)(resources.GetObject("EmailBox.Image")));
            this.EmailBox.Location = new System.Drawing.Point(70, 148);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(39, 38);
            this.EmailBox.TabIndex = 11;
            this.EmailBox.TabStop = false;
            // 
            // Registration
            // 
            this.Registration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Registration.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Registration.FlatAppearance.BorderSize = 2;
            this.Registration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registration.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registration.ForeColor = System.Drawing.Color.White;
            this.Registration.Location = new System.Drawing.Point(70, 371);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(266, 46);
            this.Registration.TabIndex = 8;
            this.Registration.Text = "Регистрация";
            this.Registration.UseVisualStyleBackColor = false;
            this.Registration.Click += new System.EventHandler(this.Registration_Click);
            // 
            // EnterApp
            // 
            this.EnterApp.BackColor = System.Drawing.Color.Turquoise;
            this.EnterApp.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.EnterApp.FlatAppearance.BorderSize = 0;
            this.EnterApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.EnterApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.EnterApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterApp.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterApp.ForeColor = System.Drawing.Color.Black;
            this.EnterApp.Location = new System.Drawing.Point(70, 310);
            this.EnterApp.Name = "EnterApp";
            this.EnterApp.Size = new System.Drawing.Size(266, 49);
            this.EnterApp.TabIndex = 7;
            this.EnterApp.Text = "Войти";
            this.EnterApp.UseVisualStyleBackColor = false;
            this.EnterApp.Click += new System.EventHandler(this.EnterApp_Click);
            // 
            // TypeLogo
            // 
            this.TypeLogo.Image = ((System.Drawing.Image)(resources.GetObject("TypeLogo.Image")));
            this.TypeLogo.Location = new System.Drawing.Point(31, 33);
            this.TypeLogo.Name = "TypeLogo";
            this.TypeLogo.Size = new System.Drawing.Size(66, 70);
            this.TypeLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TypeLogo.TabIndex = 6;
            this.TypeLogo.TabStop = false;
            // 
            // PasswordBox
            // 
            this.PasswordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.PasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordBox.ForeColor = System.Drawing.Color.White;
            this.PasswordBox.Location = new System.Drawing.Point(119, 233);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '•';
            this.PasswordBox.Size = new System.Drawing.Size(180, 26);
            this.PasswordBox.TabIndex = 5;
            // 
            // LoginBox
            // 
            this.LoginBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.LoginBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginBox.ForeColor = System.Drawing.Color.White;
            this.LoginBox.Location = new System.Drawing.Point(119, 157);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(210, 26);
            this.LoginBox.TabIndex = 3;
            // 
            // LabelEnter
            // 
            this.LabelEnter.AutoSize = true;
            this.LabelEnter.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelEnter.ForeColor = System.Drawing.Color.White;
            this.LabelEnter.Location = new System.Drawing.Point(109, 78);
            this.LabelEnter.Name = "LabelEnter";
            this.LabelEnter.Size = new System.Drawing.Size(257, 22);
            this.LabelEnter.TabIndex = 1;
            this.LabelEnter.Text = "Войдите в личный кабинет";
            // 
            // LabelAuth
            // 
            this.LabelAuth.AutoSize = true;
            this.LabelAuth.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAuth.ForeColor = System.Drawing.Color.White;
            this.LabelAuth.Location = new System.Drawing.Point(103, 33);
            this.LabelAuth.Name = "LabelAuth";
            this.LabelAuth.Size = new System.Drawing.Size(228, 38);
            this.LabelAuth.TabIndex = 0;
            this.LabelAuth.Text = "Авторизация";
            // 
            // Line1
            // 
            this.Line1.AutoSize = true;
            this.Line1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Line1.ForeColor = System.Drawing.Color.White;
            this.Line1.Location = new System.Drawing.Point(64, 167);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.Size(274, 24);
            this.Line1.TabIndex = 10;
            this.Line1.Text = "________________________";
            // 
            // Line2
            // 
            this.Line2.AutoSize = true;
            this.Line2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Line2.ForeColor = System.Drawing.Color.White;
            this.Line2.Location = new System.Drawing.Point(65, 242);
            this.Line2.Name = "Line2";
            this.Line2.Size = new System.Drawing.Size(274, 24);
            this.Line2.TabIndex = 9;
            this.Line2.Text = "________________________";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-53, -10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(825, 503);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // SettingPanel
            // 
            this.SettingPanel.BackColor = System.Drawing.Color.Teal;
            this.SettingPanel.Controls.Add(this.ServerBox);
            this.SettingPanel.Controls.Add(this.ChangeServer);
            this.SettingPanel.Controls.Add(this.Switcher);
            this.SettingPanel.Controls.Add(this.AcceptCatalog);
            this.SettingPanel.Controls.Add(this.Auto);
            this.SettingPanel.Controls.Add(this.Sqllabel);
            this.SettingPanel.Controls.Add(this.SQLBox);
            this.SettingPanel.Controls.Add(this.DataBase);
            this.SettingPanel.Controls.Add(this.Accept);
            this.SettingPanel.Controls.Add(this.ServersList);
            this.SettingPanel.Controls.Add(this.GetServerList);
            this.SettingPanel.Controls.Add(this.SettingsLabel);
            this.SettingPanel.Controls.Add(this.Line3);
            this.SettingPanel.Controls.Add(this.Line4);
            this.SettingPanel.Location = new System.Drawing.Point(0, 0);
            this.SettingPanel.Name = "SettingPanel";
            this.SettingPanel.Size = new System.Drawing.Size(426, 445);
            this.SettingPanel.TabIndex = 3;
            this.SettingPanel.Visible = false;
            // 
            // Switcher
            // 
            this.Switcher.BackColor = System.Drawing.Color.Transparent;
            this.Switcher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Switcher.BackgroundImage")));
            this.Switcher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Switcher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Switcher.Location = new System.Drawing.Point(379, 157);
            this.Switcher.Name = "Switcher";
            this.Switcher.OffColor = System.Drawing.Color.Gray;
            this.Switcher.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.Switcher.Size = new System.Drawing.Size(35, 20);
            this.Switcher.TabIndex = 29;
            this.Switcher.Value = false;
            this.Switcher.OnValueChange += new System.EventHandler(this.Switcher_OnValueChange);
            // 
            // AcceptCatalog
            // 
            this.AcceptCatalog.BackColor = System.Drawing.Color.Teal;
            this.AcceptCatalog.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.AcceptCatalog.FlatAppearance.BorderSize = 0;
            this.AcceptCatalog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.AcceptCatalog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AcceptCatalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptCatalog.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AcceptCatalog.ForeColor = System.Drawing.Color.White;
            this.AcceptCatalog.Location = new System.Drawing.Point(74, 378);
            this.AcceptCatalog.Name = "AcceptCatalog";
            this.AcceptCatalog.Size = new System.Drawing.Size(284, 35);
            this.AcceptCatalog.TabIndex = 35;
            this.AcceptCatalog.Text = "Применить";
            this.AcceptCatalog.UseVisualStyleBackColor = false;
            this.AcceptCatalog.Click += new System.EventHandler(this.AcceptCatalog_Click);
            // 
            // Auto
            // 
            this.Auto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Auto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Auto.ForeColor = System.Drawing.Color.White;
            this.Auto.Location = new System.Drawing.Point(319, 25);
            this.Auto.Name = "Auto";
            this.Auto.Size = new System.Drawing.Size(76, 41);
            this.Auto.TabIndex = 34;
            this.Auto.Text = "Auto";
            this.Auto.UseVisualStyleBackColor = true;
            this.Auto.Click += new System.EventHandler(this.Auto_Click);
            // 
            // Sqllabel
            // 
            this.Sqllabel.AutoSize = true;
            this.Sqllabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sqllabel.ForeColor = System.Drawing.Color.White;
            this.Sqllabel.Location = new System.Drawing.Point(24, 151);
            this.Sqllabel.Name = "Sqllabel";
            this.Sqllabel.Size = new System.Drawing.Size(138, 25);
            this.Sqllabel.TabIndex = 33;
            this.Sqllabel.Text = "Версия SQL:";
            // 
            // SQLBox
            // 
            this.SQLBox.BackColor = System.Drawing.Color.Teal;
            this.SQLBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SQLBox.Enabled = false;
            this.SQLBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SQLBox.ForeColor = System.Drawing.Color.White;
            this.SQLBox.Location = new System.Drawing.Point(170, 146);
            this.SQLBox.Name = "SQLBox";
            this.SQLBox.Size = new System.Drawing.Size(203, 26);
            this.SQLBox.TabIndex = 23;
            // 
            // ChangeServer
            // 
            this.ChangeServer.AutoSize = true;
            this.ChangeServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeServer.ForeColor = System.Drawing.Color.White;
            this.ChangeServer.Location = new System.Drawing.Point(25, 85);
            this.ChangeServer.Name = "ChangeServer";
            this.ChangeServer.Size = new System.Drawing.Size(137, 25);
            this.ChangeServer.TabIndex = 31;
            this.ChangeServer.Text = "Ваш сервер:";
            // 
            // DataBase
            // 
            this.DataBase.Image = ((System.Drawing.Image)(resources.GetObject("DataBase.Image")));
            this.DataBase.Location = new System.Drawing.Point(74, 323);
            this.DataBase.Name = "DataBase";
            this.DataBase.Size = new System.Drawing.Size(36, 39);
            this.DataBase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DataBase.TabIndex = 30;
            this.DataBase.TabStop = false;
            // 
            // Accept
            // 
            this.Accept.BackColor = System.Drawing.Color.Teal;
            this.Accept.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Accept.FlatAppearance.BorderSize = 0;
            this.Accept.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.Accept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Accept.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Accept.ForeColor = System.Drawing.Color.White;
            this.Accept.Location = new System.Drawing.Point(74, 200);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(284, 42);
            this.Accept.TabIndex = 29;
            this.Accept.Text = "Применить";
            this.Accept.UseVisualStyleBackColor = false;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // ServersList
            // 
            this.ServersList.BackColor = System.Drawing.Color.Teal;
            this.ServersList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServersList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ServersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServersList.ForeColor = System.Drawing.Color.White;
            this.ServersList.FormattingEnabled = true;
            this.ServersList.Location = new System.Drawing.Point(116, 327);
            this.ServersList.Name = "ServersList";
            this.ServersList.Size = new System.Drawing.Size(242, 32);
            this.ServersList.Sorted = true;
            this.ServersList.TabIndex = 29;
            // 
            // GetServerList
            // 
            this.GetServerList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetServerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetServerList.ForeColor = System.Drawing.Color.White;
            this.GetServerList.Location = new System.Drawing.Point(74, 253);
            this.GetServerList.Name = "GetServerList";
            this.GetServerList.Size = new System.Drawing.Size(284, 57);
            this.GetServerList.TabIndex = 28;
            this.GetServerList.Text = "Получить список баз данных";
            this.GetServerList.UseVisualStyleBackColor = true;
            this.GetServerList.Click += new System.EventHandler(this.GetServerList_Click);
            // 
            // SettingsLabel
            // 
            this.SettingsLabel.AutoSize = true;
            this.SettingsLabel.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsLabel.ForeColor = System.Drawing.Color.White;
            this.SettingsLabel.Location = new System.Drawing.Point(113, 22);
            this.SettingsLabel.Name = "SettingsLabel";
            this.SettingsLabel.Size = new System.Drawing.Size(193, 38);
            this.SettingsLabel.TabIndex = 22;
            this.SettingsLabel.Text = "Настройки";
            // 
            // ServerBox
            // 
            this.ServerBox.BackColor = System.Drawing.Color.Teal;
            this.ServerBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ServerBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServerBox.ForeColor = System.Drawing.Color.White;
            this.ServerBox.Location = new System.Drawing.Point(169, 84);
            this.ServerBox.Name = "ServerBox";
            this.ServerBox.Size = new System.Drawing.Size(213, 26);
            this.ServerBox.TabIndex = 22;
            // 
            // Line3
            // 
            this.Line3.AutoSize = true;
            this.Line3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Line3.ForeColor = System.Drawing.Color.White;
            this.Line3.Location = new System.Drawing.Point(163, 94);
            this.Line3.Name = "Line3";
            this.Line3.Size = new System.Drawing.Size(219, 24);
            this.Line3.TabIndex = 25;
            this.Line3.Text = "___________________";
            // 
            // Line4
            // 
            this.Line4.AutoSize = true;
            this.Line4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Line4.ForeColor = System.Drawing.Color.White;
            this.Line4.Location = new System.Drawing.Point(163, 155);
            this.Line4.Name = "Line4";
            this.Line4.Size = new System.Drawing.Size(219, 24);
            this.Line4.TabIndex = 32;
            this.Line4.Text = "___________________";
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(810, 435);
            this.Controls.Add(this.SettingPanel);
            this.Controls.Add(this.AuthPanel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Auth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Auth_Load);
            this.AuthPanel.ResumeLayout(false);
            this.AuthPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PromptPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KeyBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypeLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SettingPanel.ResumeLayout(false);
            this.SettingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataBase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel AuthPanel;
        private System.Windows.Forms.PictureBox KeyBox;
        private System.Windows.Forms.PictureBox EmailBox;
        private System.Windows.Forms.Label Line1;
        private System.Windows.Forms.Label Line2;
        private System.Windows.Forms.PictureBox TypeLogo;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.Label LabelEnter;
        private System.Windows.Forms.Label LabelAuth;
        private System.Windows.Forms.PictureBox PromptPass;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Registration;
        private System.Windows.Forms.Button EnterApp;
        private System.Windows.Forms.Label RememberLabel;
        private Bunifu.Framework.UI.BunifuiOSSwitch RememberUser;
        private System.Windows.Forms.Panel SettingPanel;
        private System.Windows.Forms.Label SettingsLabel;
        private System.Windows.Forms.TextBox ServerBox;
        private System.Windows.Forms.TextBox SQLBox;
        private System.Windows.Forms.Label Line3;
        private System.Windows.Forms.Button Setting;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.ComboBox ServersList;
        private System.Windows.Forms.Button GetServerList;
        private System.Windows.Forms.Label Sqllabel;
        private System.Windows.Forms.Label ChangeServer;
        private System.Windows.Forms.PictureBox DataBase;
        private System.Windows.Forms.Label Line4;
        private System.Windows.Forms.Button Facebook;
        private System.Windows.Forms.Button Google;
        private System.Windows.Forms.Button VK;
        private System.Windows.Forms.Label ChangeEnter;
        private System.Windows.Forms.Button Auto;
        private System.Windows.Forms.Button AcceptCatalog;
        private Bunifu.Framework.UI.BunifuiOSSwitch Switcher;
    }
}

