namespace DB_Project
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
            this.Principal_menuStrip = new System.Windows.Forms.MenuStrip();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLComandoscmdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.label1_MENU_Estado = new System.Windows.Forms.Label();
            this.comboBox_Menu = new System.Windows.Forms.ComboBox();
            this.bt_Esquema = new System.Windows.Forms.Button();
            this.Principal_menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Principal_menuStrip
            // 
            this.Principal_menuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.Principal_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionToolStripMenuItem,
            this.sQLComandoscmdToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.Principal_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.Principal_menuStrip.Name = "Principal_menuStrip";
            this.Principal_menuStrip.Size = new System.Drawing.Size(668, 24);
            this.Principal_menuStrip.TabIndex = 0;
            this.Principal_menuStrip.Text = "menuStrip1";
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AlumnosToolStripMenuItem});
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.gestionToolStripMenuItem.Text = "Manage";
            // 
            // AlumnosToolStripMenuItem
            // 
            this.AlumnosToolStripMenuItem.Name = "AlumnosToolStripMenuItem";
            this.AlumnosToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.AlumnosToolStripMenuItem.Text = "Sales";
            this.AlumnosToolStripMenuItem.Click += new System.EventHandler(this.VentasToolStripMenuItem_Click);
            // 
            // sQLComandoscmdToolStripMenuItem
            // 
            this.sQLComandoscmdToolStripMenuItem.Name = "sQLComandoscmdToolStripMenuItem";
            this.sQLComandoscmdToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.sQLComandoscmdToolStripMenuItem.Text = "SQL Commands (cmd)";
            this.sQLComandoscmdToolStripMenuItem.Click += new System.EventHandler(this.sQLComandoscmdToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.salirToolStripMenuItem.Text = "Exit";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diagramToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // diagramToolStripMenuItem
            // 
            this.diagramToolStripMenuItem.Name = "diagramToolStripMenuItem";
            this.diagramToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.diagramToolStripMenuItem.Text = "Diagram";
            // 
            // DGV
            // 
            this.DGV.AllowUserToOrderColumns = true;
            this.DGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(12, 27);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(639, 239);
            this.DGV.TabIndex = 1;
            this.DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellContentClick);
            // 
            // label1_MENU_Estado
            // 
            this.label1_MENU_Estado.AutoSize = true;
            this.label1_MENU_Estado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1_MENU_Estado.Location = new System.Drawing.Point(506, 6);
            this.label1_MENU_Estado.Name = "label1_MENU_Estado";
            this.label1_MENU_Estado.Size = new System.Drawing.Size(104, 15);
            this.label1_MENU_Estado.TabIndex = 2;
            this.label1_MENU_Estado.Text = "DATABASE STATE";
            // 
            // comboBox_Menu
            // 
            this.comboBox_Menu.FormattingEnabled = true;
            this.comboBox_Menu.Items.AddRange(new object[] {
            "Pieza",
            "Proveedor",
            "Proyecto",
            "Ventas"});
            this.comboBox_Menu.Location = new System.Drawing.Point(299, 0);
            this.comboBox_Menu.Name = "comboBox_Menu";
            this.comboBox_Menu.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Menu.TabIndex = 3;
            this.comboBox_Menu.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bt_Esquema
            // 
            this.bt_Esquema.BackColor = System.Drawing.SystemColors.Menu;
            this.bt_Esquema.Location = new System.Drawing.Point(436, 1);
            this.bt_Esquema.Name = "bt_Esquema";
            this.bt_Esquema.Size = new System.Drawing.Size(54, 23);
            this.bt_Esquema.TabIndex = 4;
            this.bt_Esquema.Text = "Diagram";
            this.bt_Esquema.UseVisualStyleBackColor = false;
            this.bt_Esquema.Click += new System.EventHandler(this.bt_Esquema_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(668, 278);
            this.Controls.Add(this.bt_Esquema);
            this.Controls.Add(this.comboBox_Menu);
            this.Controls.Add(this.label1_MENU_Estado);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.Principal_menuStrip);
            this.MainMenuStrip = this.Principal_menuStrip;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.Principal_menuStrip.ResumeLayout(false);
            this.Principal_menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Principal_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AlumnosToolStripMenuItem;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.ToolStripMenuItem sQLComandoscmdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1_MENU_Estado;
        private System.Windows.Forms.ComboBox comboBox_Menu;
        private System.Windows.Forms.Button bt_Esquema;
        private System.Windows.Forms.ToolStripMenuItem diagramToolStripMenuItem;
    }
}