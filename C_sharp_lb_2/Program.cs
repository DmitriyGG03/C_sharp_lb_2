using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using C_sharp_lb_2;
using Hostels;

public static class HostelExtension
{
    public static int AddCanteen(this Hostel hstl)
    {
        if (hstl == null)
        {
            return 1;
        }
        else if (!hstl.Canteen)
        {
            hstl.Canteen = true;
            hstl.StuffNumber += 5;
            hstl.CalcProfit();
            return 0;
        }
        else return 2;
    }
}


namespace C_sharp_lb_2
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());          
        }
    }
}
