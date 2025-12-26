class Program
{
    static void Main(string[] args)
    {
        string nr1,nr2 = "";
        Console.WriteLine("Introduceti un numar: ");
        nr1 = Console.ReadLine();
        for (int i = nr1.Length - 1; i >= 0; i--)
        {
            nr2 += nr1[i];
        }

        if (nr1 == nr2)
        {
            Console.WriteLine("Palindrom");
        }
        else
        {
            Console.WriteLine("Nu este palindrom");
        }

    }
}

///ALTERNATIV CU METODA
// class Program
// {
//     void Palindrom (int n)
//     {
//         string nr = n.ToString();
//         string nr2 = "";
//         for (int i = nr.Length - 1; i >= 0; i--)
//         {
//             nr2 += nr[i];
//         }
//         if (nr == nr2)
//         {
//             Console.WriteLine("Palindrom");
//         }
//         else
//         {
//             Console.WriteLine("Nu este palindrom");
//         }
//     }
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Introduceti un numar: ");
//         int n = Convert.ToInt32(Console.ReadLine());
//         Program p = new Program();
//         p.Palindrom(n);


//     }
// }