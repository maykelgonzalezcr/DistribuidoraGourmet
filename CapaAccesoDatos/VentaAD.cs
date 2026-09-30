using CapaEntidad;

namespace CapaAccesoDatos
{
    public class VentaAD
    {
        private static Venta[] ventas = new Venta[200];
        private static int contador = 0;

        public bool Agregar(Venta venta)
        {
            if (contador >= ventas.Length)
            {
                return false;
            }

            ventas[contador] = venta;
            contador++;

            return true;
        }

        public Venta[] Listar()
        {
            Venta[] lista = new Venta[contador];

            for (int i = 0; i < contador; i++)
            {
                lista[i] = ventas[i];
            }

            return lista;
        }

        public Venta? BuscarPorID(int id)
        {
            for (int i = 0; i < contador; i++)
            {
                if (ventas[i].IdVenta == id)
                {
                    return ventas[i];
                }
            }

            return null;
        }
    }
}