# EmployeeManagement
This is an employee management app created for Front and Back-End practice of learned skills.

# Status
Application has been finished according to my plans but there are many ways in which I can add more functionality.

# Screenshots
Lorem ipsum

# Installation and Setup
Clone down this repository and open using MS Visual Studio, preferably 2022 or higher as this is what I have used for development.
There is one external library Dapper that has been used in this project and need to be added to Extensions.

Folder " " contains created database that can be opened using Microsoft SQL Server Management Studio 18. You can move this database to a different folder if needed.


# Reflection
This application has been created to use my .NET and SQL knowledge. It is an simple version of an application that could be used in places such as HR Department. It allows to create/edit/delete data about employees, departments and positions that are available in these departments.

My goal was to learn how application can work with an external database and properly store data that can be pulled back to application in any required ways.

I have struggled the most with implementing an Edit feature. I could not figure out why data did not get loaded into fields and then updated properly in SQL tables. There were also issues with updates in multiple tables at once using foreign keys that required me to create extra Triggers that would make them work. 

For this project I have used C# programming language with Dapper extension to use dynamic parameters and Windows Forms. This combination created and app that communicates with an SQL database.
