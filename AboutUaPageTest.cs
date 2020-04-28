using DevEducationTest.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationTest
{
    public class AboutUsPageTest : BaseDriver
    {
        AboutUsPageModel aboutUsPageModel;

        public AboutUsPageTest()
        {
            aboutUsPageModel = new AboutUsPageModel();
        }
        [Test]
        public void CheckAbouUsLabel()
        {
            driver.Url = Urls.aboutUsPage;
            IWebElement aboutUsLabel = driver.FindElement(By.XPath(aboutUsPageModel.checkAboutUsLabelXpath));
            string actResult = aboutUsLabel.Text;
            Assert.AreEqual("О нас", actResult);
        }
    }
}
