using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello and welcome to this quiz!\nPlease enter your name: ");
            string playerName = Console.ReadLine();
            Console.WriteLine($"This quiz will consist of 5 multiple choice questions, I will be keeping score.\nChoose a letter to select your answer!");
            int score = 0;            
            Console.WriteLine("Question 1: Which of the following animals is considered man's best friend?\nA - Cat \nB - Dog \nC - Bird \nD - Fish");
            string answerOne = Console.ReadLine();
            answerOne = answerOne.ToUpper();
            switch (answerOne)
            {
                case "A":
                    Console.WriteLine("Cat is the wrong answer! No point awarded");
                    break;
                case "B":
                    score++;
                    Console.WriteLine($"Dog is the correct answer! Your score is now {score}");
                    break;
                case "C":
                    Console.WriteLine("Bird is the wrong answer! No point awarded");
                    break;
                case "D":
                    Console.WriteLine("Fish is the wrong answer! No point awarded");
                    break;
                default:
                    Console.WriteLine("You need to select one of the available answers!");
                    break;
            }
            Console.WriteLine("Question 2: The united kingdom is in which continent? \nA - Asia \nB - Antarctica \nC - North America \nD - Europe");
            string answerTwo = Console.ReadLine();
            answerTwo = answerTwo.ToUpper();
            switch (answerTwo)
            {
                case "A":
                    Console.WriteLine($"Asia is incorrect. Your score is still {score}!");
                    break;
                case "B":
                    Console.WriteLine($"Antarctica is incorrect. Your score is still {score}!");
                    break;
                case "C":
                    Console.WriteLine($"North America is incorrect. Your score is still {score}!");
                    break;
                case "D":
                    score++;
                    Console.WriteLine($"Well done! Europe is correct. Your score is now {score}!");
                    break;
                default:
                    Console.WriteLine("This is not a valid answer!");
                    break;
            }
            if (score >= 1)
            {
                Console.WriteLine($"Well done so far {playerName}!");
            }
            else
            {
                Console.WriteLine("Haha you havent got anything correct yet!!");
            }
            Console.WriteLine("Question 3: What does the \"D\"in D-day stand for? \nA - Dooms \nB - Dunkirk \nC - Dark");
            string answerThree = Console.ReadLine();
            answerThree = answerThree.ToUpper();
            switch (answerThree)
            {
                case "A":
                    score++;
                    Console.WriteLine($"Dooms is correct! Your score is now {score}");
                    break;
                case "B":
                    Console.WriteLine($"Dunkirk is incorrect! Your score is still {score}");
                    break;
                case "C":
                    Console.WriteLine($"Dark is incorrect! Your score is still {score}");
                    break;
                default:
                    Console.WriteLine("This is not a valid answer!");
                    break;
            }
            Console.WriteLine("Question 4: In C# what is used to make comments on your code? \nA - # \nB - // \nC - \" \nD - \\\\ ");
            string answerFour = Console.ReadLine();
            answerFour = answerFour.ToUpper();
            switch (answerFour)
            {
                case "A":
                    Console.WriteLine($"This answer is incorrect! # is used for comments in Python. \nYour score is still {score}");
                    break;
                case "B":
                    score++;
                    Console.WriteLine($"Correct! Here is a point! Your score is {score}");
                    break;
                case "C":
                    Console.WriteLine($"This answer is incorrect! Your score is still {score}");
                    break;
                case "D":
                    Console.WriteLine($"This answer is incorrect! Your score is still {score}");
                    break;
                default:
                    Console.WriteLine("Invalid answer!");
                    break;
            }
            Console.WriteLine($"Well done for making it this far {playerName}! \nThis next question is worth double points!");
            Console.WriteLine("Question 5: What data type is a whole number stored in? \nA - Float \nB - Double \nC - String \nD - Integer");
            string answerFive = Console.ReadLine();
            answerFive = answerFive.ToUpper();
            switch (answerFive)
            {
                case "A":
                    Console.WriteLine("You missed out on the double points!");
                    break;
                case "B":
                    Console.WriteLine("You missed out on the double points!");
                    break;
                case "C":
                    Console.WriteLine("You missed out on the double points!");
                    break;
                case "D":
                    score +=2;
                    Console.WriteLine("Well done! You got double point for this answer!!");
                    break;
                default:
                    Console.WriteLine("You missed out on this one by giving an invalid answer");
                    break;
            }
            switch (score)
            {
                case 6:
                    Console.WriteLine($"Congratulations {playerName}, you got all the questions correct! Your final score was {score}!");
                    break;
                case 5:
                    Console.WriteLine($"You did pretty well {playerName}, your final score was {score}!");
                    break;
                case 4:
                    Console.WriteLine($"You did ok on this quiz {playerName}, your final score was {score}!");
                    break;
                case 3:
                    Console.WriteLine($"You did ok on this quiz {playerName}, your final score was {score}!");
                    break;
                case 0:
                    Console.WriteLine($"Sorry {playerName}, you did awful on this quiz, better luck next time!");
                    break;
                default:
                    Console.WriteLine($"You didn't do too well on this quiz {playerName}, your final score was {score}!");
                    break;                 
            }
            Console.ReadLine();
        }
    }
}
