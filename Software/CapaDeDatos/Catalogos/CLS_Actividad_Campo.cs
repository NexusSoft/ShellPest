using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_Actividad_Campo : ConexionBase
    {

        public string Id_Unidad { get; set; }
        public string c_codigo_cam { get; set; }
        public string c_codigo_act { get; set; }

        public void MtdSeleccionarActividadCampo()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_actividad_campo_Select";
                
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

        public void MtdInsertarActividadCampo()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_ActividadCampo_Insert";
                _dato.CadenaTexto = Id_Unidad;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Unidad");
                _dato.CadenaTexto = c_codigo_cam;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_cam");
                _dato.CadenaTexto = c_codigo_act;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_act");
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

        public void MtdDeleteActividadCampo()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_ActividadCampo_Delete";
               
                _dato.CadenaTexto = c_codigo_cam;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_cam");
                _dato.CadenaTexto = c_codigo_act;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_act");
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
