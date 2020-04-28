using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationTest
{
    public class BLogPageTest : BaseDriver
    {
        BlogPageModel blogPageModel;

        public BLogPageTest()
        {
            blogPageModel = new BlogPageModel();            
        }
        [Test]
        public void CheckBlogLabel()
        {
            driver.Url = Urls.blogPage;
            IWebElement blogLabel = driver.FindElement(By.TagName(blogPageModel.blogMainLabaelTagName));
            string actResult = blogLabel.Text;
            Assert.AreEqual("Блог", actResult);
        }
    }
}
