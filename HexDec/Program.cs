using System;

namespace convert
{
    class Converter
    {
        static readonly Random r = new Random();

        static void Main()
        {
            bool run = true;

            Console.WriteLine("Welcome to the Number Conversion Game by Jack Jefferson!");

            while (run) {
                Console.WriteLine("Please select an option from below:");

                Console.WriteLine("[1] Converting Base 2 (Binary)");
                Console.WriteLine("[2] Converting Base 10 (Denary)");
                Console.WriteLine("[3] Converting Base 16 (Hexadecimal)");
                Console.WriteLine("[4] About...");
                Console.WriteLine("[5 Exit]");

                int select = Convert.ToInt32(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        ConvertBin();
                        //Load Converting Base2
                        break;
                    case 2:
                        ConvertDec();
                        //Load Converting Base2
                        break;
                    case 3:
                        ConvertHex();
                        //Load Converting Base2
                        break;
                    case 4:
                        //Load Converting Base2
                        break;
                    case 5:
                        run = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice please try again.");
                        //Make effective way of looping the select switch statement.
                        break;

                }
            }
        }

        //Convert Binary Numbers
        static void ConvertBin()
        {
            int select = 0;
            int score = 0;

            string? uAnswer = "";
            string answerDec = "";
            string answerHex = "";
            string questionBin = "";


            for(int i = 0; i < 5; i++)
            {
                select = r.Next(1, 3);

                answerDec = r.Next(1, 65535).ToString();
                answerHex = Convert.ToString(int.Parse(answerDec), 16).ToUpper();
                questionBin = Convert.ToString(int.Parse(answerDec), 2);

                switch (select)
                {
                    case 1:
                        Console.Write("Please convert {0} to Decimal: ", questionBin);
                        uAnswer = Console.ReadLine();
                        if (uAnswer == answerDec)
                        {
                            Console.WriteLine("Well done! +1 point.");
                            score++;
                        } else
                        {
                            Console.WriteLine("That was not the correct answer.");
                            Console.WriteLine("The correct answer was: {0}", answerDec);
                        }
                        break;
                    case 2:
                        Console.Write("Please convert {0} to Hexadecimal: ", questionBin);
                        
                        uAnswer = Console.ReadLine();
                        if (uAnswer == answerHex)
                        {
                            Console.WriteLine("Well done! +1 point.");
                            score++;
                        }
                        else
                        {
                            Console.WriteLine("That was not the correct answer.");
                            Console.WriteLine("The correct answer was: {0}", answerHex);
                        }
                        break;
                    default:
                        Console.WriteLine("Wait... What?");
                        break;
                }
            }

            if(score < 2)
            {
                Console.WriteLine("You fail. Please make sure to revise!");
            } 
            
            else if(score == 3 || score == 4)
            {
                Console.WriteLine("Well done! Make sure to revise so you can get 100%!");
            }

            else
            {
                Console.WriteLine("Congrats on 100%!");
            }
        }

        static void ConvertDec()
        {
            int select = 0;
            int score = 0;

            string? uAnswer = "";
            string answerBin = "";
            string answerHex = "";
            string questionDec = "";

            for(int i = 0; i < 5; i++){
                select = r.Next(1, 3);

                questionDec = r.Next(1, 65535).ToString();

                answerBin = Convert.ToString(int.Parse(questionDec), 2);
                answerHex = Convert.ToString(int.Parse(questionDec), 16).ToUpper();

                switch(select){
                    case 1:
                        Console.WriteLine("Please convert {0} to Binary", questionDec);
                        uAnswer = Console.ReadLine();

                        if(uAnswer == answerBin){
                            Console.WriteLine("Well done! +1 point.");
                            score++;
                        } else {
                            Console.WriteLine("That was not the correct answer.");
                            Console.WriteLine("The correct answer was: {0}", answerBin);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Please convert {0} to Hexadecimal", questionDec);
                        
                        uAnswer = Console.ReadLine();
                        if(uAnswer == answerHex){
                            System.Console.WriteLine("Well done! +1 point.");
                            score++;
                        } else{
                            Console.WriteLine("That was not the correct answer.");
                            Console.WriteLine("The correct answer was: {0}", answerHex);
                        }

                        break;
                    default:
                    System.Console.WriteLine("Error!");
                        break;
                }
            }

            if(score < 2)
            {
                Console.WriteLine("You fail. Please make sure to revise!");
            } 
            
            else if(score == 3 || score == 4)
            {
                Console.WriteLine("Well done! Make sure to revise so you can get 100%!");
            }

            else
            {
                Console.WriteLine("Congrats on 100%!");
            }
        }

        static void ConvertHex()
        {

        }
    }
}