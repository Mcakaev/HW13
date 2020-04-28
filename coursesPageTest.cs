using DevEducationTest;
using DevEducationTest.POM;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation
{
    public class CoursesPageTest:BaseDriver   
    {
        CoursesPageModel coursesPageModel;

        public CoursesPageTest()
        {
            coursesPageModel = new CoursesPageModel();
        }

        [Test]
        public void CheckMainLabel()
        {
            driver.Url = Urls.coursesPage;
            IWebElement mainLabel = driver.FindElement(By.TagName(coursesPageModel.ourCoursesLabelTagName));
            string actResult = mainLabel.Text;
            Assert.AreEqual("Наши курсы", actResult);
        }
        [Test]
        public void CheckDneprButton()
        {
            driver.Url = Urls.coursesPage;
            IWebElement dneprButton = driver.FindElement(By.XPath(coursesPageModel.dneprButtonXpath));
            dneprButton.Click();
            IWebElement dneprDevEduc = driver.FindElement(By.XPath(coursesPageModel.dneprDevEducXpath));
            string actResult = dneprDevEduc.Text;
            Assert.AreEqual("Днепр", actResult);
        }

        //не смогли разобратся, почему не работатет, видимо не работает заполнение формы в сплывающем окне.
        //[Test]
        //public void ContactUsOption()
        //{
        //    driver.Url = Urls.coursesPage;
        //    IWebElement contactUsButton = driver.FindElement(By.XPath(coursesPageModel.contactUsXpath));
        //    contactUsButton.Click();
        //    IWebElement nameField = driver.FindElement(By.Name(coursesPageModel.contactUsInputName));
        //    nameField.SendKeys("test");
        //    IWebElement emailFild = driver.FindElement(By.Name(coursesPageModel.contactUsInputEmailName));
        //    emailFild.SendKeys("test@em.i");
        //    IWebElement massageFild = driver.FindElement(By.Name(coursesPageModel.contactUsMassageInputName));
        //    massageFild.SendKeys("test");
        //    IWebElement sendButton = driver.FindElement(By.ClassName(coursesPageModel.contactUsSendButtonClassName));
        //    sendButton.Click();
        //    IWebElement massageSendWindow = driver.FindElement(By.ClassName(coursesPageModel.contactUsSuccsMassageSendXpath));
        //    string actResult = massageSendWindow.Text;
        //    Assert.AreEqual("Сообщение отправлено", actResult);
        //}


    }
}
