using TechTalk.SpecFlow;
using System.Data.SqlClient;

[Binding]
public class HomeSteps
{
    HomePage _homePage = new HomePage();
    Helper _helper = new Helper();

    private ScenarioContext _scenarioContext;

    public HomeSteps(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }


    [Given(@"I am on the home page")]
    public void GoToHomePage()
    {
        _homePage.GoToHomePage();
        _helper.Log(_scenarioContext.ScenarioInfo.Title, "GoToHomePage", "HomePage is opened.", "1");
    }

    [When(@"I close the address focus on the home page")]
    public void CloseAdressFocus()
    {
        _homePage.CloseAdressFocus();
        _helper.Log(_scenarioContext.ScenarioInfo.Title, "CloseAdressFocus", "Adress section closed.", "1");
    }

    [When(@"I go to login page")]
    public void GoToLoginPage()
    {
        _homePage.GoToLoginPage();
        _helper.Log(_scenarioContext.ScenarioInfo.Title, "GoToLoginPage", "LoginPage is opened.", "1");
    }

    [Then(@"I should see My Account section")]
    public void CheckAccountSection()
    {
        _homePage.CheckAccountSection();
        _helper.Log(_scenarioContext.ScenarioInfo.Title, "CheckAccountSection", "Account section verified.", "1");
    }
}