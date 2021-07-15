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
        public  bool ValidateLinkText(IWebDriver driver)
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

       
    }
}
