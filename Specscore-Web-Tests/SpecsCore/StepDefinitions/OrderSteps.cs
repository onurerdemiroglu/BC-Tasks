using TechTalk.SpecFlow;

[Binding]
public class OrderSteps
{
    OrderPage _orderPage = new OrderPage();
    Helper _helper = new Helper();
    private ScenarioContext _scenarioContext;

    public OrderSteps(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    [When(@"I fill out the order information form")]
    public void FillOrderInformationForm()
    {
        _orderPage.FillOrderInformationForm();
        _helper.Log(_scenarioContext.ScenarioInfo.Title, "FillOrderInformationForm", "Order Information Form completed successfully.", "1");

    }

    [When(@"I fill out the sender information form")]
    public void FillSenderInformationForm()
    {
        _orderPage.FillSenderInformationForm();
        _helper.Log(_scenarioContext.ScenarioInfo.Title, "FillSenderInformationForm", "Sender Information Form completed successfully.", "1");

    }

    [When(@"I fill out the payment form")]
    public void FillPaymentForm()
    {
        _orderPage.FillPaymentForm();
        _helper.Log(_scenarioContext.ScenarioInfo.Title, "FillPaymentForm", "Payment Form completed successfully.", "1");

    }

    [Then(@"I should see the message we received your order")]
    public void VerifyReceivedOrder()
    {
        _orderPage.VerifyReceivedOrder();
        _helper.Log(_scenarioContext.ScenarioInfo.Title, "VerifyReceivedOrder", "The order has been confirmed.", "1");

    }

    [When(@"I customize the product and click next button")]
    public void PersonalizeProduct()
    {
        _orderPage.PersonalizeProduct();
        _helper.Log(_scenarioContext.ScenarioInfo.Title, "PersonalizeProduct", "The product has been successfully personalized.", "1");

    }

    [Then(@"I should see the product added to basket")]
    public void VerifyProductAddedToBasket()
    {
        _orderPage.VerifyProductAddedToBasket();
        _helper.Log(_scenarioContext.ScenarioInfo.Title, "VerifyProductAddedToBasket", "Verified the product has been successfully added to the basket.", "1");

    }

}