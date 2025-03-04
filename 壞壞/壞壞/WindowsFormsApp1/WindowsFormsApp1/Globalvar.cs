using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Globalvar

    {
        public static string strDBConnectionString = "";
        public static bool is登入成功=false;
        public static int 使用者ID = 0;
        public static string CustomerName = "";
        public static string Name = "";
        public static string ID = "";
        public static string Password = "";
        public static int Manager = 0;
        public static int Price = 0;
        public static string Date = DateTime.Now.ToString();
        public static bool isLoggedIn { get; set; } = false;

        public static Form1 MainForm { get; set; }

        public static List<ArrayList> list購物車= new List<ArrayList>();  


    }

}
