
    int num1 = 0; int num2 = 0;

    Console.WriteLine("       kalkulator C#\r");
    Console.WriteLine("------------------------\n");

    Console.WriteLine("nomor ke 1: ");
    num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("nomor ke 2: ");
    num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Pilih opsi yang kamu inginkan:");
    Console.WriteLine("\t+ - Tambah");
    Console.WriteLine("\t- - Kurang");
    Console.WriteLine("\t* - Perkalian");
    Console.WriteLine("\t/ - Pembagian");
    Console.Write("Your option? ");

    switch (Console.ReadLine())
    {
        case "+":
            Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
            break;
        case "-":
            Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
            break;
        case "*":
            Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
            break;
        case "/":
            Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
            break;
    }
   
    Console.Write("Press any key to close the Calculator console app...");
    Console.ReadKey();
