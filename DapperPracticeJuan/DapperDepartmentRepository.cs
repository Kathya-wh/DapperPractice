using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DapperPracticeJuan
{
    public class DapperDepartmentRepository : IDepartmentRepository //here is where I tell my program WHAT TO DO
    {
        private readonly IDbConnection _connection; // here I created a property, I said redonly because I don't want anyone to change it, just declaring this
        public DapperDepartmentRepository(IDbConnection connection)//this is my constructor, adding a parameter, by placing the type and the name of the parameter
        {                                   //this is my parameter
            _connection = connection;//within my scope, I'm telling it that the names of the structure are always the same, this is how I connect to the database
        }
        
        public IEnumerable<Department> GetAllDepartments()//this is my method that is going to take action, in here we want to return all the info from my table
        {
            return _connection.Query<Department>("SELECT * FROM departments");//here I tell it to return from my _connection going into the Query called Department and use my SQL statement
        }

        public void InsertDepartment() //in this method I'm going to insert a new department into my dept. table I named it and then in my parameters I said the type and named it
        {
            _connection.Execute("INSERT INTO departments(Name) VALUES('mangos')");//here we created our value directly from our Dapper instead of our console, we must use single quotes to name it, it threw an error with double quotes

        }

        public void SecondInsertDepartment(string newDepartmentName)
        {
            _connection.Execute("INSERT INTO departments(Name) VALUES(@departmentName);", new { departmentName = newDepartmentName});

        }
    }
}
