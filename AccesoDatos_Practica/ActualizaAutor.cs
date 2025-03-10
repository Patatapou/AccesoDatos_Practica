using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccesoDatos
{
    public partial class ActualizaAutor : Form
    {
        public ActualizaAutor(string id, string fname, string lname, string phone, string address, string city, string state, string zip, bool contract)
        {
            InitializeComponent();
            txtFirst.Text = fname;
            txtLast.Text = lname;
            txtPhone.Text = phone;
            txtAddress.Text = address;
            txtCity.Text = city;
            txtState.Text = state;
            txtZip.Text = zip;
            txtId.Text = id;
            chkContract.Checked = contract;
        }

        private void frmActualizaAutor_Load(object sender, EventArgs e)
        {
            txtFirst.Focus();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            bool f = datos.comando("update authors set " +
                "au_fname='" + txtFirst.Text +
                "', au_lname='" + txtLast.Text +
                "', phone='" + txtPhone.Text +
                "', address='" + txtAddress.Text +
                "', city='" + txtCity.Text +
                "', state='" + txtState.Text +
                "', zip='" + txtZip.Text +
                "', contract=" + (chkContract.Checked ? 1 : 0) +
                " where au_id='" + txtId.Text + "'");
            if (f == true)
            {
                MessageBox.Show("Datos Actualizados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Error al actualizar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            bool f = datos.comando("delete from authors where au_id='" + txtId.Text + "'");
            if (f == true)
            {
                MessageBox.Show("Registro eiminado", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Error al eliminar el registro", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
