This app started as a coding challenge for a C# developer interview using .Net Framework 4.8 in DotNetFiddle. 

Here are the original requirements from the coding challenge: 
      
      The Fruit Problem:
      
      Deliverable
      
             This solution should only require a single file using the https://dotnetfiddle.net/ .Net Fiddle online compiler.
             Currently you should use the compiler Roslyn 4.8
             The solution must run with no errors.
             Once complete, please use the "Share" function to send us the Url to your solution.
      
      Instructions
      
      Create a console application that allows the user to put different types of fruit into a basket. Using inheritance, create at least 5 types of specific fruits (e.g. Apple, Banana, Pear, Orange, Grape) and define those classes as subclasses from Fruit.
      
             Each Fruit object has the following fields/properties:
             Color
             Weight
             Price
             Each specific fruit can have additional fields/properties.
             Be creative and add at least 1 field to each individual, specific fruit class.
             Examples:
             Apple can have a field AppleSubtype, which can hold the apple’s subtype (e.g. Granny Smith).
             Banana can have a field called Length.
             Grapes can have a field for number of grapes on one vine.
      
      The user has a basket (probably an array or list) that can hold 10 items.
      
      The user is asked how many of each Fruit they want to add to the basket, until either the basket is full, or each fruit has been offered to the user. Once the basket is full or the user chooses not to add 10 items, let the user know what the total weight of the basket is, and what the total price of the fruits is.
      
      You can decide yourself on the weights and the prices, but use somewhat appropriate numbers.

This codebase has been updated to include the following: 

  Upgrade to latest .Net using the .Net Upgrade Assistant plugin 
  Separate classes into individual files 
  Add unit test coverage 
  Address all syntactical recommendation messages in Visual Studio 

Main principles 
  Separation of concerns 
  linq 
  Recursion 
  Maintainability via atomic functions, descriptive function names, and descriptive unit tests 
  Appropriate level of engineering 
    No logging 
    No performance testing due to limited amount of data 
