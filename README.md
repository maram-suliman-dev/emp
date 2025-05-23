#  C# Console Application - Employee Management System

This is a console-based C# application that allows users to manage and display information about employees.  
It demonstrates the use of object-oriented programming, including classes, objects, and methods.

## Description

The project includes:
- Creating an `Employee` class with properties like `ID`, `Name`, `Position`, and `Salary`
- Collecting employee data from user input
- Storing employee records in a `List<Employee>`
- Displaying employee information using methods
- Applying OOP concepts such as encapsulation and class design

## Technologies Used
- C#
- .NET Console Application
- Visual Studio / Visual Studio Code

##  Sample Code

```csharp
class Employee
{
    public int ID;
    public string Name;
    public double Salary;

    public void DisplayInfo()
    {
        Console.WriteLine($"ID: {ID}, Name: {Name}, Salary: {Salary}");
    }
}
