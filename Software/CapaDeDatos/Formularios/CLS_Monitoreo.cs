using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_Monitoreo : ConexionBase
    {
        public string Id_monitoreo { get; set; }
        public string Id_zona { get; set; }
        public string Id_Plagas { get; set; }
        public string Id_Enfermedad { get; set; }
        public string Id_Deteccion { get; set; }
        public string Id_Individuo { get; set; }
        public string Id_Humbral { get; set; }
        public string Id_Usuario { get; set; }
        public string Fecha { get;  set; }
        public string Hora { get;  set; }
        public string Id_Huerta { get;  set; }
        public string Id_PuntoControl { get;  set; }
        public decimal? n_CoordenadaX { get; set; }
        public decimal? n_CoordenadaY { get;  set; }
        public decimal? n_DistanciaPuntoControl { get; set; }
        public string c_codigo_eps { get; set; }
        public string Id_Fenologico { get; set; }
        public int Cant_Individuos { get; set; }
        public string F_UsuCrea { get; set; }

        public string Observaciones { get; set; }
        public string Fumigado { get; set; }

        public void MtdSeleccionarMonitoreo()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Monitoreo_Select";
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


        public void MtdSeleccionarMonitoreoPE()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_MonitoreoPE_Select";
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

        public void MtdInsertarMonitoreo()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Monitoreo_Insert";
                _dato.CadenaTexto = Id_monitoreo;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_monitoreo");
                _dato.CadenaTexto = Id_zona;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_zona");
                _dato.CadenaTexto = Id_Plagas;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Plagas");
                _dato.CadenaTexto = Id_Enfermedad;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Enfermedad");
                _dato.CadenaTexto = Id_Deteccion;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Deteccion");
                _dato.CadenaTexto = Id_Individuo;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Individuo");
                _dato.CadenaTexto = Id_Humbral;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Humbral");
                _dato.CadenaTexto = Id_Usuario;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Usuario");
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
        public void MtdEliminarMonitoreo()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Monitoreo_Delete";
                _dato.CadenaTexto = Id_monitoreo;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_monitoreo");
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

        //Monitoreo PE
        public void MtdInsertarMonitoreoPE()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_WS_Control_MonitoreoPE_Insert";
                _dato.CadenaTexto = Fecha;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha");
                _dato.CadenaTexto = Hora;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Hora");
                _dato.CadenaTexto = Id_Huerta;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Huerta");
                _dato.CadenaTexto = Id_Plagas;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Plagas");
                _dato.CadenaTexto = Id_Enfermedad;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Enfermedad");
                _dato.CadenaTexto = Id_Deteccion;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Deteccion");
                _dato.CadenaTexto = Id_Individuo;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Individuo");
                _dato.CadenaTexto = Id_Humbral;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Humbral");
                _dato.CadenaTexto = Id_PuntoControl;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_PuntoControl");
                _dato.CadenaTexto = Id_Usuario;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Usuario");
                _dato.DecimalValor = n_CoordenadaX;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "n_CoordenadaX");
                _dato.DecimalValor = n_CoordenadaY;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "n_CoordenadaY");
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
        public void MtdInsertarMonitoreoPEEliminado()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_WS_Control_MonitoreoPE_Eliminado_Insert";
                _dato.CadenaTexto = Fecha;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha");
                _dato.CadenaTexto = Hora;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Hora");
                _dato.CadenaTexto = Id_Huerta;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Huerta");
                _dato.CadenaTexto = Id_Plagas;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Plagas");
                _dato.CadenaTexto = Id_Enfermedad;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Enfermedad");
                _dato.CadenaTexto = Id_Deteccion;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Deteccion");
                _dato.CadenaTexto = Id_Individuo;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Individuo");
                _dato.CadenaTexto = Id_Humbral;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Humbral");
                _dato.CadenaTexto = Id_PuntoControl;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_PuntoControl");
                _dato.CadenaTexto = Id_Usuario;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Usuario");
                _dato.DecimalValor = n_CoordenadaX;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "n_CoordenadaX");
                _dato.DecimalValor = n_CoordenadaY;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "n_CoordenadaY");
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

        public void MtdInsertarMonitoreoPEEncabezado()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_WS_Control_MonitoreoPE_Encabezado_Insert";
                _dato.CadenaTexto = Id_PuntoControl;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_PuntoControl");
                _dato.CadenaTexto = Fecha;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha");
                _dato.CadenaTexto = Hora;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Hora");
                _dato.CadenaTexto = Id_Huerta;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Huerta");
                _dato.DecimalValor = n_CoordenadaX;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "n_CoordenadaX");
                _dato.DecimalValor = n_CoordenadaY;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "n_CoordenadaY");
                _dato.CadenaTexto = Id_Usuario;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Usuario");
                _dato.CadenaTexto = c_codigo_eps;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_eps"); 
                _dato.CadenaTexto = F_UsuCrea;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "F_UsuCrea");
                _dato.CadenaTexto = Observaciones;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Observaciones");
                _dato.CadenaTexto = Fumigado;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fumigado");
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
        public void MtdInsertarMonitoreoPEDetalle()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_WS_Control_MonitoreoPE_Detalle_Insert";
                _dato.CadenaTexto = Id_PuntoControl;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_PuntoControl");
                _dato.CadenaTexto = Fecha;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha");
                _dato.CadenaTexto = Hora;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Hora");
                _dato.CadenaTexto = Id_Plagas;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Plagas");
                _dato.CadenaTexto = Id_Enfermedad;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Enfermedad");
                _dato.CadenaTexto = Id_Deteccion;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Deteccion");
                _dato.CadenaTexto = Id_Individuo;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Individuo");
                _dato.CadenaTexto = Id_Humbral;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Humbral");
                _dato.Entero = Cant_Individuos;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "Cant_Individuos");
                _dato.CadenaTexto = Id_Fenologico;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Fenologico");
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

        public void MtdInsertarMonitoreoPEEncabezadoEliminado()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_WS_Control_MonitoreoPE_Encabezado_Eliminado_Insert";
                _dato.CadenaTexto = Id_PuntoControl;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_PuntoControl");
                _dato.CadenaTexto = Fecha;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha");
                _dato.CadenaTexto = Hora;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Hora");
                _dato.CadenaTexto = Id_Huerta;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Huerta");
                _dato.DecimalValor = n_CoordenadaX;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "n_CoordenadaX");
                _dato.DecimalValor = n_CoordenadaY;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "n_CoordenadaY");
                _dato.CadenaTexto = Id_Usuario;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Usuario");
                _dato.CadenaTexto = c_codigo_eps;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_eps");
                _dato.CadenaTexto = F_UsuCrea;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "F_UsuCrea");
                _dato.CadenaTexto = Observaciones;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Observaciones");
                _dato.CadenaTexto = Fumigado;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fumigado");
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
        public void MtdInsertarMonitoreoPEDetalleEliminado()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_WS_Control_MonitoreoPE_Detalle_Eliminado_Insert";
                _dato.CadenaTexto = Id_PuntoControl;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_PuntoControl");
                _dato.CadenaTexto = Fecha;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha");
                _dato.CadenaTexto = Hora;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Hora");
                _dato.CadenaTexto = Id_Plagas;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Plagas");
                _dato.CadenaTexto = Id_Enfermedad;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Enfermedad");
                _dato.CadenaTexto = Id_Deteccion;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Deteccion");
                _dato.CadenaTexto = Id_Individuo;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Individuo");
                _dato.CadenaTexto = Id_Humbral;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Humbral");
                _dato.Entero = Cant_Individuos;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "Cant_Individuos");
                _dato.CadenaTexto = Id_Fenologico;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Fenologico");
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
    }
}
