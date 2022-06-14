using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication44.Modelo
{
    public partial class TableJugador
    {
        public string Id { get; set; }
        public string NombreJugador { get; set; }
        public string ApellidoJugador { get; set; }
        public string SexoJugador { get; set; }
        public decimal EdadJugador { get; set; }
        public string IdDisciplina { get; set; }

        public virtual TableDisciplina IdDisciplinaNavigation { get; set; }
        public virtual TableEvento IdNavigation { get; set; }
    }
}
