using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptography
{
    internal static class Program
    {
        //algorithms keys
        public static int cuserkey;
        public static string monokey;
        public static char[,] homokey;
        public static char[,] playkey;
        public static int raikey;
        public static string colukey;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            cuserkey=3;
            monokey = "zebra";
            homokey = new char[26,11] {
            { 'D', '9', '_', '_', '_', '_','_','_','_','_','_'},
            { 'X', '_', '_', '_', '_', '_','_','_','_','_','_'},
            { 'S', '_', '_', '_', '_', '_','_','_','_','_','_'},
            { 'F', '_', '_', '_', '_', '_','_','_','_','_','_'},
            { 'Z', '7', '2', '1','_', '_','_','_','_','_' ,'_'},
            { 'E', '_', '_', '_', '_', '_','_','_','_','_','_'},
            { 'H', '_', '_', '_', '_', '_','_','_','_','_','_'},
            { 'C', '_', '_', '_', '_', '_','_','_','_','_','_'},
            { 'V', '3', '_', '_', '_', '_','_','_','_','_','_'},
            { 'I', '_', '_', '_', '_', '_','_','_','_','_','_'},
            { 'T', '_', '_', '_', '_', '_','_','_','_','_','_'},
            { 'P', '_', '_', '_', '_', '_','_','_','_','_','_'},
            { 'G', '_', '_', '_', '_', '_','_','_','_','_','_'},
            { 'A', '5', '_', '_', '_', '_','_','_','_','_','_'},
            { 'Q', '0', '_', '_', '_', '_','_','_','_','_','_'},
            { 'L', '_', '_', '_', '_', '_','_','_','_','_','_'},
            { 'K', '_', '_', '_', '_', '_','_','_','_','_','_'},
            { 'J', '_', '_', '_', '_', '_','_','_','_','_','_'},
            { 'R', '4', '_', '_', '_', '_','_','_','_','_','_'},
            { 'U', '6', '_', '_', '_', '_','_','_','_','_','_'},
            { 'O', '_', '_', '_', '_', '_','_','_','_','_','_'},
            { 'W', '_', '_', '_', '_', '_','_','_','_','_','_'},
            { 'M', '_', '_', '_', '_', '_','_','_','_','_','_'},
            { 'Y', '_', '_', '_', '_', '_','_','_','_','_','_'},
            { 'B', '_', '_', '_', '_', '_','_','_','_','_','_'},
            { 'N', '_', '_', '_', '_', '_','_','_','_','_','_'},
            };
            playkey = new char[5,5];
            raikey = 2;
            colukey = "CAT";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BaseFrm());
        }


    }
}
