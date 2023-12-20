namespace Task3_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numbers = ReadNumbersFromUser();
                CheckDuplicates(numbers);

                if (numbers.Count > 0)
                {
                    Console.Write("[");
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        Console.Write(numbers[i]);
                        if (i < numbers.Count - 1)
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine("]");
                }

                Console.WriteLine("No duplicate numbers!");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        public static List<int> ReadNumbersFromUser()
        {
            List<int> numbers = new List<int>();
            Console.Write("How many numbers do you want to input? ");
            int count = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter an integer number:");
            for (int i = 0; i < count; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                numbers.Add(num);
            }

            return numbers;
        }

        public static void CheckDuplicates(List<int> numbers)
        {
            List<int> seenNumbers = new List<int>();

            foreach (int num in numbers)
            {
                if (seenNumbers.Contains(num))
                {
                    Console.WriteLine("Duplicate number found: " + num);

                    if (numbers.Count > 0)
                    {
                        Console.Write("[");
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            Console.Write(numbers[i]);
                            if (i < numbers.Count - 1)
                            {
                                Console.Write(" ");
                            }
                        }
                        Console.WriteLine("]");
                    }

                    throw new ArgumentException("Duplicate number found: " + num);
                }
                seenNumbers.Add(num);
            }
        }
    }
    
}

