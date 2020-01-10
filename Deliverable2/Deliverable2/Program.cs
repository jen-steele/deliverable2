using System;



namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Type message to encrypt: ");

            var input = Console.ReadLine();
            var checksum = 0;


            foreach (char letter in input)
            {
                var upperCase = char.ToUpper(letter);
                var message = ((int)upperCase) - 64;
                Console.WriteLine(message);


                //checksum
                checksum = message + checksum;

            }

            Console.WriteLine("\nchecksum: " + checksum);
        }

    }
}