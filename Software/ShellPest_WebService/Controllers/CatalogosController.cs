using System;
using System.Collections.Generic;
using CapaDeDatos;
using System.Web.Mvc;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.ServiceModel;
using CapaDeDatos;



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
        public void GetJson(DataTable dt)
        {
            Dictionary<string, object> row;

            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col].ToString());
                }
                rows.Add(row);
            }
        }
    }
}
