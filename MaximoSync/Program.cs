using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaximoSync
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static void NumeroInteiro(KeyPressEventArgs e)
        {
            //Verifica se é digíto e abilita o backspace, se tiver algo digitado no campo.
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
