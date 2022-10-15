using System.Runtime.InteropServices;

namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
        public static String Task24(double a, double b)
        {
            if (a*b <= 0)
            {
                return Convert.ToString(a * b);
            }
            else
            {
                return a * a + " " + b * b;
            }
        }
        public static String Task27(double x, double y, double z)
        {
            if (Math.Abs(x) > Math.Abs(y))
            {
                if (Math.Abs(x) > Math.Abs(z))
                    return Convert.ToString(x);
                else return Convert.ToString(z);
            }
            else if (Math.Abs(y) > Math.Abs(z))
            {
                return Convert.ToString(y);
            }
            else return Convert.ToString(z);

        }
        public static String Task30(double a1, double b1, double a2, double b2, double R)
        {
            double r1 = Math.Sqrt(Math.Pow(a1, 2) + Math.Pow(b1, 2));
            double r2 = Math.Sqrt(Math.Pow(a2, 2) + Math.Pow(b2, 2));
            if (r1 < R && r2 < R)
                return "C и D принадлежат кругу R";
            if (r1 < R)
                return "C принадлежит кругу R";
            if (r2 < R)
                return "D принадлежит кругу R";
            else
                return "Такой точки нет";
        }
        public static String Task2(double x, double y, double z)
        {
            return Convert.ToString(Math.Min(Math.Min(x, y), z));
        }
        public static String Task6(double a, double b, double c)
        {
            if (a<b && b<c)
                return Convert.ToString(b+c);
            else
                return Convert.ToString(c-b);
        }
    }
}