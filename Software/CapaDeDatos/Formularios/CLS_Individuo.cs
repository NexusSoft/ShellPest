using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_Individuo : ConexionBase
    {

        public string Id_Individuo { get; set; }
        public string No_Individuo { get; set; }
        public string Id_Usuario { get; set; }
        public int No_Inicial { get; set; }
        public int No_Final { get; set; }

        public void MtdSeleccionarIndividuo()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Individuo_Select";

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



        public void MtdInsertarIndividuo()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Individuo_Insert";
                _dato.CadenaTexto = Id_Individuo;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Individuo");
                _dato.CadenaTexto = No_Individuo;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "No_Individuo");
                _dato.Entero = No_Inicial;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "No_Inicial");
                _dato.Entero = No_Final;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "No_Final");
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

        public void MtdEliminarIndividuo()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Individuo_Delete";
                _dato.CadenaTexto = Id_Individuo;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Individuo");
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
