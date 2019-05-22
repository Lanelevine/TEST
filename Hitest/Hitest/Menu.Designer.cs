namespace Hitest
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.ClacBtn = new System.Windows.Forms.Button();
            this.HomePageBtn = new System.Windows.Forms.Button();
            this.Talk = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.Talk);
            this.panel1.Controls.Add(this.CancelBtn);
            this.panel1.Controls.Add(this.ClacBtn);
            this.panel1.Controls.Add(this.HomePageBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 100);
            this.panel1.TabIndex = 0;
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.CancelBtn.Location = new System.Drawing.Point(303, 5);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(90, 90);
            this.CancelBtn.TabIndex = 2;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // ClacBtn
            // 
            this.ClacBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.ClacBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClacBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClacBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.ClacBtn.Location = new System.Drawing.Point(105, 5);
            this.ClacBtn.Name = "ClacBtn";
            this.ClacBtn.Size = new System.Drawing.Size(90, 90);
            this.ClacBtn.TabIndex = 1;
            this.ClacBtn.Text = "Claculator";
            this.ClacBtn.UseVisualStyleBackColor = true;
            this.ClacBtn.Click += new System.EventHandler(this.ClacBtn_Click);
            // 
            // HomePageBtn
            // 
            this.HomePageBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.HomePageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomePageBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomePageBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.HomePageBtn.Location = new System.Drawing.Point(5, 5);
            this.HomePageBtn.Name = "HomePageBtn";
            this.HomePageBtn.Size = new System.Drawing.Size(90, 90);
            this.HomePageBtn.TabIndex = 0;
            this.HomePageBtn.Text = "Home page";
            this.HomePageBtn.UseVisualStyleBackColor = false;
            this.HomePageBtn.Click += new System.EventHandler(this.HomePagebtn_Click);
            // 
            // Talk
            // 
            this.Talk.BackColor = System.Drawing.Color.SkyBlue;
            this.Talk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Talk.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Talk.ForeColor = System.Drawing.SystemColors.Window;
            this.Talk.Location = new System.Drawing.Point(205, 5);
            this.Talk.Name = "Talk";
            this.Talk.Size = new System.Drawing.Size(90, 90);
            this.Talk.TabIndex = 3;
            this.Talk.Text = "Talk";
            this.Talk.UseVisualStyleBackColor = false;
            this.Talk.Click += new System.EventHandler(this.Talk_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 100);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button ClacBtn;
        private System.Windows.Forms.Button HomePageBtn;
        private System.Windows.Forms.Button Talk;
    }
}