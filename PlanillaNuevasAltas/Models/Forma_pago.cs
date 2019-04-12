using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlanillaNuevasAltas.Models
{
    public class Forma_pago
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdArticulo { get; set; }
        public string Estandar { get; set; }
        public string Datos_Manual { get; set; }
        public string Admite_Barra { get; set; }

        public ICollection<Articulos> IdArticulos { get; set; }

    }
}
