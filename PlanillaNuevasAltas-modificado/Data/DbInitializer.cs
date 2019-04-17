using PlanillaNuevasAltas.Data;
using PlanillaNuevasAltas.Models;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using System.Transactions;
using Microsoft.EntityFrameworkCore.Storage;

namespace PlanillaNuevasAltas
{
    public static class DbInitializer
    {
        public static void Initialize(NuevasAltasContext context)
        {
            context.Database.EnsureCreated();
            
                    var Articulo = new Articulo[]
                    {
            new Articulo{Id=7775,Nombre="COLEGIO DE TERAPISTAS OCUPACIONALES",Barra="151100024517060021446150717002400020081700247206",Observaciones="sin observaciones",Titular_Convenio="Asj",Fecha_Envio_Produccion=DateTime.Parse("2018-02-12 09:30:20.000"),Responsable_Alta="E.Gamba",Longitud=48}
                    };

                    var FormaPago = new FormaPago[]
                    {
            new FormaPago{Id=7775,Estandar="Esquema Genérico CB",DatosManual="NO",AdmiteBarra="SI"}
                    };

                    var TipoAnalisis = new TipoAnalisis[]
                    {
            new TipoAnalisis{Id=7775,WebService="url/terapistas",BaseDeuda=DateTime.Parse("2018-02-12 09:30:20.000"),TipoArchivo="dirección de FTP, usr, pwd."}
                    };

                    var PoliticaAnulacion = new PoliticaAnulacion[]
                    {
             new PoliticaAnulacion{Id=7775,Condicion="url/terapistas",TiempoRestriccion="Antes de las 18hs",Importe="Indistinto"}
                    };

                    var Contacto = new Contacto[]
                    {
            new Contacto{Id=7775,Nombre="Pedro Perez",Telefono="3416589532",Email="terapistas@hotmail.com"}
                    };

                    context.SaveChanges();



            
        }
    }
}