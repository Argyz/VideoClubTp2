using System;
using System.Windows.Forms;
using VideoClub.Formularios;

namespace VideoClub
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void llenarDgv(int codigo,string pelicula,string socio, string detalle,float monto)
        {
            int n = dgvSales.Rows.Add();

            dgvSales.Rows[n].Cells[0].Value = codigo;
            dgvSales.Rows[n].Cells[1].Value = pelicula;
            dgvSales.Rows[n].Cells[2].Value = socio;
            dgvSales.Rows[n].Cells[3].Value = detalle;
            dgvSales.Rows[n].Cells[4].Value = monto.ToString("C");
            dgvSales.Rows[n].Cells[5].Value = DateTime.Now.Date.ToString("dd/MM/yyyy");
            dgvSales.Rows[n].Cells[6].Value = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmLogin login=new frmLogin();
            login.ShowDialog();
        }

        private void tsbtnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar agregar = new frmAgregar();
            agregar.ShowDialog();

            if (agregar.Aceptar)
            {
                llenarDgv(agregar.Codigo, agregar.Pelicula, agregar.Socio, agregar.Detalle, agregar.Total);
            }

        }

        private void tsbtnModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opcion no disponible todavia en esta version del sistema...");
        }

        private void tsbtnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opcion no disponible todavia en esta version del sistema...");
        }
    }
}
