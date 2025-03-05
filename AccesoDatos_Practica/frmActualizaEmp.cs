using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;

namespace AccesoDatos_Practica
{
    public partial class frmActualizaEmp : Form
    {
        public frmActualizaEmp(string id, string fname, string minit, string lname, string jobid, int joblvl, string pubid, DateTime hiredate)
        {
            InitializeComponent();
            txtId.Text = id;
            txtFirst.Text = fname;
            txtLast.Text = lname;
            txtMinit.Text = minit + "";
            txtJobId.Text = jobid + "";
            txtJobLvl.Text = joblvl + "";
            txtPubId.Text = pubid + "";
            dtpHireDate.Value = hiredate;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string date = dtpHireDate.Value.ToString("yyyy-MM-dd HH:mm:ss");
            MessageBox.Show(date);

            Datos datos = new Datos();
            bool f = datos.comando("update employee set " +
                "fname='" + txtFirst.Text +
                "', minit='" + txtMinit.Text +
                "', lname='" + txtLast.Text +
                "', job_id='" + txtJobId.Text +
                "', job_lvl='" + txtJobLvl.Text +
                "', pub_id='" + txtPubId.Text +
                "', hire_date='" + date+
                "' where emp_id='" + txtId.Text + "'");
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

        private void txtJobLvl_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
