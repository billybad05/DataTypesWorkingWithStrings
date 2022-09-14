namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string phrase = ($"Max Training is cool"); //string of characters
                            // 0123456789 phrase index
            char grade = 'A'; // one character
            int age = 30; // int number
            double gpa = 3.3; //decimal numbers float least precise, double, decimal most precise
            bool isMale = true; //bool expression true or false

            //Working with strings
            //methods block of code we can call to perform a task

            Console.WriteLine(phrase.ToUpper()); // all upper case
            Console.WriteLine(phrase.Length); // length of phrase
            Console.WriteLine(phrase.ToLower()); // all lower case
            Console.WriteLine(phrase.Contains("Max")); // true or false
            Console.WriteLine(phrase[9]); // index of character in phrase
            Console.WriteLine(phrase.IndexOf("Training")); // tells location of indexed character
            Console.WriteLine(phrase.Substring(8, 3)); // grabs part of a string strarts grabbing a first number and if wanted second number tells where to end
            Console.WriteLine("Max\nTraining"); // \n puts on next line down

            Console.ReadLine();
        }
    }
}