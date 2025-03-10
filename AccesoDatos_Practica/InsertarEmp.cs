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
    public partial class InsertarEmp : Form
    {
        public InsertarEmp()
        {
            InitializeComponent();
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
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DataRowView row1 = cbJobId.SelectedItem as DataRowView;
            DataRowView row2 = cbPubId.SelectedItem as DataRowView;

            if (mtbId.Text.Last() != 'F' && mtbId.Text.Last() != 'M') // Verificar si es F o M
            {
                MessageBox.Show("El último carácter debe ser F o M.");
                mtbId.Focus();
            }

            string date = dtpHireDate.Value.ToString("yyyy-MM-dd HH:mm:ss");

            Datos datos = new Datos();
            bool f = datos.comando("insert into employee values('" + mtbId.Text.Replace("-", "") + "','" +
                txtFirst.Text + "','" + txtMinit.Text + "','" + txtLast.Text + "','" +
                row1["job_id"].ToString() + "','" + txtJobLvl.Text + "','" + row2["pub_id"].ToString() + "','" +
                date + "')");
            if (f == true)
            {
                MessageBox.Show("Datos insertados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al insertar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void InsertarEmp_Load(object sender, EventArgs e)
        {
            mtbId.Focus();
        }
    }
}
