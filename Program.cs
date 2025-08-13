using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{

    static void Main()
    { 

        Console.WriteLine("---Консольный кликер");

        while (true) {
        Console.WriteLine("Меню взаимодействия");
        Console.WriteLine("K - Кликать");
        Console.WriteLine("M - Профиль");    
        Console.WriteLine("E - Апгрейды");
        Console.WriteLine("Q - Выход");

        Console.WriteLine("Введите операцию: ");
        var key = Console.ReadKey(true).Key;

            if (key == ConsoleKey.K)
            {
                RunClicker();
            }
            else if (key == ConsoleKey.E)
            {
                RunUpgrades();
            }
            else if (key == ConsoleKey.B)
            {
                RunBuildingsStore();
            }

            else if (key == ConsoleKey.M)
            {
                ProfileMenu();
            }
            else
            {
                Console.WriteLine("Выход из игры");
                return;
            }
        }
    }



    static int resource = 0;
    static int upgradeCost = 100;
    static int clickerPower = 1;
   

   
    static void RunClicker()
    {
        Console.WriteLine("Нажимайте на 'С' чтобы получать энергию");
        Console.WriteLine("Нажмите на 'Q' чтобы выйти в основное меню");
        Console.WriteLine("Ввод");

        while (true)
        {

            var key = Console.ReadKey(true).Key;

            if (key == ConsoleKey.C)
            {
                resource += clickerPower;
                Console.WriteLine($"Энергия +{clickerPower}");

                Console.WriteLine($"\nЭнергия: {resource}");
                
            }

            else if (key == ConsoleKey.Q)
            {
                break;
            }
        }
    }

    static void RunUpgrades()
    {
        Console.WriteLine("Меню улучшений:");
        Console.WriteLine($"\n\t\t[--- Улучшить клик (+3 за одинк клик) = {upgradeCost} энергии \t Покупка = 'A' ]");
        Console.WriteLine("Выйти - нажмите 'Q'");
        while (true)
        {

            var key = Console.ReadKey(true).Key;

            if (resource >= upgradeCost && key == ConsoleKey.A)
            {
                clickerPower += 2;
                resource -= 100;

                Console.WriteLine($"Потрачено {upgradeCost} энегрии кликер теперь == {clickerPower}");
                upgradeCost = (int)(upgradeCost + 0.5 * upgradeCost);
            }
            else if (resource < upgradeCost && key == ConsoleKey.A)
            {
                Console.WriteLine($"Недостаточно ресурсов {resource} < {upgradeCost}");
                break;
            }
            else if (key == ConsoleKey.Q) 
            {
                return;
            }
        
        }
        
    }
    static int incomePerSecond = 0;

    static void ProfileMenu()
    {

        Console.WriteLine("Нажмите 'Q' чтобы выйтив главное меню");
        Console.WriteLine($"Профиль\n Доход в секунду - {incomePerSecond} \n Энергия - {resource} \n Сила клика - {clickerPower}");
        while (true) { 
        var key = Console.ReadKey(true).Key;

            if (key == ConsoleKey.Q) 
            {
                return;
            }
        }
    }

    static void RunBuildingsStore() 
    {
    
    }
}

