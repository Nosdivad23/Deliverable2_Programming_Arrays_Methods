namespace Methods_2
{
    class Program
    {

        static int[] random_array(int array_len)
        {
            Random random = new Random();
            int[] MyArray = new int[array_len];
            for (int i = 0; i < array_len; i++)
            {
                MyArray[i] = random.Next(10, 50);
            }

            return MyArray;
        }


        static int sum(int[] array)
        {
            int sum = 0;
            foreach (int i in array)
            {
                sum = sum + i;
            }
            return sum;
        }
        static void Main(string[] args)
        {

            Boolean done = false;
            while (!done)
            {



                try
                {
                    Console.Write("Enter a number between 5 and 15: ");
                    int t = Convert.ToInt32(Console.ReadLine());
                    if ((t >= 5) && (t <= 15))
                    {
                        done = true;
                    }


                    else
                    {
                        Console.WriteLine("Please enter an integer between the range of 5 and 15.");
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Invalid integer.");
                }


                int input = Convert.ToInt32(Console.ReadLine());
                int[] MyArray = random_array(input);
                Console.Write("The elements in the random array are: ");
                foreach (int i in MyArray)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine(" ");
                Console.WriteLine("The sum is : " + sum(MyArray));
            }
        }
    }
}