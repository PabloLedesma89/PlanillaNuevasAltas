using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlanillaNuevasAltas.Models
{
    public class Articulos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdArticulo{ get; set;}
        public string Nombre { get; set;}
        public string Barra { get; set; }
        public string Observaciones { get; set; }
        public string Titular_Convenio { get; set; }
        public DateTime Fecha_Envio_Produccion { get; set; }
        public string Responsable_Alta { get; set; }
        public int Longitud { get; set; }

        public ICollection<Articulos> IdArticulos { get; set; }

    }
}
