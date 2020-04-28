using DevEducationTest.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationTest
{
    public class MainPageTest : BaseDriver
    {
        MainPageModel pageModel;
        CoursesPageModel coursesModel;
        KievPageModel kievPageModel;
        BlogPageModel blogPageModel;
        GraduatePageModel graduatePageModel;
        NewsPageModel newsPageModel;
        AboutUsPageModel aboutUsPageModel;
        ContactPageModel contactPageModel;
        LanguagePageModel languagePageModel;

        public MainPageTest()
        {
            pageModel = new MainPageModel();
            coursesModel = new CoursesPageModel();
            kievPageModel = new KievPageModel();
            blogPageModel = new BlogPageModel();
            graduatePageModel = new GraduatePageModel();
            newsPageModel = new NewsPageModel();
            aboutUsPageModel = new AboutUsPageModel();
            contactPageModel = new ContactPageModel();
            languagePageModel = new LanguagePageModel();
            //добавит страницы с проверками
        }
        [Test]
        public void CheckMainLabel()
        {
            driver.Url = Urls.mainPage;
            IWebElement mainLabel = driver.FindElement(By.TagName(pageModel.mainLabelTagName));
            string actResult = mainLabel.Text;
            Assert.AreEqual("Международный IT-колледж", actResult);
        }
        [Test]
        public void CheckCourses()
        {
            driver.Url = Urls.mainPage;
            IWebElement coursesButton = driver.FindElement(By.XPath(pageModel.courseMenuButtonXpath));
            coursesButton.Click();
            IWebElement ourCoursesLabel = driver.FindElement(By.TagName(coursesModel.ourCoursesLabelTagName));
            string actResult = ourCoursesLabel.Text;
            Assert.AreEqual("Наши курсы", actResult);
        }
        [Test]
        public void CheckKievOnMap()
        {
            driver.Url = Urls.mainPage;
            IWebElement mapKievButton = driver.FindElement(By.XPath(pageModel.onMapKievButtonXpath));
            mapKievButton.Click();
            IWebElement locationLabel = driver.FindElement(By.XPath(kievPageModel.locationXpath));
            string actResult = locationLabel.Text;
            Assert.AreEqual("Киев", actResult);
        }
        [Test]
        public void CheckBlog()
        {
            driver.Url = Urls.mainPage;
            IWebElement blogButton = driver.FindElement(By.XPath(pageModel.blogMenuButtonXpath));
            blogButton.Click();
            IWebElement ourBlogLabel = driver.FindElement(By.TagName(blogPageModel.blogMainLabaelTagName));
            string actResult = ourBlogLabel.Text;            
            Assert.AreEqual("Блог", actResult);

        }
        [Test]
        public void CheckGraduate()
        {
            driver.Url = Urls.mainPage;
            IWebElement graduatesButton = driver.FindElement(By.XPath(pageModel.graduatesMenuButtonXpath));
            graduatesButton.Click();
            IWebElement ourGraduates = driver.FindElement(By.TagName(graduatePageModel.checkGraduatesMainLabelTagName));
            string actResult = ourGraduates.Text;
            Assert.AreEqual("Наши выпускники", actResult);
        }
        [Test]
        public void CheckNews()
        {
            driver.Url = Urls.mainPage;
            IWebElement newsButton = driver.FindElement(By.XPath(pageModel.newsMenuButtonXpath));
            newsButton.Click();
            IWebElement ourNews = driver.FindElement(By.XPath(newsPageModel.checkNewsMainLabelXpath));
            string actResult = ourNews.Text;
            Assert.AreEqual("Новости", actResult);
        }
        [Test]
        public void CheckAboutUs()
        {
            driver.Url = Urls.mainPage;
            IWebElement aboutUsButton = driver.FindElement(By.XPath(pageModel.aboutMenuButtonXpath));
            aboutUsButton.Click();
            IWebElement ourAboutUs = driver.FindElement(By.XPath(aboutUsPageModel.checkAboutUsLabelXpath));
            string actResult = ourAboutUs.Text;
            Assert.AreEqual("О нас", actResult);
        }
        [Test]
        public void CheckContacts()
        {
            driver.Url = Urls.mainPage;
            IWebElement contactsButton = driver.FindElement(By.XPath(pageModel.contactsMenuButtonXpath));
            contactsButton.Click();
            IWebElement ourContacts = driver.FindElement(By.XPath(contactPageModel.checkContactsButtonXpath));
            string actResult = ourContacts.Text;
            Assert.AreEqual("Наши контакты", actResult);
        }
        [Test]
        public void CheckUaButton()
        {
            driver.Url = Urls.mainPage;
            IWebElement languageButton = driver.FindElement(By.XPath(pageModel.selectLanguageButtonXpath));
            languageButton.Click();
            IWebElement uaButton = driver.FindElement(By.XPath(languagePageModel.checkUaButtonXpath));
            uaButton.Click();
            IWebElement uaMainLabel = driver.FindElement(By.TagName(languagePageModel.uaPageMainLabelName));
            string actResult = uaMainLabel.Text;
            Assert.AreEqual("Міжнародний IT-коледж", actResult);
        }
        [Test]
        public void CheckEnButton()
        {
            driver.Url = Urls.mainPage;
            IWebElement languageButton = driver.FindElement(By.XPath(pageModel.selectLanguageButtonXpath));
            languageButton.Click();
            IWebElement enButton = driver.FindElement(By.XPath(languagePageModel.checkEnButtonXpath));
            enButton.Click();
            IWebElement enMainLabel = driver.FindElement(By.TagName(languagePageModel.enPageMainLabelName));
            string actResult = enMainLabel.Text;
            Assert.AreEqual("International IT College", actResult);
        }
        [Test]
        public void CheckAzButton()
        {
            driver.Url = Urls.mainPage;
            IWebElement languageButton = driver.FindElement(By.XPath(pageModel.selectLanguageButtonXpath));
            languageButton.Click();
            IWebElement azButton = driver.FindElement(By.XPath(languagePageModel.checkAzButtonXpath));
            azButton.Click();
            IWebElement azMainLabel = driver.FindElement(By.TagName(languagePageModel.azPageMainLabelName));
            string actResult = azMainLabel.Text;
            Assert.AreEqual("Beynəlxalq İT kolleci", actResult);
        }
    }    
}
