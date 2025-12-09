using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_09
{
    internal class Program
    {
        /// <summary>
        /// Programa que per retornar la compra per ser rica en colesterol, o bé fem la la compra finalment.
        /// Si fem la compra, informar de l'import total i en cas que hagi aparegut només un producte ric en
        /// colesterol, informar-ne quin és. Si no n'ha aparegut cap, cal donar el missatge "COMPRA SANA".
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const string FILENAME = "TIQUET.TXT";
            StreamReader sRNumeros = new StreamReader(FILENAME);

            const string MF = null;
            string linia;
            int valor;

            linia = sRNumeros.ReadLine();
        }
    }
}
