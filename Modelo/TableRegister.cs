using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication44.Modelo
{
    public partial class TableRegister
    {
        public string Id { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public byte[] Nombre { get; set; }
        public string Apellido { get; set; }
        public decimal Edad { get; set; }
        public string Email { get; set; }
        public string Sexo { get; set; }
        public DateTime? FechaNacimiento { get; set; }
    }
}
