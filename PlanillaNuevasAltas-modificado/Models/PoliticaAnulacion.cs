using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlanillaNuevasAltas.Models
{
    public class PoliticaAnulacion
    {
       
        public int Id { get; set; }
        public string Condicion { get; set; }
        public string TiempoRestriccion { get; set; }
        public string Importe { get; set; }

    }
}
