using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DevEducationTest
{
    public class BaseDriver
    {
        public IWebDriver driver;
    
        
        [SetUp]
        public void StartBrowser()
        {
            driver = new ChromeDriver("C:\\Users\\User\\Downloads\\");
            driver.Manage().Window.Maximize();
        }        

        [TearDown]
        public void CloseBrowser()
        {
            //Thread.Sleep(2000); //таймер на закрытие окна, не использовать
            driver.Close();
        }
    }
}
