using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    //CREATE TABLE DETALLEVENTA(
    //IdDetalleVenta INT PRIMARY KEY IDENTITY,
    //IdVenta INT REFERENCES VENTA(IdVenta),
    //IdProducto INT REFERENCES PRODUCTO(IdProducto),
    //Cantidad INT,
    //Total DECIMAL(10, 2)
    public class DetalleVenta
    {

        public int IdDetalleVenta { get; set; }
        public int IdVenta { get; set; }
        public Producto oProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }
        
        //ID, token para que venta y detalle lo tengan 
        public string IdTransaccion { get; set; }

    }
}
