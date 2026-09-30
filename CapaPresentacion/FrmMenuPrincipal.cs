using CapaLogicaNegocios;
namespace CapaPresentacion
{
    public partial class FrmMenuPrincipal : Form
    {
        private IngredienteLN _ingredienteLN;
        private ProductoLN _productoLN;
        private RecetaProductoLN _recetaProductoLN;
        private ProduccionLN _produccionLN;

        private ClienteLN _clienteLN;

        private CajeroLN _cajeroLN;

        private VentaLN _ventaLN;


        public FrmMenuPrincipal()
        {
            InitializeComponent();

            _ingredienteLN = new IngredienteLN();
            _productoLN = new ProductoLN();
            _recetaProductoLN = new RecetaProductoLN();
            _produccionLN = new ProduccionLN();

            _clienteLN = new ClienteLN();

            _cajeroLN = new CajeroLN();

            _ventaLN = new VentaLN();
        }
        private void btnIngredientes_Click(object sender, EventArgs e)
        {
            FrmIngrediente frmIngrediente = new FrmIngrediente(_ingredienteLN);
            frmIngrediente.Show();

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmProducto frmProducto = new FrmProducto(_productoLN);
            frmProducto.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente(_clienteLN);
            frmCliente.Show();
        }

        private void btnCajeros_Click(object sender, EventArgs e)
        {
            FrmCajero frmCajero = new FrmCajero(_cajeroLN);
            frmCajero.Show();
        }

        private void btnRecetas_Click(object sender, EventArgs e)
        {
            FrmRecetaProducto frmRecetaProducto = new FrmRecetaProducto(_recetaProductoLN);
            frmRecetaProducto.Show();
        }

        private void btnProduccion_Click(object sender, EventArgs e)
        {
            FrmProduccion frmProduccion = new FrmProduccion(_produccionLN);
            frmProduccion.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FrmVenta frmVenta = new FrmVenta(_ventaLN);
            frmVenta.Show();
        }
    }
}
