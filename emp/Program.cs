using System;
using project2_maram;

class program
{

    static void Main(string[]args)

    {

        Console.WriteLine("employees informaion :");

        EmpClass employee = new EmpClass();

        employee.FirstName = " maram ";
        employee.LastName = " suliman ";
        employee.Email = " mms.bur@outlook.com ";
        employee.wage = 2.5;
        employee.WorkingHours = 2;

        Console.WriteLine($" grwth salary is {employee.wage * employee.WorkingHours}");
        Console.WriteLine($" net salay is {(employee.wage * employee.WorkingHours)- (employee.wage * employee.WorkingHours*EmpClass.Tax)}");

    }
}    