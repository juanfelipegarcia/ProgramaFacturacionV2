using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaFacturacionV2
{
    class Cliente
    {
        public int documento;
        public string nombreCliente;
        public int telefono;
        public int edad;
        public int estado = 1;

        public Cliente()
        {

        }


        public Cliente(int documento, string nombreCliente, int telefono, int edad, int estado)
        {
            this.documento = documento;
            this.nombreCliente = nombreCliente;
            this.telefono = telefono;
            this.edad = edad;
            this.estado = estado;

        }

        public int Documento { get => documento; set => documento = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}
