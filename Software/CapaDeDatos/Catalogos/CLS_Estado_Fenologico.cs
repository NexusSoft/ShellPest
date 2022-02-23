using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_Estado_Fenologico: ConexionBase
    {

        public string Id_Fenologico { get; set; }
        public string Nombre_Fenologico { get; set; }
        public string PoE { get; set; }


        public void MtdSeleccionarFenologico()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Fenologicos_Form_Select";
                _dato.CadenaTexto = PoE;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "PoE");
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

        public void MtdSeleccionarFenologicoSP()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Fenologico_Select";
                
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

        public void MtdInsertarFenologico()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_EstFenologico_Insert";
                _dato.CadenaTexto = Id_Fenologico;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Fenologico");
                _dato.CadenaTexto = Nombre_Fenologico;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Nombre_Fenologico");
                _dato.CadenaTexto = PoE;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "PoE");
                
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

        public void MtdEliminarFenologico()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_EstFenologico_Delete";
                _dato.CadenaTexto = Id_Fenologico;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Fenologico");
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
