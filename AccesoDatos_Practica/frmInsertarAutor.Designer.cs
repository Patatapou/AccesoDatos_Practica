namespace AccesoDatos_Practica
{
    partial class frmInsertarAutor
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
            chkContract = new CheckBox();
            label8 = new Label();
            txtState = new TextBox();
            label7 = new Label();
            txtCity = new TextBox();
            label6 = new Label();
            txtZip = new TextBox();
            label5 = new Label();
            txtAddress = new TextBox();
            label4 = new Label();
            txtPhone = new TextBox();
            label3 = new Label();
            txtLast = new TextBox();
            label2 = new Label();
            txtFirst = new TextBox();
            txtId = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(350, 268);
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
            btnActualizar.Location = new Point(256, 267);
            btnActualizar.Margin = new Padding(2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(90, 27);
            btnActualizar.TabIndex = 36;
            btnActualizar.Text = "Insertar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // chkContract
            // 
            chkContract.AutoSize = true;
            chkContract.Location = new Point(17, 271);
            chkContract.Margin = new Padding(2);
            chkContract.Name = "chkContract";
            chkContract.Size = new Size(87, 24);
            chkContract.TabIndex = 35;
            chkContract.Text = "Contract";
            chkContract.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(157, 201);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(43, 20);
            label8.TabIndex = 34;
            label8.Text = "State";
            // 
            // txtState
            // 
            txtState.Location = new Point(157, 224);
            txtState.Margin = new Padding(2);
            txtState.Name = "txtState";
            txtState.Size = new Size(121, 27);
            txtState.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 201);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(34, 20);
            label7.TabIndex = 32;
            label7.Text = "City";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(17, 224);
            txtCity.Margin = new Padding(2);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(121, 27);
            txtCity.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(300, 201);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 30;
            label6.Text = "ZIP Code";
            // 
            // txtZip
            // 
            txtZip.Location = new Point(300, 224);
            txtZip.Margin = new Padding(2);
            txtZip.Name = "txtZip";
            txtZip.Size = new Size(121, 27);
            txtZip.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(157, 135);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 28;
            label5.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(157, 157);
            txtAddress.Margin = new Padding(2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(283, 27);
            txtAddress.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 135);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 26;
            label4.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(17, 157);
            txtPhone.Margin = new Padding(2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(121, 27);
            txtPhone.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(237, 74);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 24;
            label3.Text = "Last Name";
            // 
            // txtLast
            // 
            txtLast.Location = new Point(237, 96);
            txtLast.Margin = new Padding(2);
            txtLast.Name = "txtLast";
            txtLast.Size = new Size(203, 27);
            txtLast.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 74);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 22;
            label2.Text = "First Name";
            // 
            // txtFirst
            // 
            txtFirst.Location = new Point(17, 96);
            txtFirst.Margin = new Padding(2);
            txtFirst.Name = "txtFirst";
            txtFirst.Size = new Size(203, 27);
            txtFirst.TabIndex = 21;
            // 
            // txtId
            // 
            txtId.Location = new Point(17, 36);
            txtId.Margin = new Padding(2);
            txtId.Name = "txtId";
            txtId.Size = new Size(121, 27);
            txtId.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 13);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 19;
            label1.Text = "Id";
            // 
            // frmInsertarAutor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 317);
            Controls.Add(btnCancelar);
            Controls.Add(btnActualizar);
            Controls.Add(chkContract);
            Controls.Add(label8);
            Controls.Add(txtState);
            Controls.Add(label7);
            Controls.Add(txtCity);
            Controls.Add(label6);
            Controls.Add(txtZip);
            Controls.Add(label5);
            Controls.Add(txtAddress);
            Controls.Add(label4);
            Controls.Add(txtPhone);
            Controls.Add(label3);
            Controls.Add(txtLast);
            Controls.Add(label2);
            Controls.Add(txtFirst);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "frmInsertarAutor";
            Text = "frmInsertarAutor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnActualizar;
        private CheckBox chkContract;
        private Label label8;
        private TextBox txtState;
        private Label label7;
        private TextBox txtCity;
        private Label label6;
        private TextBox txtZip;
        private Label label5;
        private TextBox txtAddress;
        private Label label4;
        private TextBox txtPhone;
        private Label label3;
        private TextBox txtLast;
        private Label label2;
        private TextBox txtFirst;
        private TextBox txtId;
        private Label label1;
    }
}