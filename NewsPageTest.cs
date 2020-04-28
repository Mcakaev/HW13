using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationTest
{
    public class NewsPageTest : BaseDriver
    {
        NewsPageModel newsPageModel;

        public NewsPageTest()
        {
            newsPageModel = new NewsPageModel();
        }

        [Test]
        public void CheckMainLabel()
        {
            driver.Url = Urls.newsPage;
            IWebElement newsMainLabe = driver.FindElement(By.TagName(newsPageModel.checkNewsMainLabelXpath));
            string actResult = newsMainLabe.Text;
            Assert.AreEqual("Новости", actResult);
        }        
    }

}
