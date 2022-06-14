using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication44.Modelo
{
    public partial class TableEvento
    {
        public string Id { get; set; }
        public string NombreEvento { get; set; }
        public string TipoEvento { get; set; }
        public string CategoriaEvneto { get; set; }
        public string IdEvento { get; set; }

        public virtual TableJugador TableJugador { get; set; }
    }
}
