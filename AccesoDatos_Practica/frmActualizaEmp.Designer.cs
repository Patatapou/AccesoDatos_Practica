namespace AccesoDatos_Practica
{
    partial class frmActualizaEmp
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
            btnCancelar = new Button();
            btnActualizar = new Button();
            label8 = new Label();
            txtJobLvl = new TextBox();
            label7 = new Label();
            txtJobId = new TextBox();
            label6 = new Label();
            txtPubId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtMinit = new TextBox();
            label3 = new Label();
            txtLast = new TextBox();
            label2 = new Label();
            txtFirst = new TextBox();
            txtId = new TextBox();
            label1 = new Label();
            dtpHireDate = new DateTimePicker();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(348, 266);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 27);
            btnCancelar.TabIndex = 37;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(254, 265);
            btnActualizar.Margin = new Padding(2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(90, 27);
            btnActualizar.TabIndex = 36;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(173, 199);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 34;
            label8.Text = "Job Level";
            // 
            // txtJobLvl
            // 
            txtJobLvl.Location = new Point(173, 222);
            txtJobLvl.Margin = new Padding(2);
            txtJobLvl.Name = "txtJobLvl";
            txtJobLvl.Size = new Size(121, 27);
            txtJobLvl.TabIndex = 33;
            txtJobLvl.TextChanged += txtJobLvl_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 199);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 32;
            label7.Text = "Job ID";
            // 
            // txtJobId
            // 
            txtJobId.Location = new Point(15, 222);
            txtJobId.Margin = new Padding(2);
            txtJobId.Name = "txtJobId";
            txtJobId.Size = new Size(121, 27);
            txtJobId.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(325, 199);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 30;
            label6.Text = "Pub ID";
            // 
            // txtPubId
            // 
            txtPubId.Location = new Point(325, 222);
            txtPubId.Margin = new Padding(2);
            txtPubId.Name = "txtPubId";
            txtPubId.Size = new Size(121, 27);
            txtPubId.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(155, 133);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 28;
            label5.Text = "Hire date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 133);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 26;
            label4.Text = "Minit";
            // 
            // txtMinit
            // 
            txtMinit.Location = new Point(15, 155);
            txtMinit.Margin = new Padding(2);
            txtMinit.Name = "txtMinit";
            txtMinit.Size = new Size(121, 27);
            txtMinit.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(235, 72);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 24;
            label3.Text = "Last Name";
            // 
            // txtLast
            // 
            txtLast.Location = new Point(235, 94);
            txtLast.Margin = new Padding(2);
            txtLast.Name = "txtLast";
            txtLast.Size = new Size(215, 27);
            txtLast.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 72);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 22;
            label2.Text = "First Name";
            // 
            // txtFirst
            // 
            txtFirst.Location = new Point(15, 94);
            txtFirst.Margin = new Padding(2);
            txtFirst.Name = "txtFirst";
            txtFirst.Size = new Size(203, 27);
            txtFirst.TabIndex = 21;
            // 
            // txtId
            // 
            txtId.Location = new Point(15, 34);
            txtId.Margin = new Padding(2);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(121, 27);
            txtId.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 11);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 19;
            label1.Text = "Id";
            // 
            // dtpHireDate
            // 
            dtpHireDate.Location = new Point(155, 156);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(295, 27);
            dtpHireDate.TabIndex = 38;
            // 
            // frmActualizaEmp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 319);
            Controls.Add(dtpHireDate);
            Controls.Add(btnCancelar);
            Controls.Add(btnActualizar);
            Controls.Add(label8);
            Controls.Add(txtJobLvl);
            Controls.Add(label7);
            Controls.Add(txtJobId);
            Controls.Add(label6);
            Controls.Add(txtPubId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtMinit);
            Controls.Add(label3);
            Controls.Add(txtLast);
            Controls.Add(label2);
            Controls.Add(txtFirst);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "frmActualizaEmp";
            Text = "frmActualizaEmp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnActualizar;
        private Label label8;
        private TextBox txtJobLvl;
        private Label label7;
        private TextBox txtJobId;
        private Label label6;
        private TextBox txtPubId;
        private Label label5;
        private Label label4;
        private TextBox txtMinit;
        private Label label3;
        private TextBox txtLast;
        private Label label2;
        private TextBox txtFirst;
        private TextBox txtId;
        private Label label1;
        private DateTimePicker dtpHireDate;
    }
}