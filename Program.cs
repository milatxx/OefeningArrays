using System;

class Animals
{
    static void Main(string[] args)
    {
        string[] arr = new string[4];
        arr[0] = "Hond";
        arr[1] = "Kat";
        arr[2] = "Olifant";
        arr[3] = "Papegaai";

        Console.WriteLine("Eerste array:");
        Toon(arr);

        arr = Vergroot(arr, "Dolfijn");
        arr = Vergroot(arr, "Leeuw");
        arr = Vergroot(arr, "Zebra");

        Console.WriteLine("Na toevoegen:");
        Toon(arr);

        Console.ReadLine();
    }

    static string[] Vergroot(string[] oud, string extra)
    {
        string[] nieuw = new string[oud.Length + 1];
        for (int i = 0; i < oud.Length; i++)
        {
            nieuw[i] = oud[i];
        }
        nieuw[nieuw.Length - 1] = extra;
        return nieuw;
    }

    static void Toon(string[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}
