using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senior_Project
{
     public struct Reading_Levels
     {
          /// <summary>
          /// A struct containing the reading level information.
          /// </summary>
          private char lvl;
          private bool isDef;

          /*
           NAME

               Reading_Levels::HasValue - returns if the struct has been defined.

           DESCRIPTION

               This function returns whether the class has been defined or not. 
               If the level is not specified, then the class is not defined.

            RETURNS

               True if defined, false if not defined.
          */
          public bool HasValue { get { return isDef; } }

          /*
           NAME

               Reading_Levels::Reading_Levels - the constructor for the class.

           SYNOPSIS

               Reading_Levels(char value)

                    value          --> the value given when invoking the struct
                    
           DESCRIPTION

               This function initializes the struct to level. It also sets the
               isDef variable to true.
          */
          public Reading_Levels(char value) { lvl = value; isDef = true; }

          public char Level
          {
               get { return lvl; }
               set { lvl = value; }
          } //Level property

          public List<string[]> Suggestions
          {
               get
               {
                    List<string[]> list = new List<string[]>();
                    switch (lvl)
                    {
                         case 'C':
                         case 'D':
                              list.Add(new string[]{ "Students have problems with dialogue statements by characters, for example character's statements that are assigned with the word 'said'", "Then you want to help them understand that characters talk all the time, and we know when they talk when we see the word 'said.' That word indicates that there is a conversation going on. One thing you will want to do is stop and monitor listen in to what the conversation is about." });
                              list.Add(new string[] { "If you see that students are having problems following characters", "Then you want to make sure that students stop every time they hear about a character and think about what the character's actions are." });
                              list.Add(new string[] { "If you see that students are only reading part of the pictures", "Then you want them to focus on what the pictures are saying. Have them notice what the students are saying/doing/where the colors are." });
                              list.Add(new string[] { "If you see that students are connected to the text but the connections they are making really don't match what they are reading or seeing", "Talk to your students about what it means to connect to something they read about, and how they can make those connections." });
                              list.Add(new string[] { "Students have a hard time recognizing setting", "Teach students to use what they see around the character to think about where the story is taking place." });
                              break;
                         case 'F':
                         case 'G':
                              list.Add(new string[] { "If student cannot identify the beginning, middle, and end ", "Teach student that the beginning ends after the story has been introduced and the cause is mentioned, the middle usually ends after the problem and the story changes to talk about how the problem is resolved." });
                              list.Add(new string[] { "If kids aren't using the pictures to help with the meaning", "Teach them to think about what is in the pictures and what the pictures are saying." });
                              list.Add(new string[] { "Trouble understanding what the character is feeling", "Teach students description words and how the author describes the character." });
                              list.Add(new string[] { "Students are having problems understanding when characters are talking and dialogue is interrupted", "Read with the students and have them wonder who is talking by thinking about the conversation." });
                              list.Add(new string[] { "Students have difficulty identifying important details", "Have them think about the big picture, and then what details support that big picture." });
                              break;
                         case 'H':
                         case 'I':
                         case 'J':
                              list.Add(new string[] { "Students have problems putting the information together", "Teach them to retell." });
                              list.Add(new string[] { "Students have problems reading the words and not having as much support in the picture", "Teach them to read around the words." });
                              list.Add(new string[] { "Students have problems inferring what the character is feeling", "Have them use the clues and the punctuation to understand the feeling." });
                              list.Add(new string[] { "Students cannot follow more than one conversation", "Have students think about and separate the conversations , practicing saying them aloud. Or, have them act conversations out with each other." });
                              list.Add(new string[] { "Students can infer the feelings but not the traits", "Teach them what feelings help you understand the trait of the character. Give them vocabulary for traits." });
                              list.Add(new string[] { "Students have a hard time understanding the cause of the characters' problems", "Encourage them to backtrack to who caused the problem." });
                              list.Add(new string[] { "Students have a hard time understanding character motivation", "Talk to them about how every character is pushed to do something in the plot." });
                              break;
                         case 'K':
                         case 'L':
                         case 'M':
                              list.Add(new string[] { "Students have problems transferring what they already know to a different genre", "Having students lavel what they remember about realistic fiction and look for clues of that in the text." });
                              list.Add(new string[] { "Students have problems finding the problem, solution, or both in the story", "Create a t chart thinking about one problem, then the other, Have students create a double timeline following characters across the text." });
                              list.Add(new string[] { "Students have difficulty comprehending the place, time, or space the character is in", "Have the students sketch the place. Create a mental image of the time period or what it represents." });
                              list.Add(new string[] { "Students have difficulty understanding the theme of the story", "Let them collect post-its across the text, building on a theory and then putting the theory together." });
                              list.Add(new string[] { "Students do not understand the humor or the contradictions in a story", "Stop at a part and let them draw a mental image of what they are imagining." });
                              list.Add(new string[] { "Students can't follow the episodes in a story", "Draw a time line with them. Talk to them about knowing the genre of the story and what they can glean from that understanding." });
                              list.Add(new string[] { "Students have a hard time recognizing who is talking in the story", "Make them stop-read the conversation and think to themselves who would be a part of the conversation, or what the conversation is saying." });
                              list.Add(new string[] { "Students have a hard time understading how metaphors and similes can be used to describe a character", "Teach similies as 'like' or 'as' and think about how that is used to compare to something. \r\n1. What are some ways authors write to make their details more vivid? \r\n2. What are some good describing words to describe a (list something)? \r\n3. How can we write things to show comparisons? \r\n4. Read or display the introductory poem. \r\n5. Have the students identify the similies and metaphors and what is being compared. \r\n6. Have the students changes the similies to metaphors and the metaphors to similies. \r\n7. Use the list of sample similies and metaphors and have the students identify each. \r\n8. As a class, choose a person from TV or an era in history and write several similes and metaphors to describe the person. \r\n9. Have each student choose a different person to describe with similes and metahphors. Tell your students to base their comparisons on facts." });
                              list.Add(new string[] { "Students have a hard time understanding how characters interact", "Map out the interactions, have them act it out and let them web each character and what they know about them." });
                              list.Add(new string[] { "Students have a hard time understanding the cause of a character's problems and the effects", "Try making a timeline, a web, or a list to map the problems." });
                              break;
                         case 'N':
                         case 'O':
                         case 'P':
                         case 'Q':
                              list.Add(new string[] { "Students have a hard time with more literary language", "Give the words context - what do they mean and how do you use them. Have them think about why the author chose these words." });
                              list.Add(new string[] { "Students have a hard time understanding irony", "Put irony in a real world context, show them illustrations, have them look at cartoons, or write out some absurb situations and talk about them." });
                              list.Add(new string[] { "Students have a hard time following multiple characters in their story", "Draw multiple timelines, let them create a story map, or allow them to think about the difference scenarios and how they interact." });
                              list.Add(new string[] { "Students have a hard time understanding how parenthesis and metaphors are used to describe the character", "Have students think about how the parenthesis echoes what the author is saying about the character and what its doing." });
                              list.Add(new string[] { "Students have a hard time understanding character motivation", "Have students act what or who is pushing the character to do what they are doing." });
                              list.Add(new string[] { "Students have a hard time looking at multiple characters", "Web each character, or use a graphic organizer to look at all the characters in a story." });
                              list.Add(new string[] { "Students have a hard time comparing and contrasting characters across the text", "Draw a T chart or a venn diagram to compare and/or contrast the characters." });
                              list.Add(new string[] { "Students have a hard time thinking about the causes of a characters problems and the effects as it carries across the text", "Students should envision and listen to the sound of the characters. Students should act out the characters - their feelings, actions, and desires." });
                              list.Add(new string[] { "Students have problems with the setting and how the setting often tell us about the tone of the story", "Have them draw the setting. Let them recreate the tone of the story and what it means. Let them dramatize the text." });
                              list.Add(new string[] { "Students have difficulty understanding how the text should sound and the mood of the story", "Make it sound like a radio show. Think about the punctuation, where it's taking place, etc." });
                              break;
                         case 'R':
                         case 'S':
                         case 'T':
                              list.Add(new string[] { "Student has difficulty seeing more than one story", "Help student see there is more by creating a T chart to show the different stories." });
                              list.Add(new string[] { "Students can't interpret the issues in the study and how the trait matches how the student resolved the issues", "Help students track the issues and why they feel the character reacted this way or that. \r\nHave them envision what the character is feeling or saying." });
                              list.Add(new string[] { "Student is missing the double plot line in the story", "Do a double time line or reenact a scene." });
                              list.Add(new string[] { "Students misinterpret the character", "Have them look at alternative perspectives in a character have them compare and contrast characters." });
                              list.Add(new string[] { "Students do not understand the literary devices in the text", "Show them how flashback lives in a text and its purposes." });
                              list.Add(new string[] { "Students seem to not get the true meaning the author is putting out", "Have them monitor and stop more often, thinking about the characters in the story and the world." });
                              list.Add(new string[] { "Students read it literally and not inferentially", "Have students slow down and hear what the characters would say if they were part of the story.\r\nHave them read non fiction to help them understand the deeper picture or message." });
                              list.Add(new string[] { "Students seem to only get the basic gist of what's going on", "Have them reread a story or a paragraph that feels like it relays the central message or that story." });
                              list.Add(new string[] { "Student cannot accumulate all the information", "Have them annotate the text to look for important parts of theories." });
                              break;
                         case 'U':
                         case 'V':
                         case 'W':
                              list.Add(new string[] { "Students are misinterpreting the time period or the language structure of the text", "Let them question the time period and help them think about how they can search for the information. Let them study structures of text and why they are important." });
                              list.Add(new string[] { "Students cannot see the deeper meaning of the text and the message the author is trying to portray", "Have them monitor and stop-think about the dialogue, the internal work the characters are doing and the text as a representation of the world around them." });
                              list.Add(new string[] { "Student doesn't understand the setting of the story and the way characters acted during that time or place", "Have them look at nonfiction about the place or time period to put it into context." });
                              list.Add(new string[] { "Students are missing the idea of symbolism and what it represents", "Relate what symbolism is and how it helps you understand the deeper implication of the text." });
                              list.Add(new string[] { "Students read a text but fail to understand the satire within it", "Coach them on satire - what is satirical, what does it represent?" });
                              list.Add(new string[] { "Students fail to understand the adult concepts relating in this text", "Have them compare the text with the political issues or world concerns they see today." });
                              list.Add(new string[] { "Students read the text way too slow and miss the fluency within the text", "Have them work on the fluidity of the text - how it should sound and why" });
                              break;
                         case 'X':
                         case 'Y':
                         case 'Z':
                              list.Add(new string[] { "Students fail to understand the classical time period or the political innuendos in the text", "Let them research the period. Discuss what innuendo means and why authors use it." });
                              list.Add(new string[] { "Students have a hard time with the language", "Let them study the language structure of that time or place and the meaning behind it." });
                              list.Add(new string[] { "Students think about the characters but can't relate them to the world", "Let them study or think about world issues." });
                              list.Add(new string[] { "Students fail to see the tone or mood and how it creates an understanding of the plots and subplots in a text", "Teach students about tone and what it is. Let them use that and mood to think about all the different stories surrounding one central theme." });
                              list.Add(new string[] { "Students seem to be able to think about the story in a one dimensional way", "Create webs bringing out all parts of a text." });
                              list.Add(new string[] { "Student doesn't understand the author's work within the story and what they are trying to say", "Review authors craft and the moves that authors make within a text." });
                              break;
                         default:
                              list.Add(new string[] { "Unspecified", "Unspecified" });
                              break;

                    }
                    return list;

               }
          } //Suggestions property --> contains reading level information
     }
}
