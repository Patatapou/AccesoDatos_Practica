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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AccesoDatos_Practica
{
    public partial class InsertarTitulo : Form
    {
        public InsertarTitulo()
        {
            InitializeComponent();
            Datos datos = new Datos();
            DataSet ds = datos.Consulta("select pub_id, pub_name from publishers");
            cbPubId.DataSource = ds.Tables[0];
            cbPubId.DisplayMember = "pub_name";
            cbPubId.ValueMember = "pub_id";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DataRowView row = cbPubId.SelectedItem as DataRowView;

            string date = dtpPubDate.Value.ToString("yyyy-MM-dd HH:mm:ss");

            Datos datos = new Datos();
            bool f = datos.comando("insert into titles values('" + mtbId.Text.Replace("-", "") + "','" +
                txtTitle.Text + "','" + txtType.Text + "','" + row["pub_id"].ToString() + "','" +
                mtbPrice.Text + "','" + mtbAdvance.Text + "','" + mtbRoyalty.Text + "','" +
                mtbSales.Text + "','" + rtbNotes.Text + "','" + date + "')");
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

        private void InsertarTitulo_Load(object sender, EventArgs e)
        {
            mtbId.Focus();
        }
    }
}
