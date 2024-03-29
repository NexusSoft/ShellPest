﻿using System;
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
        public ActionResult Bloques(string Fecha,string Id_Usuario,string FechaLot)
        {
            string cadena = string.Empty;
            WS_Catalogos_Bloque sel = new WS_Catalogos_Bloque();
            sel.Fecha = Fecha;
            sel.Id_Usuario = Id_Usuario;
            sel.FechaLot = FechaLot;
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
        public ActionResult Huerta(string Fecha,string Id_Usuario)
        {
            string cadena = string.Empty;
            WS_Catalogos_Huerta sel = new WS_Catalogos_Huerta();
            sel.Fecha = Fecha;
            sel.Id_Usuario = Id_Usuario;
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
        public ActionResult Huerta_Usuarios(string Id_Usuario)
        {
            string cadena = string.Empty;
            WS_Catalogos_Huerta sel = new WS_Catalogos_Huerta();
            sel.Id_Usuario = Id_Usuario;
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
        public ActionResult Productor(string Fecha,string Id_Usuario)
        {
            string cadena = string.Empty;
            WS_Catalogos_Productor sel = new WS_Catalogos_Productor();
            sel.Fecha = Fecha;
            sel.Id_Usuario = Id_Usuario;
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
        public ActionResult PuntoControl(string Fecha,string Id_Usuario)
        {
            string cadena = string.Empty;
            WS_Catalogos_PuntoControl sel = new WS_Catalogos_PuntoControl();
            sel.Fecha = Fecha;
            sel.Id_Usuario = Id_Usuario;
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
        [System.Web.Mvc.HttpGet]
        public ActionResult Productos(string Fecha,string Id_Usuario)
        {
            string cadena = string.Empty;
            WS_Catalogos_Productos sel = new WS_Catalogos_Productos();
            sel.Fecha = Fecha;
            sel.Id_Usuario = Id_Usuario;
            sel.MtdSeleccionarProductos();
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
        public ActionResult Unidades(string Fecha,string Id_Usuario)
        {
            string cadena = string.Empty;
            WS_Catalogos_Unidades sel = new WS_Catalogos_Unidades();
            sel.Fecha = Fecha;
            sel.Id_Usuario = Id_Usuario;
            sel.MtdSeleccionarUnidades();
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
        public ActionResult Presentasiones(string Fecha,string Id_Usuario)
        {
            string cadena = string.Empty;
            WS_Catalogos_Presentasiones sel = new WS_Catalogos_Presentasiones();
            sel.Fecha = Fecha;
            sel.Id_Usuario = Id_Usuario;
            sel.MtdSeleccionarPresentasion();
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
        public ActionResult TipoAplicaciones(string Fecha, string Id_Usuario)
        {
            string cadena = string.Empty;
            WS_Catalogos_TipoAplicaciones sel = new WS_Catalogos_TipoAplicaciones();
            sel.Fecha = Fecha;
            sel.Id_Usuario = Id_Usuario;
            sel.MtdSeleccionarTipoAplicaciones();
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
        public ActionResult Almacenes(string Id_Usuario)
        {
            string cadena = string.Empty;
            CLS_Almacen_Huerto sel = new CLS_Almacen_Huerto();
            sel.Id_Usuario = Id_Usuario;
            sel.MtdSeleccionarWebAlmHue();
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
        public ActionResult Empresas(string Fecha)
        {
            string cadena = string.Empty;
            WS_Catalogos_Empresas sel = new WS_Catalogos_Empresas();
            sel.Fecha = Fecha;
            sel.MtdSeleccionarEmpresa();
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
        public ActionResult UsuarioEmpresa()
        {
            string cadena = string.Empty;
            WS_Catalogos_Empresas sel = new WS_Catalogos_Empresas();
            
            sel.MtdSeleccionarUsuarioEmpresa();
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
        public ActionResult Recetas(string Id_Usuario)
        {
            string cadena = string.Empty;
            WS_Catalogos_Receta sel = new WS_Catalogos_Receta();
            sel.Id_Usuario = Id_Usuario;
            sel.MtdSeleccionarReceta();
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
        public ActionResult RecetasDetalle(string Id_Usuario)
        {
            string cadena = string.Empty;
            WS_Catalogos_Receta sel = new WS_Catalogos_Receta();
            sel.Id_Usuario = Id_Usuario;
            sel.MtdSeleccionarRecetaDet();
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
        public ActionResult Fenologicos()
        {
            string cadena = string.Empty;
            CLS_Estado_Fenologico sel = new CLS_Estado_Fenologico();
           
            sel.MtdSeleccionarFenologicoSP();
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
        public ActionResult RH()
        {
            string cadena = string.Empty;
            WS_Catalogos_RecetaHuerta sel = new WS_Catalogos_RecetaHuerta();

            sel.MtdSeleccionarRecetaHuerta();
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
        public ActionResult ActividadesPoda()
        {
            string cadena = string.Empty;
            WS_Catalogos_cosactividad sel = new WS_Catalogos_cosactividad();

            sel.MtdSeleccionarActividad();
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
        public ActionResult ActivosGasolina(string Id_Usuario,string Fecha)
        {
            string cadena = string.Empty;
            WS_Catalogos_Activos_Gasolina sel = new WS_Catalogos_Activos_Gasolina();
            sel.Id_Usuario = Id_Usuario;
            sel.Fecha = Fecha;
            sel.MtdSeleccionarActivo();
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
        public ActionResult EmpleadosHuerta(string Id_Usuario)
        {
            string cadena = string.Empty;
            WS_Catalogos_empleados_huerta sel = new WS_Catalogos_empleados_huerta();
            sel.Id_Usuario = Id_Usuario;
            sel.MtdSeleccionarEmpleados();
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
        public ActionResult ActividadesHuerta(string Id_Usuario)
        {
            string cadena = string.Empty;
            WS_Catalogos_Actividades_Huerta sel = new WS_Catalogos_Actividades_Huerta();
            sel.Id_Usuario = Id_Usuario;
            sel.MtdSeleccionarActividades();
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
        public ActionResult ValvulasRiego()
        {
            string cadena = string.Empty;
            WS_Catalogos_ValvulasYCambio sel = new WS_Catalogos_ValvulasYCambio();
          
            sel.MtdSeleccionarValvulas();
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
        public ActionResult ValvulasDetRiego()
        {
            string cadena = string.Empty;
            WS_Catalogos_ValvulasYCambio sel = new WS_Catalogos_ValvulasYCambio();

            sel.MtdSeleccionarValvulasDet();
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
        public ActionResult CambiosRiego()
        {
            string cadena = string.Empty;
            WS_Catalogos_ValvulasYCambio sel = new WS_Catalogos_ValvulasYCambio();

            sel.MtdSeleccionarCambios();
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
