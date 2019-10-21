using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senior_Project //https://stackoverflow.com/questions/2907259/what-is-the-best-way-to-store-static-data-in-c-sharp-that-will-never-change
{
     public struct Conference_Types
     {
          /// <summary>
          /// This structure is used to contain the different 
          /// Student Conference types and information
          /// so they can be called in the program.
          /// </summary>
          private int id;
          private bool isDef;

          /*
           NAME

               Conference_Types::HasValue - returns if the struct has been defined.

           DESCRIPTION

               This function returns whether the class has been defined or not. 
               If an id is not specified, then the struct is not defined.

            RETURNS

               True if defined, false if not defined.
          */
          public bool HasValue { get { return isDef; } }

          /*
           NAME

               Conference_Types::Conference_Types - the constructor for the class.

           DESCRIPTION

               This function initializes the struct to an id. It also sets the
               isDef variable to true.
          */
          public Conference_Types(int value) { id = value; isDef = true; }

          //Conference type property
          public string Type
          {
               get
               {
                    return
                         id == 0 ? "Demonstration" :
                         id == 1 ? "Explanation with Example" :
                         id == 2 ? "Guided Practice" :
                         id == 3 ? "Proficient Partner" :
                         id == 4 ? "Inquiry" : 
                         "Unspecified"; 

               }
          } 

          //Information about the conference type
          public string Blurb
          {
               get
               {
                    return
                         id == 0 ? "The teacher shows the student how to do something. The teacher demonstrates by showing the reader what she  does in her own reading, or by taking over the student's book temporarily to use for the demonstration." :
                         id == 1 ? "The teacher gives a short, memorable speech to the student and cite a personal example. The teacher references something that was already demonstrated or done by another student. Then, the teacher encourages the student to try out the new strategy going forward." :
                         id == 2 ? "The teacher may or may not decide to stop the student to teach something, but often the teacher “runs alongside” the student, coaching him with quick, lean prompts. Often at the end of this conference, the teacher more explicitly names what she has scaffolded." :
                         id == 3 ? "The teacher researches what the student (or partnership) is doing and assumes the role of a “proficient partner” in the work. This enables the teacher to lift the level of work the students are doing. At the end of this conference, the teacher may state the strategies or qualities of good reading and good book talks that he or she demonstrated." :
                         id == 4 ? "The teacher invites the student to study something with her and then helps the student extrapolate from the example principles that he could apply to his own reading. Specifically, the teacher asks the student to be a researcher of a transcript, partners talking, or post-its, and to make observations. Sometimes the teacher acts as a commentator, sharing what she notices." :
                         "Unspecified";
               }
          }

          //How to use each type of conference
          public string Usage
          {
               get
               {
                    return 
                         id == 0 ? "This type of conference is most often used when the teacher decides that she is going to stop the student’s reading to introduce a new strategy or to reinforce or tune-up a strategy to which the student has already been exposed." :
                         id == 1 ? "This type of conference is helpful when the teacher has an exact example that the reader would be able to grasp quickly. Often, the example is something the whole class has studied so that it is familiar to the student, allowing the conference to be quicker than a demonstration conference, thus allowing the teacher to reach other readers during the workshop." :
                         id == 2 ? "This type of conference is meant to support the student in the midst of his reading. Coaching conferences are especially effective with beginning readers who need extra support internalizing strategies they’ve learned." :
                         id == 3 ? "This conference is effective when supporting students to have thoughts about their texts or to have stronger talks about their books. The teacher meets the student(s) where he, she, or they are and gently nudges them to do more proficient work. " :
                         id == 4 ? "This type of conference is meant to draw upon what the reader has learned over a few days or weeks. The research involved highlights what the reader has learned and helps him see what he might do to ratchet up his work. This conference ends with a reader making plans for what he will do." :
                         "Unspecified";
               }
          }

          //An example of this type of conference
          public string Example
          {
               get
               {
                    return 
                         id == 0 ? "“Alex, I love the way you’re using your own experience to infer what this character is feeling. Another way readers infer what a character is feeling is by (present strategy). Watch me while I (demonstrate strategy). Now you try…”" :
                         id == 1 ? "“Jessica, you’re doing a terrific job reading. Remember when we were reading Fly Away Home, and we learned about homelessness by walking in Andrew’s shoes. We discovered… Now, in your book, you’re studying racism. Walk in your character’s shoes…”" :
                         id == 2 ? "“Run your finger under the word…” \n “Check the picture…” \n “Does that make sense? Go back and check…” (point under beginning of the word) \n “Really see the school...what color is it ? Add that to your picture.”" :
                         id == 3 ? "“I was also thinking that Amanda Beale was the hero of Maniac Magee. An example of that from the book is…” \n “So, we’re talking about how Amanda is the hero of Maniac Magee, but I’m wondering, what do we really believe a hero is?”" :
                         id == 4 ? "“Let’s study a few of your prediction post-its and compare them to our mentor post-its. What are you noticing?” \n “So let’s watch these reading partners and see what you guys can learn from them.”" :
                         "Unspecified";
               }
          }
     }
}
