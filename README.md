# EmployeeManagement
This is an employee management app created for Front and Back-End practice of learned skills. It works together with an SQL Database that can be found in my repository <a href="https://github.com/szymanskidawid/SQL_DB-EmployeeManagement" target="_blank">SQL_DB-EmployeeManagement</a>.

 



# Status
Application has been finished according to my plans but there are many ways in which I can add more functionality.

# GIFs highlighting some functionalities (click for zoom)
<img src="https://github.com/szymanskidawid/EmployeeManagement/assets/17786383/e71e3b38-e53a-40a5-b858-99f76f87240f" alt="project_GIF_1" width="250">
<img src="https://github.com/szymanskidawid/EmployeeManagement/assets/17786383/9432d387-9065-40e6-b029-71b2e6e3f2e5" alt="project_GIF_2" width="250">
<img src="https://github.com/szymanskidawid/EmployeeManagement/assets/17786383/d7aff651-303f-4b04-834c-2eb07e0b660f" alt="project_GIF_3" width="250">

# Installation and Setup
1) Clone down EmployeeManagement repository and open the solution using MS Visual Studio (preferably 2022 as this is what I have used).
2) Right click your solution and click "Restore NuGet Packages" to get all extra packages used for this project.
3) Right click ProgramUI and "Set as Startup Project".
4) Visit my "SQL_DB-EmployeeManagement" repo to clone down "EmployeeManagement.sql" file for this project.
   
   <a href="https://github.com/szymanskidawid/SQL_DB-EmployeeManagement" target="_blank">LINK to SQL_DB-EmployeeManagement repository</a>

5) Download and run SQL Server Installation Center from Microsoft website and install SQL Server 2022.
6) Set up a basic server, preferably under the name "MyServer" as this is the server name used in my application.
   
   **If you have an existing server under a different name, you will need to change the name in the App.config file inside this project.**
7) Using the same installation wizard, install Microsoft SQL Server Management Studio 19 and login into the server created above.
8) Open the database file you have cloned down and execute all code contained in the file.

   **WARNING: If you use an older version of SQL Server OR the server has a different name, you will need to update file paths inside EmployeeManagement.sql file:**
   <img width="1181" alt="filepaths" src="https://github.com/szymanskidawid/EmployeeManagement/assets/17786383/c9ba3ba1-6d13-4986-af2f-1dfd77d24461">
9) Add your own Username and Password to the dbo.LoginTable file, you can do it using the example query below:
   
   **INSERT INTO dbo.LoginTable (username, password) VALUES ('userexample', 'passexample');**
   
   *(example above does not contain any password hashing, it is just for testing purposes)*
   
10) You can now Run the app and check all functionalities it has.

# Reflection
This application has been created to use my .NET and SQL knowledge. It is a simple version of an application that could be used in places such as the HR Department. It allows to create/edit/delete data about employees, departments and job titles that are available in these departments.

My goal was to learn how the application can work with an external database and properly store data that can be pulled back to the application in any required way.

I have struggled the most with implementing an Edit feature. I could not figure out why data did not get loaded into fields and then updated properly in SQL tables. There were also issues with updates in multiple tables at once using foreign keys that required me to create extra Triggers that would make them work. 

For this project, I have used C# programming language with Dapper extension to use dynamic parameters and Windows Forms. This combination created an app that communicates with an SQL database.
