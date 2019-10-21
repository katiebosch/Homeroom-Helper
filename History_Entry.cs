using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senior_Project
{
     class History_Entry
     {
          /// <summary>
          /// A container to help history entries be passed around the program.
          /// </summary>
          /// 
          //Properties
          public int id, student_id;
          public string date;
          public char current_lvl;

          /*
               NAME

                    History_Entry::Generate_Entry_ID - Generates a unique id for a history_entry object.

               RETURNS

                    A unique history entry id.
          */
          public static int Generate_Entry_ID()
          {
               long id = DateTime.Now.ToFileTime();
               return (int) id;
          }
     }
}
