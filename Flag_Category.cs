using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senior_Project
{
     class Flag_Category
     {
          /// <summary>
          /// A class to define the different flag categories, colors, 
          /// and what information each of them represent.
          /// </summary>

          private string color;
          private string category;
          private bool isDef;

          /*
           NAME

               Flag_Category::HasValue - returns if the struct has been defined.

           DESCRIPTION

               This function returns whether the class has been defined or not. 
               If the color and category are not specified, then the class is not defined.

            RETURNS

               True if defined, false if not defined.
          */
          public bool HasValue { get { return isDef; } }

          public string Color
          {
               get { return Color; }
               set
               {
                    if (value == "red" || value == "orange" || value == "yellow" || value == "green" || value == "blue")
                    {
                         color = value;
                         if (category != "")
                         {
                              isDef = true;
                         }
                    }
               }
          }

          public string Category
          {
               get { return category; }
               set
               {
                    if (value == "EI" || value == "VS" || value == "PW" || value == "PI")
                    {
                         category = value;
                         if(color != "")
                         {
                              isDef = true;
                         }
                    }
               }
          }

          /*
           NAME

               Flag_Category::Flag_Category - the constructor for the class.

           SYNOPSIS

               Flag_Category()

               Flag_Category(string n_category)

                    n_category --> the category the flag is in.

               Flag_Category(string n_color, string n_category)

                    n_color    --> the color of the flag
                    n_category --> the category the flag is in.
                    
           DESCRIPTION

               This function initializes the struct to a color and category. It also sets the
               isDef variable to true.
          */
          public Flag_Category()
          {
               color = "";
               category = "";
               isDef = false;
          }
          public Flag_Category(string n_color, string n_category)
          {
               string fc = n_color.ToLower();
               string c = n_category.ToUpper();
               if(fc == "red" || fc == "orange" || fc == "yellow" || fc == "green" || fc == "blue")
               {
                    if(c == "EI" || c == "VS" || c == "PW" || c == "PI")
                    {
                         color = fc;
                         category = n_category;
                         isDef = true;
                    }
                    else
                    {
                         color = "";
                         category = "";
                         isDef = false;
                    }
               }
               else
               {
                    color = "";
                    category = "";
                    isDef = false;
               }
          }
          public Flag_Category(string n_category)
          {
               string c = n_category.ToUpper();
               if (c == "EI" || c == "VS" || c == "PW" || c == "PI")
               {
                    color = "";
                    category = n_category;
                    isDef = true;
               }
               else
               {
                    color = "";
                    category = "";
                    isDef = false;
               }
          }

          public List<string> Observations
          {
               get
               {
                    if(category == "EI")
                    {
                         List<string> obs = new List<string>();
                         switch (color)
                         {
                              case "red":
                                   obs.Add("Student is going to the bathroom/sharpening pencils during reading workshop.");
                                   obs.Add("Student is reading for a short time, then putting book down.");
                                   obs.Add("Student is abandoning books.");
                                   obs.Add("When asked to read aloud, student's reading does not sound like talking - they are not reading with punctuation, and the reading is choppy.");
                                   break;
                              case "orange":
                                   obs.Add("Student is reading with book held away from them.");
                                   obs.Add("Student has bored expressions while reading and glances up frequently.");
                                   obs.Add("Student is reading books at one level without patterns (when asked why they chose a book, they might say ''I don't know, it was in the Q basket''.");
                                   obs.Add("When asked to stop reading, kids immediately shutting books and laying them down.");
                                   break;
                              case "yellow":
                                   obs.Add("Yourself saying 'I don't want to interrupt their reading to confer.' or 'As long as they are reading I'm happy'.");
                                   obs.Add("Student is talking about the content of their books only when asked what they are working on reading.");
                                   obs.Add("Student is reading books at one level without patterns (when asked, they might say they liked the cover).");
                                   break;
                              case "green":
                                   obs.Add("Student is reading with their book pulled close.");
                                   obs.Add("Student is drawing on repertoire of strategies when reading.");
                                   obs.Add("Student is making plans for what they want to read (either written or can say when asked)");
                                   obs.Add("Student is able to say goals for themself as a reader.");
                                   break;
                              case "blue":
                                   obs.Add("Student is reading nose-in-book, eyes on print and their faces will usually show great expression while they read (eyes widen, mouths drop open, chuckle, etc).");
                                   obs.Add("Student is reluctant to stop reading.");
                                   obs.Add("Student is reading every chance they get (in line, recess, etc).");
                                   obs.Add("Student is drawing on a repertoire of strategies.");
                                   obs.Add("Student has piles of books they want to read next.");
                                   break;
                         }
                         return obs;
                    }
                    else if(category == "VS")
                    {
                         List<string> obs = new List<string>();
                         switch (color)
                         {
                              case "red":
                                   obs.Add("Student is only reading at school or home.");
                                   obs.Add("Student is jumping from book to book.");
                                   obs.Add("Student is reading one book for longer than it should take.");
                                   obs.Add("Student is reading less than 10 x 12 pages in 15 mins.");
                                   break;
                              case "orange":
                                   obs.Add("Student is reading for inconsistent amounts of time.");
                                   obs.Add("Student is jumping from book to book.");
                                   obs.Add("Student is abandoning books.");
                                   break;
                              case "yellow":
                                   obs.Add("Student is reading for inconsistent amounts of time.");
                                   break;
                              case "green":
                                   obs.Add("Student is reading for the appropriate amount of time each day given their levels.");
                                   obs.Add("Student is finishing books in an appropriate amount of time given their reading level.");
                                   obs.Add("Student is making purposeful choices about what to read.");
                                   break;
                              case "blue":
                                   obs.Add("Student is often reading beyond the required amount of time.");
                                   obs.Add("Student is frequently reading for long chunks of time.");
                                   break;
                         }
                         return obs;
                    }
                    else if(category == "PW")
                    {
                         List<string> obs = new List<string>();
                         switch (color)
                         {
                              case "red":
                                   obs.Add("Partners are looking away from each other.");
                                   obs.Add("Partners' conversations running out of steam quickly - one partner speaks, then the other, then they are 'done'.");
                                   break;
                              case "orange":
                                   obs.Add("One partner probing, nudging the other to speak.");
                                   break;
                              case "yellow":
                                   obs.Add("Partners only agreeing with each other.");
                                   obs.Add("Partners talking without referring to the text.");
                                   obs.Add("Partners repeating the other's idea.");
                                   break;
                              case "green":
                                   obs.Add("Partners actively listening to each other and reflecting what the other has said.");
                                   obs.Add("Partners talking and referring to the text.");
                                   obs.Add("Partners repeating the other's idea and using prompts to build new ideas.");
                                   break;
                              case "blue":
                                   obs.Add("Partners using the books in their conversations and grounding all ideas in the text.");
                                   obs.Add("Partners coming prepared with questions, ideas, favorite parts marked.");
                                   obs.Add("Partners building on what the other says.");
                                   obs.Add("Partners keeping a conversation going for longer than required.");
                                   obs.Add("Partners speaking with passion about books.");
                                   break;
                         }
                         return obs;
                    }
                    else if(category == "PI")
                    {
                         List<string> obs = new List<string>();
                         switch (color)
                         {
                              case "red":
                                   obs.Add("Student has few or no post-its in their book.");
                                   break;
                              case "orange":
                                   obs.Add("Post-it notes reflect cursory reactions to text (may only restate what is happening).");
                                   break;
                              case "yellow":
                                   obs.Add("Post-its that all predict or all retell and so on, rather than showing a variety of responses to reading.");
                                   obs.Add("Post-its that all follow only the strategy taught that day rather than showing a repitoire of strategies learned previously.");
                                   break;
                              case "green":
                                   obs.Add("Post-it notes that show a reader is drawing on a repertoire of strategies.");
                                   break;
                              case "blue":
                                   obs.Add("Post-it notes show that reader sees when a part is best suited for a specific type of response.");
                                   break;
                         }
                         return obs;
                    }
                    else
                    {
                         new Log("Flag_Category.cs: Observations : get", "Error: category not assigned");
                         throw new Exception();
                    }
               }
          }
          public List<string> Responses
          {
               get
               {
                    if(category == "EI")
                    {
                         List<string> res = new List<string>();
                         switch (color)
                         {
                              case "red":
                                   res.Add("Quickly assess and match readers to books - you must get books that are within reach into their hands.");
                                   res.Add("Develop a plan for inspiring the community (do community circles around books, have frequent reading celebrations, show video clips about people helping each other to inspire)");
                                   res.Add("Get high-interest, popular, easy books into readers hands.");
                                   res.Add("Do book introductions and have other students do book buzzes to build up level of excitement around reading; have students make up recommendation charts and basket labels.");
                                   res.Add("Do lessons on finding tons of within-reach books.");
                                   res.Add("Do lessons on fluency and helping readers outgrow choppy, robotic sounding reading.");
                                   break;
                              case "orange":
                                   res.Add("Be sure readers are matched to books - readers will not be engaged unless they are reading books that are right for them.");
                                   res.Add("Develop a plan for inspiring the community (do community circles around books, have frequent reading celebrations, show video clips about people helping each other to inspire).");
                                   res.Add("Get high-interest, popular, easy books into reader's hands");
                                   res.Add("Do book introductions and have other students do book buzzes to build up level of excitement around reading; have students make up recommendation charts and basket labels.");
                                   res.Add("Be sure you are modeling loving reading yourself - wear a love of reading on your sleeve!");
                                   res.Add("During read-aloud, consistenly model passion in responding to stories.");
                                   res.Add("Do lessons on finding tons of within-reach books.");
                                   res.Add("Start doing lessons on reading yourself awake, holding onto meaning, and welcoming your books.");
                                   break;
                              case "yellow":
                                   res.Add("Be sure readers are matched to books!");
                                   res.Add("Get kids off of reading on 'autopilot!'");
                                   res.Add("Start doing lessons on reading yourself awake, holding onto meaning, and welcoming your books.");
                                   res.Add("During read-aloud consistently model 'think-alouds' which show kids the reading work you are doing as you read.");
                                   res.Add("Teach your readers to set important, ambitious goals.");
                                   break;
                              case "green":
                                   res.Add("Do lessons to teach readers that they should not just draw on all of the strategies that they have learned but that they should be purposeful in knowing what part of a story is best for a given strategy.");
                                   res.Add("Push students' independence and goal-setting by doing lessons about developing identity as a reader by learning from best and worst reading times, making honest, important resolutions.");
                                   res.Add("Model continuing to set goals that help you outgrow what you have been doing as a reader.");
                                   res.Add("Do lessons to heighten envisioning, inference, and interpretation skills.");
                                   break;
                              case "blue":
                                   res.Add("Get kids involved in their own private genre studies or author studies so that they are creating strong reading identities.");
                                   res.Add("Talk to teachers in grades above you and/or study the standards and learning progressions of grades above you to gain an understanding of what your highest readers need to learn next.");
                                   res.Add("Help kids to have ambitious goals that they can work on for two or three weeks ('Keep other books in mind while I am reading.' 'I will keep old books out on my desk and think across texts.')");
                                   break;
                         }
                         return res;
                    }
                    else if (category == "VS")
                    {
                         List<string> res = new List<string>();
                         switch (color)
                         {
                              case "red":
                                   res.Add("Be sure your readers are matched to books.");
                                   res.Add("Be sure you are giving readers protected reading time every day.");
                                   res.Add("Do a minilesson about how reading is like running. We need to set goals so we can read strong, fast, and long. We can use Post-it notes as goal posts and mark our books.");
                                   res.Add("Coach individual readers to outgrow early reading habits.");
                                   res.Add("Give readers time in share to discuss, analyze their logs, and problem solve.");
                                   res.Add("Talk directly to kids and have them set ambitious goals.");
                                   break;
                              case "orange":
                                   res.Add("Be sure readers are matched to books.");
                                   res.Add("Do lessons on fluency and reading with expression to improve rate, volume, and stamina.");
                                   res.Add("Talk directly to kids about how to make more time for reading, and have them set more ambitious goals.");
                                   break;
                              case "yellow":
                                   res.Add("Be sure readers are matched to books.");
                                   res.Add("Show students a mentor log and get them to name and notice patterns and help problem-solve, if necessary. Make a class 'Solution Chart'.");
                                   res.Add("Give readers time in share to discuss, analyze their own logs, and problem solve.");
                                   res.Add("Talk directly to kids about how to make more time for reading and set strong goals.");
                                   break;
                              case "green":
                                   res.Add("Talk directly to kids about the research in reading and the amounts they should be reading to excel as readers.");
                                   res.Add("Find powerful ways to celebrate readers' attempts to go above and beyond.");
                                   res.Add("Do lessons about using the reading log as a tool to let us know our patterns and what our leaps toward new work should be.");
                                   break;
                              case "blue":
                                   res.Add("Consistently remind students about using the log as an artifact to reflect on growth as a reader and set goals.");
                                   res.Add("Model reflecting your own log.");
                                   res.Add("Share reading research on rate, volume, and stamina with students.");
                                   res.Add("Have students use logs to record the whole of their reading lives (magazines, newspapers, websites, etc.)");
                                   res.Add("Help them keep their nonfiction reading life going while they are reading fiction.");
                                   break;
                         }
                         return res;
                    }
                    else if (category == "PW")
                    {
                         List<string> res = new List<string>();
                         switch (color)
                         {
                              case "red":
                                   res.Add("Have partners read aloud parts they love to each other.");
                                   res.Add("Teach partners ways to encourage and support each other.");
                                   res.Add("Do lessons on ways you can share your reading with a partner.");
                                   res.Add("Model partner talk.");
                                   break;
                              case "orange":
                                   res.Add("Ramp up passion around books within partnerships: you can model how to act out parts with a partner and have partners act out parts from their own books.");
                                   res.Add("Do lesson about how to read in the company of others.");
                                   res.Add("Coach into conversations.");
                                   res.Add("Give students prompts to help them listen to each other.");
                                   break;
                              case "yellow":
                                   res.Add("Do lesson about how to read in the company of others.");
                                   res.Add("Coach into conversations.");
                                   res.Add("Give prompts to help students build on each other's thoughts.");
                                   res.Add("Take the part of a proficient partner in a conversation.");
                                   res.Add("Teach kids to act out parts to learn more about how a character feels and get insight into what type of person a character is.");
                                   res.Add("Give time for students to prepare before talking.");
                                   res.Add("Show class a transcript of successful conversation and let kids name the moves that make it successful.");
                                   break;
                              case "green":
                                   res.Add("Do lessons on reading in the company of partners and thinking over stories with partners.");
                                   res.Add("Teach readers to act out parts to grow ideas and insights about texts.");
                                   res.Add("Talk to readers about how they can read differently because of their conversations.");
                                   res.Add("Fishbowl conversations and let readers name what is strong about these and/or offer suggestions.");
                                   break;
                              case "blue":
                                   res.Add("Take the part of a proficient partner and help ratchet up the level of the partnership's work.");
                                   res.Add("Have partners watch other partnerships to find new work they could try.");
                                   res.Add("Help partners to talk to each other not only about their books, but also their goals and how they can help each other.");
                                   break;
                         }
                         return res;
                    }
                    else if (category == "PI")
                    {
                         List<string> res = new List<string>();
                         switch (color)
                         {
                              case "red":
                                   res.Add("Teach readers to use Post-it notes as goal posts so they can read more.");
                                   res.Add("Teach readers to mark cool parts they are dying to talk about.");
                                   res.Add("Teach readers to mark parts that are confusing for them.");
                                   res.Add("Be sure materials are easily accessible to students.");
                                   break;
                              case "orange":
                                   res.Add("Do lessons on ways you can use Post-it notes as you read.");
                                   res.Add("Do shared writing as a class-create class mentor Post-it notes and hang them as charts.");
                                   res.Add("Consistenly model writing Post-it notes in the read-aloud.");
                                   res.Add("Model deeply passionate Post-its in a read-aloud.");
                                   break;
                              case "yellow":
                                   res.Add("Do shares/mid-workshop teaching points that remind students of the repitoire of ways they can use Post-its.");
                                   res.Add("Do shared writing as a class. Create different class mentor Post-it notes and hang them as charts along a learning progression and have kids label which one is their specific goal Post-it note.");
                                   res.Add("Have students look at others' Post-its and name what is strong that they can try.");
                                   res.Add("Give share time to partners to look at and assess each other's post-it notes.");
                                   break;
                              case "green":
                                   res.Add("Put up charts with more nuanced words to describe character traits/emotions.");
                                   res.Add("Do lessons on learning words from books and using these words in our writing and conversations about books.");
                                   res.Add("Create mentor Post-its and name for students what is strong about these, then let them try to create their own.");
                                   break;
                              case "blue":
                                   res.Add("Do lessons about looking over all of your Post-it notes, organizing and growing more ideas from looking at these.");
                                   res.Add("Do lessons about looking across your Post-its over time to assess your own growth as a reader and make new plans/set goals.");
                                   break;
                         }
                         return res;
                    }
                    else
                    {
                         new Log("Flag_Category.cs: Responses : get", "Error: category not assigned");
                         throw new Exception();
                    }
               }
          }
     }
}
