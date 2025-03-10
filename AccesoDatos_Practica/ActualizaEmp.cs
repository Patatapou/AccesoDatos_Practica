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
    public partial class ActualizaEmp : Form
    {
        public ActualizaEmp(string id, string fname, string minit, string lname, string jobid, int joblvl, string pubid, DateTime hiredate)
        {
            InitializeComponent();
            txtId.Text = id;
            txtFirst.Text = fname;
            txtLast.Text = lname;
            txtMinit.Text = minit + "";
            txtJobLvl.Text = joblvl + "";
            
            dtpHireDate.Value = hiredate;

            Datos datos1 = new Datos();
            DataSet ds1 = datos1.Consulta("select job_id, job_desc from jobs");
            cbJobId.DataSource = ds1.Tables[0];
            cbJobId.DisplayMember = "job_desc";
            cbJobId.ValueMember = "job_id";

            Datos datos2 = new Datos();
            DataSet ds2 = datos2.Consulta("select pub_id, pub_name from publishers");
            cbPubId.DataSource = ds2.Tables[0];
            cbPubId.DisplayMember = "pub_name";
            cbPubId.ValueMember = "pub_id";

            cbPubId.Text = pubid + "";
            cbJobId.Text = jobid + "";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string date = dtpHireDate.Value.ToString("yyyy-MM-dd HH:mm:ss");

            DataRowView row1 = cbJobId.SelectedItem as DataRowView;
            DataRowView row2 = cbPubId.SelectedItem as DataRowView;

            Datos datos = new Datos();
            bool f = datos.comando("update employee set " +
                "fname='" + txtFirst.Text +
                "', minit='" + txtMinit.Text +
                "', lname='" + txtLast.Text +
                "', job_id='" + row1["job_id"].ToString() +
                "', job_lvl='" + txtJobLvl.Text +
                "', pub_id='" + row2["pub_id"].ToString() +
                "', hire_date='" + date +
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

        private void button1_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            bool f = datos.comando("delete from employee where emp_id='" + txtId.Text + "'");
            if (f == true)
            {
                MessageBox.Show("Registro eiminado", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Error al eliminar el registro", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ActualizaEmp_Load(object sender, EventArgs e)
        {
            txtFirst.Focus();
        }
    }
}
