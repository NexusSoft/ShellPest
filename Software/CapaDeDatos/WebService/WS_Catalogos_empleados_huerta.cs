using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class WS_Catalogos_empleados_huerta : ConexionBase
    {

        public string Id_Usuario { get; set; }
        public string Id_Huerta { get; set; }

        public void MtdSeleccionarEmpleados()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_WS_empleados_huerta_Select";
                _dato.CadenaTexto = Id_Usuario;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Usuario");
              
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

        public void MtdSeleccionarEmpleadosLocal()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_empleados_huerta_Select";
                _dato.CadenaTexto = Id_Usuario;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Usuario");
                _dato.CadenaTexto = Id_Huerta;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Huerta");
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
