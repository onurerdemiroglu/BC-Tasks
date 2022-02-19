using TechTalk.SpecFlow;

[Binding]
public class MenuSteps
{
    MenuPage _menuPage = new MenuPage();
    Helper _helper = new Helper();
    private ScenarioContext _scenarioContext;

    public MenuSteps(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    [Then(@"I scrolling down to page (.*) and check see (.*) products displayed per page")]
    public void ScrollToDownPage(int pageNumber, int perPageProduct)
    {
        _menuPage.DownPage(pageNumber, perPageProduct);

        _helper.Log(_scenarioContext.ScenarioInfo.Title, "ScrollToDownPage", "Scrolled to the desired page.", "1");
    }

    [When(@"I sort result list based on (.*)")]
    public void SortResult(string sortCriterion)
    {
        _menuPage.SortByCriteria(sortCriterion);

        _helper.Log(_scenarioContext.ScenarioInfo.Title, "SortResult", "Sort criterion successful.", "1");
    }

    [When(@"I scroll to the end of the page")]
    public void ScrollToLastPage()
    {
        _menuPage.ScrollToLastPage();

        _helper.Log(_scenarioContext.ScenarioInfo.Title, "ScrollToLastPage", "Scrolled to last page.", "1");
    }

    [Then(@"I should see the prices listed from high to low")]
    public void PricesShouldBeListedHighToLow()
    {
        _menuPage.VerifiyHighToLow();
        _helper.Log(_scenarioContext.ScenarioInfo.Title, "PricesShouldBeListedHighToLow", "Successfully sorted from high to low.", "1");

    }

    [When(@"I choose shipping address '(.*)'")]
    public void IChooseShippingAddress(string address)
    {
        _menuPage.ChooseAdress(address);
        _helper.Log(_scenarioContext.ScenarioInfo.Title, "IChooseShippingAddress", "Shipping address selected.", "1");

    }

    [When(@"I open the first product page")]
    public void OpenFirstProductPage()
    {
        _menuPage.OpenFirstProductPage();
        _helper.Log(_scenarioContext.ScenarioInfo.Title, "OpenFirstProductPage", "The first product page is opened.", "1");
    }

    [When(@"I find all the links under the menu")]
    public void FindMenuLinks()
    {
        _menuPage.FindMenuLinks();
        _helper.Log(_scenarioContext.ScenarioInfo.Title, "FindMenuLinks", "Hovered over all links in the menu.", "1");
    }

    [Then(@"I should see the links are not broken")]
    public void VerifyLinks()
    {
        _menuPage.VerifyLinks();
        _helper.Log(_scenarioContext.ScenarioInfo.Title, "FindMenuLinks", "Hovered over all links in the menu.", "1");
    }
}