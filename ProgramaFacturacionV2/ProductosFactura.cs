using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaFacturacionV2
{
    class ProductosFactura
    {
        public int idFactur;
        public int idProduct;
        public string nombreProduct;
        public int val;
        public int canti;
        public int valorTotalUnidad;
        public int valorTotal;

        public int IdFactur { get => idFactur; set => idFactur = value; }
        public int IdProduct { get => idProduct; set => idProduct = value; }
        public string NombreProduct { get => nombreProduct; set => nombreProduct = value; }
        public int Val { get => val; set => val = value; }
        public int Canti { get => canti; set => canti = value; }
        public int ValorTotalUnidad { get => valorTotalUnidad; set => valorTotalUnidad = value; }
        public int ValorTotal { get => valorTotal; set => valorTotal = value; }
    }
}
