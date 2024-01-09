namespace JCD1._5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Digite um número: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nSeguem abaixo os números em ordem crescente:");
            Array.Sort(numeros);
            Console.WriteLine("\n");
            foreach (int i in numeros) Console.WriteLine(i);   
            Console.WriteLine("\n");

        }
    }
}
