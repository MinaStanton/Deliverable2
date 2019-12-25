//Mina Stanton
//Program description: This program will take a word from the user and convert it to a basic encoded message.

using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            String input, message = ""; //utilizing variable input to get user input from the console and message to display the encoded message
            int checksum = 0, sum; //utilizing variable checksum to keep track of the value sum of the unicode/ascii values
           

            Console.WriteLine("Hello, please enter the message you would like encoded.");
            input = Console.ReadLine();
            input = input.ToUpper(); //converting message to uppercase
            Console.WriteLine();//creating a line space to console readability

            for (int i = 0; i < input.Length; i++) //loop utilized to run through the string input 
            {
                sum = input[i];
                checksum += sum; 
                sum -= 64; //subtracting 64 in order to get the encoded value
                message = message + sum + "-";  //adding the sum each iteration to the string message
            }

            //outputting the message and checksum total
            Console.WriteLine("Your encoded message is " + message);
            Console.WriteLine("Message checksum is: " + checksum);
        }
    }
}
