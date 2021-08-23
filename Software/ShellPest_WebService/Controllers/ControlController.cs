using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapaDeDatos;

namespace ShellPest_WebService
{
    [System.ServiceModel.ServiceBehavior(
        IncludeExceptionDetailInFaults = true)]
    public class ControlController : Controller
    {
        public List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
        [HttpGet]
        public ActionResult MonitoreoPE(string Fecha,string Hora,string Id_Huerta,string Id_Plagas,string Id_Enfermedad,
                                string Id_Deteccion,string Id_Individuo,string Id_Humbral,string Id_PuntoControl,
                                string Id_Usuario,string n_CoordenadaX,string n_CoordenadaY)
        {
            string cadena = string.Empty;
            CLS_Monitoreo sel = new CLS_Monitoreo();
            sel.Fecha = Fecha;
            sel.Hora = Hora;
            sel.Id_Huerta = Id_Huerta;
            sel.Id_Plagas = Id_Plagas;
            sel.Id_Enfermedad = Id_Enfermedad;
            sel.Id_Deteccion = Id_Deteccion;
            sel.Id_Individuo = Id_Individuo;
            sel.Id_Humbral = Id_Humbral;
            sel.Id_PuntoControl = Id_PuntoControl;
            sel.Id_Usuario = Id_Usuario;
            sel.n_CoordenadaX =decimal.Parse(n_CoordenadaX);
            sel.n_CoordenadaY =decimal.Parse(n_CoordenadaY);


            sel.MtdInsertarMonitoreoPE();
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("Mensaje", typeof(string));
            DataRow _ravi = dt.NewRow();
            if (sel.Exito)
            {
                _ravi["Mensaje"] = "1";
                dt.Rows.Add(_ravi);
                GetJson(dt);
                return Json(rows, JsonRequestBehavior.AllowGet);
            }
            else
            {
                _ravi["Mensaje"] = sel.Mensaje;
                dt.Rows.Add(_ravi);
                GetJson(dt);
                return Json(rows, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult MonitoreoPEEliminado(string Fecha, string Hora
                               , string Id_Huerta, string Id_Plagas, string Id_Enfermedad,
                                string Id_Deteccion, string Id_Individuo, string Id_Humbral, string Id_PuntoControl,
                                string Id_Usuario, string n_CoordenadaX, string n_CoordenadaY)
        {
            string cadena = string.Empty;
            CLS_Monitoreo sel = new CLS_Monitoreo();
            sel.Fecha = Fecha;
            sel.Hora = Hora;
            sel.Id_Huerta = Id_Huerta;
            sel.Id_Plagas = Id_Plagas;
            sel.Id_Enfermedad = Id_Enfermedad;
            sel.Id_Deteccion = Id_Deteccion;
            sel.Id_Individuo = Id_Individuo;
            sel.Id_Humbral = Id_Humbral;
            sel.Id_PuntoControl = Id_PuntoControl;
            sel.Id_Usuario = Id_Usuario;
            sel.n_CoordenadaX = decimal.Parse(n_CoordenadaX);
            sel.n_CoordenadaY = decimal.Parse(n_CoordenadaY);


            sel.MtdInsertarMonitoreoPEEliminado();
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("Mensaje", typeof(string));
            DataRow _ravi = dt.NewRow();
            if (sel.Exito)
            {
                _ravi["Mensaje"] = "1";
                dt.Rows.Add(_ravi);
                GetJson(dt);
                return Json(rows, JsonRequestBehavior.AllowGet);
            }
            else
            {
                _ravi["Mensaje"] = sel.Mensaje;
                dt.Rows.Add(_ravi);
                GetJson(dt);
                return Json(rows, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult MonitoreoPEEncabezado(string Fecha, string Hora, string Id_Huerta, 
                                string Id_PuntoControl,string Id_Usuario, string n_CoordenadaX, string n_CoordenadaY)
        {
            string cadena = string.Empty;
            CLS_Monitoreo sel = new CLS_Monitoreo();
            sel.Id_PuntoControl = Id_PuntoControl;
            sel.Fecha = Fecha;
            sel.Hora = Hora;
            sel.Id_Huerta = Id_Huerta;
            sel.n_CoordenadaX = decimal.Parse(n_CoordenadaX);
            sel.n_CoordenadaY = decimal.Parse(n_CoordenadaY);
            sel.Id_Usuario = Id_Usuario;

            sel.MtdInsertarMonitoreoPEEncabezado();
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("Mensaje", typeof(string));
            DataRow _ravi = dt.NewRow();
            if (sel.Exito)
            {
                _ravi["Mensaje"] = "1";
                dt.Rows.Add(_ravi);
                GetJson(dt);
                return Json(rows, JsonRequestBehavior.AllowGet);
            }
            else
            {
                _ravi["Mensaje"] = sel.Mensaje;
                dt.Rows.Add(_ravi);
                GetJson(dt);
                return Json(rows, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult MonitoreoPEDetalle(string Fecha, string Hora, string Id_PuntoControl, string Id_Plagas, string Id_Enfermedad,
                                string Id_Deteccion, string Id_Individuo, string Id_Humbral)
        {
            string cadena = string.Empty;
            if (string.IsNullOrWhiteSpace(Id_Plagas))
            {
                Id_Plagas = string.Empty;
            }
            if (string.IsNullOrWhiteSpace(Id_Enfermedad))
            {
                Id_Enfermedad = string.Empty;
            }
            CLS_Monitoreo sel = new CLS_Monitoreo();
            sel.Fecha = Fecha;
            sel.Hora = Hora;
            sel.Id_PuntoControl = Id_PuntoControl;
            sel.Id_Plagas = Id_Plagas;
            sel.Id_Enfermedad = Id_Enfermedad;
            sel.Id_Deteccion = Id_Deteccion;
            sel.Id_Individuo = Id_Individuo;
            sel.Id_Humbral = Id_Humbral;

            sel.MtdInsertarMonitoreoPEDetalle();
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("Mensaje", typeof(string));
            DataRow _ravi = dt.NewRow();
            if (sel.Exito)
            {
                _ravi["Mensaje"] = "1";
                dt.Rows.Add(_ravi);
                GetJson(dt);
                return Json(rows, JsonRequestBehavior.AllowGet);
            }
            else
            {
                _ravi["Mensaje"] = sel.Mensaje;
                dt.Rows.Add(_ravi);
                GetJson(dt);
                return Json(rows, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult MonitoreoPEEncabezadoEliminado(string Fecha, string Hora, string Id_Huerta,
                                string Id_PuntoControl, string Id_Usuario, string n_CoordenadaX, string n_CoordenadaY)
        {
            string cadena = string.Empty;
            CLS_Monitoreo sel = new CLS_Monitoreo();
            sel.Id_PuntoControl = Id_PuntoControl;
            sel.Fecha = Fecha;
            sel.Hora = Hora;
            sel.Id_Huerta = Id_Huerta;
            sel.n_CoordenadaX = decimal.Parse(n_CoordenadaX);
            sel.n_CoordenadaY = decimal.Parse(n_CoordenadaY);
            sel.Id_Usuario = Id_Usuario;

            sel.MtdInsertarMonitoreoPEEncabezadoEliminado();
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("Mensaje", typeof(string));
            DataRow _ravi = dt.NewRow();
            if (sel.Exito)
            {
                _ravi["Mensaje"] = "1";
                dt.Rows.Add(_ravi);
                GetJson(dt);
                return Json(rows, JsonRequestBehavior.AllowGet);
            }
            else
            {
                _ravi["Mensaje"] = sel.Mensaje;
                dt.Rows.Add(_ravi);
                GetJson(dt);
                return Json(rows, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult MonitoreoPEDetalleEliminado(string Fecha, string Hora, string Id_PuntoControl, string Id_Plagas, string Id_Enfermedad,
                                string Id_Deteccion, string Id_Individuo, string Id_Humbral)
        {
            string cadena = string.Empty;
            if (string.IsNullOrWhiteSpace(Id_Plagas))
            {
                Id_Plagas = string.Empty;
            }
            if (string.IsNullOrWhiteSpace(Id_Enfermedad))
            {
                Id_Enfermedad = string.Empty;
            }
            CLS_Monitoreo sel = new CLS_Monitoreo();
            sel.Fecha = Fecha;
            sel.Hora = Hora;
            sel.Id_PuntoControl = Id_PuntoControl;
            sel.Id_Plagas = Id_Plagas;
            sel.Id_Enfermedad = Id_Enfermedad;
            sel.Id_Deteccion = Id_Deteccion;
            sel.Id_Individuo = Id_Individuo;
            sel.Id_Humbral = Id_Humbral;

            sel.MtdInsertarMonitoreoPEDetalleEliminado();
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("Mensaje", typeof(string));
            DataRow _ravi = dt.NewRow();
            if (sel.Exito)
            {
                _ravi["Mensaje"] = "1";
                dt.Rows.Add(_ravi);
                GetJson(dt);
                return Json(rows, JsonRequestBehavior.AllowGet);
            }
            else
            {
                _ravi["Mensaje"] = sel.Mensaje;
                dt.Rows.Add(_ravi);
                GetJson(dt);
                return Json(rows, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public ActionResult Riego(string Fecha, string Hora
                              , string Id_Bloque, string Precipitacion_Sistema, string Caudal_Inicio,
                               string Caudal_Fin, string Horas_riego, string Id_Usuario
           )
        {
            string cadena = string.Empty;
            CLS_Riego sel = new CLS_Riego();
            sel.Fecha = Fecha;
            sel.Hora = Hora;
            sel.Id_Bloque = Id_Bloque;
            sel.Precipitacion_Sistema = decimal.Parse(Precipitacion_Sistema);
            sel.Caudal_Inicio = decimal.Parse(Caudal_Inicio);
            sel.Caudal_Fin = decimal.Parse(Caudal_Fin);
            sel.Horas_riego = decimal.Parse(Horas_riego);
            sel.Id_Usuario_Crea = Id_Usuario;

            sel.MtdInsertarRiego();
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("Mensaje", typeof(string));
            DataRow _ravi = dt.NewRow();
            if (sel.Exito)
            {
                _ravi["Mensaje"] = "1";
                dt.Rows.Add(_ravi);
                GetJson(dt);
                return Json(rows, JsonRequestBehavior.AllowGet);
            }
            else
            {
                _ravi["Mensaje"] = sel.Mensaje;
                dt.Rows.Add(_ravi);
                GetJson(dt);
                return Json(rows, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult RiegoEliminado(string Fecha, string Hora
                              , string Id_Bloque, string Precipitacion_Sistema, string Caudal_Inicio,
                               string Caudal_Fin, string Horas_riego, string Id_Usuario
           )
        {
            string cadena = string.Empty;
            CLS_Riego sel = new CLS_Riego();
            sel.Fecha = Fecha;
            sel.Hora = Hora;
            sel.Id_Bloque = Id_Bloque;
            sel.Precipitacion_Sistema =decimal.Parse(Precipitacion_Sistema);
            sel.Caudal_Inicio = decimal.Parse(Caudal_Inicio);
            sel.Caudal_Fin = decimal.Parse(Caudal_Fin);
            sel.Horas_riego = decimal.Parse(Horas_riego);
            sel.Id_Usuario_Crea = Id_Usuario;
            sel.MtdInsertarRiegoEliminado();
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("Mensaje", typeof(string));
            DataRow _ravi = dt.NewRow();
            if (sel.Exito)
            {
                _ravi["Mensaje"] = "1";
                dt.Rows.Add(_ravi);
                GetJson(dt);
                return Json(rows, JsonRequestBehavior.AllowGet);
            }
            else
            {
                _ravi["Mensaje"] = sel.Mensaje;
                dt.Rows.Add(_ravi);
                GetJson(dt);
                return Json(rows, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public ActionResult Aplicaciones(string Id_Aplicacion, string Id_Huerta, string Observaciones,
                               string Id_TipoAplicacion, string Id_Presentacion, string Id_Usuario, string F_Creacion,string Anio)
        {
            string cadena = string.Empty;
            WS_Control_Aplicaciones CLS = new WS_Control_Aplicaciones();
            CLS.Id_Aplicacion = Id_Aplicacion;
            CLS.Id_Huerta = Id_Huerta;
            CLS.Observaciones = Observaciones;
            CLS.Id_TipoAplicacion = Id_TipoAplicacion;
            CLS.Id_Presentacion = Id_Presentacion;
            CLS.Id_Usuario = Id_Usuario;
            CLS.F_Creacion = F_Creacion;
            CLS.Fecha = Anio.Substring(2);
            CLS.MtdInsertarAplicacion();
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("Mensaje", typeof(string));
            DataRow _ravi = dt.NewRow();
            if (CLS.Exito)
            {
                _ravi["Mensaje"] = CLS.Datos.Rows[0][0].ToString();
                dt.Rows.Add(_ravi);
                GetJson(dt);
                return Json(rows, JsonRequestBehavior.AllowGet);
            }
            else
            {
                _ravi["Mensaje"] = CLS.Mensaje;
                dt.Rows.Add(_ravi);
                GetJson(dt);
                return Json(rows, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public ActionResult Aplicaciones_Det(string Id_Aplicacion, string Fecha, string c_codigo_pro,
                               string Dosis, string Unidades_aplicadas, string Id_Usuario, string F_Creacion)
        {
            string cadena = string.Empty;
            WS_Control_Aplicaciones CLS = new WS_Control_Aplicaciones();
            CLS.Id_Aplicacion = Id_Aplicacion;
            CLS.Fecha = Fecha;
            CLS.c_codigo_pro = c_codigo_pro;
            CLS.Dosis = decimal.Parse(Dosis);
            CLS.Unidades_aplicadas = decimal.Parse(Unidades_aplicadas);

            CLS.Id_Usuario = Id_Usuario;
            CLS.F_Creacion = F_Creacion;
            CLS.MtdInsertarAplicacion_Det();
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("Mensaje", typeof(string));
            DataRow _ravi = dt.NewRow();
            if (CLS.Exito)
            {
                _ravi["Mensaje"] = "1";
                dt.Rows.Add(_ravi);
                GetJson(dt);
                return Json(rows, JsonRequestBehavior.AllowGet);
            }
            else
            {
                _ravi["Mensaje"] = CLS.Mensaje;
                dt.Rows.Add(_ravi);
                GetJson(dt);
                return Json(rows, JsonRequestBehavior.AllowGet);
            }
        }

        public void GetJson(DataTable dt)
        {
            Dictionary<string, object> row;

            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, Convert.ToString(dr[col].ToString()));
                }
                rows.Add(row);
            }
        }
        //192.168.3.254:8090//Control/MonitoreoPE?Fecha=20200111&Hora=10:08:59&Id_Huerta=00008&Id_Plagas=0001&Id_Enfermedad=""&Id_Deteccion=0004&Id_Individuo=0001&Id_Humbral=0004&Id_PuntoControl=0137&Id_Usuario=admin&n_CoordenadaX=15.2&n_CoordenadaY=14.6
   }
}

//192.168.3.254:8090//Control/MonitoreoPEEliminado?Fecha=20201201&Hora=10:23:56&Id_Huerta=00008&Id_Plagas=0001&Id_Enfermedad=1&Id_Deteccion=0004&Id_Individuo=0001&Id_Humbral=0004&Id_PuntoControl=0137&Id_Usuario=admin&n_CoordenadaX=15.3&n_CoordenadaY=16.5
//192.168.3.254:8090//Control/Riego?Fecha=20201201&Hora=10:23:56&Id_Bloque=00008&Precipitacion_Sistema=0001&Caudal_Inicio=1&Caudal_Fin=0004&Horas_riego=0001&Id_Usuario=admin
//192.168.3.254:8090//Control/MonitoreoPEEliminado?Fecha=20201201&Hora=10:23:56&Id_Huerta=00008&Id_Plagas=0001&Id_Enfermedad=1&Id_Deteccion=0004&Id_Individuo=0001&Id_Humbral=0004&Id_PuntoControl=0137&Id_Usuario=admin&n_CoordenadaX=15.3&n_CoordenadaY=16.5