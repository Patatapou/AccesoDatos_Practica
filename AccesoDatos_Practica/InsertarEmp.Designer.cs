namespace AccesoDatos_Practica
{
    partial class InsertarEmp
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
            dtpHireDate = new DateTimePicker();
            btnCancelar = new Button();
            btnActualizar = new Button();
            label8 = new Label();
            txtJobLvl = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtMinit = new TextBox();
            label3 = new Label();
            txtLast = new TextBox();
            label2 = new Label();
            txtFirst = new TextBox();
            label1 = new Label();
            cbJobId = new ComboBox();
            cbPubId = new ComboBox();
            mtbId = new MaskedTextBox();
            SuspendLayout();
            // 
            // dtpHireDate
            // 
            dtpHireDate.Cursor = Cursors.Hand;
            dtpHireDate.Location = new Point(20, 178);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(295, 27);
            dtpHireDate.TabIndex = 56;
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Location = new Point(530, 228);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 27);
            btnCancelar.TabIndex = 55;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.Location = new Point(436, 228);
            btnActualizar.Margin = new Padding(2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(90, 27);
            btnActualizar.TabIndex = 54;
            btnActualizar.Text = "Insertar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(497, 82);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 53;
            label8.Text = "Job Level";
            // 
            // txtJobLvl
            // 
            txtJobLvl.BorderStyle = BorderStyle.FixedSingle;
            txtJobLvl.Cursor = Cursors.IBeam;
            txtJobLvl.Location = new Point(497, 105);
            txtJobLvl.Margin = new Padding(2);
            txtJobLvl.Name = "txtJobLvl";
            txtJobLvl.Size = new Size(121, 27);
            txtJobLvl.TabIndex = 52;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 82);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 51;
            label7.Text = "Job ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(270, 82);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 49;
            label6.Text = "Pub ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 155);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 47;
            label5.Text = "Hire date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(353, 155);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 46;
            label4.Text = "Minit";
            // 
            // txtMinit
            // 
            txtMinit.BorderStyle = BorderStyle.FixedSingle;
            txtMinit.Cursor = Cursors.IBeam;
            txtMinit.Location = new Point(353, 177);
            txtMinit.Margin = new Padding(2);
            txtMinit.Name = "txtMinit";
            txtMinit.Size = new Size(121, 27);
            txtMinit.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(395, 14);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 44;
            label3.Text = "Last Name";
            // 
            // txtLast
            // 
            txtLast.BorderStyle = BorderStyle.FixedSingle;
            txtLast.Cursor = Cursors.IBeam;
            txtLast.Location = new Point(395, 36);
            txtLast.Margin = new Padding(2);
            txtLast.Name = "txtLast";
            txtLast.Size = new Size(223, 27);
            txtLast.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(156, 14);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 42;
            label2.Text = "First Name";
            // 
            // txtFirst
            // 
            txtFirst.BorderStyle = BorderStyle.FixedSingle;
            txtFirst.Cursor = Cursors.IBeam;
            txtFirst.Location = new Point(156, 36);
            txtFirst.Margin = new Padding(2);
            txtFirst.Name = "txtFirst";
            txtFirst.Size = new Size(224, 27);
            txtFirst.TabIndex = 41;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 14);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 39;
            label1.Text = "Id";
            // 
            // cbJobId
            // 
            cbJobId.Cursor = Cursors.Hand;
            cbJobId.FormattingEnabled = true;
            cbJobId.Location = new Point(20, 105);
            cbJobId.Name = "cbJobId";
            cbJobId.Size = new Size(234, 28);
            cbJobId.TabIndex = 57;
            // 
            // cbPubId
            // 
            cbPubId.Cursor = Cursors.Hand;
            cbPubId.FormattingEnabled = true;
            cbPubId.Location = new Point(270, 104);
            cbPubId.Name = "cbPubId";
            cbPubId.Size = new Size(204, 28);
            cbPubId.TabIndex = 58;
            // 
            // mtbId
            // 
            mtbId.BorderStyle = BorderStyle.FixedSingle;
            mtbId.Cursor = Cursors.IBeam;
            mtbId.Location = new Point(20, 37);
            mtbId.Mask = "LLL-00000-L";
            mtbId.Name = "mtbId";
            mtbId.Size = new Size(125, 27);
            mtbId.TabIndex = 59;
            // 
            // InsertarEmp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(654, 260);
            Controls.Add(mtbId);
            Controls.Add(cbPubId);
            Controls.Add(cbJobId);
            Controls.Add(dtpHireDate);
            Controls.Add(btnCancelar);
            Controls.Add(btnActualizar);
            Controls.Add(label8);
            Controls.Add(txtJobLvl);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtMinit);
            Controls.Add(label3);
            Controls.Add(txtLast);
            Controls.Add(label2);
            Controls.Add(txtFirst);
            Controls.Add(label1);
            Name = "InsertarEmp";
            Text = "InsertarEmp";
            Load += InsertarEmp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpHireDate;
        private Button btnCancelar;
        private Button btnActualizar;
        private Label label8;
        private TextBox txtJobLvl;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtMinit;
        private Label label3;
        private TextBox txtLast;
        private Label label2;
        private TextBox txtFirst;
        private Label label1;
        private ComboBox cbJobId;
        private ComboBox cbPubId;
        private MaskedTextBox mtbId;
    }
}