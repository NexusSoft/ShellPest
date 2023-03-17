using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_Valvulas : ConexionBase
    {
        public string Id_Bloque { get; set; }
        public int N_Valvula { get; set; }
        public int N_Arboles { get; set; }
        public int N_Replantes { get; set; }
        public int N_Morras { get; set; }
        public int N_Micros { get; set; }
        public decimal N_Caudales { get; set; }
        public decimal M3 { get; set; }

        public void MtdSeleccionarValvulasDet()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_ValvulasDet_Select";
                _dato.CadenaTexto = Id_Bloque;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Bloque");
                _dato.Entero = N_Valvula;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "N_Valvula");
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

        public void MtdInsertarValvulas()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Valvulas_Insert";
                _dato.CadenaTexto = Id_Bloque;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Bloque");
                _dato.Entero = N_Valvula;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "N_Valvula");
                _dato.Entero = N_Arboles;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "N_Arboles");
                _dato.Entero = N_Replantes;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "N_Replantes");
                _dato.Entero = N_Morras;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "N_Morras");
                _dato.Entero = N_Micros;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "N_Micros");
                _dato.DecimalValor = N_Caudales;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "N_Caudales");
                _dato.DecimalValor = M3;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "M3");
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
