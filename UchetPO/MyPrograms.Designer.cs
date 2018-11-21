namespace UchetPO
{
    partial class MyPrograms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyPrograms));
            this.Table = new System.Windows.Forms.DataGridView();
            this.AdditionalPanel = new System.Windows.Forms.Panel();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.Switcher = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.Create = new System.Windows.Forms.Button();
            this.ChangesCancel = new System.Windows.Forms.Button();
            this.SaveChanges = new System.Windows.Forms.Button();
            this.DaysLabel = new System.Windows.Forms.Label();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.NameProgrammLabel = new System.Windows.Forms.Label();
            this.DaysBox = new System.Windows.Forms.TextBox();
            this.KeyBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.Delete = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.TablePanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.AdditionalPanel.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.TablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Table
            // 
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table.Location = new System.Drawing.Point(0, 0);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(612, 370);
            this.Table.TabIndex = 2;
            this.Table.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_CellDoubleClick);
            this.Table.Click += new System.EventHandler(this.Table_Click);
            // 
            // AdditionalPanel
            // 
            this.AdditionalPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.AdditionalPanel.Controls.Add(this.DescriptionBox);
            this.AdditionalPanel.Controls.Add(this.DescriptionLabel);
            this.AdditionalPanel.Controls.Add(this.Switcher);
            this.AdditionalPanel.Controls.Add(this.Create);
            this.AdditionalPanel.Controls.Add(this.ChangesCancel);
            this.AdditionalPanel.Controls.Add(this.SaveChanges);
            this.AdditionalPanel.Controls.Add(this.DaysLabel);
            this.AdditionalPanel.Controls.Add(this.KeyLabel);
            this.AdditionalPanel.Controls.Add(this.NameProgrammLabel);
            this.AdditionalPanel.Controls.Add(this.DaysBox);
            this.AdditionalPanel.Controls.Add(this.KeyBox);
            this.AdditionalPanel.Controls.Add(this.NameBox);
            this.AdditionalPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AdditionalPanel.Location = new System.Drawing.Point(0, 370);
            this.AdditionalPanel.Name = "AdditionalPanel";
            this.AdditionalPanel.Size = new System.Drawing.Size(802, 194);
            this.AdditionalPanel.TabIndex = 3;
            this.AdditionalPanel.Visible = false;
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.DescriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionBox.ForeColor = System.Drawing.Color.White;
            this.DescriptionBox.Location = new System.Drawing.Point(460, 88);
            this.DescriptionBox.MaxLength = 254;
            this.DescriptionBox.Multiline = true;
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(330, 46);
            this.DescriptionBox.TabIndex = 13;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionLabel.ForeColor = System.Drawing.Color.White;
            this.DescriptionLabel.Location = new System.Drawing.Point(456, 51);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(201, 23);
            this.DescriptionLabel.TabIndex = 12;
            this.DescriptionLabel.Text = "Добавить описание";
            // 
            // Switcher
            // 
            this.Switcher.BackColor = System.Drawing.Color.Transparent;
            this.Switcher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Switcher.BackgroundImage")));
            this.Switcher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Switcher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Switcher.Location = new System.Drawing.Point(663, 54);
            this.Switcher.Name = "Switcher";
            this.Switcher.OffColor = System.Drawing.Color.Gray;
            this.Switcher.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.Switcher.Size = new System.Drawing.Size(35, 20);
            this.Switcher.TabIndex = 11;
            this.Switcher.Value = false;
            this.Switcher.OnValueChange += new System.EventHandler(this.Switcher_OnValueChange);
            // 
            // Create
            // 
            this.Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Create.ForeColor = System.Drawing.Color.White;
            this.Create.Location = new System.Drawing.Point(599, 150);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(191, 32);
            this.Create.TabIndex = 10;
            this.Create.Text = "Добавить";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Visible = false;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // ChangesCancel
            // 
            this.ChangesCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangesCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangesCancel.ForeColor = System.Drawing.Color.White;
            this.ChangesCancel.Location = new System.Drawing.Point(490, 150);
            this.ChangesCancel.Name = "ChangesCancel";
            this.ChangesCancel.Size = new System.Drawing.Size(103, 32);
            this.ChangesCancel.TabIndex = 9;
            this.ChangesCancel.Text = "Отменить";
            this.ChangesCancel.UseVisualStyleBackColor = true;
            this.ChangesCancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // SaveChanges
            // 
            this.SaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveChanges.ForeColor = System.Drawing.Color.White;
            this.SaveChanges.Location = new System.Drawing.Point(599, 150);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(191, 32);
            this.SaveChanges.TabIndex = 8;
            this.SaveChanges.Text = "Сохранить изменения";
            this.SaveChanges.UseVisualStyleBackColor = true;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // DaysLabel
            // 
            this.DaysLabel.AutoSize = true;
            this.DaysLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DaysLabel.ForeColor = System.Drawing.Color.White;
            this.DaysLabel.Location = new System.Drawing.Point(98, 138);
            this.DaysLabel.Name = "DaysLabel";
            this.DaysLabel.Size = new System.Drawing.Size(157, 23);
            this.DaysLabel.TabIndex = 6;
            this.DaysLabel.Text = "Дней лицензии:";
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyLabel.ForeColor = System.Drawing.Color.White;
            this.KeyLabel.Location = new System.Drawing.Point(48, 97);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(207, 23);
            this.KeyLabel.TabIndex = 5;
            this.KeyLabel.Text = "Лицензионный ключ:";
            // 
            // NameProgrammLabel
            // 
            this.NameProgrammLabel.AutoSize = true;
            this.NameProgrammLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameProgrammLabel.ForeColor = System.Drawing.Color.White;
            this.NameProgrammLabel.Location = new System.Drawing.Point(28, 54);
            this.NameProgrammLabel.Name = "NameProgrammLabel";
            this.NameProgrammLabel.Size = new System.Drawing.Size(227, 23);
            this.NameProgrammLabel.TabIndex = 4;
            this.NameProgrammLabel.Text = "Название программы:";
            // 
            // DaysBox
            // 
            this.DaysBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.DaysBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DaysBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DaysBox.ForeColor = System.Drawing.Color.White;
            this.DaysBox.Location = new System.Drawing.Point(261, 139);
            this.DaysBox.MaxLength = 10;
            this.DaysBox.Name = "DaysBox";
            this.DaysBox.Size = new System.Drawing.Size(162, 22);
            this.DaysBox.TabIndex = 2;
            // 
            // KeyBox
            // 
            this.KeyBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.KeyBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KeyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyBox.ForeColor = System.Drawing.Color.White;
            this.KeyBox.Location = new System.Drawing.Point(261, 97);
            this.KeyBox.MaxLength = 64;
            this.KeyBox.Name = "KeyBox";
            this.KeyBox.Size = new System.Drawing.Size(162, 22);
            this.KeyBox.TabIndex = 1;
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameBox.ForeColor = System.Drawing.Color.White;
            this.NameBox.Location = new System.Drawing.Point(261, 55);
            this.NameBox.MaxLength = 63;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(162, 22);
            this.NameBox.TabIndex = 0;
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.RightPanel.Controls.Add(this.Delete);
            this.RightPanel.Controls.Add(this.Cancel);
            this.RightPanel.Controls.Add(this.Change);
            this.RightPanel.Controls.Add(this.Add);
            this.RightPanel.Controls.Add(this.Refresh);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(612, 0);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(190, 370);
            this.RightPanel.TabIndex = 4;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Delete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Delete.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Delete.FlatAppearance.BorderSize = 0;
            this.Delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Location = new System.Drawing.Point(0, 288);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(190, 50);
            this.Delete.TabIndex = 22;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Cancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Cancel.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Cancel.FlatAppearance.BorderSize = 0;
            this.Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel.ForeColor = System.Drawing.Color.Silver;
            this.Cancel.Location = new System.Drawing.Point(0, 338);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(190, 32);
            this.Cancel.TabIndex = 20;
            this.Cancel.Text = "Отменить";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Change
            // 
            this.Change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Change.Dock = System.Windows.Forms.DockStyle.Top;
            this.Change.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Change.FlatAppearance.BorderSize = 0;
            this.Change.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Change.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.Change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Change.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Change.ForeColor = System.Drawing.Color.White;
            this.Change.Location = new System.Drawing.Point(0, 100);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(190, 50);
            this.Change.TabIndex = 19;
            this.Change.Text = "Изменить";
            this.Change.UseVisualStyleBackColor = false;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Add.Dock = System.Windows.Forms.DockStyle.Top;
            this.Add.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Add.FlatAppearance.BorderSize = 0;
            this.Add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.Location = new System.Drawing.Point(0, 50);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(190, 50);
            this.Add.TabIndex = 18;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Refresh
            // 
            this.Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Refresh.Dock = System.Windows.Forms.DockStyle.Top;
            this.Refresh.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Refresh.FlatAppearance.BorderSize = 0;
            this.Refresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Refresh.ForeColor = System.Drawing.Color.White;
            this.Refresh.Location = new System.Drawing.Point(0, 0);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(190, 50);
            this.Refresh.TabIndex = 23;
            this.Refresh.Text = "Обновить";
            this.Refresh.UseVisualStyleBackColor = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // TablePanel
            // 
            this.TablePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.TablePanel.Controls.Add(this.Table);
            this.TablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablePanel.Location = new System.Drawing.Point(0, 0);
            this.TablePanel.Name = "TablePanel";
            this.TablePanel.Size = new System.Drawing.Size(612, 370);
            this.TablePanel.TabIndex = 5;
            // 
            // MyPrograms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(802, 564);
            this.Controls.Add(this.TablePanel);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.AdditionalPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyPrograms";
            this.Text = "MyPrograms";
            this.Load += new System.EventHandler(this.MyPrograms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.AdditionalPanel.ResumeLayout(false);
            this.AdditionalPanel.PerformLayout();
            this.RightPanel.ResumeLayout(false);
            this.TablePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.Panel AdditionalPanel;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Panel TablePanel;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Label DaysLabel;
        private System.Windows.Forms.Label KeyLabel;
        private System.Windows.Forms.Label NameProgrammLabel;
        private System.Windows.Forms.TextBox DaysBox;
        private System.Windows.Forms.TextBox KeyBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button SaveChanges;
        private System.Windows.Forms.Button ChangesCancel;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Label DescriptionLabel;
        private Bunifu.Framework.UI.BunifuiOSSwitch Switcher;
        private System.Windows.Forms.TextBox DescriptionBox;
    }
}