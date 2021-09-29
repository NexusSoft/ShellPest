using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_Movimientos : ConexionBase
    {
        public string Almacen { get; set; }
        public string Fini { get; set; }
        public string Ffin { get; set; }
        public string c_codigo_eps { get; set; }
        public string TipoMov { get; set; }

        public void MtdSeleccionarSalidas()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Rpt_Salidas_Select";
                _dato.CadenaTexto = Almacen;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Almacen");
                _dato.CadenaTexto = Fini;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fini");
                _dato.CadenaTexto = Ffin;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Ffin");
                _dato.CadenaTexto = c_codigo_eps;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_eps");
                _dato.CadenaTexto = TipoMov;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "TipoMov");
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
