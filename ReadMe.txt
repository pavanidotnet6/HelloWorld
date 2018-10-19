

This HelloWorld solution has a ConsoleApp, Web API, Individual domain class projects and a Unit test Project.
Console Application has a function HelloWorldFunction() which would make a call to WebAPI.
Web API call in this solution is coded in ValuesController.
Web API will then make call to Domian Service. Domain Service would be calling Unit Of Work which is tied with Database Repository.
When service calls UnitOfWork it would make a database call to fetch data from databse.
In this scenario, it would call Sample_Table and returns Text HelloWorld!
This is all designed to be Repository Pattern.
And service and Unit of Work has Interfaces implemented.
Once Unit of work returns data from Database, it would return result to service.
Service will return result to Controller. Controller would then return Response to Console.

