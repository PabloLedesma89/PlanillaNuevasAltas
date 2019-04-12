using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlanillaNuevasAltas.Models
{
    public class Politica_Anulacion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdArticulo { get; set; }
        public string Condicion { get; set; }
        public string Tiempo_Restriccion { get; set; }
        public string Importe { get; set; }

        public ICollection<Articulos> IdArticulos { get; set; }
    }
}
