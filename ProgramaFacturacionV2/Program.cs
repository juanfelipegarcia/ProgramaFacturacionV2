using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaFacturacionV2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> listaClientes = new List<Cliente>();

         
            listaClientes.Add(new Cliente(1,"Luisa", 1234444, 21, 1));
            listaClientes.Add(new Cliente(2, "Carolina", 3215555, 25, 1));
            listaClientes.Add(new Cliente(3, "Olmeiro", 4562222, 30, 1));
            listaClientes.Add(new Cliente(4, "Giver", 6784444, 20, 1));
            listaClientes.Add(new Cliente(5, "Juan", 9872222, 40, 1));
            listaClientes.Add(new Cliente(6, "Pedro", 2225555, 50, 1));


            List<Factura> listaFacturas = new List<Factura>();
                                 
            List<Producto> listaProductos = new List<Producto>();


            listaProductos.Add(new Producto(1, "Arroz", 1970, 20, 1));
            listaProductos.Add(new Producto(2, "Leche", 2000, 50, 1));
            listaProductos.Add(new Producto(3, "Lenteja", 2200, 100, 1));
            listaProductos.Add(new Producto(4, "Frijol", 3250, 70, 1));
            listaProductos.Add(new Producto(5, "Aceite", 4000, 50, 1));
            listaProductos.Add(new Producto(6, "Papa", 2300, 40, 1));

            


            int idFactura;
            string fecha;
            int doc;
            string datoModificar;
            int numeroProductos = 0;


            int respuestaInicio = 0;
            int respuestaCliente = 0;
            int respuestaProducto = 0;
            bool resp = true;
           



          

            while (respuestaInicio != 5)
            {
                Console.Clear();
                Console.WriteLine(" _________________________________________");
                Console.WriteLine("|                                         |");
                Console.WriteLine("|      KREMO SISTEMA DE FACTURACION       |");
                Console.WriteLine("|       ELija el Modulo a ingresar        |");
                Console.WriteLine("|_________________________________________|");
                Console.WriteLine("|                                         |");
                Console.WriteLine("|          *ELIJA UNA OPCION*             |");
                Console.WriteLine("|                                         |");
                Console.WriteLine("| (1) Gestion de Clientes                 |");
                Console.WriteLine("| (2) Gestion de Productos                |");
                Console.WriteLine("| (3) Facturacion                         |");
                Console.WriteLine("| (4) Gestion de Reportes                 |");
                Console.WriteLine("| (5) Salir                               |");
                Console.WriteLine("|_________________________________________|");
                respuestaInicio = int.Parse(Console.ReadLine());
                Console.Clear();

                if (respuestaInicio == 1)
                {
                    resp = true;
                    while (resp != false)

                    {

                        Console.WriteLine(" _________________________________________");
                        Console.WriteLine("|                                         |");
                        Console.WriteLine("|      KREMO SISTEMA DE FACTURACION       |");
                        Console.WriteLine("|           GESTION DE CLIENTES           |");
                        Console.WriteLine("|_________________________________________|");
                        Console.WriteLine("|                                         |");
                        Console.WriteLine("| (1) Agregar Cliente                     |");
                        Console.WriteLine("| (2) Modificar Cliente                   |");
                        Console.WriteLine("| (3) Cambiar Estado del Cliente          |");
                        Console.WriteLine("| (4) Listar clientes                     |");
                        Console.WriteLine("| (5) salir del modulo clientes           |");
                        Console.WriteLine("|_________________________________________|");


                        respuestaCliente = int.Parse(Console.ReadLine());
                        Console.Clear();

                        if (respuestaCliente == 1)
                        {
                            //TODO: agregar cliente
                            Cliente cliente = new Cliente();
                            Console.Clear();
                            Console.WriteLine(" _________________________________________");
                            Console.WriteLine("|                                         |");
                            Console.WriteLine("|    Ingrese el documento del cliente     |");
                            Console.WriteLine("|_________________________________________|");
                            //Console.WriteLine("Ingrese el documento del cliente");
                            cliente.documento = int.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine(" _________________________________________");
                            Console.WriteLine("|                                         |");
                            Console.WriteLine("|      Ingrese el nombre del cliente      |");
                            Console.WriteLine("|_________________________________________|");
                            //Console.WriteLine("Ingrese el nombre del cliente");
                            cliente.nombreCliente = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine(" _________________________________________");
                            Console.WriteLine("|                                         |");
                            Console.WriteLine("|          Ingrese el telefono            |");
                            Console.WriteLine("|_________________________________________|");
                            //Console.WriteLine("Ingrese el telefono");
                            cliente.telefono = int.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine(" _________________________________________");
                            Console.WriteLine("|                                         |");
                            Console.WriteLine("|        Ingrese la edad del cliente      |");
                            Console.WriteLine("|_________________________________________|");
                            //Console.WriteLine("Ingrese la edad del cliente");
                            cliente.edad = int.Parse(Console.ReadLine());


                            listaClientes.Add(cliente);



                        }
                        else if (respuestaCliente == 2)
                        {//TODO: modificar cliente
                            Console.Clear();
                            Console.WriteLine(" _________________________________________");
                            Console.WriteLine("|                                         |");
                            Console.WriteLine("|      Digite el documento del cliente    |");
                            Console.WriteLine("|                a modificar              |");
                            Console.WriteLine("|_________________________________________|");
                            //Console.WriteLine("Digite el documento del cliente a modificar");
                            doc = int.Parse(Console.ReadLine());

                            for (int i = 0; i < listaClientes.Count; i++)
                            {
                                if (doc == listaClientes[i].documento && listaClientes[i].estado == 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine(" _________________________________________");
                                    Console.WriteLine("|                                         |");
                                    Console.WriteLine("|             Desea modificar:            |");
                                    Console.WriteLine("|         nombre, edad o telefono         |");
                                    Console.WriteLine("|_________________________________________|");
                                    //Console.WriteLine("Desea modificar: nombre, edad o telefono");
                                    datoModificar = Console.ReadLine();
                                    switch (datoModificar)
                                    {
                                        case "nombre":
                                            Console.Clear();
                                            Console.WriteLine(" _________________________________________");
                                            Console.WriteLine("|                                         |");
                                            Console.WriteLine("|          Ingrese el nuevo nombre        |");
                                            Console.WriteLine("|_________________________________________|");
                                            //Console.WriteLine("Ingrese el nuevo nombre");
                                            string nomCliente = Console.ReadLine();
                                            listaClientes[i].nombreCliente = nomCliente;
                                            break;
                                        case "edad":
                                            Console.Clear();
                                            Console.WriteLine(" _________________________________________");
                                            Console.WriteLine("|                                         |");
                                            Console.WriteLine("|          Ingrese la nueva edad          |");
                                            Console.WriteLine("|_________________________________________|");
                                            //Console.WriteLine("Ingrese la nueva edad");
                                            int edadCliente = int.Parse(Console.ReadLine());
                                            listaClientes[i].edad = edadCliente;
                                            break;
                                        case "telefono":
                                            Console.Clear();
                                            Console.WriteLine(" _________________________________________");
                                            Console.WriteLine("|                                         |");
                                            Console.WriteLine("|        Ingrese el nuevo telefono        |");
                                            Console.WriteLine("|_________________________________________|");
                                            //Console.WriteLine("Ingrese el nuevo telefono");
                                            int telCliente = int.Parse(Console.ReadLine());
                                            listaClientes[i].telefono = telCliente;
                                            break;
                                    }
                                }
                            }
                        }
                        else if (respuestaCliente == 3)
                        {
                            //TODO: cambiar estado cliente
                            Console.Clear();
                            Console.WriteLine(" _________________________________________");
                            Console.WriteLine("|                                         |");
                            Console.WriteLine("|     Digite el documento del cliente     |");
                            Console.WriteLine("|          a modificar el estado          |");
                            Console.WriteLine("|_________________________________________|");
                            //Console.WriteLine("Digite el documento del cliente a modificar el estado");
                            doc = int.Parse(Console.ReadLine());
                            for (int i = 0; i < listaClientes.Count; i++)
                            {


                                if (doc == listaClientes[i].documento)
                                {
                                    Console.Clear();
                                    Console.WriteLine(" _________________________________________");
                                    Console.WriteLine("|                                         |");
                                    Console.WriteLine("|            Estado modificar:            |");
                                    Console.WriteLine("|                                         |");
                                    Console.WriteLine("| (0) para deshabilitar                   |");
                                    Console.WriteLine("| (1) para habilitar                      |");
                                    Console.WriteLine("|_________________________________________|");
                                    //Console.WriteLine("Estado modificar: (1) para habilitar o (0) para deshabilitar");
                                    int estadoModificar = int.Parse(Console.ReadLine());
                                    switch (estadoModificar)
                                    {
                                        case 1:
                                            listaClientes[i].estado = estadoModificar;
                                            break;
                                        case 0:

                                            listaClientes[i].estado = estadoModificar;
                                            break;

                                    }
                                }
                            }

                        }
                        else if (respuestaCliente == 4)
                        {
                            //TODO: listar clientes

                            int rtaListar;

                            Console.WriteLine(" _________________________________________");
                            Console.WriteLine("|                                         |");
                            Console.WriteLine("|          Listar Cliente por :           |");
                            Console.WriteLine("|                                         |");
                            Console.WriteLine("| (1) listar clientes por documento       |");
                            Console.WriteLine("| (2) listar todos los clientes           |");
                            Console.WriteLine("|_________________________________________|");
                            //Console.WriteLine("(1) listar clientes por documento (2) listar todos los clientes.");
                            rtaListar = int.Parse(Console.ReadLine());
                            Console.Clear();

                            if (rtaListar == 1)
                            {
                                //listar por documento

                                Console.WriteLine(" _________________________________________");
                                Console.WriteLine("|                                         |");
                                Console.WriteLine("|     Ingrese el numero del documento     |");
                                Console.WriteLine("|_________________________________________|");
                                //Console.WriteLine("Ingrese el numero del documento");
                                doc = int.Parse(Console.ReadLine());

                                foreach (var client in listaClientes)
                                {
                                    if (client.documento == doc)
                                    {

                                        Console.WriteLine(" _________________________________________");
                                        Console.WriteLine("|                                         |");
                                        Console.WriteLine("| Nombre: " + client.NombreCliente);
                                        Console.WriteLine("| Documento: " + client.Documento);
                                        Console.WriteLine("| Telefono: " + client.Telefono);
                                        Console.WriteLine("| Edad: " + client.Edad);
                                        Console.WriteLine("| Estado: " + client.Estado);
                                        Console.WriteLine("|_________________________________________|");
                                        // Console.WriteLine("nombre: " + client.NombreCliente
                                        //+ " documento: " + client.Documento
                                        //+ " telefono: " + client.Telefono
                                        //+ " edad: " + client.Edad
                                        //+ " estado: " + client.Estado);
                                    }
                                }
                            }
                            else if (rtaListar == 2)
                            {
                                //listar todos los clientes

                                foreach (Cliente client in listaClientes)
                                {

                                    Console.WriteLine(" _________________________________________");
                                    Console.WriteLine("|                                         |");
                                    Console.WriteLine("| Nombre: " + client.NombreCliente);
                                    Console.WriteLine("| Documento: " + client.Documento);
                                    Console.WriteLine("| Telefono: " + client.Telefono);
                                    Console.WriteLine("| Edad: " + client.Edad);
                                    Console.WriteLine("| Estado: " + client.Estado);
                                    Console.WriteLine("|_________________________________________|");
                                    //Console.WriteLine("nombre: " + client.NombreCliente
                                    //        + " documento: " + client.Documento
                                    //        + " telefono: " + client.Telefono
                                    //        + " edad: " + client.Edad
                                    //        + " estado: " + client.Estado);
                                }

                            }
                        }
                        else if (respuestaCliente == 5)

                        {
                            resp = false;
                        }

                    }
                }
                else if (respuestaInicio == 2)
                {
                    resp = true;
                    while (resp != false)

                    {

                        Console.WriteLine(" _________________________________________");
                        Console.WriteLine("|                                         |");
                        Console.WriteLine("|      KREMO SISTEMA DE FACTURACION       |");
                        Console.WriteLine("|           GESTION DE PRODUCTOS          |");
                        Console.WriteLine("|_________________________________________|");
                        Console.WriteLine("|                                         |");
                        Console.WriteLine("| (1) Agregar Producto                    |");
                        Console.WriteLine("| (2) Modificar Estado de Producto        |");
                        Console.WriteLine("| (3) Modificar Producto                  |");
                        Console.WriteLine("| (4) Listar Productom                    |");
                        Console.WriteLine("| (5) Para salir de Gestion Productos     |");
                        Console.WriteLine("|_________________________________________|");

                        respuestaProducto = int.Parse(Console.ReadLine());
                        Console.Clear();

                        if (respuestaProducto == 1)
                        {

                            //Agregar producto
                            Producto producto = new Producto();
                            Console.WriteLine(" _________________________________________");
                            Console.WriteLine("|                                         |");
                            Console.WriteLine("|      Ingrese el codigo del producto     |");
                            Console.WriteLine("|_________________________________________|");
                            //Console.WriteLine("Ingrese el codigo del producto");
                            producto.idProducto = int.Parse(Console.ReadLine());
                            Console.WriteLine(" _________________________________________");
                            Console.WriteLine("|                                         |");
                            Console.WriteLine("|      Ingrese el nombre del producto     |");
                            Console.WriteLine("|_________________________________________|");
                            //Console.WriteLine("Ingrese el nombre del producto");
                            producto.nombreProducto = Console.ReadLine();
                            Console.WriteLine(" _________________________________________");
                            Console.WriteLine("|                                         |");
                            Console.WriteLine("|      Ingrese el valor del producto      |");
                            Console.WriteLine("|_________________________________________|");
                            //Console.WriteLine("Ingrese el valor del producto");
                            producto.valor = int.Parse(Console.ReadLine());
                            Console.WriteLine(" _________________________________________");
                            Console.WriteLine("|                                         |");
                            Console.WriteLine("|       Ingrese el stock del producto     |");
                            Console.WriteLine("|_________________________________________|");
                            //Console.WriteLine("Ingrese el stock del producto");
                            producto.stock = int.Parse(Console.ReadLine());

                            listaProductos.Add(producto);
                        }

                        else if (respuestaProducto == 2)
                        {
                            //Modificar estado producto
                            Console.WriteLine(" _________________________________________");
                            Console.WriteLine("|                                         |");
                            Console.WriteLine("|      Ingrese el codigo del producto     |");
                            Console.WriteLine("|           a cambiar de estado           |");
                            Console.WriteLine("|_________________________________________|");
                            //Console.WriteLine("Ingrese el codigo del producto a cambiar de estado");
                            int codModificar = int.Parse(Console.ReadLine());

                            for (int i = 0; i < listaProductos.Count; i++)
                            {
                                if (codModificar == listaProductos[i].idProducto)
                                {
                                    Console.WriteLine(" _________________________________________");
                                    Console.WriteLine("|                                         |");
                                    Console.WriteLine("|            Estado modificar:            |");
                                    Console.WriteLine("|                                         |");
                                    Console.WriteLine("| (0) para deshabilitar                   |");
                                    Console.WriteLine("| (1) para habilitar                      |");
                                    Console.WriteLine("|_________________________________________|");
                                    //Console.WriteLine("(0) para deshabilitar producto, (1) para habilitar");
                                    int cambEstadoP = int.Parse(Console.ReadLine());
                                    switch (cambEstadoP)
                                    {
                                        case 1:
                                            listaProductos[i].estadoProducto = cambEstadoP;
                                            break;
                                        case 0:
                                            listaProductos[i].estadoProducto = cambEstadoP;
                                            break;
                                    }
                                }
                            }
                        }
                        else if (respuestaProducto == 3)
                        {
                            //Modificar producto
                            Console.Clear();
                            Console.WriteLine(" _________________________________________");
                            Console.WriteLine("|                                         |");
                            Console.WriteLine("|      Digite el codigo del producto      |");
                            Console.WriteLine("|                a modificar              |");
                            Console.WriteLine("|_________________________________________|");
                            //Console.WriteLine("Digite el codigo del producto a modificar");
                            doc = int.Parse(Console.ReadLine());

                            for (int i = 0; i < listaProductos.Count; i++)
                            {
                                if (doc == listaProductos[i].IdProducto)
                                {
                                    Console.Clear();
                                    Console.WriteLine(" _________________________________________");
                                    Console.WriteLine("|                                         |");
                                    Console.WriteLine("|             Desea modificar:            |");
                                    Console.WriteLine("|          nombre, precio o stock         |");
                                    Console.WriteLine("|_________________________________________|");
                                    //Console.WriteLine("Desea modificar: nombre, precio o stock");
                                    datoModificar = Console.ReadLine();
                                    switch (datoModificar)
                                    {
                                        case "nombre":
                                            Console.Clear();
                                            Console.WriteLine(" _________________________________________");
                                            Console.WriteLine("|                                         |");
                                            Console.WriteLine("|  Ingrese el nuevo nombre del producto   |");
                                            Console.WriteLine("|_________________________________________|");
                                            //Console.WriteLine("Ingrese el nuevo nombre del producto");
                                            string nomProducto = Console.ReadLine();
                                            listaProductos[i].nombreProducto = nomProducto;
                                            break;
                                        case "precio":
                                            Console.Clear();
                                            Console.WriteLine(" _________________________________________");
                                            Console.WriteLine("|                                         |");
                                            Console.WriteLine("|         Ingrese la nuevo precio         |");
                                            Console.WriteLine("|_________________________________________|");
                                            //Console.WriteLine("Ingrese la nuevo precio");
                                            int precioProducto = int.Parse(Console.ReadLine());
                                            listaProductos[i].valor = precioProducto;
                                            break;
                                        case "stock":
                                            Console.Clear();
                                            Console.WriteLine(" _________________________________________");
                                            Console.WriteLine("|                                         |");
                                            Console.WriteLine("|          Ingrese el nuevo stock         |");
                                            Console.WriteLine("|_________________________________________|");
                                            //Console.WriteLine("Ingrese el nuevo stock");
                                            int stockproduct = int.Parse(Console.ReadLine());
                                            listaProductos[i].stock = stockproduct;
                                            break;
                                    }
                                }
                            }

                        }
                        else if (respuestaProducto == 4)
                        {
                            //Listar producto

                            int rtaListar;

                            Console.WriteLine(" _________________________________________");
                            Console.WriteLine("|                                         |");
                            Console.WriteLine("|          Listar Producto por :          |");
                            Console.WriteLine("|                                         |");
                            Console.WriteLine("| (1) listar producto por Id              |");
                            Console.WriteLine("| (2) listar todos los productos          |");
                            Console.WriteLine("|_________________________________________|");
                            //Console.WriteLine("(1) listar producto por id (2) listar todos los productos.");
                            rtaListar = int.Parse(Console.ReadLine());

                            if (rtaListar == 1)
                            {
                                //listar por id producto
                                Console.Clear();
                                Console.WriteLine(" _________________________________________");
                                Console.WriteLine("|                                         |");
                                Console.WriteLine("|        Ingrese el numero del id         |");
                                Console.WriteLine("|_________________________________________|");
                                //Console.WriteLine("Ingrese el numero del id");
                                doc = int.Parse(Console.ReadLine());

                                foreach (var product in listaProductos)
                                {
                                    if (product.idProducto == doc)
                                    {
                                        Console.Clear();
                                        Console.WriteLine(" _________________________________________");
                                        Console.WriteLine("|                                         |");
                                        Console.WriteLine("| Codigo producto: " + product.IdProducto);
                                        Console.WriteLine("| Nombre: " + product.NombreProducto);
                                        Console.WriteLine("| Valor: " + product.Valor);
                                        Console.WriteLine("| Stock: " + product.Stock);
                                        Console.WriteLine("| Eestado: " + product.EstadoProducto);
                                        Console.WriteLine("|_________________________________________|");
                                        // Console.WriteLine("codigo producto: " + product.IdProducto
                                        //+ " nombre: " + product.NombreProducto
                                        //+ " valor: " + product.Valor
                                        //+ " stock: " + product.Stock
                                        //+ " estado: " + product.EstadoProducto);
                                    }
                                }
                            }
                            else if (rtaListar == 2)
                            {
                                //listar todos los productos

                                foreach (Producto product in listaProductos)
                                {

                                    Console.WriteLine(" _________________________________________");
                                    Console.WriteLine("|                                         |");
                                    Console.WriteLine("| Codigo producto: " + product.IdProducto);
                                    Console.WriteLine("| Nombre: " + product.NombreProducto);
                                    Console.WriteLine("| Valor: " + product.Valor);
                                    Console.WriteLine("| Stock: " + product.Stock);
                                    Console.WriteLine("| Eestado: " + product.EstadoProducto);
                                    Console.WriteLine("|_________________________________________|");
                                    //Console.WriteLine("codigo producto: " + product.IdProducto
                                    //   + " nombre: " + product.NombreProducto
                                    //   + " valor: " + product.Valor
                                    //   + " stock: " + product.Stock
                                    //   + " estado: " + product.EstadoProducto);
                                }

                            }
                        }
                        else if (respuestaProducto == 5)

                        {
                            resp = false;
                        }

                    }

                }
                else if (respuestaInicio == 3)
                {

                    resp = true;
                    while (resp != false)

                    {
                        //facturar

                        int rtaFacturar;
                      
                        Console.WriteLine(" _________________________________________");
                        Console.WriteLine("|                                         |");
                        Console.WriteLine("|      KREMO SISTEMA DE FACTURACION       |");
                        Console.WriteLine("|           GESTION DE FACTURAS           |");
                        Console.WriteLine("|_________________________________________|");
                        Console.WriteLine("|                                         |");
                        Console.WriteLine("| (1) Agregar Factura                     |");
                        Console.WriteLine("| (2) listar todas las facturas           |");
                        Console.WriteLine("| (3) Salir de Facturacion                |");
                        Console.WriteLine("|_________________________________________|");
                        //////Console.WriteLine("(1) Agregar Factura (2) listar todas las facturas");
                        rtaFacturar = int.Parse(Console.ReadLine());

                        //idFactura = listaFacturas.Count + 1;

                        if (rtaFacturar == 1)
                        {
                            

                            //Agregar factura
                            Factura factura = new Factura();
                            Console.Clear();
                            Console.WriteLine(" _________________________________________");
                            Console.WriteLine("|                                         |");
                            Console.WriteLine("|         Ingrese la Fecha factura:       |");
                            Console.WriteLine("|_________________________________________|");
                            fecha = Console.ReadLine();
                            idFactura = listaFacturas.Count + 1;
                            

                            Console.Clear();
                            Console.WriteLine(" _________________________________________");
                            Console.WriteLine("|                                         |");
                            Console.WriteLine("|    Ingrese el documento del cliente     |");
                            Console.WriteLine("|_________________________________________|");
                            //Console.WriteLine("Ingrese el documento del cliente");
                            int idCliente = int.Parse(Console.ReadLine());

                            //factura.idFactura = idFactura;
                            //factura.fecha = fecha;
                            //factura.IdCliente = idCliente;


                            for (int i = 0; i < listaClientes.Count; i++)
                            {
                                if (idCliente == listaClientes[i].documento)
                                {

                                    foreach (Cliente client in listaClientes)
                                    {
                                        //Console.WriteLine("nombre: " + client.NombreCliente
                                        //  + " documento: " + client.Documento
                                        //  + " telefono: " + client.Telefono
                                        //  + " edad: " + client.Edad
                                        //  + " estado: " + client.Estado);
                                        //listaFacturas.Add(factura);
                                    }

                                }
                            }
                            resp = true;

                            while (resp)
                            {
                                
                                Console.Clear();
                                Console.WriteLine(" _________________________________________");
                                Console.WriteLine("|                                         |");
                                Console.WriteLine("| Ingrese el codigo del producto comprado |");
                                Console.WriteLine("|_________________________________________|");
                                int CodProd = int.Parse(Console.ReadLine());

                              

                                for (int i = 0; i < listaProductos.Count; i++)
                                {
                                    if (CodProd == listaProductos[i].idProducto)
                                    {
                                        numeroProductos = i + 1;

                                        foreach (var produc in listaProductos)
                                        {
                                            //Console.WriteLine("------------Productos Comprados--------");
                                            //Console.WriteLine("Codigo Producto " + produc.IdProducto
                                            //    + " Nombre Producto " + produc.NombreProducto
                                            //    + " Valor Producto " + produc.Valor);
                                            //listaFacturas.Add(factura);
                                        }
                                        

                                    }
                                    
                                }
                                Console.WriteLine("¿Desea seguir ingresando productos?");
                                if (Console.ReadLine().Equals("no"))
                                {
                                    resp = false;
                                }

                                factura.NumeroProductos = numeroProductos;

                            }
                            factura.idFactura = idFactura;
                            factura.fecha = fecha;
                            factura.IdCliente = idCliente;
                            




                            listaFacturas.Add(factura);

                        }
                        else if (rtaFacturar == 2)
                        {
                            //listar todas las facturas
                            Console.Clear();
                            Console.WriteLine(" _________________________________________");
                            Console.WriteLine("|                                         |");
                            Console.WriteLine("|          Listar Factura por :           |");
                            Console.WriteLine("|                                         |");
                            Console.WriteLine("| (1) listar por codigo factura           |");
                            Console.WriteLine("| (2) todas las facturas                  |");
                            Console.WriteLine("|_________________________________________|");
                            //Console.WriteLine("(1) para listar por codigo factura (2) todas las facturas");
                            int rta = int.Parse(Console.ReadLine());
                            if (rta == 1)
                            {
                                
                                Console.WriteLine(" _________________________________________");
                                Console.WriteLine("|                                         |");
                                Console.WriteLine("|    Ingrese el numero de la factura      |");
                                Console.WriteLine("|_________________________________________|");
                                //Console.WriteLine("Ingrese el numero de la factura");
                                doc = int.Parse(Console.ReadLine());

                                foreach (var fact in listaFacturas)
                                {
                                    if (fact.idFactura == doc)
                                    {
                                        
                                        Console.WriteLine(" _________________________________________");
                                        Console.WriteLine("|                                         |");
                                        Console.WriteLine("| número factura: " + fact.idFactura);
                                        Console.WriteLine("| Fecha : " + fact.fecha);
                                        Console.WriteLine("| Referencias compradas : " + fact.numeroProductos);
                                        Console.WriteLine("|                                         |");
                                        Console.WriteLine("|                                         |");
                                        Console.WriteLine("|_________________________________________|");
                                        // Console.WriteLine("número factura: " + fact.idFactura
                                        //+ " Fecha : " + fact.fecha
                                        //+ " Cliente : " + fact.listaClientes);





                                    }
                                }

                            }

                            else if (rta == 2)
                            {
                                //listar todos los productos

                                foreach (var fact in listaFacturas)
                                {
                                    Console.WriteLine(" _________________________________________");
                                    Console.WriteLine("|                                         |");
                                    Console.WriteLine("| número factura: " + fact.idFactura);
                                    Console.WriteLine("| Fecha : " + fact.fecha);
                                    Console.WriteLine("| Referencias compradas : " + fact.numeroProductos);
                                    Console.WriteLine("|                                         |");
                                    Console.WriteLine("|                                         |");
                                    Console.WriteLine("|_________________________________________|");
                                    //Console.WriteLine("número factura: " + fact.idFactura
                                    //   + " Fecha : " + fact.fecha
                                    //   + " Cliente : " + fact.listaClientes);
                                }



                            }

                        }

                        else if (rtaFacturar == 3)

                        {
                            resp = false;
                        }




                    }
                }
                else if (respuestaInicio == 4)
                {
                    //resp = true;
                    //while (resp != false)


                    //reportes
                    int rtaReportes;
                    Console.Clear();
                    Console.WriteLine(" _________________________________________");
                    Console.WriteLine("|                                         |");
                    Console.WriteLine("|      KREMO SISTEMA DE FACTURACION       |");
                    Console.WriteLine("|                 REPORTES                |");
                    Console.WriteLine("|_________________________________________|");
                    Console.WriteLine("|                                         |");
                    Console.WriteLine("| (1) Clientes mayores 30 años            |");
                    Console.WriteLine("| (2) Producto con Stock menor a 2 unds   |");
                    Console.WriteLine("| (3) Facturas con valor mayor a $200.000 |");
                    Console.WriteLine("|_________________________________________|");
                    //Console.WriteLine("(1) Clientes > 30 años (2) Producto con Stock<2 (3) Facturas>200.000$.");
                    rtaReportes = int.Parse(Console.ReadLine());

                    if (rtaReportes == 1)
                    {
                        Console.WriteLine("clientes mayores de 30 años");

                    }
                    else if (rtaReportes == 2)
                    {
                        Console.WriteLine("clientes con Stock menor a 2 unidades");
                    }
                    else if (rtaReportes == 3)
                    {
                        Console.WriteLine("Facturas con valor mayor a $200.000");
                    }

                }


            }
        }
    }
}
