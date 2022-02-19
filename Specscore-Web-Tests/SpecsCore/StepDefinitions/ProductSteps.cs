using TechTalk.SpecFlow;

[Binding]
public class ProductSteps
{
    ProductPage _productPage = new ProductPage();
    Helper _helper = new Helper();
    private ScenarioContext _scenarioContext;

    public ProductSteps(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }
    [Given(@"I open the '(.*)' url")]
    public void OpenTheUrl(string searchKey)
    {
        _helper.GoToUrl(searchKey);
        _helper.Log(_scenarioContext.ScenarioInfo.Title, "OpenTheUrl", "URL successfully opened.", "1");

    }

    [When(@"I add product to basket")]
    public void AddProductToBasket()
    {
        _productPage.AddProductToBasket();
        _helper.Log(_scenarioContext.ScenarioInfo.Title, "AddProductToBasket", "The product has been added to the basket.", "1");

    }

    [When(@"I select the delivery time and click the add to cart button")]
    public void DeliveryTimeAndAddToCard()
    {
        _productPage.DeliveryTimeAndAddToCard();
        _helper.Log(_scenarioContext.ScenarioInfo.Title, "DeliveryTimeAndAddToCard", "Delivery time selected and added to basket.", "1");

    }
}