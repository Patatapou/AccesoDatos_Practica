namespace AccesoDatos_Practica
{
    partial class AUTORES
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
            pUTOSToolStripMenuItem = new ToolStripMenuItem();
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
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Dock = DockStyle.Fill;
            dgv.Location = new Point(0, 28);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(800, 422);
            dgv.TabIndex = 0;
            dgv.CellContentDoubleClick += dgv_CellContentDoubleClick;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { pUTOSToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // pUTOSToolStripMenuItem
            // 
            pUTOSToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { autoresToolStripMenuItem, empleadosToolStripMenuItem, titulosToolStripMenuItem });
            pUTOSToolStripMenuItem.Name = "pUTOSToolStripMenuItem";
            pUTOSToolStripMenuItem.Size = new Size(64, 24);
            pUTOSToolStripMenuItem.Text = "Tablas";
            // 
            // autoresToolStripMenuItem
            // 
            autoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { insertarToolStripMenuItem });
            autoresToolStripMenuItem.Name = "autoresToolStripMenuItem";
            autoresToolStripMenuItem.Size = new Size(224, 26);
            autoresToolStripMenuItem.Text = "Autores";
            autoresToolStripMenuItem.Click += autoresToolStripMenuItem_Click;
            // 
            // insertarToolStripMenuItem
            // 
            insertarToolStripMenuItem.Name = "insertarToolStripMenuItem";
            insertarToolStripMenuItem.Size = new Size(224, 26);
            insertarToolStripMenuItem.Text = "Insertar";
            insertarToolStripMenuItem.Click += insertarToolStripMenuItem_Click;
            // 
            // empleadosToolStripMenuItem
            // 
            empleadosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { insertarToolStripMenuItem1 });
            empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            empleadosToolStripMenuItem.Size = new Size(224, 26);
            empleadosToolStripMenuItem.Text = "Empleados";
            empleadosToolStripMenuItem.Click += empleadosToolStripMenuItem_Click;
            // 
            // insertarToolStripMenuItem1
            // 
            insertarToolStripMenuItem1.Name = "insertarToolStripMenuItem1";
            insertarToolStripMenuItem1.Size = new Size(224, 26);
            insertarToolStripMenuItem1.Text = "Insertar";
            insertarToolStripMenuItem1.Click += insertarToolStripMenuItem1_Click;
            // 
            // titulosToolStripMenuItem
            // 
            titulosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { insertarToolStripMenuItem2 });
            titulosToolStripMenuItem.Name = "titulosToolStripMenuItem";
            titulosToolStripMenuItem.Size = new Size(224, 26);
            titulosToolStripMenuItem.Text = "Titulos";
            titulosToolStripMenuItem.Click += titulosToolStripMenuItem_Click;
            // 
            // insertarToolStripMenuItem2
            // 
            insertarToolStripMenuItem2.Name = "insertarToolStripMenuItem2";
            insertarToolStripMenuItem2.Size = new Size(224, 26);
            insertarToolStripMenuItem2.Text = "Insertar";
            insertarToolStripMenuItem2.Click += insertarToolStripMenuItem2_Click;
            // 
            // AUTORES
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "AUTORES";
            Text = "AUTORES";
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem pUTOSToolStripMenuItem;
        private ToolStripMenuItem autoresToolStripMenuItem;
        private ToolStripMenuItem insertarToolStripMenuItem;
        private ToolStripMenuItem empleadosToolStripMenuItem;
        private ToolStripMenuItem insertarToolStripMenuItem1;
        private ToolStripMenuItem titulosToolStripMenuItem;
        private ToolStripMenuItem insertarToolStripMenuItem2;
    }
}
