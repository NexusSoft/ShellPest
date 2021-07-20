using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_Receta : ConexionBase
    {

        public string Id_Receta { get; set; }
        public string Fecha_Receta { get; set; }
        public string Id_AsesorTecnico { get; set; }
        public string Id_MonitoreoPE { get; set; }
        public string Id_Cultivo { get; set; }
        public string Id_TipoAplicacion { get; set; }
        public string Id_Presentacion { get; set; }
        public string Observaciones { get; set; }
        public decimal Intervalo_Seguridad { get; set; }
        public decimal Intervalo_Reingreso { get; set; }
        public string Usuario { get; set; }
        public string Activo { get; set; }

        public void MtdSeleccionarReceta()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Receta_Select";
               
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
                _conexion.NombreProcedimiento = "SP_Receta_Insert";
                _dato.CadenaTexto = Id_Receta;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Receta");
                _dato.CadenaTexto = Fecha_Receta;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha_Receta");
                _dato.CadenaTexto = Id_AsesorTecnico;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_AsesorTecnico");
                _dato.CadenaTexto = Id_MonitoreoPE;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_MonitoreoPE");
                _dato.CadenaTexto = Id_Cultivo;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Cultivo");
                _dato.CadenaTexto = Id_TipoAplicacion;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_TipoAplicacion");
                _dato.CadenaTexto = Id_Presentacion;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Presentacion");
                _dato.CadenaTexto = Observaciones;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Observaciones");
                _dato.DecimalValor = Intervalo_Seguridad;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Intervalo_Seguridad");
                _dato.DecimalValor = Intervalo_Reingreso;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Intervalo_Reingreso");
                _dato.CadenaTexto = Usuario;
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

        public void MtdEliminarReceta()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Receta_Delete";
                _dato.CadenaTexto = Id_Receta;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Receta");
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
