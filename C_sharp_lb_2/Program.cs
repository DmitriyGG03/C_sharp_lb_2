using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using C_sharp_lb_2;
using Hostels;



public static class HostelExtension
{
    public static bool AddCanteen(this Hostel hstl)
    {
        if (!hstl.Canteen)
        {
            hstl.Canteen = true;
            hstl.StuffNumber += 5;
            hstl.CalcProfit();
            return true;
        }
        else return false;
    }
}

public static class Extensions
{
    public static bool find<T>(this List<T> list, T target) {
        return list.Contains(target);
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
