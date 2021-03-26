using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_Riego : ConexionBase
    {
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string Id_Bloque { get; set; }
        public decimal Precipitacion_Sistema { get; set; }
        public decimal Caudal_Inicio { get; set; }
        public decimal Caudal_Fin { get; set; }
        public decimal Horas_riego { get; set; }
        public string Id_Usuario_Crea { get; set; }

        
        public void MtdInsertarRiego()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Riego_Insert";
                _dato.CadenaTexto = Fecha;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha");
                _dato.CadenaTexto = Hora;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Hora");
                _dato.CadenaTexto = Id_Bloque;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Bloque");
                _dato.DecimalValor = Precipitacion_Sistema;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Precipitacion_Sistema");
                _dato.DecimalValor = Caudal_Inicio;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Caudal_Inicio");
                _dato.DecimalValor = Caudal_Fin;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Caudal_Fin");
                _dato.DecimalValor = Horas_riego;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Horas_riego");
                _dato.CadenaTexto = Id_Usuario_Crea;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Usuario_Crea");
                _conexion.EjecutarDataset();

                if (_conexion.Exito)
                {
                    Datos = _conexion.Datos;
                }
                else
                {
                    Mensaje = _conexion.Mensaje;
                    Exito = false;
                }
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }
        }

        public void MtdInsertarRiegoEliminado()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Riego_Eliminado_Insert";
                _dato.CadenaTexto = Fecha;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha");
                _dato.CadenaTexto = Hora;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Hora");
                _dato.CadenaTexto = Id_Bloque;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Bloque");
                _dato.DecimalValor = Precipitacion_Sistema;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Precipitacion_Sistema");
                _dato.DecimalValor = Caudal_Inicio;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Caudal_Inicio");
                _dato.DecimalValor = Caudal_Fin;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Caudal_Fin");
                _dato.DecimalValor = Horas_riego;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Horas_riego");
                _dato.CadenaTexto = Id_Usuario_Crea;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Usuario_Crea");
                _conexion.EjecutarDataset();

                if (_conexion.Exito)
                {
                    Datos = _conexion.Datos;
                }
                else
                {
                    Mensaje = _conexion.Mensaje;
                    Exito = false;
                }
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }
        }
    }
}
