using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_Riego : ConexionBase
    {

        public string Id_Bloque { get; set; }
        public string Fecha_Riego { get; set; }
        public decimal Horas_Riego { get; set; }
        public string Id_Usuario { get; set; }

        public void MtdSeleccionarRiego()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Riego_Select";
                _dato.CadenaTexto = Fecha_Riego;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha_Riego");
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
        public void MtdInsertarRiego()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Riego_Insert";
                _dato.CadenaTexto = Id_Bloque;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Bloque");
                _dato.CadenaTexto = Fecha_Riego;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha_Riego");
                _dato.DecimalValor = Horas_Riego;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Horas_Riego");
                _dato.CadenaTexto = Id_Usuario;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Usuario");
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
        public void MtdEliminarRiego()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Riego_Delete";
                _dato.CadenaTexto = Id_Bloque;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Bloque");
                _dato.CadenaTexto = Fecha_Riego;
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
