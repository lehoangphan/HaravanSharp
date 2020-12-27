# HaravanSharp: A .NET library for Haravan.

HaravanSharp is a .NET library that enables you to authenticate and make API calls to Haravan. It's great for building custom Haravan Apps using C# and .NET. You can quickly and easily get up and running with Haravan using this library.

# Important
This library build on ShopifySharp, please check README.md in ShopifySharp project.

# Frequently Asked Questions
- **Question**: Why is ShopifySharp project in this solution ?
    - **Answer**: This library build on ShopifySharp, and Haravan is Shopify, but the authentication ways is different (Haravan uses JWT auth) and the original ShopifySharp is not virtual base class for overriding, so the ShopifySharp project was customized by direct change in ShopifySharp open source
    (please check Original source at: ``https://github.com/nozzlegear/ShopifySharp)``

- **Question**: Why still use ShopifySharp although the ShopifySharp package is not    virtual for overriding? What is the point here? 
    - **Answer**: The ShopifySharp project contains all the services and data models works well with Haravan/Shopify Ecosystem, and some tool library deal with LeakyBucket algrogrithm

# Installation
1. Nuget Package 
updating 
2. Clone this repo and reference your project to 2 child projects inside this repo

# Usage
1. Call API without repository 

Example: List all custom collection
```cs
var service = new CustomCollectionService("https://apis.haravan.com/","YOUR KEY HERE"); 
var custom_collections = service.ListAsync().GetAwaiter().GetResult();
```
More example: ``https://github.com/nozzlegear/ShopifySharp``

2. Call API inside your Repository
- Make your repository inheritance abstract haravan repository
```cs
public class HaravanRepository : BaseHaravanRepository
{
    override string Jwtoken = "YOUR_TOKEN";
    override string BaseApiUrl = "https://apis.haravan.com/";
}
public class CategoryRepository : HaravanRepository
{
    CustomCollectionService service = new CustomCollectionService(Jwtoken,BaseApiUrl); 
    public object ListAllCategory()
    {
        var custom_collections = service.ListAsync().GetAwaiter().GetResult();
        return custom_collections;
    }
}
```
**These repository is for noprofit purpose**. If you'd like your pull request to be published, make sure you write tests for it!




 
