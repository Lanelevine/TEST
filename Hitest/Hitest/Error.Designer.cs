namespace Hitest
{
    partial class Error
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Error));
            this.Erroricon = new System.Windows.Forms.Panel();
            this.ErrorListBox = new System.Windows.Forms.ListBox();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Erroricon
            // 
            this.Erroricon.AutoScroll = true;
            this.Erroricon.BackColor = System.Drawing.Color.Transparent;
            this.Erroricon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Erroricon.BackgroundImage")));
            this.Erroricon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Erroricon.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Erroricon.Location = new System.Drawing.Point(12, 12);
            this.Erroricon.Name = "Erroricon";
            this.Erroricon.Size = new System.Drawing.Size(50, 50);
            this.Erroricon.TabIndex = 0;
            // 
            // ErrorListBox
            // 
            this.ErrorListBox.FormattingEnabled = true;
            this.ErrorListBox.ItemHeight = 14;
            this.ErrorListBox.Location = new System.Drawing.Point(12, 68);
            this.ErrorListBox.Name = "ErrorListBox";
            this.ErrorListBox.Size = new System.Drawing.Size(316, 242);
            this.ErrorListBox.TabIndex = 1;
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.Cancelbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancelbtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelbtn.ForeColor = System.Drawing.Color.Transparent;
            this.Cancelbtn.Location = new System.Drawing.Point(253, 32);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(75, 30);
            this.Cancelbtn.TabIndex = 2;
            this.Cancelbtn.Text = "취소";
            this.Cancelbtn.UseVisualStyleBackColor = false;
            this.Cancelbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.ErrorListBox);
            this.panel2.Controls.Add(this.Cancelbtn);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 350);
            this.panel2.TabIndex = 3;
            // 
            // error
            // 
            this.AcceptButton = this.Cancelbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.Cancelbtn;
            this.ClientSize = new System.Drawing.Size(340, 318);
            this.Controls.Add(this.Erroricon);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "error";
            this.ShowIcon = false;
            this.Text = "Error";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Erroricon;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.ListBox ErrorListBox;
    }
}