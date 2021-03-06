﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enigma
{
    public static class Program
    {

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Enigma());
        }

        public static int GetRot(int r, int number)
        {
            int[] rot1 = { 8, 3, 2, 6, 9, 0, 1, 4, 5, 7 };
            int[] rot2 = { 4, 8, 1, 3, 9, 0, 2, 5, 6, 7 };
            int[] rot3 = { 14, 1, 6, 2, 8, 2, 4, 5, 2, 10 };

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

        public static int Roters2(int r2, int r3)
        {

            if (r3 == 0)
            {
                if (r2 == 9)
                {
                    r2 = 0;
                }
                else
                {
                    r2 = r2 + 1;
                }
            }


            return r2;

        }

        public static int Roters1(int r1, int r2, int r3)
        {
            if ((r2 == 0) && (r3 == 0))
            {
                if (r1 == 9)
                {
                    r1 = 0;
                }
                else
                {
                    r1 = r1 + 1;
                }
            }

            return r1;

        }
        public static string[] alphabet = { "А", "Б", "В", "Г", "Д", "Е", "Ё", "Ж", "З", "И", "Й", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "У", "Ф", "Х", "Ц", "Ч", "Ш", "Щ", "Ъ", "Ы", "Ь", "Э", "Ю", "Я" };

        public static string Coding(int a, int shift)
        {
            a += shift;
            while (a > 32)
            {
                a -= 33;
            }
          
            return alphabet[a];
        }

        public static string Decoding(int a, int shift)
        {
            a -= shift;
            while (a < 0)
            {
                a += 33;
            }

            return alphabet[a];
        }
    }
}
