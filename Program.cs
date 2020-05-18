using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace KR
{
    class Program
    {
        const int N = 5;
        const int M = 6;
        static int[] GetInfo(int[] mas, int NM, string name)
        {
            Console.WriteLine("  Введите елементы масива " + name);
            for (int i = 0; i < NM; i++)
            {
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }
            return mas;
        }

        static void Culc_A(out double X, out double Y, out double Z, int[] ab)
        {
            double s = 0;
            X = 0; Y = 1; Z = 0;
            for (int i = 0; i < ab.Length; i++)
            {
                s += ab[i];
            }

            for (int i = 0; i < ab.Length; i++)
            {
                X += ab[i] * Math.Exp(ab[i]);
            }
            X *= s;

            for (int i = 0; i < ab.Length; i++)
            {
                Y *= ab[i] * Math.Cos(ab[i]);
            }

            for (int i = 0; i < ab.Length; i++)
            {
                Z += ab[i] * Math.Sin(ab[i]);
            }
            Z *= s;

        }
        static void Culc_B(out double X, out double Y, out double Z, int[] ab)
        {
            double s = 0;
            X = 0; Y = 1; Z = 0;
            for (int i = 0; i < ab.Length; i++)
            {
                s += ab[i];
            }

            for (int i = 0; i < ab.Length; i++)
            {
                X += ab[i] * Math.Sin(ab[i]);
            }
            X *= s;

            for (int i = 0; i < ab.Length; i++)
            {
                Y *= ab[i] * Math.Tan(ab[i]);
            }

            for (int i = 0; i < ab.Length; i++)
            {
                Z += ab[i] * Math.Abs(ab[i]);
            }
            Z *= s;

        }
        static void Main()
        {
            int[] a = new int[N];
            int[] b = new int[M];

            GetInfo(a, N, "A");
            GetInfo(b, M, "B");

            double A, B, C, D, E, F, s = 0;
            double Sigma = 0;
            Culc_A(out A, out B, out C, a);
            Culc_A(out D, out E, out F, b);
            Sigma = (A + B + Math.Sin(C)) / (D + E + Math.Cos(F));
            Console.WriteLine("  Result - " + Sigma);

        }
    }
}
