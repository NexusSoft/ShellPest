using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_Cambios_Riego : ConexionBase
    {
        public string Id_Bloque { get; set; }
        public string N_Cambio { get; set; }

        public string Id_Valvula { get; set; }
        public string Id_Cambio { get; set; }
        public Boolean SinDet { get; set; }

        public void MtdSeleccionarCambiosRiego()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Cambios_Riego_Select";
                _dato.CadenaTexto = Id_Bloque;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Bloque");
                _dato.CadenaTexto = N_Cambio;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "N_Cambio");
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

        public void MtdSeleccionarCargarValvulas()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Cargar_Valvulas_Select";
                _dato.CadenaTexto = Id_Bloque;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Bloque");

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

        public void MtdInsertarCambios()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Cambios_Riego_Insert";
                _dato.CadenaTexto = Id_Bloque;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Bloque");
                _dato.CadenaTexto = Id_Valvula;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Valvula");
                _dato.CadenaTexto = N_Cambio;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "N_Cambio");
                _dato.CadenaTexto = Id_Cambio;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Cambio");
                _dato.BoleanoValor = SinDet;
                _conexion.agregarParametro(EnumTipoDato.Boleano, _dato, "SinDet");
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
