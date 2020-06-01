using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enigma
{
    static class Program
    {

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static int GetRot(int r, int number)
        {
            int[] rot1 = new int[10] { 8, 3, 2, 6, 9, 0, 1, 4, 5, 7 };
            int[] rot2 = new int[10] { 4, 8, 1, 3, 9, 0, 2, 5, 6, 7 };
            int[] rot3 = new int[10] { 14, 1, 6, 2, 8, 2, 4, 5, 2, 10 };

            switch (r)
            {
                case 1:
                    return rot1[number];
                case 2:
                    return rot2[number];
                case 3:
                    return rot3[number];
                default:
                    return 0;
            }
        }

        public static int Roters3(int r3)
        {
            if (r3 == 9)
            {
                r3 = 0;
            }
            else r3 = r3 + 1;
            return r3;

        }


    }
}
