using PlanillaNuevasAltas.Data;
using PlanillaNuevasAltas.Models;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace PlanillaNuevasAltas
{
    public static class DbInitializer
    {
        public static void Initialize(NuevasAltasContext context)
        {
            context.Database.EnsureCreated();


            var Articulos = new Articulos[]
            {
            new Articulos{IdArticulo=7775,Nombre="COLEGIO DE TERAPISTAS OCUPACIONALES",Barra="151100024517060021446150717002400020081700247206",Observaciones="sin observaciones",Titular_Convenio="Asj",Fecha_Envio_Produccion=DateTime.Parse("2018-02-12 09:30:20.000"),Responsable_Alta="E.Gamba",Longitud=48}
            };
            foreach (Articulos s in Articulos)
            {
                context.Articulos.Add(s);
            }
            context.SaveChanges();

            var Forma_Pago = new Forma_pago[]
            {
            new Forma_pago{IdArticulo=7775,Estandar="Esquema Genérico CB",Datos_Manual="NO",Admite_Barra="SI"}
            };
            foreach (Forma_pago c in Forma_Pago)
            {
                context.Forma_pago.Add(c);
            }
            context.SaveChanges();

            var Tipo_Analisis = new Tipo_Analisis[]
            {
            new Tipo_Analisis{IdArticulo=7775,Web_Service="url/terapistas",Base_Deuda=DateTime.Parse("2018-02-12 09:30:20.000"),Tipo_Archivo="dirección de FTP, usr, pwd."}
            };
            foreach (Tipo_Analisis e in Tipo_Analisis)
            {
                context.Tipo_Analisis.Add(e);
            }
            context.SaveChanges();

            var Politica_Anulacion = new Politica_Anulacion[]
            {
             new Politica_Anulacion{IdArticulo=7775,Condicion="url/terapistas",Tiempo_Restriccion="Antes de las 18hs",Importe="Indistinto"}
            };
            foreach (Politica_Anulacion e in Politica_Anulacion)
            {
                context.Politica_Anulacion.Add(e);
            }
            context.SaveChanges();

            var Contacto = new Contacto[]
            {
            new Contacto{IdArticulo=7775,Nombre="Pedro Perez",Telefono="3416589532",Email="terapistas@hotmail.com"}
            };
            foreach (Contacto e in Contacto)
            {
                context.Contacto.Add(e);
            }
            context.SaveChanges();
        }
    }
}