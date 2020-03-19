﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Ecom_framework.ComponentHelper;
using Ecom_framework.BaseClasses;
using SeleniumExtras.PageObjects;
using Ecom_framework.Configuration;
namespace Ecom_framework.TestScript
{
    [TestClass]
   public class test
    {
        AppConfigReader obj = new AppConfigReader();
        private static IWebDriver driver;
        public test()
        {
            driver = BaseClass.driver;
            PageFactory.InitElements(driver, this);
        }
 

        [FindsBy(How = How.LinkText, Using = "SwitchTo")]
        private IWebElement SwitchTo { get; set; }

        

        [TestMethod]
       public void Alert_with_ok()
        {
            string URL = obj.GetWebsite();
            NavigationHelper.NavigateToUrl(URL);
            BrowserHelper.BrowserMaximize();
            Mouseoverhelper.Domouseover(By.LinkText("SwitchTo"));
            LinkHelper.ClickLink(By.LinkText("Alerts"));
            LinkHelper.ClickLink(By.XPath("//*[@id='OKTab']/button"));
            Alerthelper.SwitchtoAlert();



        }
        [TestMethod]
        public void Alert_with_ok_cancel()
        {
            string URL = obj.GetWebsite();
            NavigationHelper.NavigateToUrl(URL);
            BrowserHelper.BrowserMaximize();
            Mouseoverhelper.Domouseover(By.LinkText("SwitchTo"));
            LinkHelper.ClickLink(By.LinkText("Alerts"));
            LinkHelper.ClickLink(By.XPath("//a[contains(text(),'Alert with OK & Cancel ')]"));
            LinkHelper.ClickLink(By.XPath("//button[contains(text(),'click the button to display a confirm box ')]"));
            Alerthelper.CancelAlert();
        }
        [TestMethod]
        public void switchtowindow()
        {
            string URL = obj.GetWebsite();
            NavigationHelper.NavigateToUrl(URL);
            BrowserHelper.BrowserMaximize();
            Mouseoverhelper.Domouseover(By.LinkText("SwitchTo"));
            LinkHelper.ClickLink(By.LinkText("Windows"));
            LinkHelper.ClickLink(By.XPath("//a[contains(text(),'Open New Seperate Windows')]"));
            LinkHelper.ClickLink(By.XPath("//*[@id='Seperate']/button"));
            BrowserHelper.SwitchToWindowLast();
            BrowserHelper.SwitchToWindowfirst();


        }
        [TestMethod]
        public void switchtofrmae()
        {
            string URL = obj.GetWebsite();
            NavigationHelper.NavigateToUrl(URL);
            BrowserHelper.BrowserMaximize();
            Mouseoverhelper.Domouseover(By.LinkText("SwitchTo"));
            LinkHelper.ClickLink(By.LinkText("Frames"));
            BrowserHelper.waitforsec();
            BrowserHelper.SwitchToFrame(By.Id("singleframe"));
            TextBoxHelper.TypeInTextBox(By.XPath("//div[@class='col-xs-6 col-xs-offset-5']//input"), "Hi");





        }
        
    }
}