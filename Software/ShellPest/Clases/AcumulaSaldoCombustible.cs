using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellPest
{

    internal class AcumulaSaldoCombustible
    {
        public  string Id_Huerta { get; set; }
        public string TipoGas { get; set; }
        public double Saldo { get; set; }
        public int Linea { get; set; }

        public string getHuerta()
        {
            return Id_Huerta;
        }

        public double getSaldo()
        {
            return Saldo;
        }

        public string getTipoGas()
        {
            return TipoGas;
        }

        public int getLinea()
        {
            return Linea;
        }

        public void updateSaldo(double saldo)
        {
            this.Saldo = saldo;
        }
       
    }
}
