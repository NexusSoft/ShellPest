using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml;

namespace Servicios_ShellPest
{
    /// <summary>
    /// Descripción breve de Servicios_ShellPest
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Servicios_ShellPest : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod(Description = "Saluda a la persona")]
        public string Saludar(string nombre)
        {
            return "Hola "+ nombre;
        }
        [WebMethod]
        public string GuardarLog(string mensaje)
        {
            Funciones.Logs("LogServicios", mensaje);
            return "Ok";
        }

        [WebMethod]
        public int Sumar(int numero_1, int numero_2)
        {
            int suma= numero_1+numero_2;
            return suma;
        }

        [WebMethod]
        public string[] ObtenerFruta()
        {
            string[] frutas = new string[3];
            frutas[0] = "Fresa";
            frutas[1] = "Limon";
            frutas[2] = "Melon";
            
            return frutas;
        }
        [WebMethod]
        public string GuardarFrutas( string[] frutas)
        {
            foreach(string fruta in frutas)
            {
                Funciones.Logs("Frutas", fruta);
            }
            return "Proceso realizado con exito";
        }

        [WebMethod]
        public List<Equipos> ObtenerEquipo()
        {
            List<Equipos> equipos = new List<Equipos>();
            equipos.Add(new Equipos { nombre = "Milan", pais = "Italia" });
            equipos.Add(new Equipos { nombre = "Ajax", pais = "Holanda" });

            return equipos;
        }

        [WebMethod]
        public string GuardarEquipos(Equipos[] equipos)
        {
            foreach (Equipos equipo in equipos)
            {
                Funciones.Logs("Equipos", equipo.nombre + " - " + equipo.pais);
            }
            return "Proceso realizado con exito";
        }

        [WebMethod]
        public string GuardarXML(string xml)
        {
            XmlDocument data_xml = new XmlDocument();

            data_xml.LoadXml(xml);
            XmlNode documento = data_xml.SelectSingleNode("documento");
            string deporte = documento["deporte"].InnerText;

            Funciones.Logs("XML", "Deporte: " + deporte + "; Equipos: ");

            XmlNodeList node_equipos = data_xml.GetElementsByTagName("equipos");
            XmlNodeList equipos = ((XmlElement)node_equipos[0]).GetElementsByTagName("equipo");

            foreach (XmlElement equipo in equipos)
            {
                string nombre = equipo.GetElementsByTagName("nombre")[0].InnerText;
                string pais = equipo.GetElementsByTagName("pais")[0].InnerText;

                Funciones.Logs("XML", nombre + " - " + pais);
            }
          
            return "Proceso realizado con exito";
        }

        [WebMethod]
        public string RetornarJson()
        {
            dynamic json = new Dictionary<string, dynamic>();
            json.Add("deporte", "futbol");

            List<Dictionary<string, string>> equipos = new List<Dictionary<string, string>>();

            Dictionary<string, string> equipo1 = new Dictionary<string, string>();
            equipo1.Add("nombre", "Manchester");
            equipo1.Add("pais", "Inglaterra");
            equipos.Add(equipo1);

            Dictionary<string, string> equipo2 = new Dictionary<string, string>();
            equipo2.Add("nombre", "Valencia");
            equipo2.Add("pais", "España");
            equipos.Add(equipo2);

            json.Add("equipos", equipos);

            return JsonConvert.SerializeObject(json);
        }

        [WebMethod]
        public string GuardarJson(string json)
        {
            var data_json = JsonConvert.DeserializeObject<DataJson>(json);

            Funciones.Logs("JSON", "Deporte: " + data_json.deporte + "; Equipos: ");
            foreach(var equipo in data_json.equipos)
            {
                Funciones.Logs("JSON", equipo.nombre + " - " + equipo.pais);
            }

            return "Hola a todos";
        }
    }
}
