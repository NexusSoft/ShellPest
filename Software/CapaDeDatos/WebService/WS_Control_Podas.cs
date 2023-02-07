using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class WS_Control_Podas : ConexionBase
    {
        public string Id_bloque { get; set; }
        public string c_codigo_eps { get; set; }
        public string Fecha { get; set; }
        public int N_arboles { get; set; }
        public string Observaciones { get; set; }
        public string Id_Usuario_Crea { get; set; }
        public string F_Usuario_Crea { get; set; }
        public string Actividad { get; set; }

        public void MtdInsertarPoda()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {

                _conexion.NombreProcedimiento = "SP_Poda_Insert";
                _dato.CadenaTexto = Fecha;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha");
                _dato.CadenaTexto = Id_bloque;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_bloque");
                _dato.CadenaTexto = c_codigo_eps;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_eps");
                _dato.Entero = N_arboles;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "N_arboles");
                _dato.CadenaTexto = Observaciones;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Observaciones");
                _dato.CadenaTexto = Id_Usuario_Crea;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Usuario_Crea");
                _dato.CadenaTexto = F_Usuario_Crea;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "F_Usuario_Crea");
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

        public void MtdInsertarPodaDet()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {

                _conexion.NombreProcedimiento = "SP_PodaDet_Insert";
                _dato.CadenaTexto = Fecha;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha");
                _dato.CadenaTexto = Id_bloque;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_bloque");
                _dato.CadenaTexto = c_codigo_eps;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_eps");
                _dato.CadenaTexto = Actividad;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Actividad");
                
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

        public void PodasSelect()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {

                _conexion.NombreProcedimiento = "SP_Podas_Select";
                _dato.CadenaTexto = Fecha;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha");
               

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

        public void PodasDetSelect()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {

                _conexion.NombreProcedimiento = "SP_PodasDet_Select";
                _dato.CadenaTexto = Fecha;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha");
                _dato.CadenaTexto = Id_bloque;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_bloque");

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
