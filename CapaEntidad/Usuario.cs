using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{

	//CREATE TABLE USUARIO(
	//IdUsuario INT PRIMARY KEY IDENTITY,
	//Nombre VARCHAR (100),
	//Apellido VARCHAR(100),
	//Correo VARCHAR(100),
	//Clave VARCHAR(500),
	//Reestablecer BIT DEFAULT 1,
	//Activo BIT DEFAULT 1,
	//FechaRegistro DATETIME DEFAULT GETDATE()

	public class Usuario
    {
		public int IdUsuario { get; set; }
		public string Nombre { get; set; }
		public string Apellido { get; set; }
		public string Clave { get; set; }
		public bool Reestablecer { get; set; }
		public bool Activo { get; set; }


	}
}
