

public class MathGameLogic
{
    public List<string> GameHistory { get; set; } = new List<string>();


    public void Menu()
    {

        Console.WriteLine("Welcome");
        Console.WriteLine("Select one option");
        Console.WriteLine("1 - Sum");
        Console.WriteLine("2 - Subtraction");
        Console.WriteLine("3 - Multiplication");
        Console.WriteLine("4 - Division");
        Console.WriteLine("5 - Show history");
        float option = float.Parse(Console.ReadLine());

        if(option < 1 || option > 5)
        {
            Console.WriteLine("Invalid option, please select a valid option");
            Thread.Sleep(2000);
            Console.Clear();
            Menu();
        }

        switch (option)
        {
            case 1: Sum(); break;

            case 2: Subtraction(); break;

            case 3: Multiplication(); break;

            case 4: Division(); break;

            case 5: History(); break;
        }


    }

    public void Sum()
    {
        Console.Clear();

        Random random = new();
        Console.WriteLine("Try to get this sum right");
        double num1 = random.Next(1, 100);
        double num2 = random.Next(1, 100);

        Console.WriteLine($"What is {num1} + {num2}?");

        double userAnswer;

        if (double.TryParse(Console.ReadLine(), out userAnswer))
        {
            double correctAnswer = num1 + num2;

            if (userAnswer == correctAnswer)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorrect!");
            }
        }


        Console.WriteLine($"The result of {num1} + {num2} is : {num1 + num2}");

        var gameHistory = $"{DateTime.Now} : {num1} + {num2} = {num1 + num2}";

        GameHistory.Add(gameHistory);

        Thread.Sleep(2000);

        Menu();
    }

    public void Subtraction()
    {
        Console.Clear();

        int i = 0;
        while (i < 5)
        {
            Random random = new();
            Console.WriteLine("Try to get this subtraction right");
            double num1 = random.Next(1, 100);
            double num2 = random.Next(1, 100);

            Console.WriteLine($"What is {num1} - {num2}?");
            double userAnswer;

            if (double.TryParse(Console.ReadLine(), out userAnswer))
            {
                double correctAnswer = num1 - num2;

                if (userAnswer == correctAnswer)
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect!");
                }
            }

            Console.WriteLine($"The result of {num1} - {num2} is : {num1 - num2}");

            var gameHistory = $"{DateTime.Now} : {num1} - {num2} = {num1 - num2}";

            GameHistory.Add(gameHistory);

            Thread.Sleep(2500);

            Console.Clear();

            i++;
        }

        Thread.Sleep(2000);

        Menu();

    }

    public void Multiplication()
    {
        Console.Clear();

        Random random = new();
        Console.WriteLine("Try to get this multiplication right");
        double num1 = random.Next(1, 100);
        double num2 = random.Next(1, 100);

        Console.WriteLine($"What is {num1} X {num2}?");

        double userAnswer;

        if (double.TryParse(Console.ReadLine(), out userAnswer))
        {
            double correctAnswer = num1 * num2;

            if (userAnswer == correctAnswer)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorrect!");
            }
        }


        Console.WriteLine($"The result of {num1} X {num2} is : {num1 * num2}");

        var gameHistory = $"{DateTime.Now} : {num1} X {num2} = {num1 * num2}";

        GameHistory.Add(gameHistory);

        Thread.Sleep(2000);

        Menu();
    }

    public void Division()
    {
        Console.Clear();

        Random random = new();
        Console.WriteLine("Try to get this division right");
        double num1 = random.Next(1, 100);
        double num2 = random.Next(1, 100);

        Console.WriteLine($"What is {num1} / {num2}?");

        double userAnswer;

        if (double.TryParse(Console.ReadLine(), out userAnswer))
        {
            double correctAnswer = num1 / num2;

            if (userAnswer == correctAnswer)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorrect!");
            }
        }


        Console.WriteLine($"The result of {num1} / {num2} is : {num1 / num2}");

        var gameHistory = $"{DateTime.Now} : {num1} / {num2} = {num1 / num2}";

        GameHistory.Add(gameHistory);

        Thread.Sleep(2000);

        Menu();
    }

    public void History()
    {
        Console.Clear();

        foreach (var i in GameHistory)
        {
            Console.WriteLine($"History: {i}");
        }

        Menu();
    }
}



