
namespace LoginRagistration
{
    partial class Form1
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
            this.btnRagistration = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRagistration
            // 
            this.btnRagistration.Location = new System.Drawing.Point(136, 111);
            this.btnRagistration.Name = "btnRagistration";
            this.btnRagistration.Size = new System.Drawing.Size(168, 47);
            this.btnRagistration.TabIndex = 18;
            this.btnRagistration.Text = "Ragistration";
            this.btnRagistration.UseVisualStyleBackColor = true;
            this.btnRagistration.Click += new System.EventHandler(this.btnRagistration_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(329, 111);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(132, 47);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(17, 68);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(219, 27);
            this.password.TabIndex = 21;
            this.password.Text = "Enter Password : ";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(242, 65);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(219, 35);
            this.txtPassword.TabIndex = 16;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(19, 24);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(173, 27);
            this.name.TabIndex = 20;
            this.name.Text = "Enter Name : ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(242, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(219, 35);
            this.txtName.TabIndex = 15;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(24, 111);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(89, 47);
            this.btnLogin.TabIndex = 17;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 176);
            this.Controls.Add(this.btnRagistration);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.password);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.name);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnLogin);
            this.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRagistration;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnLogin;
    }
}

