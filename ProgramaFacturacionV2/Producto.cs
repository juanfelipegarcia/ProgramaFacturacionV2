﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaFacturacionV2
{
    class Producto
    {
        public int idProducto;
        public string nombreProducto;
        public int stock;
        public int valor;
        public int estadoProducto = 1;
        public int cantidad;

        public Producto()
        { 
        }


        public Producto(int idProducto, string nombreProducto,  int valor, int stock, int estadoProducto)
        {
            this.idProducto = idProducto;
            this.nombreProducto = nombreProducto;
            this.stock = stock;
            this.valor = valor;
            this.estadoProducto = estadoProducto;
            
        }

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public int Stock { get => stock; set => stock = value; }
        public int Valor { get => valor; set => valor = value; }
        public int EstadoProducto { get => estadoProducto; set => estadoProducto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}
