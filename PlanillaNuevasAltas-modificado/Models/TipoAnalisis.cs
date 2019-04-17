using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlanillaNuevasAltas.Models
{
    public class TipoAnalisis
    {
       
        public int Id{ get; set; }
        public string WebService { get; set; }
        public DateTime BaseDeuda { get; set; }
        public string TipoArchivo { get; set; }

    }
}
