namespace DB_Project
{
    partial class Comandos
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
            this.groupBox_SQL = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_SQL_CMD = new System.Windows.Forms.TextBox();
            this.groupBox_SQL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_SQL
            // 
            this.groupBox_SQL.Controls.Add(this.pictureBox2);
            this.groupBox_SQL.Controls.Add(this.label1);
            this.groupBox_SQL.Controls.Add(this.textBox_SQL_CMD);
            this.groupBox_SQL.Location = new System.Drawing.Point(12, 12);
            this.groupBox_SQL.Name = "groupBox_SQL";
            this.groupBox_SQL.Size = new System.Drawing.Size(474, 192);
            this.groupBox_SQL.TabIndex = 0;
            this.groupBox_SQL.TabStop = false;
            this.groupBox_SQL.Text = "SQL";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::DB_Project.Properties.Resources.databases;
            this.pictureBox2.Location = new System.Drawing.Point(6, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(462, 130);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ENTER A QUERY IN  SQL";
            // 
            // textBox_SQL_CMD
            // 
            this.textBox_SQL_CMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SQL_CMD.Location = new System.Drawing.Point(6, 19);
            this.textBox_SQL_CMD.Name = "textBox_SQL_CMD";
            this.textBox_SQL_CMD.Size = new System.Drawing.Size(462, 21);
            this.textBox_SQL_CMD.TabIndex = 0;
            this.textBox_SQL_CMD.Text = "SELECT * FROM Ventas";
            this.textBox_SQL_CMD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_SQL_CMD_KeyPress);
            // 
            // Comandos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 216);
            this.Controls.Add(this.groupBox_SQL);
            this.MaximizeBox = false;
            this.Name = "Comandos";
            this.Text = "SQL Commands ( CMD )";
            this.Load += new System.EventHandler(this.Comandos_Load);
            this.groupBox_SQL.ResumeLayout(false);
            this.groupBox_SQL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_SQL;
        private System.Windows.Forms.TextBox textBox_SQL_CMD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}