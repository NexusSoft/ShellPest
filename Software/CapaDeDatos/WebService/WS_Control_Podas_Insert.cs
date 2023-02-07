using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class WS_Control_Podas_Insert : ConexionBase
    {

        public string Fecha { get; set; }
        public string Id_Bloque { get; set; }
        public int N_arboles { get; set; }
        public string Observaciones { get; set; }
        public string Id_Usuario_Crea { get; set; }
        public int detalle { get; set; }
        public string c_codigo_eps { get; set; }
        public string actividad { get; set; }

        public void MtdInsertarPodas()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                DateTime FechaT = Convert.ToDateTime(Fecha);
               
                _conexion.NombreProcedimiento = "SP_WS_Control_Podas_Insert";
                _dato.CadenaTexto = FechaT.Year.ToString() + DosCero(FechaT.Month.ToString()) + DosCero(FechaT.Day.ToString());
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha");
                _dato.CadenaTexto = Id_Bloque;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Bloque");
                _dato.Entero = N_arboles;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "N_arboles");
                _dato.CadenaTexto = Observaciones;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Observaciones");
                _dato.CadenaTexto = Id_Usuario_Crea;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Usuario_Crea");
                _dato.CadenaTexto = c_codigo_eps;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_eps");
                _dato.CadenaTexto = actividad;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "actividad");

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

        public void MtdDeletePodas()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                DateTime FechaT = Convert.ToDateTime(Fecha);

                _conexion.NombreProcedimiento = "SP_Podas_Delete";
                _dato.CadenaTexto = FechaT.Year.ToString() + DosCero(FechaT.Month.ToString()) + DosCero(FechaT.Day.ToString());
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha");
                _dato.CadenaTexto = Id_Bloque;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Bloque");
                _dato.Entero = detalle;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "detalle");
               
                _dato.CadenaTexto = actividad;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "actividad");

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

        private string DosCero(string sVal)
        {
            string str = "";
            if (sVal.Length == 1)
            {
                return (str = "0" + sVal);
            }
            return sVal;
        }

    }
}
