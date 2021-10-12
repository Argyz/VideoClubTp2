using System;
using System.Windows.Forms;

namespace VideoClub.Formularios
{
    public partial class frmAgregar : Form
    {
        private float total;
        private int codigo;
        private string pelicula;
        private string socio;
        private string detalles;
        private bool aceptar;
        public frmAgregar()
        {
            InitializeComponent();
        }

        public int Codigo => codigo;
        public string Pelicula => pelicula;
        public string Socio => socio;
        public string Detalle => detalles;
        public float Total => total;
        public bool Aceptar => aceptar;

        private bool verificar()
        {
            return (txtVentaCodigo.Text == "" || txtVentaPelicula.Text=="" || cboCalidad.SelectedItem.ToString() == "") ? false : true;
        }

       
        private string verificarSocio()
        {
            if (rdoNoSocio.Checked)
            {
                return "NO SOCIO";
            }
            else
            {
                return txtVentaSocio.Text;
            }
        }

        private float calcularPrecio()
        {
            float totalPagar=0;
            if (rdoAlquiler.Checked)
            {
                if (rdoSocio.Checked)
                {
                    totalPagar += 100;
                }
                if (rdoNoSocio.Checked)
                {
                    totalPagar += 200;
                }
            }

            if (rdoVenta.Checked)
            {
                if (rdoSocio.Checked)
                {
                    totalPagar += 200;
                }

                if (rdoNoSocio.Checked)
                {
                    totalPagar += 400;
                }

            }
            return totalPagar;
        } 

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            lblVentaTotal.Text = "";
        }
        private void cboCalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboCalidad.SelectedItem)
            {
                case "Comun":
                    total = calcularPrecio();
                    lblVentaTotal.Text = total.ToString("C");
                    
                    break;
                case "3D":
                    total = calcularPrecio() + 50;
                    lblVentaTotal.Text = total.ToString("C");
                    
                    break;
                case "HD":
                    total = calcularPrecio() + 30;
                    lblVentaTotal.Text = total.ToString("C");
                    
                    break;
                case "Full HD":
                    total = calcularPrecio() + 100;
                    lblVentaTotal.Text = total.ToString("C");
                   
                    break;
                case "Full 4K":
                    total = calcularPrecio() + 300;
                    lblVentaTotal.Text = total.ToString("C");
                    
                    break;
                default:
                    total = calcularPrecio();
                    lblVentaTotal.Text = total.ToString("C");
                    break;
            }
        }

        private void rdoNoSocio_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNoSocio.Checked)
            {
                txtVentaSocio.Enabled = false;
            }
            if (rdoSocio.Checked)
            {
                txtVentaSocio.Enabled = true;
            }
        }

        private void btnVentaAceptar_Click(object sender, EventArgs e)
        {
          
            bool ver = verificar();

            if (ver) {

                DialogResult msj = MessageBox.Show("Esta seguro que desea realizar la venta?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (msj == DialogResult.OK)
                {

                    codigo = int.Parse(txtVentaCodigo.Text);
                    pelicula = txtVentaPelicula.Text;
                    socio = verificarSocio();
                    detalles = cboCalidad.SelectedItem.ToString();
                    aceptar = true;
                    MessageBox.Show("Su venta se registro exitosamente");
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Oops hubo un error... uno o mas campos no pueden estar vacios","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnVentaCancelar_Click(object sender, EventArgs e)
        {
            aceptar = false;
            this.Close();
        }
    }
}
