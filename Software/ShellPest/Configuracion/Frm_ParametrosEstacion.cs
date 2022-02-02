using System;

using DevExpress.XtraEditors;
using CapaDeDatos;

namespace ShellPest
{
    public partial class Frm_ParametrosEstacion : DevExpress.XtraEditors.XtraForm
    {
        public Frm_ParametrosEstacion()
        {
            InitializeComponent();
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (spFilaInicio.Value > 0)
            {
                if (spFecha.Value > 0)
                {
                    if (spTempOut.Value > 0)
                    {
                        if (spET.Value > 0)
                        {
                            if (spRain.Value > 0)
                            {
                                CLS_ParametrosEstacion modparam = new CLS_ParametrosEstacion();
                                //Tab Carga Excel
                                modparam.Row_Est_Inicio = Convert.ToInt32(spFilaInicio.Value);
                                modparam.Col_Est_Fecha = Convert.ToInt32(spFecha.Value);
                                modparam.Col_Est_TempOut = Convert.ToInt32(spTempOut.Value);
                                modparam.Col_Est_ET = Convert.ToInt32(spET.Value);
                                modparam.Col_Est_Rain = Convert.ToInt32(spRain.Value);
                                modparam.MtdModificar();
                                if (modparam.Exito)
                                {
                                    XtraMessageBox.Show("Los Parametros fueron Cargados con Exito");
                                }
                                else
                                {
                                    XtraMessageBox.Show(modparam.Mensaje);
                                }
                            }
                            else
                            {
                                XtraMessageBox.Show("La columna de Rain debe ser mayor a 0");
                            }
                        }
                        else
                        {
                            XtraMessageBox.Show("La columna de ET debe ser mayor a 0");
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("La columna de Temp Out debe ser mayor a 0");
                    }
                }
                else
                {
                    XtraMessageBox.Show("La columna de Fecha debe ser mayor a 0");
                }
            }
            else
            {
                XtraMessageBox.Show("La fila de inico debe ser mayor a 0");
            }
        }

        private void CargarParametros()
        {
            CLS_ParametrosEstacion param = new CLS_ParametrosEstacion();
            param.MtdSeleccionar();
            if (param.Exito)
            {
                if (param.Datos.Rows.Count > 0)
                {
                    spFilaInicio.Value = Convert.ToInt32(param.Datos.Rows[0]["Row_Est_Inicio"].ToString());
                    spFecha.Value = Convert.ToInt32(param.Datos.Rows[0]["Col_Est_Fecha"].ToString());
                    spHora.Value = Convert.ToInt32(param.Datos.Rows[0]["Col_Est_Hora"].ToString());
                    spTempOut.Value = Convert.ToInt32(param.Datos.Rows[0]["Col_Est_TempOut"].ToString());
                    spET.Value = Convert.ToInt32(param.Datos.Rows[0]["Col_Est_ET"].ToString());
                    spRain.Value = Convert.ToInt32(param.Datos.Rows[0]["Col_Est_Rain"].ToString());
                }
            }
        }

        private void Frm_ParametrosEstacion_Shown(object sender, EventArgs e)
        {
            CargarParametros();
        }
    }
}