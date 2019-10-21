using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senior_Project
{
    class Student
    {
          /// <summary>
          /// A class to encapsulate all the student data together.
          /// </summary>
          
          int id;
          string fname, lname;
          char startingLvl, currentLvl, goalLvl;

          /*
          
               NAME

                    Student::Student - A constructor for the Student class. 

               SYNOPSIS

                    Student()

                    Student(int n_id, string n_fname, string n_lname, char n_currentLvl)
                     
                         n_id             --> student id
                         n_fname          --> first name
                         n_lname          --> last name
                         n_currentLvl     --> current reading level

                    Student(int n_id, string n_fname, string n_lname, char n_startingLvl, char n_currentLvl, char n_goalLvl)
                        
                         n_id             --> student id
                         n_fname          --> first name
                         n_lname          --> last name
                         n_startingLvl    --> starting level
                         n_currentLvl     --> current level
                         n_goalLvl        --> goal level

                    Student(List<string> str_array)

                         str_array        --> a list of student objects

               DESCRIPTION

                    These constructors instantiate a Student object in a stable state. Depending on what kind of constructor is used, they may be 
                    lacking certain information that is unecessary for use of the object.

                    
          */
          public Student()
          {
               id = 0;
               fname = "";
               lname = "";
               startingLvl = 'a';
               currentLvl = 'a';
               goalLvl = 'a';
          }
          public Student(int n_id, string n_fname, string n_lname, char n_currentLvl)
          {
               id = n_id;
               fname = n_fname;
               lname = n_lname;
               currentLvl = n_currentLvl;
          }
          public Student(int n_id, string n_fname, string n_lname, char n_startingLvl, char n_currentLvl, char n_goalLvl)
          {
               id = n_id;
               fname = n_fname;
               lname = n_lname;
               startingLvl = n_startingLvl;
               currentLvl = n_currentLvl;
               goalLvl = n_goalLvl;
          }
          public Student(List<string> str_array)
          {
               id = Convert.ToInt32(str_array[0]);
               fname = str_array[1];
               lname = str_array[2];
               startingLvl = Convert.ToChar(str_array[3]);
               currentLvl = Convert.ToChar(str_array[4]);
               goalLvl = Convert.ToChar(str_array[5]);
          }

          /*
               NAME

                    Student::Generate_Student_ID - Generates a unique id for a student object.

               RETURNS

                    A unique student id.
          */
          public static int Generate_Student_ID()
          {
               long id = DateTime.Now.ToFileTime();
               return (int)id;
          }

          /*
               NAME

                    Student::ToArray - Returns student information in an array.

               RETURNS

                    An array containing the student's data.
          */
          public string[] ToArray()
          {
               string[] temp = { ID.ToString(), FirstName, LastName, StartLevel.ToString(), CurrentLevel.ToString(), GoalLevel.ToString() };
               return temp;
          }

          //Properties
          public int ID
          {
               get { return id; }
               set { id = value; }
          }

          public string FirstName
          {
               get { return fname; }
               set { fname = value; }
          }

          public string LastName
          {
               get { return lname; }
               set { lname = value; }
          }
          public char StartLevel
          {
               get { return startingLvl; }
               set { startingLvl = value; }
          }
          public char CurrentLevel
          {
               get { return currentLvl; }
               set { currentLvl = value; }
          }
          public char GoalLevel
          {
               get { return goalLvl; }
               set { goalLvl = value; }
          }
     }
}
