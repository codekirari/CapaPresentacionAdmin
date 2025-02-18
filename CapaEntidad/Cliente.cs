using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{

    //CREATE TABLE CLIENTE(
    //IdCliente INT PRIMARY KEY IDENTITY,
    //Nombre VARCHAR(100),
    //Correo VARCHAR(100),
    //Clave VARCHAR(200),
    //Reestablecer BIT DEFAULT 0,
    //FechaRegistro DATETIME DEFAULT GETDATE() 
    public class Cliente

    {
        public int IdCliente { get; set}
        public string Nombre { get; set; }
        public string Correo { get; set; }
    public string Clave { get; set; }
        public bool Reestablecer { get; set; }




    }
}
