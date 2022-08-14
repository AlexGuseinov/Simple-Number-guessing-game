
namespace app
{
    public class person
    {

        public class app
        {
            public static void Main(string[] args)
            {
                Random random = new Random();
                bool playAgain = true;
                int max = 100;
                int min = 1;
                int number;
                int guess;
                int guesses;
                string response;

                while (playAgain)
                {
                    guess = 0;
                    guesses = 0;
                    response = "";
                    number = random.Next(min, max + 1);


                    while (guess != number)
                    {
                        System.Console.WriteLine("guess a number between " + min + " - " + max + " : ");
                        guess = Convert.ToInt32(System.Console.ReadLine());
                        System.Console.WriteLine("guess: " + guess);

                        if (guess > number)
                        {
                            System.Console.WriteLine(guess + " number is too high");

                        }

                        else if (guess < number)
                        {
                            System.Console.WriteLine(guess + " number is too low");

                        }


                        guesses++;

                    }

                    System.Console.WriteLine("number: " + number);
                    System.Console.WriteLine("u won!!");
                    System.Console.WriteLine("guesses: " + guesses);

                    System.Console.WriteLine("would u like to play again? (Y/N) ?");
                    response = System.Console.ReadLine();
                    response = response.ToUpper();
                    if (response == "Y")
                    {
                        playAgain = true;
                    }
                    else
                    {
                        playAgain = false;
                    }

                }

            }

        }
    }

}

