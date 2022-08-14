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

        for (int i = 1; i <= 1000; i++)
        {
            if(i%2==1)
            tekSayac += i;
            else
            ciftSayac += i;

        }

        Console.WriteLine("Tek sayilarin toplami: " +tekSayac);
        Console.WriteLine("Cift sayilarin toplami: " +ciftSayac);

        //break, continue
        
        for (int i = 1; i < 10; i++)
        {
            if (i==4)
            break;
            Console.WriteLine(i);
        }

        for (int i = 1; i < 20; i++)
        {
            if(i==5 || i==10)
            continue;
            Console.WriteLine(i);
        }

    }
}