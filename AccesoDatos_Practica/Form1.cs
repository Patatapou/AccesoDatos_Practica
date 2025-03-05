using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data;
using AccesoDatos;

namespace AccesoDatos_Practica
{
    public partial class AUTORES : Form
    {
        public AUTORES()
        {
            InitializeComponent();
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Datos obj = new Datos();
            DataSet ds = obj.Consulta("Select au_id as ID, au_lname as [Last Name], au_fname as [First Name], phone as Phone, authors.address as Address, city as City, state as State, zip as Zip, contract as Contract From authors");
            if (ds != null)
            {
                dgv.DataSource = ds.Tables[0];
            }
        }

        private void dgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnas = dgv.ColumnCount;
            switch (columnas)
            {
                case 8:
                    string HireDate = dgv[7, e.RowIndex].Value.ToString();
                    string dia = HireDate[0].ToString() + HireDate[1].ToString();
                    string mes = HireDate[3].ToString() + HireDate[4].ToString(); ;
                    string ano = HireDate[6].ToString() + HireDate[7].ToString() + HireDate[8].ToString() + HireDate[9].ToString();
                    HireDate = ano + "-" + mes + "-" + dia;

                    frmActualizaEmp actualizaEmp = new frmActualizaEmp(
                        dgv[0, e.RowIndex].Value.ToString(),
                        dgv[1, e.RowIndex].Value.ToString(),
                        dgv[2, e.RowIndex].Value.ToString(),
                        dgv[3, e.RowIndex].Value.ToString(),
                        dgv[4, e.RowIndex].Value.ToString(),
                        int.Parse(dgv[5, e.RowIndex].Value.ToString()),
                        dgv[6, e.RowIndex].Value.ToString(),
                        DateTime.Parse(HireDate)
                    );
                    actualizaEmp.Show();
                    break;
                case 9:
                    frmActualizaAutor actualizaAutor = new frmActualizaAutor(
                        dgv[0, e.RowIndex].Value.ToString(),
                        dgv[1, e.RowIndex].Value.ToString(),
                        dgv[2, e.RowIndex].Value.ToString(),
                        dgv[3, e.RowIndex].Value.ToString(),
                        dgv[4, e.RowIndex].Value.ToString(),
                        dgv[5, e.RowIndex].Value.ToString(),
                        dgv[6, e.RowIndex].Value.ToString(),
                        dgv[7, e.RowIndex].Value.ToString(),
                        Convert.ToBoolean(dgv[8, e.RowIndex].Value)
                    );
                    actualizaAutor.Show();
                    break;
                case 10:
                    string PubDate = dgv[9, e.RowIndex].Value.ToString();
                    MessageBox.Show(PubDate);
                    string dia2 = PubDate[0].ToString() + PubDate[1].ToString();
                    string mes2 = PubDate[3].ToString() + PubDate[4].ToString(); ;
                    string ano2 = PubDate[6].ToString() + PubDate[7].ToString() + PubDate[8].ToString() + PubDate[9].ToString();
                    PubDate = ano2 + "-" + mes2 + "-" + dia2;
                    MessageBox.Show(PubDate);
                    frmActualizaTitulo actualizaTitulo = new frmActualizaTitulo(
                        dgv[0, e.RowIndex].Value.ToString(),
                        dgv[1, e.RowIndex].Value.ToString(),
                        dgv[2, e.RowIndex].Value.ToString(),
                        dgv[3, e.RowIndex].Value.ToString(),
                        float.Parse(dgv[4, e.RowIndex].Value.ToString()),
                        float.Parse(dgv[5, e.RowIndex].Value.ToString()),
                        int.Parse(dgv[6, e.RowIndex].Value.ToString()),
                        int.Parse(dgv[7, e.RowIndex].Value.ToString()),
                        dgv[8, e.RowIndex].Value.ToString(),
                        DateTime.Parse(PubDate)
                    );
                    actualizaTitulo.Show();
                    break;
                default:
                    MessageBox.Show("Error al abrir la ventana de actualización", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Datos obj = new Datos();
            DataSet ds = obj.Consulta("Select emp_id as ID, fname as [First Name], minit as Minit, lname as [Last Name], job_id as [Job ID], job_lvl as [Job Level], pub_id as [Pub ID], hire_date as [Hire Date] From employee");
            if (ds != null)
            {
                dgv.DataSource = ds.Tables[0];
            }
        }

        private void titulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Datos obj = new Datos();
            DataSet ds = obj.Consulta("Select title_id as ID, title as Title, type as Type, pub_id as [Pub ID], price as Price, advance as Advance, royalty as Royalty, ytd_sales as Sales, notes as Notes, pubdate as [Pub date] From titles");
            if (ds != null)
            {
                dgv.DataSource = ds.Tables[0];
            }
        }

        private void insertarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInsertarAutor frmInsertarAutor = new frmInsertarAutor();
            frmInsertarAutor.Show();
        }

        private void insertarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmInsertarEmp frmInsertarEmp = new frmInsertarEmp();
            frmInsertarEmp.Show();
        }

        private void insertarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmInsertarTitulo frmInsertarTitulo = new frmInsertarTitulo();
            frmInsertarTitulo.Show();
        }
    }
}
