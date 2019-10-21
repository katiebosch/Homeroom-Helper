using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senior_Project
{
     class Teacher
     {
          /// <summary>
          /// A class to keep teacher data together.
          /// </summary>
          private string fname, lname;
          private string grade;

          //Properties
          public string First_Name
          {
               get { return fname; }
               set { fname = value; }
          }

          public string Last_Name
          {
               get { return lname; }
               set { lname = value; }
          }

          public string Grade
          {
               get { return grade; }
               set { grade = value; }
          }
     }
}
