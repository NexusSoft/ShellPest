using System;
using System.Collections.Generic;
using CapaDeDatos;
using System.Web.Mvc;
using System.Data;



namespace ShellPest_WebService
{
    [System.ServiceModel.ServiceBehavior(
        IncludeExceptionDetailInFaults = true)]
    public class CatalogosController : Controller
    {
        string key = "ShellPest";
        public List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
        // GET: api/Pedidos
        [System.Web.Mvc.HttpGet]
        public ActionResult Bloques(string Fecha)
        {
            string cadena = string.Empty;
            WS_Catalogos_Bloque sel = new WS_Catalogos_Bloque();
            sel.Fecha = Fecha;

            sel.MtdSeleccionarBloque();
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
        public ActionResult Calidad(string Fecha)
        {
            string cadena = string.Empty;
            WS_Catalogos_Calidad sel = new WS_Catalogos_Calidad();
            sel.Fecha = Fecha;

            sel.MtdSeleccionarCalidad();
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
        public ActionResult Ciudad(string Fecha)
        {
            string cadena = string.Empty;
            WS_Catalogos_Ciudad sel = new WS_Catalogos_Ciudad();
            sel.Fecha = Fecha;

            sel.MtdSeleccionarCiudad();
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
        public ActionResult Cultivo(string Fecha)
        {
            string cadena = string.Empty;
            WS_Catalogos_Cultivo sel = new WS_Catalogos_Cultivo();
            sel.Fecha = Fecha;

            sel.MtdSeleccionarCultivo();
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
        public ActionResult Zona(string Fecha)
        {
            string cadena = string.Empty;
            WS_Catalogos_Zona sel = new WS_Catalogos_Zona();
            sel.Fecha = Fecha;

            sel.MtdSeleccionarZona();
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
        public ActionResult Deteccion(string Fecha)
        {
            string cadena = string.Empty;
            WS_Catalogos_Deteccion sel = new WS_Catalogos_Deteccion();
            sel.Fecha = Fecha;

            sel.MtdSeleccionarDeteccion();
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
        public ActionResult Duenio(string Fecha)
        {
            string cadena = string.Empty;
            WS_Catalogos_Duenio sel = new WS_Catalogos_Duenio();
            sel.Fecha = Fecha;

            sel.MtdSeleccionarDuenio();
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
        public ActionResult Enfermedad(string Fecha)
        {
            string cadena = string.Empty;
            WS_Catalogos_Enfermedad sel = new WS_Catalogos_Enfermedad();
            sel.Fecha = Fecha;

            sel.MtdSeleccionarEnfermedad();
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
        public ActionResult Estado(string Fecha)
        {
            string cadena = string.Empty;
            WS_Catalogos_Estado sel = new WS_Catalogos_Estado();
            sel.Fecha = Fecha;

            sel.MtdSeleccionarEstado();
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
        public ActionResult Huerta(string Fecha)
        {
            string cadena = string.Empty;
            WS_Catalogos_Huerta sel = new WS_Catalogos_Huerta();
            sel.Fecha = Fecha;

            sel.MtdSeleccionarHuerta();
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
        public ActionResult Huerta_Usuarios()
        {
            string cadena = string.Empty;
            WS_Catalogos_Huerta sel = new WS_Catalogos_Huerta();
            sel.MtdSeleccionarHuertaUsuario();
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
        public ActionResult Humbral(string Fecha)
        {
            string cadena = string.Empty;
            WS_Catalogos_Humbral sel = new WS_Catalogos_Humbral();
            sel.Fecha = Fecha;

            sel.MtdSeleccionarHumbral();
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
        public ActionResult Pais(string Fecha)
        {
            string cadena = string.Empty;
            WS_Catalogos_Pais sel = new WS_Catalogos_Pais();
            sel.Fecha = Fecha;

            sel.MtdSeleccionarPais();
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
        public ActionResult Plagas(string Fecha)
        {
            string cadena = string.Empty;
            WS_Catalogos_Plagas sel = new WS_Catalogos_Plagas();
            sel.Fecha = Fecha;

            sel.MtdSeleccionarPlagas();
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
        public ActionResult Productor(string Fecha)
        {
            string cadena = string.Empty;
            WS_Catalogos_Productor sel = new WS_Catalogos_Productor();
            sel.Fecha = Fecha;

            sel.MtdSeleccionarProductor();
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
        public ActionResult PuntoControl(string Fecha)
        {
            string cadena = string.Empty;
            WS_Catalogos_PuntoControl sel = new WS_Catalogos_PuntoControl();
            sel.Fecha = Fecha;

            sel.MtdSeleccionarPuntoControl();
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
        public ActionResult Individuo(string Fecha)
        {
            string cadena = string.Empty;
            WS_Catalogos_Individuo sel = new WS_Catalogos_Individuo();
            sel.Fecha = Fecha;

            sel.MtdSeleccionarIndividuo();
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
        public ActionResult Monitoreo(string Fecha)
        {
            string cadena = string.Empty;
            WS_Catalogos_Monitoreo sel = new WS_Catalogos_Monitoreo();
            sel.Fecha = Fecha;

            sel.MtdSeleccionarMonitoreo();
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
    }
}
