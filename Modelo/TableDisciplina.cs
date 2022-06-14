using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication44.Modelo
{
    public partial class TableDisciplina
    {
        public TableDisciplina()
        {
            TableJugadors = new HashSet<TableJugador>();
        }

        public string Id { get; set; }
        public string DisciplinaDeportiva { get; set; }
        public string NombreEquipo { get; set; }
        public string CategoriaDeportiva { get; set; }

        public virtual ICollection<TableJugador> TableJugadors { get; set; }
    }
}
