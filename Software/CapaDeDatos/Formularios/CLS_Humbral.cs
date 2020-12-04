using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_Humbral : ConexionBase
    {

        public string Id_Humbral { get; set; }
        public string Nombre_Humbral { get; set; }
        public string Valor_Humbral { get; set; }
        public string Color_Humbral { get; set; }
        public string Id_Usuario { get; set; }

        public void MtdSeleccionarHumbral()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Humbral_Select";

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
        public void MtdInsertarHumbral()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Humbral_Insert";
                _dato.CadenaTexto = Id_Humbral;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Humbral");
                _dato.CadenaTexto = Nombre_Humbral;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Nombre_Humbral");
                _dato.CadenaTexto = Valor_Humbral;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Valor_Humbral");
                _dato.CadenaTexto = Color_Humbral;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Color_Humbral");
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
        public void MtdEliminarHumbral()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Humbral_Delete";
                _dato.CadenaTexto = Id_Humbral;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Humbral");
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
