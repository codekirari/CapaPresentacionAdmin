using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    //CREATE TABLE CARRITO(
    //    IdCarrito INT PRIMARY KEY IDENTITY,
    //    IdCliente INT,
    //    IdProducto INT,
    //    Cantidad INT,
    //    FOREIGN KEY (IdCliente) REFERENCES CLIENTE(IdCliente),
    //    FOREIGN KEY (IdProducto) REFERENCES PRODUCTO(IdProducto)
    class Carrito

    {
        public int IdCarrito { get; set}
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public bool Reestablecer { get; set; }




    }
}