﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Chrome;
using RaffleHouseAutomation.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleHouseAutomation.Helpers
{
    public class Browser
    {
        public IWebDriver WindowsDriver { get; set; }
        private static IWebDriver windowsDriver;


        public Browser(IWebDriver windowsDriver)
        {
            WindowsDriver = windowsDriver;
        }

        public static void Initialize(string application)
        {
            windowsDriver = new ChromeDriver();
            _Driver.Manage().Cookies.DeleteAllCookies();
            _Driver.Manage().Window.Maximize();
            
            Assert.NotNull(windowsDriver);
        }


        public static string RootPath()
        {
            string mainpath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\"));
            return mainpath;
        }
        public static ISearchContext Driver { get { return windowsDriver; } }
        public static IWebDriver _Driver { get { return windowsDriver; } }
        public static string Title
        {
            get { return windowsDriver.Title; }
        }

        public static string CurrentURL
        {
            get { return windowsDriver.Url; }
        }

        public static void Close()
        {
            windowsDriver.Close();
        }

        public static void Quit()
        {
            windowsDriver.Quit();
        }

        public static string RootPath1()
        {
            string currentPath = AppDomain.CurrentDomain.BaseDirectory;
            var directoryName = System.IO.Path.GetDirectoryName(currentPath);
            var directory = System.IO.Path.GetDirectoryName(directoryName);
            

            return currentPath;
        }


    }
}
