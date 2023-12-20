namespace Task3_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a string: ");
                string inputString = Console.ReadLine();
                CheckForVowels(inputString);
                Console.WriteLine("String contains vowels!");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        public static void CheckForVowels(string input)
        {
            if (!ContainsVowels(input))
            {
                throw new ArgumentException("String does not contain any vowels.");
            }
        }

        public static bool ContainsVowels(string input)
        {
            string vowels = "AEIOUaeiou";

            foreach (char character in input)
            {
                if (vowels.Contains(character))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
    
