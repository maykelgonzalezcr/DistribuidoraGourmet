using CapaAccesoDatos;
using CapaLogicaNegocios;
namespace CapaPresentacion
{
    public partial class FrmMenuPrincipal : Form
    {
        private IngredienteAD _ingredienteAD;
        private IngredienteLN _ingredienteLN;
        private ProductoAD _productoAD;
        private ProductoLN _productoLN;
        private RecetaProductoAD _recetaProductoAD;
        private RecetaProductoLN _recetaProductoLN;
        private ProduccionAD _produccionAD;
        private ProduccionLN _produccionLN;

        private ClienteAD _clienteAD;
        private ClienteLN _clienteLN;

        private CajeroAD _cajeroAD;
        private CajeroLN _cajeroLN;

        private VentaAD _ventaAD;
        private VentaLN _ventaLN;


        public FrmMenuPrincipal()
        {
            InitializeComponent();

            _ingredienteAD = new IngredienteAD();
            _ingredienteLN = new IngredienteLN(_ingredienteAD);

            _productoAD = new();
            _productoLN = new(_productoAD);

            _recetaProductoAD = new();
            _recetaProductoLN = new(
                _recetaProductoAD,
                _productoAD,
                _ingredienteAD
            );

            _produccionAD = new();
            _produccionLN = new(
                _produccionAD,
                _productoAD,
                _recetaProductoAD,
                _ingredienteAD
            );

            _clienteAD = new();
            _clienteLN = new(_clienteAD);

            _cajeroAD = new();
            _cajeroLN = new(_cajeroAD);

            _ventaAD = new();
            _ventaLN = new(
                _ventaAD,
                _clienteAD,
                _cajeroAD,
                _produccionAD
            );
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
    }
}
