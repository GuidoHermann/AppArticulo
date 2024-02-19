using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace presentacion
{
    public partial class frmArticulo : Form
    {
        private List<Articulo> listaArticulo;
        private Articulo articulo;
        

        
        public frmArticulo()
        {
            InitializeComponent();
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulo = negocio.listar();
                dgvArticulo.DataSource = listaArticulo;
                ocultarColumnas();
                cargarImagen(listaArticulo[0].Imagen);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
            cboCampo.Items.Add("Codigo");
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Descripcion");
            cboCampo.Items.Add("Precio");
            dgvArticulo.Columns[1].Visible = false;
            dgvArticulo.Columns[3].Visible = false;
            dgvArticulo.Columns["Precio"].DefaultCellStyle.Format = "N2";
            

        }

        private void ocultarColumnas()
        {
            dgvArticulo.Columns["IdArticulo"].Visible = false;
            dgvArticulo.Columns["Imagen"].Visible = false;
        }

        private void dgvArticulo_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvArticulo.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.Imagen);
            }
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {

                pbxArticulo.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/6/65/No-Image-Placeholder.svg/1665px-No-Image-Placeholder.svg.png");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo nuevaVentana = new frmAltaArticulo();
            nuevaVentana.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(dgvArticulo.CurrentRow != null)
            {
                Articulo seleccionado;
                seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
                frmAltaArticulo modificar = new frmAltaArticulo(seleccionado, "Modificar Articulo");
                modificar.ShowDialog();
                cargar();
            }
            else
            {
                MessageBox.Show("No hay ningun articulo seleccionado para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                                  
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
            try
            {
                if(dgvArticulo.CurrentRow != null)
                {
                    ArticuloNegocio negocio = new ArticuloNegocio();
                    Articulo seleccionado;
                    DialogResult respuesta = MessageBox.Show("El articulo seleccionado sera eliminado PERMANENTEMENTE ¿Continuar?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
                        negocio.eliminar(seleccionado.IdArticulo);

                        cargar();
                    }
                }
                else
                {
                    MessageBox.Show("No hay ningún artículo seleccionado para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltro;
            string filtro = txtFiltroRapido.Text;

            if(filtro.Length >= 2)
            {
                listaFiltro = listaArticulo.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()));

            }
            else
            {
                listaFiltro = listaArticulo;
            }
            dgvArticulo.DataSource = null;
            dgvArticulo.DataSource = listaFiltro;
            ocultarColumnas();
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();


            try
            {
                if (opcion == "Codigo" || opcion == "Nombre" || opcion == "Descripcion")
                {
                 
                    cboCriterio.DataSource = null;
                    cboCriterio.Items.Clear();
                    cboCriterio.Items.Add("Comienza con");
                    cboCriterio.Items.Add("Termina con");
                    cboCriterio.Items.Add("Contiene");
                }
                else if (opcion == "Precio")
                {                
                    cboCriterio.DataSource = null;
                    cboCriterio.Items.Clear();
                    cboCriterio.Items.Add("Mayor a");
                    cboCriterio.Items.Add("Menor a");
                    cboCriterio.Items.Add("Igual a");
                }
                
                               

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btnBuscarAvanzado_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (validarFiltro())
                    return;

                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;
                dgvArticulo.DataSource = negocio.filtrar(campo, criterio, filtro);
                lblFiltroAvanzadoError.Text = "Busqueda realizada correctamente";
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void txtFiltroAvanzado_Enter(object sender, EventArgs e)
        {
           
        }

        private bool validarDecimal(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                return false;
            if (decimal.TryParse(texto, out decimal resultado))
                if (resultado >= 0)
                    return true;
            return false;
        }

        private bool validarFiltro()
        {
            lblFiltroAvanzadoError.Text = "";
            if(cboCampo.SelectedIndex < 0)
            {
               
                lblFiltroAvanzadoError.Text = "Debes seleccionar el campo para filtrar";
                return true;
            }
            if(cboCriterio.SelectedIndex < 0)
            {
                lblFiltroAvanzadoError.Text = "Debes seleccionar el criterio para filtrar";
                return true;
            }
            if(cboCampo.SelectedItem.ToString() == "Precio")
            {
                if (!(validarDecimal(txtFiltroAvanzado.Text)))
                {
                    lblFiltroAvanzadoError.Text = "Debes ingresar un precio valido para filtrar";
                    return true;
                }
            }
            



            return false;
        }

        private void btnVerArticulo_Click(object sender, EventArgs e)
        {
            if (dgvArticulo.CurrentRow != null)
            {
                Articulo seleccionado;
                seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
                frmAltaArticulo verArticulo = new frmAltaArticulo(seleccionado, "Ver Articulo");

                verArticulo.ShowDialog();
                

                cargar();
            }
            else
            {
                MessageBox.Show("No hay ningun articulo seleccionado para inspeccionar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtFiltroAvanzado_TextChanged(object sender, EventArgs e)
        {
            if(txtFiltroAvanzado.Text.Length > 9)
            {
                lblFiltroAvanzadoError.Text = "";
                lblFiltroAvanzadoError.Text = "Maximo 10 caracteres para filtrar";
            }
        }

        
    }


    
}
