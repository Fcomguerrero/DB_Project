namespace DB_Project
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }    

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_user = new System.Windows.Forms.TextBox();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.bt_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_user
            // 
            this.textBox_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_user.Location = new System.Drawing.Point(184, 96);
            this.textBox_user.Name = "textBox_user";
            this.textBox_user.Size = new System.Drawing.Size(151, 15);
            this.textBox_user.TabIndex = 0;
            // 
            // textBox_pass
            // 
            this.textBox_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_pass.Location = new System.Drawing.Point(184, 138);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.Size = new System.Drawing.Size(151, 15);
            this.textBox_pass.TabIndex = 1;
            this.textBox_pass.UseSystemPasswordChar = true;
            this.textBox_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_pass_KeyPress);
            // 
            // bt_Login
            // 
            this.bt_Login.Location = new System.Drawing.Point(354, 174);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Size = new System.Drawing.Size(75, 23);
            this.bt_Login.TabIndex = 2;
            this.bt_Login.Text = "Login";
            this.bt_Login.UseVisualStyleBackColor = true;
            this.bt_Login.Click += new System.EventHandler(this.bt_Login_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::DB_Project.Properties.Resources.login;
            this.ClientSize = new System.Drawing.Size(450, 249);
            this.Controls.Add(this.bt_Login);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.textBox_user);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_user;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.Button bt_Login;
    }
}

