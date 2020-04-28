using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationTest.POM
{
    public class MainPageModel
    {
        public string mainLabelTagName = "h1";

        public string courseMenuButtonXpath= "/html/body/div[1]/div[1]/header/div/div[1]/nav/ul/li[1]/a";
        public string graduatesMenuButtonXpath = "/html/body/div[1]/div[1]/header/div/div[1]/nav/ul/li[2]/a";
        public string newsMenuButtonXpath = "/html/body/div[1]/div[1]/header/div/div[1]/nav/ul/li[3]/a";
        public string blogMenuButtonXpath = "/html/body/div[1]/div[1]/header/div/div[1]/nav/ul/li[4]/a";
        public string aboutMenuButtonXpath = "/html/body/div[1]/div[1]/header/div/div[1]/nav/ul/li[5]/a";
        public string contactsMenuButtonXpath = "/html/body/div[1]/div[1]/header/div/div[1]/nav/ul/li[6]/a";
        public string selectLanguageButtonXpath = "/html/body/div[1]/div[1]/header/div/div[1]/ul/li/button";

        public string onMapKievButtonXpath = "/ html / body / div[1] / main / section / div / div[2] / div / a[1] / span[2]";
    }
}
