namespace Library
{
    partial class FormLogin
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.labelPESEL = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxPESEL = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLogin.Location = new System.Drawing.Point(15, 60);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Zaloguj";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            this.buttonLogin.Enter += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRegister.Location = new System.Drawing.Point(116, 60);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(75, 23);
            this.buttonRegister.TabIndex = 6;
            this.buttonRegister.Text = "Rejestruj";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // labelPESEL
            // 
            this.labelPESEL.AutoSize = true;
            this.labelPESEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPESEL.Location = new System.Drawing.Point(12, 9);
            this.labelPESEL.Name = "labelPESEL";
            this.labelPESEL.Size = new System.Drawing.Size(60, 16);
            this.labelPESEL.TabIndex = 2;
            this.labelPESEL.Text = "PESEL:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPassword.Location = new System.Drawing.Point(12, 35);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(56, 16);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Hasło:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(91, 34);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 4;
            // 
            // textBoxPESEL
            // 
            this.textBoxPESEL.Location = new System.Drawing.Point(91, 8);
            this.textBoxPESEL.Name = "textBoxPESEL";
            this.textBoxPESEL.Size = new System.Drawing.Size(100, 20);
            this.textBoxPESEL.TabIndex = 3;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 94);
            this.Controls.Add(this.textBoxPESEL);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelPESEL);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonLogin);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label labelPESEL;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxPESEL;
    }
}

