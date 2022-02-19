using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

[Binding]
public class LoginSteps
{
    LoginPage _loginPage = new LoginPage();
    Helper _helper = new Helper();
    private ScenarioContext _scenarioContext;

    public LoginSteps(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    [When(@"I logged in with the following data:")]
    public void Login(Table table)
    {
        var user = table.CreateInstance<(string mail, string password)>();
        _loginPage.Login(user.mail, user.password);

        _helper.Log(_scenarioContext.ScenarioInfo.Title, "Login", "Successfully logged in.", "1");

    }

    [When(@"I click the Guest Checkout")]
    public void ClickTheGuestCheckout()
    {
        _loginPage.ClickTheGuestCheckout();

        _helper.Log(_scenarioContext.ScenarioInfo.Title, "ClickTheGuestCheckout", "Guest checkout button clicked.", "1");

    }
}