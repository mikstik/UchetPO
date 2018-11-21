namespace UchetPO
{
    partial class BuyLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyLicense));
            this.Month = new System.Windows.Forms.Button();
            this.Year = new System.Windows.Forms.Button();
            this.Month3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Month
            // 
            this.Month.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Month.Dock = System.Windows.Forms.DockStyle.Left;
            this.Month.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Month.FlatAppearance.BorderSize = 0;
            this.Month.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Month.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.Month.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Month.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Month.ForeColor = System.Drawing.Color.White;
            this.Month.Image = ((System.Drawing.Image)(resources.GetObject("Month.Image")));
            this.Month.Location = new System.Drawing.Point(0, 0);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(293, 565);
            this.Month.TabIndex = 21;
            this.Month.Text = "Купить Pro версию на месяц";
            this.Month.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Month.UseVisualStyleBackColor = false;
            // 
            // Year
            // 
            this.Year.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Year.Dock = System.Windows.Forms.DockStyle.Left;
            this.Year.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Year.FlatAppearance.BorderSize = 0;
            this.Year.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Year.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.Year.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Year.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Year.ForeColor = System.Drawing.Color.White;
            this.Year.Image = ((System.Drawing.Image)(resources.GetObject("Year.Image")));
            this.Year.Location = new System.Drawing.Point(586, 0);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(293, 565);
            this.Year.TabIndex = 22;
            this.Year.Text = "Купить Pro версию на год";
            this.Year.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Year.UseVisualStyleBackColor = false;
            // 
            // Month3
            // 
            this.Month3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Month3.Dock = System.Windows.Forms.DockStyle.Left;
            this.Month3.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Month3.FlatAppearance.BorderSize = 0;
            this.Month3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Month3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.Month3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Month3.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Month3.ForeColor = System.Drawing.Color.White;
            this.Month3.Image = ((System.Drawing.Image)(resources.GetObject("Month3.Image")));
            this.Month3.Location = new System.Drawing.Point(293, 0);
            this.Month3.Name = "Month3";
            this.Month3.Size = new System.Drawing.Size(293, 565);
            this.Month3.TabIndex = 23;
            this.Month3.Text = "Купить Pro версию на 3 месяца";
            this.Month3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Month3.UseVisualStyleBackColor = false;
            // 
            // BuyLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(801, 565);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Month3);
            this.Controls.Add(this.Month);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuyLicense";
            this.Text = "BuyLicense";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Month;
        private System.Windows.Forms.Button Year;
        private System.Windows.Forms.Button Month3;
    }
}