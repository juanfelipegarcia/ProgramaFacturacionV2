using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaFacturacionV2
{
    class Factura
    {
        public int idFactura;
        public int idCliente;
        public string fecha;
        public int numeroProductos;
        public double totalFactura = 0;
        public List<Cliente> listaClientes = new List<Cliente>();
        public List<Producto> listaProductos = new List<Producto>();

        public int IdFactura { get => idFactura; set => idFactura = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int NumeroProductos { get => numeroProductos; set => numeroProductos = value; }
    }
}
