using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QuantumPOM.POMRepositiory
{
    public class HomePage
    {
        public HomeProps Property { get; set; }

        private List<string> expectedList = new List<string>
        {
            "Vaccination Centres","COVID-19 Test Providers", "Nearby Parks",
            "Essential Amenities (2km)", "SchoolQuery", "PHPC near you",
            "LandQuery","DroneQuery","TrafficQuery", "PropertyQuery",
            "PopulationQuery","Nearby","BizQuery","Bus Explorer",
            "Basemaps","Gallery"
        };

        private string expectedLinkText = "https://www.moh.gov.sg/licensing-and-regulation/regulations-guidelines-and-circulars/details/list-of-covid-19-swab-providers";


        private string expectedVaccinationLink = "https://www.vaccine.gov.sg/";


        private string expectedCardTitle = "ABC WATERS @ KALLANG RIVER";

        private List<string> expecteddataList = new List<string>
        {
            "Hawker Centres and NEA Markets","Supermarkets","PHPCs","Retail Pharmacy Locations",
            "Bank Branches","ATMs","DBS ATMs","OCBC ATMs","Convenience Stores","Post Offices",
            "Social Service Offices","Food Establishments","Hair Cuts","Optical Shops","Telcos"
        };

        public HomePage()
        {
            Property = new HomeProps();
        }

        public bool ValidateMenu(IWebDriver driver)
        {
            driver.FindElement(Property.CloseButton).Click();
            driver.FindElement(Property.Menu).Click();

            var menuItems = driver.FindElements(Property.MenuItemsBy);
            var menuItemTexts = new List<string>();

            foreach (var item in menuItems)
            {
                menuItemTexts.Add(item.Text);
            }

            menuItemTexts = menuItemTexts.Where(s => !string.IsNullOrWhiteSpace(s)).Distinct().ToList();

            var isEqual = menuItemTexts.SequenceEqual(expectedList);

            return isEqual;
        }
        public bool ValidateLinkText(IWebDriver driver)
        {
            driver.FindElement(Property.CloseButton).Click();
            driver.FindElement(Property.Link).Click();

            Thread.Sleep(1000);
            var CovidMessageLink = driver.FindElement(Property.CovidMessageLinkBy);
            var CovidMessageLinkText = CovidMessageLink.Text.Trim();

            var isEqual = CovidMessageLinkText.Equals(expectedLinkText);

            return isEqual;
        }

        public bool validateVaccinationLink(IWebDriver driver)
        {
            driver.FindElement(Property.CloseButton).Click();
            driver.FindElement(Property.Center).Click();

            Thread.Sleep(2000);

            var VaccinationCenterLinks = driver.FindElement(Property.VaccinationCenterLinkBy);
            var VaccinationCenterLinkText = VaccinationCenterLinks.GetAttribute("href");

            var isEqual = VaccinationCenterLinkText.Equals(expectedVaccinationLink);

            return isEqual;
        }

        public bool ValidateSearchText(IWebDriver driver)
        {
            driver.FindElement(Property.CloseButton).Click();
            driver.FindElement(Property.SearchBox).SendKeys("ABC WATERS @ KALLANG RIVER");
            driver.FindElement(Property.SearchBox).SendKeys(Keys.Enter);

            Thread.Sleep(3000);
            var CardTitle = driver.FindElement(Property.CardTitleBy);
            var CardTitleText = CardTitle.Text.Trim();

            var isEqual = CardTitleText.Equals(expectedCardTitle);

            return isEqual;
        }

        public bool validateAmenities(IWebDriver driver)
        {
            driver.FindElement(Property.CloseButton).Click();
            driver.FindElement(Property.Amenities).Click();
            Thread.Sleep(1000);

            driver.FindElement(Property.ConfirmationCardBy).Click();

            Thread.Sleep(2000);

            var IndividualTab = driver.FindElements(Property.IndividualTabBy);
            var IndividualTabList = new List<string>();

            foreach (var item in IndividualTab)
            {
                IndividualTabList.Add(item.Text);
            }

            IndividualTabList = IndividualTabList.Where(s => !string.IsNullOrWhiteSpace(s)).Distinct().ToList();

            var isEqual = IndividualTabList.Intersect(expecteddataList).Count() == IndividualTabList.Count();

            return isEqual;
        }
            
    }
}
