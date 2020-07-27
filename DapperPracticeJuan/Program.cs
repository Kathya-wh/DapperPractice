using System;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;


namespace DapperPracticeJuan
{
    class Program //Don't change anything within my MAIN class
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder() //this is a special methos I need in order to use database from line 14 to line 20
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string connString = config.GetConnectionString("DefaultConnection");
            IDbConnection conn = new MySqlConnection(connString);

            var repoDepartments = new DapperDepartmentRepository(conn); //in here we are creating and instance/object for our Dapper class, I first named the object then
            //because the purpose is to get all departments, I added conn here because is part of the name of the IDbConnection which is my Dapper database
            //repoDepartments.InsertDepartment(); "in here we created a department, once we create it, I can comment it out so it doesn't create multiple ones everytime I run the program

            //repoDepartments.SecondInsertDepartment("chocolate");

            Console.WriteLine("Type the new department name:");
            string userInput = Console.ReadLine();
            repoDepartments.SecondInsertDepartment(userInput);


            var departments = repoDepartments.GetAllDepartments();//this is where I save in this variable a method that belongs to this object

            foreach(var department in departments)//we use a foreach loop so we can print out the properties of the department ID and the Name {remember every loop has it's own echosystem)
            {
                Console.WriteLine($"{department.DepartmentID}, {department.Name}");//we use this to print it to the console
            }


        }
    }
}
