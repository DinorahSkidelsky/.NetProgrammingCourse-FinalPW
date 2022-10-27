## .NetProgrammingCourse-FinalPW

From the given database, create an application that allows the administration of employees of a business. The program must have the following functionality:
1. List the employees in a dataGridView with information obtained from the database. The "Id" should not be shown in the list, but it should be (hide columns). In addition, the grid must not be editable.

2. “Add” ("Agregar") button: allows you to open another window or enable fields in it to load the data to register a new employee. It must be saved in the database and reflected in the list in the application. It must be validated that all the data is required.

3. “Modify” ("Modificar") button: allows, once selected from the list, to pre-load an employee's data in a form so that it can be modified later. The changes must impact the database.

4. “Delete” ("Eliminar") button: allows you to delete a record selected in the grid. The deletion must impact the database.

The application must have an Employee class with the following attributes:

- Id (int)
- FullName (NombreCompleto) (string)
- ID Number (DNI) (string)
- Age (Edad) (int)
- Married (Casado) (boolean, that is, YES or NO)
- Salary (Sueldo) (double)

Note: use OOP, WinForm, ADO Net, SQL Server, DataGridView, Exception Handling (try, catch).


Example images:

![image](https://user-images.githubusercontent.com/99146275/198252426-7f2f18c8-9bb6-436c-869c-0881ab8714fe.png)

![image](https://user-images.githubusercontent.com/99146275/198252539-c9b66312-a42b-4491-9bcc-5f9f19c278ef.png)


DB script (paste in SQL Management and run).

use master

go

Create database EMPLEADOS_DB

GO

Use EMPLEADOS_DB

Go

Create Table Empleados (

Id int IDENTITY(1,1) PRIMARY KEY,

NombreCompleto varchar(100) not null,

DNI varchar(10) not null,

Edad int not null,

Casado bit not null,

Salario decimal(12,2)

);  

GO

Insert into Empleados(NombreCompleto,DNI,Edad,Casado,Salario)

values ('Juan Topo','12345633',55,1,2500.02)

Go

Insert into Empleados(NombreCompleto,DNI,Edad,Casado,Salario)

values ('Mirta Grand','100000',85,1,99989989.12)

Go

Insert into Empleados(NombreCompleto,DNI,Edad,Casado,Salario)

values ('Marcos Pereira','36154214',18,0,10000)

Go

Insert into Empleados(NombreCompleto,DNI,Edad,Casado,Salario)

values ('Josefina Fausto','54653756',45,1,1111152.45)

Go

Insert into Empleados(NombreCompleto,DNI,Edad,Casado,Salario)

values ('Raul Portal','23152478',65,0,1000)

Go

Insert into Empleados(NombreCompleto,DNI,Edad,Casado,Salario)

values ('Lizy Gaga','91235487',35,1,2556600.22)
