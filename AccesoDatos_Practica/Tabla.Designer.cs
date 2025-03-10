namespace AccesoDatos_Practica
{
    partial class TABLAS
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv = new DataGridView();
            menuStrip1 = new MenuStrip();
            TablasToolStripMenuItem = new ToolStripMenuItem();
            autoresToolStripMenuItem = new ToolStripMenuItem();
            insertarToolStripMenuItem = new ToolStripMenuItem();
            empleadosToolStripMenuItem = new ToolStripMenuItem();
            insertarToolStripMenuItem1 = new ToolStripMenuItem();
            titulosToolStripMenuItem = new ToolStripMenuItem();
            insertarToolStripMenuItem2 = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Dock = DockStyle.Fill;
            dgv.GridColor = SystemColors.Desktop;
            dgv.Location = new Point(0, 28);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(1339, 458);
            dgv.TabIndex = 0;
            dgv.CellContentDoubleClick += dgv_CellContentDoubleClick;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { TablasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1339, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // TablasToolStripMenuItem
            // 
            TablasToolStripMenuItem.BackColor = SystemColors.GradientInactiveCaption;
            TablasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { autoresToolStripMenuItem, empleadosToolStripMenuItem, titulosToolStripMenuItem });
            TablasToolStripMenuItem.Name = "TablasToolStripMenuItem";
            TablasToolStripMenuItem.Size = new Size(64, 24);
            TablasToolStripMenuItem.Text = "Tablas";
            // 
            // autoresToolStripMenuItem
            // 
            autoresToolStripMenuItem.BackColor = SystemColors.GradientInactiveCaption;
            autoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { insertarToolStripMenuItem });
            autoresToolStripMenuItem.Name = "autoresToolStripMenuItem";
            autoresToolStripMenuItem.Size = new Size(166, 26);
            autoresToolStripMenuItem.Text = "Autores";
            autoresToolStripMenuItem.Click += autoresToolStripMenuItem_Click;
            // 
            // insertarToolStripMenuItem
            // 
            insertarToolStripMenuItem.BackColor = SystemColors.InactiveCaption;
            insertarToolStripMenuItem.Name = "insertarToolStripMenuItem";
            insertarToolStripMenuItem.Size = new Size(141, 26);
            insertarToolStripMenuItem.Text = "Insertar";
            insertarToolStripMenuItem.Click += insertarToolStripMenuItem_Click;
            // 
            // empleadosToolStripMenuItem
            // 
            empleadosToolStripMenuItem.BackColor = SystemColors.GradientInactiveCaption;
            empleadosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { insertarToolStripMenuItem1 });
            empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            empleadosToolStripMenuItem.Size = new Size(166, 26);
            empleadosToolStripMenuItem.Text = "Empleados";
            empleadosToolStripMenuItem.Click += empleadosToolStripMenuItem_Click;
            // 
            // insertarToolStripMenuItem1
            // 
            insertarToolStripMenuItem1.BackColor = SystemColors.InactiveCaption;
            insertarToolStripMenuItem1.Name = "insertarToolStripMenuItem1";
            insertarToolStripMenuItem1.Size = new Size(141, 26);
            insertarToolStripMenuItem1.Text = "Insertar";
            insertarToolStripMenuItem1.Click += insertarToolStripMenuItem1_Click;
            // 
            // titulosToolStripMenuItem
            // 
            titulosToolStripMenuItem.BackColor = SystemColors.GradientInactiveCaption;
            titulosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { insertarToolStripMenuItem2 });
            titulosToolStripMenuItem.Name = "titulosToolStripMenuItem";
            titulosToolStripMenuItem.Size = new Size(166, 26);
            titulosToolStripMenuItem.Text = "Titulos";
            titulosToolStripMenuItem.Click += titulosToolStripMenuItem_Click;
            // 
            // insertarToolStripMenuItem2
            // 
            insertarToolStripMenuItem2.BackColor = SystemColors.InactiveCaption;
            insertarToolStripMenuItem2.Name = "insertarToolStripMenuItem2";
            insertarToolStripMenuItem2.Size = new Size(141, 26);
            insertarToolStripMenuItem2.Text = "Insertar";
            insertarToolStripMenuItem2.Click += insertarToolStripMenuItem2_Click;
            // 
            // TABLAS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1339, 486);
            Controls.Add(dgv);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TABLAS";
            Text = "Ver";
            Activated += TABLAS_Activated;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem TablasToolStripMenuItem;
        private ToolStripMenuItem autoresToolStripMenuItem;
        private ToolStripMenuItem insertarToolStripMenuItem;
        private ToolStripMenuItem empleadosToolStripMenuItem;
        private ToolStripMenuItem insertarToolStripMenuItem1;
        private ToolStripMenuItem titulosToolStripMenuItem;
        private ToolStripMenuItem insertarToolStripMenuItem2;
    }
}
