namespace Hitest
{
    partial class LoginMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginMain));
            this.Login = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Name = new System.Windows.Forms.Label();
            this.IdTextbox = new System.Windows.Forms.TextBox();
            this.PwTextbox = new System.Windows.Forms.TextBox();
            this.pwd = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Login.BackColor = System.Drawing.Color.SkyBlue;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Login.Location = new System.Drawing.Point(14, 131);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 35);
            this.Login.TabIndex = 0;
            this.Login.Text = "로그인";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Cancel
            // 
            this.Cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Cancel.BackColor = System.Drawing.Color.SkyBlue;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancel.Location = new System.Drawing.Point(119, 131);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 35);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "취소";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.BackColor = System.Drawing.SystemColors.Window;
            this.Name.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name.Location = new System.Drawing.Point(12, 25);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(29, 12);
            this.Name.TabIndex = 2;
            this.Name.Text = "이름";
            // 
            // IdTextbox
            // 
            this.IdTextbox.Location = new System.Drawing.Point(12, 40);
            this.IdTextbox.Name = "IdTextbox";
            this.IdTextbox.Size = new System.Drawing.Size(182, 21);
            this.IdTextbox.TabIndex = 3;
            // 
            // PwTextbox
            // 
            this.PwTextbox.Location = new System.Drawing.Point(12, 89);
            this.PwTextbox.Name = "PwTextbox";
            this.PwTextbox.Size = new System.Drawing.Size(182, 21);
            this.PwTextbox.TabIndex = 5;
            // 
            // pwd
            // 
            this.pwd.AutoSize = true;
            this.pwd.BackColor = System.Drawing.SystemColors.Window;
            this.pwd.Location = new System.Drawing.Point(12, 74);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(53, 12);
            this.pwd.TabIndex = 4;
            this.pwd.Text = "비밀번호";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 191);
            this.panel1.TabIndex = 6;
            // 
            // LoginMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 181);
            this.Controls.Add(this.PwTextbox);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.IdTextbox);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox IdTextbox;
        private System.Windows.Forms.TextBox PwTextbox;
        private System.Windows.Forms.Label pwd;
        private System.Windows.Forms.Panel panel1;
    }
}

