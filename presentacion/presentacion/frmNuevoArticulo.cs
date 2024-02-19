using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using System.Configuration;

namespace presentacion
{
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog archivoImagen = null;
        
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        public frmAltaArticulo(Articulo articulo, string titulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = titulo;
                         

        }
      



        private void btnAltaArticulo_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            int banderaError = 0;
            try
            {
                lblCodigoError.Text = "";
                lblNombreError.Text = "";
                lblPrecioError.Text = "";

                if (!string.IsNullOrEmpty(validarCodigo()))
                {
                    lblCodigoError.Text = validarCodigo();
                    banderaError++;
                }
                if (!string.IsNullOrEmpty(validarNombre()))
                {
                    lblNombreError.Text = validarNombre();
                    banderaError++;
                }
                if (!string.IsNullOrEmpty(validarPrecio()))
                {
                    lblPrecioError.Text = validarPrecio();
                    banderaError++;
                }
                if (banderaError >= 1)
                    return;
                
                if (articulo == null)
                    articulo = new Articulo();

                articulo.CodigoArticulo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Imagen = txtUrlImagen.Text;
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.Precio = decimal.Parse(txtPrecio.Text);


                if (articulo.IdArticulo != 0)
                {
                   negocio.modificar(articulo);
                   MessageBox.Show("Su articulo ha sido modificado.");                        
                }
                else
                {
                   negocio.añadir(articulo);
                   MessageBox.Show("Tu articulo ha sido añadido al sistema.");
                        
                }
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void cargarImagen(string imagen)
        {
            try
            {
                pbxNuevoArticulo.Load(imagen);
            }
            catch (Exception ex)
            {

                pbxNuevoArticulo.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/6/65/No-Image-Placeholder.svg/1665px-No-Image-Placeholder.svg.png");
            }
        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                cboMarca.DataSource = marcaNegocio.listarMarca();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";

                cboCategoria.DataSource = categoriaNegocio.listarCategoria();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";

                if(articulo != null)
                {
                    txtCodigo.Text = articulo.CodigoArticulo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtUrlImagen.Text = articulo.Imagen;
                    cargarImagen(articulo.Imagen);
                    cboMarca.SelectedValue = articulo.Marca.Id;
                    cboCategoria.SelectedValue = articulo.Categoria.Id;
                    txtPrecio.Text = articulo.Precio.ToString();
                    
                    if(Text == "Ver Articulo")
                    {
                        btnAltaArticulo.Visible = false;
                        btnCancelar.Location = new System.Drawing.Point(159, 441);
                        txtCodigo.Enabled = false;
                        txtNombre.Enabled = false;
                        txtDescripcion.Enabled = false;
                        txtUrlImagen.Enabled = false;
                        cboMarca.Enabled = false;
                        cboCategoria.Enabled = false;
                        txtPrecio.Enabled = false;
                        lblCodigoNecesario.Hide();
                        lblCodigoError.Hide();
                        lblNombreNecesario.Hide();
                        lblNombreError.Hide();
                        lblPrecioNecesario.Hide();
                        lblPrecioError.Hide();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private string validarCodigo()
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
                return "Debe cargar el codigo del articulo";
            return "";
        }
        private string validarNombre()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
                return "Debe cargar el nombre del articulo";
            return "";
        }
        private string validarPrecio()
        {
            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio < 0)
                return "Debe cargar un precio valido";
            return "";
        }

        private void pbxNuevoArticulo_Click(object sender, EventArgs e)
        {

        }

        private void lblCodigoNecesario_MouseHover(object sender, EventArgs e)
        {
            campoRequerido(lblCodigoNecesario);
        }

        private void campoRequerido(Label label)
        {
            ToolTip camporequerido = new ToolTip();
            camporequerido.SetToolTip(label, "Campo requerido");
        }

        private void lblNombreNecesario_MouseHover(object sender, EventArgs e)
        {
            campoRequerido(lblNombreNecesario);
        }

        private void lblPrecioNecesario_MouseHover(object sender, EventArgs e)
        {
            campoRequerido(lblPrecioNecesario);
        }

        private void lblCodigoError_Click(object sender, EventArgs e)
        {

        }

       
    }
}
