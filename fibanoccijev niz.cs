namespace uvodnaVježba04___ivano_karkovic_3.D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int broj1, rezultat = 0, pret1 = 1, pret2 = 0;
            Console.WriteLine("Unesi broj za n ---> ");
            broj1 = int.Parse(Console.ReadLine());
            if (broj1 == 0)
            {
                Console.WriteLine(" rezultat je 0 ");
            }
            if (broj1 == 1)
            {
                Console.WriteLine(" rezultat je 1 ");
            }

            if (broj1 > 1)
            {
                for (int i = 0; i < broj1; i++)
                {
                    for (int a = 1; a < broj1; a++)
                    {
                        rezultat = pret2 + pret1;
                        pret2 = pret1;
                        pret1 = rezultat;
                    }
                }
            }
            Console.WriteLine(" Rezultat Fibonaccijevog niza je " + rezultat);
            Console.ReadKey();
        }
    }
}