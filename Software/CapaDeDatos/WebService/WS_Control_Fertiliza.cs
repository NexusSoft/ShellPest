using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class WS_Control_Fertiliza : ConexionBase
    {

        public string Id_Fertiliza { get; set; }
        public string Id_Huerta { get; set; }
        public string Observaciones { get; set; }
        public string Id_TipoAplicacion { get; set; }
        public string Id_Presentacion { get; set; }
        public string Id_Usuario { get; set; }
        public string F_Creacion { get; set; }
        public string c_codigo_eps { get; set; }
        public string Centro_Costos { get; set; }

        public string Fecha { get; set; }
        public string c_codigo_pro { get; set; }
        public Decimal Cantidad_Aplicada { get; set; }
        public Decimal Ha_aplicadas { get; set; }

        public void MtdInsertarAplicacion()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {


                _conexion.NombreProcedimiento = "SP_Fertiliza_Insert";
                _dato.CadenaTexto = Id_Fertiliza;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Fertiliza");
                _dato.CadenaTexto = Id_Huerta;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Huerta");
                _dato.CadenaTexto = Observaciones;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Observaciones");
                _dato.CadenaTexto = Id_TipoAplicacion;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_TipoAplicacion");
                _dato.CadenaTexto = Id_Presentacion;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Presentacion");
                _dato.CadenaTexto = Id_Usuario;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Usuario");
                _dato.CadenaTexto = F_Creacion;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "F_Usuario_Crea");
                _dato.CadenaTexto = Fecha;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Anio");
                _dato.CadenaTexto = c_codigo_eps;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_eps");
                _dato.CadenaTexto = Centro_Costos;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Centro_Costos");
                _dato.DecimalValor = Ha_aplicadas;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Ha_aplicadas");
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

        public void MtdInsertarAplicacion_Det()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Fertiliza_Det_Insert";
                _dato.CadenaTexto = Id_Fertiliza;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Fertiliza");
                _dato.CadenaTexto = Fecha;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha");
                _dato.CadenaTexto = c_codigo_pro;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_pro");
                _dato.DecimalValor = Cantidad_Aplicada;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Cantidad_Aplicada");
                _dato.CadenaTexto = Id_Usuario;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Usuario");
                _dato.CadenaTexto = F_Creacion;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "F_Usuario_Crea");
                _dato.CadenaTexto = c_codigo_eps;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_eps");
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
