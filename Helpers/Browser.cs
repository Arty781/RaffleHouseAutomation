/*using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleHouseTests
{
   public class Browser
    {
        public IWebDriver WebDriver { get; set; }
        *//*public static IWebDriver webDriver = new ChromeDriver();*//*
        public WindowsDriver<WindowsElement> WindowsDriver { get; set; }
        private static WindowsDriver<WindowsElement> windowsDriver;




        public Browser(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }
        public Browser(WindowsDriver<WindowsElement> windowsDriver)
        {
            WindowsDriver = windowsDriver;
        }


        *//*public static void Initialize()
        {
            
            webDriver.Manage().Cookies.DeleteAllCookies();
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl("https://staging.rafflehouse.com/");

            
        }*//*

        public static void Initialize(string application)
        {
            AppiumOptions options = new();
            options.AddAdditionalCapability("app", application);
            options.AddAdditionalCapability("deviceName", "WindowsPC");
            options.AddAdditionalCapability("ms:waitForAppLaunch", 3);
            windowsDriver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723/"), options);
            Assert.NotNull(windowsDriver);
            windowsDriver.Manage().Window.Maximize();
        }


        public static string RootPath()
        {
            string mainpath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\"));
            return mainpath;
        }
        public static ISearchContext Driver { get { return windowsDriver; } }
        public static WindowsDriver<WindowsElement> _Driver { get { return windowsDriver; } }
        *//*public static string Title
        {
            get { return webDriver.Title; }
        }

        public static string CurrentURL
        {
            get { return webDriver.Url; }
        }

        public static ISearchContext Driver
        {
            get { return webDriver; }
        }

        public static IWebDriver _Driver
        {
            get { return webDriver; }
        }

        public static void Close()
        {
            webDriver.Close();
        }

        public static void Quit()
        {
            webDriver.Quit();
        }*//*

        public static string RootPath1()
        {
            string currentPath = AppDomain.CurrentDomain.BaseDirectory;
            var directoryName = System.IO.Path.GetDirectoryName(currentPath);
            var directory = System.IO.Path.GetDirectoryName(directoryName);
            var mainpath = directory.Replace("\\bin\\Debug", "");

            return mainpath;
        }


    }
}
*/