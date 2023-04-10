using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_Riego : ConexionBase
    {
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string Id_Bloque { get; set; }
        public decimal Precipitacion_Sistema { get; set; }
        public decimal Caudal_Inicio { get; set; }
        public decimal Caudal_Fin { get; set; }
        public decimal Horas_riego { get; set; }
        public string Id_Usuario_Crea { get; set; }
        public string c_codigo_eps { get; set; }
        public decimal Temperatura { get; set; }
        public decimal ET { get; set; }
        public string F_UsuCrea { get; set; }
        public string Hora_Fin { get; set; }
        public int Id_Cambio { get; set; }

        public void MtdInsertarRiego()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Riego_Insert";
                _dato.CadenaTexto = Fecha;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha");
                _dato.CadenaTexto = Hora;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Hora");
                _dato.CadenaTexto = Id_Bloque;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Bloque");
                _dato.DecimalValor = Precipitacion_Sistema;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Precipitacion_Sistema");
                _dato.DecimalValor = Caudal_Inicio;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Caudal_Inicio");
                _dato.DecimalValor = Caudal_Fin;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Caudal_Fin");
                _dato.DecimalValor = Horas_riego;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Horas_riego");
                _dato.CadenaTexto = Id_Usuario_Crea;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Usuario_Crea");
                _dato.CadenaTexto = c_codigo_eps;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_eps");
                _dato.DecimalValor = Temperatura;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Temperatura");
                _dato.DecimalValor = ET;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "ET");
                _dato.CadenaTexto = F_UsuCrea;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "F_UsuCrea");
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

        public void MtdInsertarRiegoEliminado()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Riego_Eliminado_Insert";
                _dato.CadenaTexto = Fecha;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha");
                _dato.CadenaTexto = Hora;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Hora");
                _dato.CadenaTexto = Id_Bloque;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Bloque");
                _dato.DecimalValor = Precipitacion_Sistema;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Precipitacion_Sistema");
                _dato.DecimalValor = Caudal_Inicio;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Caudal_Inicio");
                _dato.DecimalValor = Caudal_Fin;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Caudal_Fin");
                _dato.DecimalValor = Horas_riego;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Horas_riego");
                _dato.CadenaTexto = Id_Usuario_Crea;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Usuario_Crea");
                _dato.CadenaTexto = c_codigo_eps;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_eps");
                _dato.DecimalValor = Temperatura;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Temperatura");
                _dato.DecimalValor = ET;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "ET");
                _dato.CadenaTexto = F_UsuCrea;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "F_UsuCrea");
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

        public void MtdCargarCambiosXblq()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_CargarCambiosXBlq_Select";
                _dato.CadenaTexto = Id_Bloque;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Bloque");
                
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

        public void MtdInsertarRiegoV2()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_RiegoV2_Insert";
                _dato.CadenaTexto = Fecha;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha");
                _dato.CadenaTexto = Hora;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Hora");
                _dato.CadenaTexto = Id_Bloque;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Bloque");
                _dato.DecimalValor = Precipitacion_Sistema;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Precipitacion_Sistema");
                _dato.DecimalValor = Caudal_Inicio;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Caudal_Inicio");
                _dato.DecimalValor = Caudal_Fin;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Caudal_Fin");
                _dato.DecimalValor = Horas_riego;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Horas_riego");
                _dato.CadenaTexto = Id_Usuario_Crea;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Usuario_Crea");
                _dato.CadenaTexto = c_codigo_eps;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_eps");
                _dato.DecimalValor = Temperatura;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Temperatura");
                _dato.DecimalValor = ET;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "ET");
                _dato.CadenaTexto = F_UsuCrea;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "F_UsuCrea");
                _dato.CadenaTexto = Hora_Fin;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Hora_Fin");
                _dato.Entero = Id_Cambio;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "Id_Cambio");
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

        public void MtdSelectRiegoV2()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_RiegoV2_Select";
                _dato.CadenaTexto = Id_Bloque;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Bloque");
                _dato.CadenaTexto = Fecha;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha");
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

        public void MtdSelectRiegoValvulas()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_RiegoValvulas_Select";
                _dato.CadenaTexto = Id_Bloque;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Bloque");
                _dato.CadenaTexto = Fecha;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha");
                _dato.CadenaTexto = Hora;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Hora");
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

        public void MtdEliminarRiegoV2()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_RiegoV2_Delete";
                _dato.CadenaTexto = Id_Bloque;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Bloque");
                _dato.CadenaTexto = Fecha;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha");
                _dato.CadenaTexto = Hora;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Hora");
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
