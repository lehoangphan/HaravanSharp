# HaravanSharp: A .NET library for Haravan.

HaravanSharp is a .NET library that enables you to authenticate and make API calls to Haravan. It's great for building custom Haravan Apps using C# and .NET. You can quickly and easily get up and running with Haravan using this library.

# Important
This library build on ShopifySharp, please check README.md in ShopifySharp project.

# Frequently Asked Questions
- **Question**: Why is ShopifySharp project in this solution ?
    - **Answer**: This library build on ShopifySharp, and Haravan is Shopify, but the authentication ways is different (Haravan uses JWT auth) and the original ShopifySharp is not virtual base class for overriding, so the ShopifySharp project was customized by direct change in ShopifySharp open source
    (please check Original source at: https://github.com/nozzlegear/ShopifySharp)

- **Question**: Why still use ShopifySharp although the ShopifySharp package is not    virtual for overriding? What is the point here? 
    - **Answer**: The ShopifySharp project contains all the services and data models works well with Haravan/Shopify Ecosystem, and some tool library deal with LeakyBucket algrogrithms

 
