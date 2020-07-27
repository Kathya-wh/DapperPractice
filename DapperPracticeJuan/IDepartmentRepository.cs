using System;
using System.Collections.Generic;
using System.Text;

namespace DapperPracticeJuan
{
    public interface IDepartmentRepository//this is where we make our class an interface so it can be use as a collection through
        //IEnumerable that uses the info from the type Department, I created a method named GetAllDepartments
    {
        IEnumerable<Department> GetAllDepartments();//here I just define Method
    }
}
