using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeDatos;

namespace ShellPest
{
    public partial class Frm_ImportarTxt : DevExpress.XtraEditors.XtraForm
    {
        public Frm_ImportarTxt()
        {
            InitializeComponent();
        }

        String fileContent = "";

        private void btn_SelArchivo_Click(object sender, EventArgs e)
        {
            
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    text_Ruta.Text = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            if (fileContent.Contains("t_Riego"))
            {
                label_Ventana.Text = "Riego";
            }
            else
            {
                if (fileContent.Contains("t_Monitoreo_PE_Encabezado"))
                {
                    label_Ventana.Text = "Monitoreo";
                }
                else
                {
                    label_Ventana.Text = "No reconocido";
                }
            }
            

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Importar_Click(object sender, EventArgs e)
        {
            if (label_Ventana.Text.Equals("No reconocido"))
            {
                XtraMessageBox.Show("EL ARCHIVO SELECCIONADO NO SE RECONOCE, FAVOR DE NOTIFICARLO A SISTEMAS");
            }
            else
            {
                if (label_Ventana.Text.Equals("Sin identificar"))
                {
                    XtraMessageBox.Show("NO SE A IDENTIFICADO UN ARCHIVO AUN,VUELVA A SELECCIONARLO DESDE EL BOTON [...]");
                }
                else
                {
                    CLS_ShellPest Clase = new CLS_ShellPest();
                    Clase.Comando = fileContent;
                    Clase.MtdInsertImportacionTxt();

                    if (Clase.Exito)
                    {
                        XtraMessageBox.Show("Se ha Insertado el registro con exito");
                    }
                    else
                    {
                        XtraMessageBox.Show(Clase.Mensaje);
                    }
                }
                    
            }
            
        }
    }
}