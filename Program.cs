internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Lütfen bir sayi giriniz: ");
        int sayac = int.Parse(Console.ReadLine());

       for (int i = 0; i <  sayac; i++)
        {
            if(i%2==1)
            Console.WriteLine(i);
        }
         
        int tekSayac = 0;
        int ciftSayac = 0;

        for (int i = 0; i <= 1000; i++)
        {
            if(i%2==1)
            tekSayac += i;
            else
            ciftSayac += i;

        }

        Console.WriteLine("Tek sayilarin toplami: " +tekSayac);
        Console.WriteLine("Cift sayilarin toplami: " +ciftSayac);

    }
}