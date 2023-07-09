using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JetShooter
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 form1 = new Form1();

            Application.Run(form1);
            //if (!form1.)
            //{
                GameForm form2 = new GameForm(form1.sizeSkin, form1.choosenSkin, 0, form1.Hardness);
                form2.ShowDialog();
                //if (!form2.IsFormClosing) 
                //{
                    //GameOver form3 = new GameOver();
                    //form3.ShowDialog(); 
                //}
            //}

            //Application.Exit();
        }
    }
}
