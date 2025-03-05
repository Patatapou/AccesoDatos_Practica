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
using static System.Windows.Forms.AxHost;

namespace AccesoDatos_Practica
{
    public partial class frmActualizaTitulo : Form
    {
        public frmActualizaTitulo(string id, string title, string type, string pubId, float price, float advance, int royalty, int sales, string notes, DateTime pubdate)
        {
            InitializeComponent();
            txtId.Text = id;
            txtTitle.Text = title;
            txtType.Text = type;
            txtPubId.Text = pubId + "";
            txtPrice.Text = price + "";
            txtAdvance.Text = advance + "";
            txtRoyalty.Text = royalty + "";
            txtSales.Text = sales + "";
            rtbNotes.Text = notes;
            dtpPubDate.Value= pubdate;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string date = dtpPubDate.Value.ToString("yyyy-MM-dd HH:mm:ss");
            Datos datos = new Datos();
            bool f = datos.comando("update titles set " +
                "title='" + txtTitle.Text +
                "', type='" + txtType.Text +
                "', pub_id='" + txtPubId.Text +
                "', price='" + txtPrice.Text +
                "', advance='" + txtAdvance.Text +
                "', royalty='" + txtRoyalty.Text +
                "', ytd_sales='" + txtSales.Text +
                "', notes='" + rtbNotes.Text +
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
    }
}
