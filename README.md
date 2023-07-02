Application to work with `REST Countries` API using endpoint https://restcountries.com/v3.1/all. 
Created with .NET 6.0. Contains Unit tests that use XUnit.
API has one GET endpoint that extracts data about countries. This endpoint has parameters and can:
- filter countries by Name (common)
- filter countries by population (< passedPopulation * 10^6)
- Sort by countries Name (common) in Ascending or Descending order
- Take first n countries from the list (n - passed number)

In order to run this project you need .Net 6.0 SDK installed on your computer.
To run application you can use Visual Studio or `dotnet run` command.
TO run Unit tests you aolse need Visual Studio Test Exproler or `dotnet test` command.

Examples of use:
https://localhost:7250/DataExtraction - GET without parameters
https://localhost:7250/DataExtraction?countryName=Jord - GET with parameter to filter by country name
https://localhost:7250/DataExtraction?population=2 - GET with parameter to filter by population
https://localhost:7250/DataExtraction?sortingOrder=ascend - GET with parameter to sort by name in Ascending order
https://localhost:7250/DataExtraction?pageSize=5 - GET with parameter to take first 5 countries from the list
https://localhost:7250/DataExtraction?sortingOrder=descend&pageSize=5 - GET several parameters
https://localhost:7250/DataExtraction?countryName=a&population=5&sortingOrder=descend&pageSize=5 - GET all parameters at the same time