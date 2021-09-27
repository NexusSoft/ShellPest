using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class WS_Control_Salidas : ConexionBase
    {

        public string c_codigo_sal { get; set; }
        public string c_codigo_ent { get; set; }
        public string c_codigo_tmv { get; set; }
        public string c_codigo_tra { get; set; }
        public string d_documento_sal { get; set; }
        public string c_codigo_alm { get; set; }
        public string c_codigo_eps { get; set; }
        public string Id_Responsable { get; set; }
        public string Id_Aplicacion { get; set; }
        public string Id_Usuario { get; set; }
        public string F_Creacion { get; set; }


        public string c_tipodoc_mov { get; set; }
        public string c_coddoc_mov { get; set; }
        public string c_codigo_pro { get; set; }
        public string n_movipro_mov { get; set; }
        public string n_exiant_mov { get; set; }
        public string n_cantidad_mov { get; set; }
        public string Id_Bloque { get; set; }

        public void MtdInsertarSalida()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {


                _conexion.NombreProcedimiento = "SP_Salida_Insert";
                _dato.CadenaTexto = c_codigo_sal;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_sal");
                _dato.CadenaTexto = c_codigo_ent;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_ent");
                _dato.CadenaTexto = c_codigo_tmv;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_tmv");
                _dato.CadenaTexto = c_codigo_tra;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_tra");
                _dato.CadenaTexto = d_documento_sal;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "d_documento_sal");
                _dato.CadenaTexto = c_codigo_alm;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_alm");
                _dato.CadenaTexto = c_codigo_eps;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_eps");
                _dato.CadenaTexto = Id_Responsable;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Responsable");
                _dato.CadenaTexto = Id_Aplicacion;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Aplicacion");
                _dato.CadenaTexto = Id_Usuario;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Usuario");
                _dato.CadenaTexto = F_Creacion;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "F_Creacion");
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

        public void MtdInsertarSalida_Det()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Salidas_Det_Insert";
                _dato.CadenaTexto = c_tipodoc_mov;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_tipodoc_mov");
                _dato.CadenaTexto = c_coddoc_mov;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_coddoc_mov");
                _dato.CadenaTexto = c_codigo_pro;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_pro");
                _dato.CadenaTexto = n_movipro_mov;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "n_movipro_mov");
                _dato.CadenaTexto = n_exiant_mov;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "n_exiant_mov");
                _dato.CadenaTexto = n_cantidad_mov;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "n_cantidad_mov");
                _dato.CadenaTexto = Id_Bloque;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Bloque");
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
