using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_Asesor_Tecnico : ConexionBase
    {

        public string Id_AsesorTecnico { get; set; }
        public string Nombre_AsesorTecnico { get; set; }
        public string Usuario { get; set; }
        public string Activo { get; set; }

        public void MtdSeleccionarAsesor()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_AsesorTecnico_Select";
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



        public void MtdInsertarAsesor()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_AsesorTecnico_Insert";
                _dato.CadenaTexto = Id_AsesorTecnico;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_AsesorTecnico");
                _dato.CadenaTexto = Nombre_AsesorTecnico;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Nombre_AsesorTecnico");
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

        public void MtdEliminarAsesor()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_AsesorTecnico_Delete";
                _dato.CadenaTexto = Id_AsesorTecnico;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_AsesorTecnico");
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
