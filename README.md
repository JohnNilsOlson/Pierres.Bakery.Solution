# _Pierre's Bakery_
Epicodus Week 8 Independent Project  
Version 1.0 - July 17, 2020 

## _Project Description_
An exploration of test driven developement utilizing C# and .NET framework.

## _Contributors_
JohnNils Olson

## _Usage_
A console application where the user can order baked goods from Pierre's Bakery.

## _Behavior Specifications_
| Behavior | Input | Output |
| ---- | ---- | ---- |
| Program creates custom class for breads | - | "Today's bread selection: Example Bread" |
| Program creates a custom class for pastries | - | "Today's pastry selection: Example Pastry |
| Program sets a price value for breads | - | "Todays bread selection: Example Bread - $5.00 (Buy two, get one free!)" |
| Program sets a price value for pastries | - | "Todays pastry selection: Example Pastry - $2.00 (Buy three for $5.00!)" |
| Program prompts the user for an order | - | "What would you like today? |
| Program recieves user inputted order | 1 Example Bread, 3 Example Pastries | - |
| Program calculates order total | - | "1 Example Bread, 3 Example Pastries: $11.00 |
| Program calculates order total with discounts | - | "1 Example Bread, 3 Example Pastries: $10.00 |

## _Technologies Used_
C#  
.NET

## _Installation Instructions_
* Cloning instructions.
  1. Open Git Bash.
  2. Change the current working directory to the location where you would like to clone the repository.
  3. Type "git clone" followed by "https://github.com/JohnNilsOlson/Pierres.Bakery.Solution" (without quotes) and hit enter.

* Download instructions.
  1. Visit "https://github.com/JohnNilsOlson/Pierres.Bakery.Solution".
  2. Click the green "code" button and download zip file of project.
  3. Extract zip file to directory of choice.

* Instructions to run program.
  1. Open project directory in code editor of choice.
  2. In the terminal, change working directory to ./PierresBakery.
  3. Type "dotnet run".

* Instructions to run model tests.
  1. Open project directory in code editor of choice.
  2. In the terminal, change working directory to ./PierresBakeryTests.
  3. Type "dotnet test".

## _Bugs_
Version 1.0 - Randomly generated menus should not include duplicates.

## _Contact Information_
JohnNils Olson - johnnils@gmail.com

## _License_
The [MIT] license.
Copyright (c) 2020 JohnNils Olson