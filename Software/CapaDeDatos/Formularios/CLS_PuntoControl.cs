using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_PuntoControl : ConexionBase
    {

        public string Id_PuntoControl { get; set; }
        public string Id_Bloque { get; set; }
        public string Nombre_PuntoControl { get; set; }
        public string n_coordenadaX { get; set; }
        public string n_coordenadaY { get; set; }
        public string Id_Usuario { get; set; }
        public string c_codigo_eps { get; set; }
        public int Activo { get; set; }

        public void MtdSeleccionarPuntoControl()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_PuntoControl_Select";
                _dato.CadenaTexto = c_codigo_eps;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_eps");
                _dato.Entero = Activo;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "Activo");
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
        public void MtdInsertarPuntoControl()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_PuntoControl_Insert";
                _dato.CadenaTexto = Id_PuntoControl;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_PuntoControl");
                _dato.CadenaTexto = Id_Bloque;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Bloque");
                _dato.CadenaTexto = Nombre_PuntoControl;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Nombre_PuntoControl");
                _dato.CadenaTexto = n_coordenadaX;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "n_coordenadaX");
                _dato.CadenaTexto = n_coordenadaY;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "n_coordenadaY");
                _dato.CadenaTexto = Id_Usuario;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Usuario");
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
        public void MtdEliminarPuntoControl()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_PuntoControl_Delete";
                _dato.CadenaTexto = Id_PuntoControl;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_PuntoControl");
                _dato.Entero = Activo;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "Activo");
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
