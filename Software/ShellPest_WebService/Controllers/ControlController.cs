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
                                string Id_Usuario,string n_CoordenadaX,string n_CoordenadaY,string c_codigo_eps)
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
            sel.c_codigo_eps = c_codigo_eps;

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
                                string Id_PuntoControl,string Id_Usuario, string n_CoordenadaX, string n_CoordenadaY,string c_codigo_eps)
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
            sel.c_codigo_eps = c_codigo_eps;
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
                                string Id_Deteccion, string Id_Individuo, string Id_Humbral,string Cant_Individuos,string Id_Fenologico,string c_codigo_eps)
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
            sel.Cant_Individuos =Convert.ToInt32( Cant_Individuos);
            sel.Id_Fenologico = Id_Fenologico;
            sel.c_codigo_eps = c_codigo_eps;
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
                                string Id_PuntoControl, string Id_Usuario, string n_CoordenadaX, string n_CoordenadaY,string c_codigo_eps)
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
            sel.c_codigo_eps = c_codigo_eps;
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
                                string Id_Deteccion, string Id_Individuo, string Id_Humbral, string Cant_Individuos, string Id_Fenologico,string c_codigo_eps)
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
            sel.Cant_Individuos = Convert.ToInt32(Cant_Individuos);
            sel.Id_Fenologico = Id_Fenologico;
            sel.c_codigo_eps = c_codigo_eps;
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
                               string Caudal_Fin, string Horas_riego, string Id_Usuario, string c_codigo_eps, string Temperatura, string ET
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
            sel.c_codigo_eps = c_codigo_eps;
            sel.Temperatura = decimal.Parse(Temperatura);
            sel.ET = decimal.Parse(ET);
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
                               string Caudal_Fin, string Horas_riego, string Id_Usuario, string c_codigo_eps, string Temperatura, string ET
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
            sel.c_codigo_eps = c_codigo_eps;
            sel.Temperatura = decimal.Parse(Temperatura);
            sel.ET = decimal.Parse(ET);
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
                               string Id_TipoAplicacion, string Id_Presentacion, string Id_Usuario, string F_Creacion,string Anio,string c_codigo_eps,string CC, string Unidades_aplicadas)
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
            CLS.c_codigo_eps = c_codigo_eps;
            CLS.Centro_Costos = CC;
            CLS.Unidades_aplicadas = decimal.Parse(Unidades_aplicadas);
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
                               string Dosis, string Id_Usuario, string F_Creacion,string c_codigo_eps)
        {
            string cadena = string.Empty;
            WS_Control_Aplicaciones CLS = new WS_Control_Aplicaciones();
            CLS.Id_Aplicacion = Id_Aplicacion;
            CLS.Fecha = Fecha;
            CLS.c_codigo_pro = c_codigo_pro;
            CLS.Dosis = decimal.Parse(Dosis);
            

            CLS.Id_Usuario = Id_Usuario;
            CLS.F_Creacion = F_Creacion;
            CLS.c_codigo_eps = c_codigo_eps;
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

        [HttpGet]
        public ActionResult Salidas(string c_codigo_sal, string c_codigo_ent, string c_codigo_tmv,
                               string c_codigo_tra, string d_documento_sal,string c_codigo_alm,string c_codigo_eps,string Id_Responsable,string Id_Aplicacion, string Id_Usuario, string F_Creacion)
        {
            string cadena = string.Empty;
            WS_Control_Salidas CLS = new WS_Control_Salidas();
            CLS.c_codigo_sal = c_codigo_sal;
            CLS.c_codigo_ent = c_codigo_ent;
            CLS.c_codigo_tmv = c_codigo_tmv;
            CLS.c_codigo_tra = c_codigo_tra;
            CLS.d_documento_sal = d_documento_sal;
            CLS.c_codigo_alm = c_codigo_alm;
            CLS.c_codigo_eps = c_codigo_eps;
            CLS.Id_Responsable = Id_Responsable;
            CLS.Id_Aplicacion = Id_Aplicacion;
            CLS.Id_Usuario = Id_Usuario;
            CLS.F_Creacion = F_Creacion;
            CLS.MtdInsertarSalida();
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
        public ActionResult Salidas_Det(string c_tipodoc_mov, string c_coddoc_mov, string c_codigo_pro,
                               string n_movipro_mov, string n_exiant_mov, string n_cantidad_mov, string Id_Bloque,string c_codigo_eps)
        {
            string cadena = string.Empty;
            WS_Control_Salidas CLS = new WS_Control_Salidas();
            CLS.c_tipodoc_mov = c_tipodoc_mov;
            CLS.c_coddoc_mov = c_coddoc_mov;
            CLS.c_codigo_pro = c_codigo_pro;
            CLS.n_movipro_mov = n_movipro_mov;
            CLS.n_exiant_mov = n_exiant_mov;

            CLS.n_cantidad_mov = n_cantidad_mov;
            CLS.Id_Bloque = Id_Bloque;
            CLS.c_codigo_eps = c_codigo_eps;
            CLS.MtdInsertarSalida_Det();
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

        [System.Web.Mvc.HttpGet]
        public ActionResult ExistenciaPro()
        {
            string cadena = string.Empty;
            CLS_Inventum sel = new CLS_Inventum();
            
            sel.MtdExistenciasProSelect();
            if (sel.Exito)
            {
                GetJson(sel.Datos);
                return Json(rows, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(cadena, JsonRequestBehavior.AllowGet);
            }
        }

        [System.Web.Mvc.HttpGet]
        public ActionResult ExistenciaProAlm(string Id_Usuario)
        {
            string cadena = string.Empty;
            CLS_Inventum sel = new CLS_Inventum();
            sel.Id_Usuario = Id_Usuario;
            sel.MtdExistenciasProAlmSelect();
            if (sel.Exito)
            {
                GetJson(sel.Datos);
                return Json(rows, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(cadena, JsonRequestBehavior.AllowGet);
            }
        }

        [System.Web.Mvc.HttpGet]
        public ActionResult Podas(string Fecha, string Id_bloque, string c_codigo_eps, string N_arboles, string Observaciones, string Id_Usuario_Crea, string F_Usuario_Crea)
        {
            string cadena = string.Empty;
            WS_Control_Podas sel = new WS_Control_Podas();
            sel.Fecha = Fecha;
            sel.Id_bloque = Id_bloque;
            sel.c_codigo_eps = c_codigo_eps;
            sel.N_arboles = Convert.ToInt32(N_arboles);
            sel.Observaciones = Observaciones;
            sel.Id_Usuario_Crea = Id_Usuario_Crea;
            sel.F_Usuario_Crea = F_Usuario_Crea;
            sel.MtdInsertarPoda();
            if (sel.Exito)
            {
                GetJson(sel.Datos);
                return Json(rows, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(cadena, JsonRequestBehavior.AllowGet);
            }
        }

        [System.Web.Mvc.HttpGet]
        public ActionResult PodasDet(string Fecha, string Id_bloque, string c_codigo_eps, string Actividad)
        {
            string cadena = string.Empty;
            WS_Control_Podas sel = new WS_Control_Podas();
            sel.Fecha = Fecha;
            sel.Id_bloque = Id_bloque;
            sel.c_codigo_eps = c_codigo_eps;
            sel.Actividad = Actividad;
           
            sel.MtdInsertarPodaDet();
            if (sel.Exito)
            {
                GetJson(sel.Datos);
                return Json(rows, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(cadena, JsonRequestBehavior.AllowGet);
            }
        }

        [System.Web.Mvc.HttpGet]
        public ActionResult Cosecha(string Fecha, string Id_bloque, string c_codigo_eps, string BICO, string Cajas_Cosecha, string Cajas_Desecho, string Cajas_Pepena, string Cajas_RDiaria, string Id_Usuario, string F_Fecha_Crea)
        {
            string cadena = string.Empty;
            WS_Control_Cosecha sel = new WS_Control_Cosecha();
            sel.Fecha = Fecha;
            sel.Id_bloque = Id_bloque;
            sel.c_codigo_eps = c_codigo_eps;
            sel.Cajas_Cosecha = Convert.ToInt32(Cajas_Cosecha);
            sel.Cajas_Desecho = Convert.ToInt32(Cajas_Desecho);
            sel.Cajas_Pepena = Convert.ToInt32(Cajas_Pepena);
            sel.Cajas_RDiaria = Convert.ToInt32(Cajas_RDiaria);
            sel.BICO = BICO;
            sel.Id_Usuario = Id_Usuario;
            sel.F_Fecha_Crea = F_Fecha_Crea;
            sel.MtdInsertarCosecha();
            if (sel.Exito)
            {
                GetJson(sel.Datos);
                return Json(rows, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(cadena, JsonRequestBehavior.AllowGet);
            }
        }

        [System.Web.Mvc.HttpGet]
        public ActionResult Gasolina(string d_fecha_crea,string c_folio_gas,string d_fechainicio_gas,string d_fechafin_gas,string c_codigo_eps,string Id_Huerta,string v_Bloques_gas,string Id_ActivosGas,string c_codigo_emp,string c_codigo_act,string v_cantingreso_gas,string v_cantsaldo_gas,string v_tipo_gas,string v_horometro_gas,string v_kminicial_gas,string v_kmfinal_gas,string v_observaciones_gas)
        {
            string cadena = string.Empty;
            WS_Control_Gasolina sel = new WS_Control_Gasolina();
            sel.d_fecha_crea = d_fecha_crea;
            sel.c_folio_gas = c_folio_gas;
            sel.d_fechainicio_gas = d_fechainicio_gas;
            sel.d_fechafin_gas = d_fechafin_gas;
            sel.c_codigo_eps = c_codigo_eps;
            sel.Id_Huerta = Id_Huerta; 
            sel.v_Bloques_gas = v_Bloques_gas;
            sel.Id_ActivosGas = Id_ActivosGas;
            sel.c_codigo_emp = c_codigo_emp;
            sel.c_codigo_act = c_codigo_act;
            sel.v_cantingreso_gas = v_cantingreso_gas;
            sel.v_cantsaldo_gas = v_cantsaldo_gas;
            sel.v_tipo_gas = v_tipo_gas;
            sel.v_horometro_gas = v_horometro_gas;
            sel.v_kminicial_gas = v_kminicial_gas;
            sel.v_kmfinal_gas = v_kmfinal_gas;
            sel.v_observaciones_gas = v_observaciones_gas;

            sel.MtdInsertarGasolina();
            if (sel.Exito)
            {
                GetJson(sel.Datos);
                return Json(rows, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(cadena, JsonRequestBehavior.AllowGet);
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