using System;
using System.Drawing;
using System.Windows.Forms;

namespace VideoClub.Formularios
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblError.Text = "";
        }

        private void btnLoginAceptar_Click(object sender, EventArgs e)
        {
            if (txtLoginUser.Text == "admin" && txtLoginPass.Text == "admin")
            {
                this.Close();
            }
            else
            {
                lblError.Text = "Error el usuario o contraseña es incorrecto";
                lblError.ForeColor = Color.Red;
                txtLoginPass.Text = "";
            }
        }

        private void btnLoginCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
