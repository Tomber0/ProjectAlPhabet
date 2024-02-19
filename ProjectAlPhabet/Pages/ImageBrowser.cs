using OpenQA.Selenium;

namespace ProjectAlPhabet.Pages
{
    internal class ImageBrowser
    {
        private By _pageLocator = By.Id("pagesGrid");
        private By _pictureGrid = By.Id("pagesGrid");
        private By _chosenPic = By.Id("pagesGrid");

        public void ClickOnImage(string pic) 
        {
            //_chosenPic => pic
            //driver.FindElement(By.ClassName("AddContentBTN")).Click();
        }

        public List<bool> ListOfImages { 
            get 
            {
                return null;
            }
        } 

    }
}
