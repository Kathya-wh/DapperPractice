using System;
using System.Collections.Generic;
using System.Text;

namespace DapperPracticeJuan
{
    public class Department //this is my regular class where I give the general properties to follow, this is my base or template, 
        //this is where I create a property from each column I'm going to use from my table in my database
    {
       
        public Department()
        {
        }
        public int DepartmentID { get; set; }//these are my properties that are named after the columns withing my database

        public string Name { get; set; }

    }
}







