using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senior_Project
{
     class Note
     {
          /// <summary>
          /// A class to encapsulate all Note data.
          /// </summary>
          //Properties
          public int id;
          public int student_id;
          public string date;
          public string note;
          public string category;

          /*
               NAME

                    Note::Generate_Note_ID - Generates a unique id for a note object.

               RETURNS

                    A unique note id.
          */
          public static int Generate_Note_ID()
          {
               long id = DateTime.Now.ToFileTime();
               return (int)id;
          }
     }
}
