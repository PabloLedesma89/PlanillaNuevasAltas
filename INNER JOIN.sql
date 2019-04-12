use Nuevas_Altas

SELECT  Articulos.Nombre,Articulos.Barra,Articulos.Observaciones,Articulos.Titular_Convenio,Articulos.Fecha_Envio_Produccion,Articulos.Responsable_Alta,Forma_pago.Estandar,Forma_pago.Datos_Manual,Forma_pago.Admite_Barra,Tipo_Analisis.Web_Service,Tipo_Analisis.Base_Deuda,Tipo_Analisis.Tipo_Archivo,Politica_Anulacion.Condicion,Politica_Anulacion.Tiempo_Restriccion,Politica_Anulacion.Importe,Contacto.Nombre,Contacto.Telefono,Contacto.Email
from 
Articulos 
INNER JOIN Forma_pago ON Articulos.IdArticulo = Articulos.IdArticulo
INNER JOIN Tipo_Analisis ON Forma_pago.IdArticulo = Tipo_Analisis.IdArticulo
INNER JOIN Politica_Anulacion ON Tipo_Analisis.IdArticulo = Politica_Anulacion.IdArticulo
INNER JOIN Contacto ON Politica_Anulacion.IdArticulo = Contacto.IdArticulo 