using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class WS_Control_Cosecha : ConexionBase
    {
        public string Id_bloque { get; set; }
        public string c_codigo_eps { get; set; }
        public string Fecha { get; set; }
        public string BICO { get; set; }
        public int Cajas_Cosecha { get; set; }
        public int Cajas_Desecho { get; set; }
        public int Cajas_Pepena { get; set; }
        public int Cajas_RDiaria { get; set; }
        public string Id_Usuario { get; set; }
        public string F_Fecha_Crea { get; set; }

        public void MtdInsertarCosecha()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {

                _conexion.NombreProcedimiento = "SP_Cosecha_Insert";
                _dato.CadenaTexto = Fecha;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha");
                _dato.CadenaTexto = Id_bloque;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_bloque");
                _dato.CadenaTexto = c_codigo_eps;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_eps");
                _dato.CadenaTexto = BICO;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "BICO");
                _dato.Entero = Cajas_Cosecha;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "Cajas_Cosecha");
                _dato.Entero = Cajas_Desecho;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "Cajas_Desecho");
                _dato.Entero = Cajas_Pepena;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "Cajas_Pepena");
                _dato.Entero = Cajas_RDiaria;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "Cajas_RDiaria");
                _dato.CadenaTexto = Id_Usuario;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Usuario");
                _dato.CadenaTexto = F_Fecha_Crea;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "F_Fecha_Crea");
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
