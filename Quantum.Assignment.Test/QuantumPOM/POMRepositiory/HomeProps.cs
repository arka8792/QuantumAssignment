﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumPOM.POMRepositiory
{
    public class HomeProps
    {
        public static string Search = "search-text";
        public By SearchBox = By.Id(Search);

        public static string CloseAd = "my-text";
        public By CloseButton = By.Id(CloseAd);

        public static string CovidLink = "PCRTDisplay";
        public By Link = By.Id(CovidLink);

        public static string MoreMenu = "widgetbar";
        public By Menu = By.Id(MoreMenu);

        
        public static string VaccinationCenter = "VaccinationDisplay";
        public By Center = By.Id(VaccinationCenter);

        public static string EssentialAmenities = "EssDisplay";
        public By Amenities = By.Id(EssentialAmenities);

        public static string MenuItems = "//span[@class='topView_text']";
        public By MenuItemsBy = By.XPath(MenuItems);
    }
}