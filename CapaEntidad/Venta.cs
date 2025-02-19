using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    //CREATE TABLE VENTA(
    //IdVenta INT PRIMARY KEY IDENTITY,
    //IdCliente INT REFERENCES CLIENTE(IdCliente),
    //TotalProducto INT,
    //MontoTotal DECIMAL(10, 2),
    //Contacto VARCHAR(100),
    //IdDepartamento VARCHAR(100),
    //Telefono VARCHAR(50),
    //IdTransaccion VARCHAR(100),
    //FechaVenta DATETIME DEFAULT GETDATE()
    public class Venta
    {
        public int IdVenta { get; set; }
        public int IdCliente { get; set; }
        public int TotalProducto { get; set; }
        public decimal MontoTotal { get; set; }
        public string Contacto { get; set; }
        public string IdDepartamento { get; set; }
        public string Telefono { get; set; }
        public string IdTransaccion { get; set; }

        //añadir referencia  adetalle de venta

       public List<DetalleVenta> oDetalleVentas{ get; set; }



    }
}
