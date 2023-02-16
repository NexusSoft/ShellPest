using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class WS_Control_Gasolina : ConexionBase
    {
        public string d_fecha_crea { get; set; }
        public string c_folio_gas { get; set; }
        public string d_fechaconsumo_gas { get; set; }
        public string c_codigo_eps { get; set; }
        public string Id_Huerta { get; set; }
        public string v_Bloques_gas { get; set; }
        public string Id_ActivosGas { get; set; }
        public string c_codigo_emp { get; set; }
        public string c_codigo_act { get; set; }
        public string v_tipo_gas { get; set; }
        public string v_cantutilizada_gas { get; set; }
        public string v_horometro_gas { get; set; }
        public string v_kminicial_gas { get; set; }
        public string v_kmfinal_gas { get; set; }
        public string v_observaciones_gas { get; set; }		   

        public void MtdInsertarGasolina()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {

                _conexion.NombreProcedimiento = "SP_Gasolina_Insert";
                _dato.CadenaTexto = d_fecha_crea;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "d_fecha_crea");
                _dato.CadenaTexto = c_folio_gas;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_folio_gas");
                _dato.CadenaTexto = d_fechaconsumo_gas;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "d_fechaconsumo_gas");
                _dato.CadenaTexto = c_codigo_eps;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_eps");
                _dato.CadenaTexto = Id_Huerta;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Huerta");
                _dato.CadenaTexto = v_Bloques_gas;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "v_Bloques_gas");
                _dato.CadenaTexto = Id_ActivosGas;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_ActivosGas");
                _dato.CadenaTexto = c_codigo_emp;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_emp");
                _dato.CadenaTexto = c_codigo_act;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_act");
                _dato.CadenaTexto = v_tipo_gas;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "v_tipo_gas");
                _dato.CadenaTexto = v_cantutilizada_gas;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "v_cantutilizada_gas");
                _dato.CadenaTexto = v_horometro_gas;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "v_horometro_gas");
                _dato.CadenaTexto = v_kminicial_gas;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "v_kminicial_gas");
                _dato.CadenaTexto = v_kmfinal_gas;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "v_kmfinal_gas");
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

        public void MtdConsultaCantidadCombustible()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_WS_Control_Cant_Combustible_Select";
                _dato.CadenaTexto = c_codigo_eps;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_eps");
                _dato.CadenaTexto = Id_Huerta;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Huerta");
                _dato.CadenaTexto = v_tipo_gas;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "v_tipo_gas");
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

        public void MtdConsultaCombustiblexFecha()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Combustibles_Select";
                _dato.CadenaTexto = d_fechaconsumo_gas;
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

    }
}
