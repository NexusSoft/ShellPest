using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_ParametrosEstacion:ConexionBase
    {

        public int Row_Est_Inicio { get; set; }
        public int Col_Est_Fecha { get; set; }
        public int Col_Est_TempOut { get; set; }
        public int Col_Est_ET { get; set; }
        public int Col_Est_Rain { get; set; }
       

        public void MtdSeleccionar()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_ParametrosEstacion_Select";
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

        public void MtdModificar()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            this.Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_ParametrosEstacion_Update";
                _dato.Entero = Row_Est_Inicio;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "Row_Est_Inicio");
                _dato.Entero = Col_Est_Fecha;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "Col_Est_Fecha");
                _dato.Entero = Col_Est_TempOut;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "Col_Est_TempOut");
                _dato.Entero = Col_Est_ET;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "Col_Est_ET");
                _dato.Entero = Col_Est_Rain;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "Col_Est_Rain");
                _conexion.EjecutarNonQuery();
                Exito = _conexion.Exito;
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }

        }

    }
}
