using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class WS_Control_Gasolina_Ingreso : ConexionBase
    {
        public string d_fecha_crea { get; set; }
        public string c_folio_gas { get; set; }
        public string d_fechaingreso_gas { get; set; }
        public string c_codigo_eps { get; set; }
        public string Id_Huerta { get; set; }
        public string c_codigo_emp { get; set; }
        public string v_tipo_gas { get; set; }
        public string v_cantingreso_gas { get; set; }
        public string v_observaciones_gas { get; set; }		   

        public void MtdInsertarGasolinaIngreso()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {

                _conexion.NombreProcedimiento = "SP_Gasolina_Ingreso_Insert";
                _dato.CadenaTexto = d_fecha_crea;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "d_fecha_crea");
                _dato.CadenaTexto = c_folio_gas;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_folio_gas");
                _dato.CadenaTexto = d_fechaingreso_gas;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "d_fechaingreso_gas");
                _dato.CadenaTexto = c_codigo_eps;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_eps");
                _dato.CadenaTexto = Id_Huerta;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Huerta");
                _dato.CadenaTexto = c_codigo_emp;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_emp");
                _dato.CadenaTexto = v_tipo_gas;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "v_tipo_gas");
                _dato.CadenaTexto = v_cantingreso_gas;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "v_cantingreso_gas");
                _dato.CadenaTexto = v_observaciones_gas;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "v_observaciones_gas");

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
