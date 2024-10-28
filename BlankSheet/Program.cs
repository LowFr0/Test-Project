internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();
        //String choice;
        //String computer;
        bool playAgain = true;
        //int rand = random.Next(1, 4);

        while (playAgain)
        {
            int rand = random.Next(1, 4);
            String choice = "";
            String computer = "";
            Console.WriteLine("Lets play rock paper scissors!Now tell me which will you choose?");
            choice = Console.ReadLine();
            choice = choice.ToUpper();

            switch (rand)
            {
                case 1:
                    computer = "ROCK";
                    break;
                case 2:
                    computer = "PAPER";
                    break;
                case 3:
                    computer = "SCISSORS";
                    break;
            }
            //Console.WriteLine(rand);
            //Console.WriteLine(choice);
            Console.WriteLine(computer);

            switch (choice)
            {
                case "ROCK":
                    if (computer == "ROCK")
                    {
                        Console.WriteLine("Its a draw");
                    }
                    else if (computer == "PAPER")
                    {
                        Console.WriteLine("I win!!!");
                    }
                    else if (computer == "SCISSORS")
                    {
                        Console.WriteLine("I lose...");
                    }
                    break;
                case "PAPER":
                    if (computer == "ROCK")
                    {
                        Console.WriteLine("I lose...");
                    }
                    else if (computer == "PAPER")
                    {
                        Console.WriteLine("Its a draw");
                    }
                    else if (computer == "SCISSORS")
                    {
                        Console.WriteLine("I win!!!");
                    }
                    break;
                case "SCISSORS":
                    if (computer == "ROCK")
                    {
                        Console.WriteLine("I win!!!");
                    }
                    else if (computer == "PAPER")
                    {
                        Console.WriteLine("I lose...");
                    }
                    else if (computer == "SCISSORS")
                    {
                        Console.WriteLine("Its a draw");
                    }
                    break;
            }
        }

       

        
        
    }
}