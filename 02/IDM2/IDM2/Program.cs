using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using IDM2.BaseDonnee;
using IDM2.Controleur;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Text.RegularExpressions;

namespace IDM2
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Controller.MiseAJour();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPrincipal());
        }

    }
}
