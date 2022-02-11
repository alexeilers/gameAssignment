namespace LabMids
{

    class Program
    {


        static void Main(string[] args)
        {    
               welcomeUser();     
        }

        public static void welcomeUser()
        {
            Console.WriteLine("Welcome to LabMids! The copyright-dodging version of everyone's favorite fill-in-the-blank word game.");
            Console.Write("First off, how would you like your name to appear in the LabMid Hall of Fame?: ");
            string userName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Nice to meet you, " + userName + "!");
            Console.WriteLine("_____________________________________");
            Console.WriteLine("Press ENTER to advance each screen --->");
            Console.ReadLine();
            Console.Clear();
            introScreen();

        }

        public static void introScreen()
        {
            Console.WriteLine("So you probably already know the drill, but here's how LabMids works:");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You'll select a topic, or we will select one for you...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("From there, you'll be prompted to come up with different kinds of words like nouns, adjectives, verbs, etc...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Once complete, we'll put it all together, and present you with your LabMid!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("If you're ready to rock and roll, press ENTER to reveal the topics");
            Console.ReadLine();
            Console.Clear();

            choiceMenu();

        }

        public static void choiceMenu()

        {
            Console.WriteLine(" SELECT A NUMBER -- 1) Road Trip -- 2) The Screaming Beagle -- 3) Mass Ave Madness -- 4) Lost at the State Fair");
            Console.Write("Which one would you like? ");
            string storyChoice = Console.ReadLine();
            Console.Clear();

            switch (storyChoice) 
            {
                case "1":
                roadTrip();  
                break; 

                case "2":    
                screamingBeagle();
                break;
            
                case "3":
                massAve();
                break;

                case "4":
                stateFair();
                break;

            }

        }

        
        
        public static void roadTrip()
        {
            Console.WriteLine("Roooooad triiiiiip!! Where are the snacks?");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Alright, get ready - I'm about to ask you to come up with a bunch of good words to make the best road trip story ever. Let's go!");
            Console.ReadLine();
            Console.Clear();
            Console.Write("PERSON'S NAME: ");
            string personOne = Console.ReadLine();
            Console.Clear();

            Console.Write("ADJECTIVE: ");
            string adjOne = Console.ReadLine();
            Console.Clear();

            Console.Write("VEHICLE: ");
            string vehicleOne = Console.ReadLine();
            Console.Clear();

            Console.Write("FOOD: ");
            string foodOne = Console.ReadLine();
            Console.Clear();

            Console.Write("ANOTHER FOOD: ");
            string foodTwo = Console.ReadLine();
            Console.Clear();

            Console.Write("DRINK: ");
            string drinkOne = Console.ReadLine();
            Console.Clear();

            Console.Write("ANIMAL: ");
            string animalOne = Console.ReadLine();
            Console.Clear();

            Console.Write("PAST TENSE VERB: ");
            string verbOne = Console.ReadLine();
            Console.Clear();


            Console.WriteLine("Summer is finally here! So " + personOne + " and I are going to load up our " + adjOne + " " + vehicleOne + " and head toward the coast! I packed lots of delicious snacks, like " + foodOne + ", " + foodTwo + ", and " + drinkOne + "." + " Hopefully it's not a repeat of last year, when a " + animalOne + " " + verbOne + " " + "all over our camping gear!");

            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("NICE! Do you want to do another LabMid? y/n)");
            string anotherRoundResponse = Console.ReadLine();
            if (anotherRoundResponse == "y")
            {
                Console.Clear();
                choiceMenu();
            }
            else if (anotherRoundResponse == "n") 
            {
                Console.Clear();
                gameOverScreen();
            }

        }

        public static void screamingBeagle()
        {
            Console.WriteLine("The screaming beagle. Oh man... I hope you brought ear plugs.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Alright, get ready - I'm about to ask you to come up with a bunch of good words to make the best story ever. Let's go!");
            Console.ReadLine();
            Console.Clear();
            Console.Write("NAME: ");
            string dogName = Console.ReadLine();
            Console.Clear();

            Console.Write("OCCUPATION: ");
            string personType = Console.ReadLine();
            Console.Clear();

            Console.Write("STORE NAME: ");
            string placeOne = Console.ReadLine();
            Console.Clear();

            Console.Write("OBJECT: ");
            string objectOne = Console.ReadLine();
            Console.Clear();

            Console.Write("DRINK: ");
            string drinkOne = Console.ReadLine();
            Console.Clear();

            Console.Write("GREETING: ");
            string greeting = Console.ReadLine();
            Console.Clear();

            Console.Write("CELEBRITY: ");
            string celebrityOne = Console.ReadLine();
            Console.Clear();

            Console.Write("VERB: ");
            string verbOne = Console.ReadLine();
            Console.Clear();

            Console.Write("ANOTHER VERB: ");
            string verbTwo = Console.ReadLine();
            Console.Clear();

            Console.Write("ANIMAL: ");
            string animalOne = Console.ReadLine();
            Console.Clear();

            Console.Write("NATURAL DISASTER: ");
            string disaster = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Have you ever heard a screaming dog? Me either, until I met " + dogName + " the beagle. I should have known this dog was going to be different when I bought them from a " + personType + " behind the old " + placeOne + ". " + "When we settled in at home, and the beagle quickly fell asleep on my " + objectOne + ". " + "After a few hours, I thought I should wake up " + dogName + " and take them outside, because they drank a lot of " + drinkOne + " on the car ride home. I tried saying, 'Psssst, " + greeting + " ... Wake up...' Nothing. 'Hey buddy, " + celebrityOne + " is here! Wake up!!' Still nothing. So I finally decided to pick them up and take them outside, and that's when I heard it. A sound like no other. A shriek that made me " + verbOne + " and " + verbTwo + ". " + "It sounded like a " + animalOne + " caught in a " + disaster + "!!!");

            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("NICE! Do you want to do another LabMid? y/n)");
            string anotherRoundResponse = Console.ReadLine();
            if (anotherRoundResponse == "y")
            {
                Console.Clear();
                choiceMenu();
            }
            else if (anotherRoundResponse == "n") 
            {
                Console.Clear();
                gameOverScreen();
            }

        }

        public static void massAve()
        {
            Console.WriteLine("Mass Ave Madness! I've had a few crazy nights downtown myself... ahem...");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Alright, get ready - I'm about to ask you to come up with a bunch of good words to make the best story ever. Let's go!");
            Console.ReadLine();
            Console.Clear();

            Console.Write("ADJECTIVE: ");
            string adjOne = Console.ReadLine();
            Console.Clear();

            Console.Write("NOUN: ");
            string nounOne = Console.ReadLine();
            Console.Clear();

            Console.Write("NAME: ");
            string nameOne = Console.ReadLine();
            Console.Clear();

            Console.Write("NUMBER: ");
            string numOne = Console.ReadLine();
            Console.Clear();

            Console.Write("ANOTHER NUMBER: ");
            string numTwo = Console.ReadLine();
            Console.Clear();

            Console.Write("CELEBRITY: ");
            string celebOne = Console.ReadLine();
            Console.Clear();

            Console.Write("TYPE OF FAMILY MEMBER: ");
            string familyMember = Console.ReadLine();
            Console.Clear();

            Console.Write("ADJECTIVE: ");
            string adjTwo = Console.ReadLine();
            Console.Clear();

            Console.Write("ANOTHER ADJECTIVE: ");
            string adjThree = Console.ReadLine();
            Console.Clear();

            Console.Write("FARM ANIMAL: ");
            string farmAnimal = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("I'll tell you right now, I will NEVER go to the " + adjOne + " " + nounOne + " bar and grill ever again. " + nameOne + " the bartender has the heaviest pour I've ever seen! Instead of just a single or double shot, he ends up pouring like " + numOne + " into one drink! At first, I thought that would be awesome, but after " + numTwo + " drinks, I started getting loopy! I thought I saw " + celebOne + " riding the mechanical bull, and by the end of the night, I could have sworn my dead " + familyMember + " was giving me stock market advice from beyond the grave! It was insane!! But the final straw... the reason I can never go back... on the way out, I called " + nameOne + " the bartender a " + adjTwo + " " + adjThree + " " + farmAnimal + "!!");

            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("NICE! Do you want to do another LabMid? y/n)");
            string anotherRoundResponse = Console.ReadLine();
            if (anotherRoundResponse == "y")
            {
                Console.Clear();
                choiceMenu();
            }
            else if (anotherRoundResponse == "n") 
            {
                Console.Clear();
                gameOverScreen();
            }

        }

        public static void stateFair()
        {
            Console.WriteLine("Lost at the State Fair. Hopefully there's a corndog stand nearby!");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Alright, get ready - I'm about to ask you to come up with a bunch of good words to make the best story ever. Let's go!");
            Console.ReadLine();
            Console.Clear();

            Console.Write("FOOD: ");
            string foodOne = Console.ReadLine();
            Console.Clear();

            Console.Write("SOMETHING AT THE CIRCUS: ");
            string circusThing = Console.ReadLine();
            Console.Clear();

            Console.Write("TYPE OF FAMILY MEMBER: ");
            string familyMember = Console.ReadLine();
            Console.Clear();

            Console.Write("NUMBER: ");
            string numOne = Console.ReadLine();
            Console.Clear();

            Console.Write("JUNK FOOD: ");
            string foodTwo = Console.ReadLine();
            Console.Clear();

            Console.Write("DRINK: ");
            string drinkOne = Console.ReadLine();
            Console.Clear();

            Console.Write("BODY PART: ");
            string bodyPart = Console.ReadLine();
            Console.Clear();

            Console.Write("TYPE OF PLANT: ");
            string plantOne = Console.ReadLine();
            Console.Clear();

            Console.Write("FARM ANIMAL: ");
            string farmAnimal = Console.ReadLine();
            Console.Clear();

            Console.Write("NOUN: ");
            string nounOne = Console.ReadLine();
            Console.Clear();

            Console.Write("ANOTHER NOUN: ");
            string nounTwo = Console.ReadLine();
            Console.Clear();


            Console.WriteLine("'I don't know!! I'm somewhere between the " + foodOne + " stand and the " + circusThing + " tent!!!' I remember screaming at my " + familyMember + ". This was about " + numOne + " hours after I had last seen anyone I knew. At first I really didn't think much of it, but after hours of consuming only " + foodTwo + ", " + drinkOne + ", and getting a terrible sunburn on my " + bodyPart + ", I was starting to get scared I would never make it back home or see my pet " + plantOne + " ever again. Thankfully, I stumbled upon the " + farmAnimal + " impression competition - my specialty - got on the microphone, and did my signature sound so the whole fair could hear me. One lady yelled, 'Holy " + nounOne + "!!' And I heard another guy say, 'What in the good " + nounTwo + " is all that racket?!' But then I finally heard a familiar voice hollering for me, and I saw my " + familyMember + " running towards me. Found at last!");

            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("NICE! Do you want to do another LabMid? y/n)");
            string anotherRoundResponse = Console.ReadLine();
            if (anotherRoundResponse == "y")
            {
                Console.Clear();
                choiceMenu();
            }
            else if (anotherRoundResponse == "n") 
            {
                Console.Clear();
                gameOverScreen();
            }
           
        }


        public static void gameOverScreen()
        {
            Console.WriteLine("Well done! Come back again soon!");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("COPYRIGHT 2022 EILERS ALBACETE LLC.");
        }
    }
}