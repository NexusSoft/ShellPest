using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_RecetaDet : ConexionBase
    {

        public string Id_Receta { get; set; }
        public int Secuencia { get; set; }
        public string c_codigo_pro { get; set; }
        public string v_nombre_pro { get; set; }
        //public string c_codigo_cac { get; set; }
        //public string v_nombre_cac { get; set; }
        public string c_codigo_uni { get; set; }
        public decimal Dosis { get; set; }
        public decimal Cantidad_Unitaria { get; set; }
        public string Descripcion { get; set; }
        public string Id_Usuario { get; set; }
        public string c_codigo_eps { get; set; }

        public void MtdSeleccionarReceta()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_RecetaDet_Select";
                _dato.CadenaTexto = Id_Receta;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Receta");
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



        public void MtdInsertarReceta()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_RecetaDet_Insert";
                _dato.CadenaTexto = Id_Receta;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Receta");
                _dato.Entero = Secuencia;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "Secuencia");
                _dato.CadenaTexto = c_codigo_pro;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_pro");
                _dato.CadenaTexto = v_nombre_pro;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "v_nombre_pro");
                //_dato.CadenaTexto = c_codigo_cac;
                //_conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_cac");
                //_dato.CadenaTexto = v_nombre_cac;
                //_conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "v_nombre_cac");
                _dato.CadenaTexto = c_codigo_uni;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_uni");
                _dato.DecimalValor = Dosis;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Dosis");
                _dato.DecimalValor = Cantidad_Unitaria;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Cantidad_Unitaria");
                _dato.CadenaTexto = Descripcion;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Descripcion");
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

        public void MtdEliminarReceta()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_RecetaDet_Delete";
                _dato.CadenaTexto = Id_Receta;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Receta");
                _dato.Entero = Secuencia;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "Secuencia");
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
