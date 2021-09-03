using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_UnidadesMedida : ConexionBase
    {
        public string Id_Unidad { get; set; }
        public string Nombre_Unidad { get; set; }
        public string Abreviatura { get; set; }

        public string Usuario { get; set; }
        public string Activo { get; set; }
        public string c_codigo_eps { get; set; }

        public void MtdSeleccionarUnidadesMedida()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Unidad_Select";
                _dato.CadenaTexto = Activo;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Activo");
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



        public void MtdInsertarUnidadesMedida()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Unidad_Insert";
                _dato.CadenaTexto = Id_Unidad;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Unidad");
                _dato.CadenaTexto = Nombre_Unidad;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Nombre_Unidad");
                _dato.CadenaTexto = Abreviatura;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Abreviatura");

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

        public void MtdEliminarUnidadesMedida()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_UnidadesMedida_Delete";
                _dato.CadenaTexto = Id_Unidad;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Unidad");
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
