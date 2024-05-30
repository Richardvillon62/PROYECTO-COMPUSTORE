using MODULO_USUARIO;
using MODULO_PROVEEDOR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MODULO_PRODUCTOS_DE_CATALOGO;
using MODULO_EMPRESA_DE_TRANSPORTE;
using MODULO_ORDEN_DE_COMPRA;
using MODULO_FACTURA;
using DATOS_TSP;


namespace PROYECTO_TELESHOPPING
{
    public partial class FormMenuPrincipal : Form
    {
       

        public FormMenuPrincipal()
        {
            InitializeComponent();
            panelSubmenu();
        }
        Dato_ts data = Dato_ts.getObject();
        private void panelSubmenu()
        {
            panelSubmenuUsuario.Visible = false;
            panelSubmenuProveedor.Visible = false;
            panelSubmenuCatalogo.Visible = false;
            panelSubmenuTransporte.Visible = false;
            panelSubmenuCompra.Visible = false;
            

        }

        private void hideSubMenu()
        {
            if(panelSubmenuUsuario.Visible == true)
                panelSubmenuUsuario.Visible = false;

            if (panelSubmenuProveedor.Visible == true)
                panelSubmenuProveedor.Visible = false;

            if (panelSubmenuCatalogo.Visible == true)
                panelSubmenuCatalogo.Visible = false;

            if (panelSubmenuTransporte.Visible == true)
                panelSubmenuTransporte.Visible = false;

            if (panelSubmenuCompra.Visible == true)
                panelSubmenuCompra.Visible = false;
        }

        private void showSubmenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                hideSubMenu();
                SubMenu.Visible = true;
            }
            else
           SubMenu.Visible = false;
        }

        private Form activeForm = null;
        private void contenedores(Form conten)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = conten;
            conten.TopLevel = false;
            conten.FormBorderStyle = FormBorderStyle.None;
            conten.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(conten);
            panelContenedor.Tag = conten;
            conten.BringToFront();
            conten.Show();

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubmenuUsuario);
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubmenuProveedor);
        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubmenuCatalogo);
        }

        private void btnTransporte_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubmenuTransporte);
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubmenuCompra);
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            contenedores(new FormFactura());
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {

            contenedores(new FormRegistarUsuario());
            hideSubMenu();
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            contenedores(new FormModificarUsuario());
            hideSubMenu();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            contenedores(new FormEliminarUsuario());
            hideSubMenu();
        }

        private void btnRegistrarProveedor_Click(object sender, EventArgs e)
        {
            contenedores(new FormRegistrarProveedor());
            hideSubMenu();
        }

        private void btnModificarProveedor_Click(object sender, EventArgs e)
        {
            contenedores(new FormModificarProveedor());
            hideSubMenu();
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            contenedores(new FormEliminarProveedor());
            hideSubMenu();
        }

        private void btnRegistrarProducto_Click(object sender, EventArgs e)
        {
            contenedores(new FormRegistrarProducto());
            hideSubMenu();
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            contenedores(new FormModificarProducto());
            hideSubMenu();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            contenedores(new FormEliminarProducto());
            hideSubMenu();
        }

        private void btnRegistrarEmpresa_Click(object sender, EventArgs e)
        {
            contenedores(new FormRegistrarEmpresa());
            hideSubMenu();
        }

        private void btnModificarEmpresa_Click(object sender, EventArgs e)
        {
            contenedores(new FormModificarEmpresa());
            hideSubMenu();
        }

        private void btnEliminarEmpresa_Click(object sender, EventArgs e)
        {
            contenedores(new FormEliminarEmpresa());
            hideSubMenu();
        }

        private void btnRegistrarCompra_Click(object sender, EventArgs e)
        {
            contenedores(new FormRegistrarOrden());
            hideSubMenu();
        }

        private void btnModificarCompra_Click(object sender, EventArgs e)
        {
            contenedores(new FormModificarOrden());
            hideSubMenu();
        }

        private void btnEliminarCompra_Click(object sender, EventArgs e)
        {
            contenedores(new FormEliminarOrden());
            hideSubMenu();
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
