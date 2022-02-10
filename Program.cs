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
            Console.WriteLine("Welcome to LabMids! The classic fill-in-the-blank game with a twist.");
            Console.Write("First off, how would you like your name to appear in the LabMid Hall of Fame?: ");
            string userName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Nice to meet you, " + userName + "!");
            Console.WriteLine("Alright, enough of the pleasentries - let's get down to it! Press ENTER to advance.");
            Console.ReadLine();
            Console.Clear();
            twistScreen();

        }

        public static void twistScreen()
        {
            Console.WriteLine("OH! Wait a minute. I forgot to tell you what the twist is!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("In *other* word games like this, one of the players gets to see the story as you go along...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Well, we didn't really like that, because that person usually ends up laughing, or giving something away, or killing the vibe for the word-giver...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("So we said forget it - no story until the finished product is ready!"); 
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You will be prompted to give nouns, verbs, adjectives, etc., we will do all the magic in the background, and then present you with your Shakespearean work of art.");
            Console.ReadLine();
            Console.Clear();
            choiceMenu();

        }

        public static void choiceMenu()
        {
            Console.WriteLine("To kick off our LabMid, you'll need to select a topic, or if you're feeling brave, you can select random and we'll pick a topic for you.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(" SELECT A NUMBER -- 1) Road Trip -- 2) The Screaming Beagle -- 3) Mass Ave Massacre -- 4) Lost at the State Fair -- 5) Snowpocalypse -- 6) Random");
            Console.Write("Which one would you like? ");
            string storyChoice = Console.ReadLine().ToLower();
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

                case "5":
                snowStorm();
                break;

                case "6":
                case "random":    
                randomLabMid();
                break;

                default:
                Console.WriteLine("Sorry, I didn't catch that. Please select a number.");
                choiceMenu();
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
            Console.Write("PERSON: ");
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

        }

        public static void screamingBeagle()
        {
            Console.WriteLine("Adam's screaming beagle. Oh man... I hope you brought ear plugs.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Alright, get ready - I'm about to ask you to come up with a bunch of good words to make the best story ever. Let's go!");
            Console.ReadLine();
            Console.Clear();
            Console.Write("NAME: ");
            string dogName = Console.ReadLine();
            Console.Clear();

            Console.Write("TYPE OF PERSON: ");
            string personType = Console.ReadLine();
            Console.Clear();

            Console.Write("PLACE: ");
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

            Console.WriteLine("Have you ever heard a screaming dog? Me either, until I met " + dogName + " the beagle. I should have known this dog was going to be different when I bought them from a " + personType + " in " + placeOne + ". " + "When we got home, we quickly settled in, and the beagle quickly fell asleep on my " + objectOne + ". " + "After a few hours, I thought I should wake up " + dogName + " and take them outside, because they drank a lot of " + drinkOne + " on the car ride home. I tried saying, 'Psssst, " + greeting + " ... Wake up...' Nothing. 'Hey buddy, " + celebrityOne + " is here! Wake up!!' Still nothing. So I finally decided to pick them up and take them outside, and that's when I heard it. A sound like no other. A shriek that made me " + verbOne + " and " + verbTwo + "." + "It sounded like a " + animalOne + " caught in a " + disaster + "!!!");

        }

        public static void massAve()
        {
            Console.WriteLine("Mass Ave Massacre! I've had a few massacres downtown myself... ahem...");
            Console.ReadLine();
            Console.Clear();

        }

        public static void stateFair()
        {
            Console.WriteLine("Lost at the State Fair. Hopefully there's a corndog stand nearby!");
            Console.ReadLine();
            Console.Clear();

        }

        public static void snowStorm()
        {
            Console.WriteLine("SNOWPOCALYPSE! Hope you went and bought 40 gallons of milk.");
            Console.ReadLine();
            Console.Clear();

        }

        public static void randomLabMid()
        {
            Console.WriteLine("You brave soul... let me see what I can cook up...");
            Console.ReadLine();
            Console.Clear();

        }


    }
}