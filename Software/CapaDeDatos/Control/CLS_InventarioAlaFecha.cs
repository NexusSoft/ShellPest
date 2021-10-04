using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_InventarioAlaFecha : ConexionBase
    {

        public string Fecha, Empresa, FamIni, FamFin, SubIni, SubFin, IncluyeCero;

        public CLS_InventarioAlaFecha(string Fecha, string Empresa, string FamIni, string FamFin, string SubIni, string SubFin, string IncluyeCero)
        {
            this.Fecha = Fecha;
            this.Empresa = Empresa;
            this.FamIni = FamIni;
            this.FamFin = FamFin;
            this.SubIni = SubIni;
            this.SubFin = SubFin;
            this.IncluyeCero = IncluyeCero;

            MtdInventarioAlaFechaSelect();
        }

        public void MtdInventarioAlaFechaSelect()
        {
           
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Rpt_InventarioAlaFecha";
                _dato.CadenaTexto = Fecha;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha");
                _dato.CadenaTexto = Empresa;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Empresa");
                _dato.CadenaTexto = FamIni;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "FamIni");
                _dato.CadenaTexto = FamFin;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "FamFin");
                _dato.CadenaTexto = SubIni;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "SubIni");
                _dato.CadenaTexto = SubFin;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "SubFin");
                _dato.CadenaTexto = IncluyeCero;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "IncluyeCero");
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
