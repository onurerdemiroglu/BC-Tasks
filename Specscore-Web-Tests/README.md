#  .NET & SpecFlow (BDD-Framework for .NET) ile Mizu Web UI Testleri  

Merhaba, bu projede .Net dilinde NUnit, Selenium, WebDriverManager, SpecFlow, InputSimulator kütüphaneleri kullanılarak Mizu sitesinin UI(User Interface) testleri yapılmaktadır. 
- [X] NUnit'i, .Net diliyle test geliştirmek,
- [X] Selenium'u, test yapılarını otomatikleştirmek,
- [X] SpecFlow'u, .Net dilinde BDD gherkin yapısını kullanmak,
- [X] WebDriverManager'i, her browser için farklı bir driver indirmemek ve aksini belirtmedikçe driverın son versiyonunu indirmesi için,
- [X] Ve son olarak InputSimulator'u ürün kişiselleştirme senaryosundaki openfiledialog'u kapatmak için kullandım 🙂


#### 👉 Testlerinizi yürütmenin yollarından biri, VS Code terminalini kullanmaktır. Dotnet testinde terminali açmanız ve gerekli parametreleri girip enter tuşuna basmanız yeterlidir

Tüm testleri koşmak için : `dotnet test`

Tag'a bağlı testleri koşmak için : `dotnet test --filter Category=casetag`
 
### Database [Bimser]
--- 
  
```Sql
dbo.Log

[ID] [int] IDENTITY(1,1) NOT NULL,
[Title] [nvarchar](max) NULL,
[Step] [nvarchar](max) NULL,
[Detail] [nvarchar](max) NULL,
[Status] [bit] NULL,
[RunTime] [datetime] NULL
```

![sql](https://user-images.githubusercontent.com/35347777/154800404-4c2a070f-96bc-4b3b-b170-17ada4489f9b.PNG)

### 👨🏿‍💻 Senaryo-1 : Geçerli Oturum Açma Kontrolü
---

```cucumber
@caseone @User_validUserLogin
Scenario: Valid User Login Control
    Given I am on the home page
    When  I close the address focus on the home page

    And   I go to login page
    And   I logged in with the following data:
        | email                | password |
        | pulmotirti@vusra.com | bimser |
    Then  I should see My Account section
```


https://user-images.githubusercontent.com/35347777/154799511-64582be3-2300-444d-9a16-4d92763f56bf.mp4


 
#### 📝 SpecFlow LivingDoc Raporu
---
 
 ![caseone](https://user-images.githubusercontent.com/35347777/154798825-cefa3c9a-59b3-49bc-82c6-6a8246af11ae.png)

**Sonuç :** `Başarılı bir şekilde login olunduğu görülmüştür. ✅`

### 👨‍💻 Senaryo-2 : Geçerli Ürün Sıralama Kontrolü
---
Pc video kayıtta olduğundan çok yavaşlıyor ve test uzuyor(Video kırptım). Gerçek test süresi raporda olduğu gibidir.

```cucumber
@casetwo @Product_validSorting
Scenario Outline: Valid Product Sorting Control
    Given  I open the 'flowers' url
    When   I close the address focus on the home page
    And    I sort result list based on <sortCriterion>
    And    I scroll to the end of the page
    Then   I should see the prices listed from high to low

    Examples:
        | sortCriterion      |
        | Price: High to Low |
```
   

https://user-images.githubusercontent.com/35347777/154799836-c55d5647-b68d-4349-b9e3-1e847ce95a9f.mp4


 
#### 📝 SpecFlow LivingDoc Raporu
---
 
![casetwo](https://user-images.githubusercontent.com/35347777/154798539-67b410ba-10a8-4529-a5df-56fa161592bb.png)

**Sonuç :** `Ürünlerin fiyatları başarılı bir şekilde sıralandığı görülmüştür. ✅`

### 👨🏿‍💻 Senaryo-3 : Her Yeni Sayfada Yeni Ürünlerin Görüntülenme Kontrolü
---

```cucumber
@casetree @Product_displayedEachNewPage
Scenario: Control The New Products Are Displayed On Each New Page
    Given  I open the 'flowers' url
    When   I close the address focus on the home page
    Then   I scrolling down to page 10 and check see 60 products displayed per page
```
 
 

https://user-images.githubusercontent.com/35347777/154799849-ed80a18c-45a7-4e85-9833-bd0e159bf419.mp4
 
 
#### 📝 SpecFlow LivingDoc Raporu
---
 
![casetree](https://user-images.githubusercontent.com/35347777/154798555-7ad3fed8-950e-4906-b479-b71cae72d95c.png)

**Sonuç :** `Başarılı bir şekilde her sayfada 60 ürün geldiği görülmüştür. ✅`

### 👨‍💻 Senaryo-4 : "OXXO" ile Ödeme Kontrolü
---

```cucumber
@casefour @Payment_validWithOxxo
Scenario: Payment Check With "OXXO"
    Given I open the 'flowers' url
    When  I choose shipping address 'mexico city'
    And   I open the first product page
    And   I select the delivery time and click the add to cart button
    And   I click the Guest Checkout
    And   I fill out the order information form
    And   I fill out the sender information form
    And   I fill out the payment form
    Then  I should see the message we received your order
```
   
https://user-images.githubusercontent.com/35347777/154799862-ecdaba01-d73d-471f-ac9d-0701ce52b0e5.mp4

  
#### 📝 SpecFlow LivingDoc Raporu
---
  
![casefour](https://user-images.githubusercontent.com/35347777/154798569-0e71d5e8-19b2-4011-b877-ed79dcf6c3f3.png)


**Sonuç :** `Başarılı bir şekilde OXXO ile ödeme yapıldığı görülmüştür. ✅`

### 👨🏿‍💻 Senaryo-5 : Ürünü Özelleştirme ve Sepete Ekleme
---

```cucumber
@casefive @Product_customizeAndBasket
Scenario: Customizing Product And Add To Basket
    Given I open the 'en-mx/portarretratos-de-cristal-personalizado-cancion-kcm64138299' url
    When  I add product to basket
    And   I customize the product and click next button
    Then  I should see the product added to basket
```
  

https://user-images.githubusercontent.com/35347777/154799872-567cc2f0-bfb3-4080-bb57-851976ce86df.mp4
 
  
#### 📝 SpecFlow LivingDoc Raporu
---
 
![casefive](https://user-images.githubusercontent.com/35347777/154798587-5d2154f3-7f6d-4976-8af5-0faccdec959c.png)


**Sonuç :** `Ürün kişiselleştirilip başarılı bir şekilde sepete eklendiği görülmüştür. ✅`

### 👨‍💻 Senaryo-6 : Menü Bağlantılarının Bozuk Olup Olmadığını Kontrol Etme
---

```cucumber
@casesix @Menu_brokenLinks
    Scenario: Checking If Menu Links Are Broken
    Given I am on the home page
    When  I close the address focus on the home page
    And   I find all the links under the menu
    Then  I should see the links are not broken
```
   


https://user-images.githubusercontent.com/35347777/154799884-b0e30f82-cdf5-4969-83cd-2c6edf1c9ff5.mp4
 
 
#### 📝 SpecFlow Living Raporu
---
 
![casesix](https://user-images.githubusercontent.com/35347777/154798595-b0dd7133-14d0-457f-ba66-cb02ce9fc6b3.png)


**Sonuç :** `Menü linklerin birinde kırık link tespit edilmiştir. (https://www.mizu.com/new-products-gourmet) ❌`

