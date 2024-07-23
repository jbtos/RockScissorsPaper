
using System.ComponentModel;

Console.WriteLine("Rock, Paper, Scissors");

var keepPlaying = true;

Random random = new Random();

string randomOption = random.Next(1, 4).ToString();

while (keepPlaying)
{

    ShowMenu();


    string option = Console.ReadLine();

    if (option != "0"){
        Console.WriteLine($"You selected {option}\n");

        Console.WriteLine($"I chose {randomOption}\n");
    }

    switch (option)
    {
        case "1": 
            if (option == "1" && randomOption == "2") Console.WriteLine("Paper beats Rock, I Win!");
            else if (option == "1" && randomOption == "3") Console.WriteLine("Rock beats Scissors, You Win!");
            else Console.WriteLine("Tie!");
            break;
        case "3":
            if (option == "3" && randomOption == "1") Console.WriteLine("Rock beats Scissors, I Win!");
            else if (option == "3" && randomOption == "2") Console.WriteLine("Scissors beats Paper, You Win!");
            else Console.WriteLine("Tie!");
            break;
        case "2":
            if (option == "2" && randomOption == "3") Console.WriteLine("Scissors beats Paper, I Win!");
            else if (option == "2" && randomOption == "1") Console.WriteLine("Paper beats Rock, You Win!");
            else Console.WriteLine("Tie!");
            break;
        case "0":
            Console.WriteLine("Exit");
            keepPlaying = false;
            break;
        default:
            Console.WriteLine("Enter the Correct Values");
            break;
    }


    Thread.Sleep(5000);
    Console.Clear();


    randomOption = random.Next(1, 4).ToString();


}



void ShowMenu()
{
    Console.WriteLine("Opciones:\n 1.Rock\n 2.Paper\n 3.Scissors\n 0.Exit");
}