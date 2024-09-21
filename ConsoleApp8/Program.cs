using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int arraySize = rand.Next(10, 21);
            int[] numbers = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                int randomNumber;
                do
                {
                    randomNumber = rand.Next(0, 101);
                } while (Array.Exists(numbers, x => x == randomNumber));

                numbers[i] = randomNumber;
            }

            Console.WriteLine($"Dizinin eleman sayısı: {arraySize}");


            Console.Write("Dizi elemanları: ");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();


            int min = numbers[0];
            int max = numbers[0];

            foreach (int num in numbers)
            {
                if (num < min) min = num;
                if (num > max) max = num;
            }

            Console.WriteLine($"En küçük sayı: {min}");
            Console.WriteLine($"En büyük sayı: {max}");
        }
    }


}
    
	

    

