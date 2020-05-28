# HelloWorldNetcore

The HelloworldNetcore application is practice building a basic web API with a controller class and Xunit testing to test output using C#. 
Xunit is available as a package with template in the .NET Core library. The project also uses Swashbuckle an avalable nuget package in 
the .NET library. Swashbuckle tools include the swaggerUI that can be used to document API methods and generate test. The final output 
displays a Hello World string to a localhost. 
 

#Build

1. The user first creates a new project in visual studio using the .NetCore web application template.
2. After assigining an appropriate naming convention the user clicks create and selects the API .NET Core template. (Leave configure with
HTTPS as the only box checked.)
3. The user will click create again, and the project is generated with classes already generated for user to review.
4. The listed class weatherforecast.cs can be deleted, and inside of the controller class the weatherforecastcontroller can be renamed.
5. The renamed weatherforecastcontroller class code can be deleted with the exception of the [HttpGet] for routing.
6. The user inputs a method to return a Hello World string.
7. The user next right clicks on the solution and selects manage Nuget packages.
8. The user will browse and search for Swashbuckle.ASPNetCore to dowload and install.
9. Once the package is installed the user navigates to the startup class.
10. In the Startup Class the user can implement Swashbuckle using this Microsoft guide https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-3.1&tabs=visual-studio.

#Xunit Testing 

1. The user navigates to the solution 1 of 1 project field and right clicks to add a new project.
2. Next the user can search for Xunit testing project or search the All project types drop down for test/testing and navigate to Xunit
.NetCore. (ensure template is for C# Linux MAcOS & Windows)
3. Click and create the project with an appropriate naming convention which can include the project name plus Test or Demo added.(i.e HelloDemo) 
4. Check dependcies/packages for this solution to ensure Xunit packages are installed. (if not installed install using nuget manager).
5. Right click on the new project solution and add a reference to the first project that was built.
6. Once the reference is added navigate to the generated UnitTest class.
7. Inside of this class the [FACT] attribute denotes the method is a test and must be present.
8. The user can then use the Assert attribute to perform a test in side of a method with the [Fact] attribute place above.
(The intellisense describes each keyword that can be used with the Assert attribute..examples are the following: Assert.Equals(), Assert.Contains(), Assert.Istype(), Assert.True(), Assert.False() to name a few.)
9. Once complete click test and run/all test. The program generates pass or fail. 

#RUN
1. Debug the project and double check for errors. 
2. Run the application, and the default browser should display the Swagger generated UI.
3. When displayed correctly, the user should notice the get button.
4. Click the get button and then click execute to review outputs.


