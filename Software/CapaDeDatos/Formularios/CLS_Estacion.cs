using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_Estacion:ConexionBase
    {
        public string Fecha { get; set; }
        public decimal TimeOut { get; set; }
        public decimal ET { get; set; }
        public decimal Rain { get; set; }
        public void MtdSeleccionarParametroEstacion()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            this.Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_EstacionColumnas_Select";
                _conexion.EjecutarDataset();

                if (_conexion.Exito)
                {
                    this.Datos = _conexion.Datos;
                }
                else
                {
                    this.Mensaje = _conexion.Mensaje;
                    this.Exito = false;


                }
            }
            catch (Exception e)
            {
                this.Mensaje = e.Message;
                this.Exito = false;
            }


        }
        public void MtdInsertarParametroEstacion()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_EstacionColumnas_Insert";
                _dato.CadenaTexto = Fecha;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha");
                _dato.DecimalValor = TimeOut;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "TimeOut");
                _dato.DecimalValor = ET;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "ET");
                _dato.DecimalValor = Rain;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Rain");
                
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
