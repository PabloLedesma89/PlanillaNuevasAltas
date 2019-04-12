using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlanillaNuevasAltas.Models
{
    public class Tipo_Analisis
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdArticulo { get; set; }
        public string Web_Service { get; set; }
        public DateTime Base_Deuda { get; set; }
        public string Tipo_Archivo { get; set; }

        public ICollection<Articulos> IdArticulos { get; set; }
    }
}
