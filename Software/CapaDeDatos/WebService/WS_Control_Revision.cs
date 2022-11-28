using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    
    public class WS_Control_Revision: ConexionBase
    {
        public string Id_bloque { get; set; }
        public string Fecha { get; set; }
        public int N_Arboles { get; set; }
        public string Observaciones { get; set; }
        public string Fruta { get; set; }
        public string Floracion { get; set; }
        public decimal Nivel_Humedad { get; set; }

        public void MtdInsertarRevision()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {

                _conexion.NombreProcedimiento = "SP_WS_Control_Revision_Insert";
                _dato.CadenaTexto = Fecha;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha");
                _dato.CadenaTexto = Id_bloque;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_bloque");
                _dato.CadenaTexto = Fruta;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fruta");
                _dato.Entero = N_Arboles;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "N_Arboles");
                _dato.CadenaTexto = Observaciones;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Observaciones");
                _dato.CadenaTexto = Floracion;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Floracion");
                _dato.DecimalValor = Nivel_Humedad;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Nivel_Humedad");
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
