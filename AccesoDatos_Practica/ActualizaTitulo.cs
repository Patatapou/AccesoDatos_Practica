using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.AxHost;

namespace AccesoDatos_Practica
{
    public partial class ActualizaTitulo : Form
    {
        public ActualizaTitulo(string id, string title, string type, string pubId, float price, float advance, int royalty, int sales, string notes, DateTime pubdate)
        {
            InitializeComponent();
            txtId.Text = id;
            txtTitle.Text = title;
            txtType.Text = type;
            mtbPrice.Text = price + "";
            mtbAdvance.Text = advance + "";
            mtbRoyalty.Text = royalty + "";
            mtbSales.Text = sales + "";
            rtbNotes.Text = notes;
            dtpPubDate.Value = pubdate;

            Datos datos = new Datos();
            DataSet ds = datos.Consulta("select pub_id, pub_name from publishers");
            cbPubId.DataSource = ds.Tables[0];
            cbPubId.DisplayMember = "pub_name";
            cbPubId.ValueMember = "pub_id";

            cbPubId.Text = pubId + "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string date = dtpPubDate.Value.ToString("yyyy-MM-dd HH:mm:ss");

            DataRowView row = cbPubId.SelectedItem as DataRowView;

            Datos datos = new Datos();
            bool f = datos.comando("update titles set " +
                "title='" + txtTitle.Text.Replace("'","") +
                "', type='" + txtType.Text +
                "', pub_id='" + row["pub_id"].ToString() +
                "', price='" + mtbPrice.Text +
                "', advance='" + mtbAdvance.Text +
                "', royalty='" + mtbRoyalty.Text +
                "', ytd_sales='" + mtbSales.Text +
                "', notes='" + rtbNotes.Text.Replace("'", "") +
                "', pubdate='" + date +
                "' where title_id='" + txtId.Text + "'");
            if (f == true)
            {
                MessageBox.Show("Datos Actualizados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Error al actualizar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            bool f = datos.comando("delete from titles where title_id='" + txtId.Text + "'");
            if (f == true)
            {
                MessageBox.Show("Registro eiminado", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Error al eliminar el registro", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ActualizaTitulo_Load(object sender, EventArgs e)
        {
            txtTitle.Focus();
        }
    }
}
