using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SophiaFioriAutomation
{
    public class MainPage
    {
        public static bool IsAt
        {
            get
            {
                var mainPage = Driver.Instance.FindElement(By.Id("main-menu"));
                if (mainPage == null)
                    return false;
                else
                    return true;
            }
        }
    }
}
