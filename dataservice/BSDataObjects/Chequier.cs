using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataService.BSDataObjects
{
    public class Chequier : MoyenPaiement
    {
        private int nombreCheque;
        private int numero1Cheque;
        private int dernierCheque;

        public int NombreCheque
        {
            get { return nombreCheque; }
            set { nombreCheque = value; }
        }
        

        public int Numero1Cheque
        {
            get { return numero1Cheque; }
            set { numero1Cheque = value; }
        }
        

        public int DernierCheque
        {
            get { return dernierCheque; }
            set { dernierCheque = value; }
        }
    }
}