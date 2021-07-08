using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_Presentacion : ConexionBase
    {

        public string Id_Presentacion { get; set; }
        public string Nombre_Presentacion { get; set; }
        public string Id_TipoAplicacion { get; set; }
        public string Id_Unidad { get; set; }
        public string Usuario { get; set; }
        public string Activo { get; set; }

        public void MtdSeleccionarPresentacion()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Presentacion_Select";
                _dato.CadenaTexto = Activo;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Activo");
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



        public void MtdInsertarPresentacion()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Presentacion_Insert";
                _dato.CadenaTexto = Id_Presentacion;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Presentacion");
                _dato.CadenaTexto = Nombre_Presentacion;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Nombre_Presentacion");
                _dato.CadenaTexto = Id_TipoAplicacion;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_TipoAplicacion");
                _dato.CadenaTexto = Id_Unidad;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Unidad");
                _dato.CadenaTexto = Usuario;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Usuario");
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

        public void MtdEliminarPresentacion()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Presentacion_Delete";
                _dato.CadenaTexto = Id_Presentacion;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Presentacion");
                _dato.CadenaTexto = Usuario;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Usuario");
                _dato.CadenaTexto = Activo;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Activo");
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
