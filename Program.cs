using System.IO;

namespace DZ_firstPart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int countApple;
            double weihgt;
            float height;
            byte age;
            bool falseTruePeople;
            uint path_Traveled;
            char firstNameLetter;
            string firstWord;
            short countGrapes;
            object nameDog;*/

            /*int paintings = 52;
             int row = 3;
             Console.WriteLine("количество заполненных рядов: " +paintings/row );
             Console.WriteLine("остаток картин сверх меры: " +paintings%row );*/

            float money;
            int crystalsCount;
            int priceCrystals = 10;
            bool moneyCount;
            //moneyCount = money / priceCrystals > 0;
            Console.WriteLine($"Добро пожаловать в магазин! Сегодня кристаллы стоят по {priceCrystals}");
            Console.WriteLine("Сколько у Вас денег?");
            money = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сколько кристаллов вам нужно?");
            crystalsCount = Convert.ToInt32(Console.ReadLine());
            moneyCount = money >= crystalsCount * priceCrystals;
            crystalsCount *= Convert.ToInt32(moneyCount);
            money -= crystalsCount * priceCrystals;

            Console.WriteLine($"у вас осталось в кошельке {money} монет и вы купили {crystalsCount} кристаллов");

            //----------------------------------

            /*Console.WriteLine("введите кол-во людей в очереди ");
            int countPeople=Convert.ToInt32(Console.ReadLine());
            int timeQueue = 10;
             Console.WriteLine($"Осталось ждать "+ (countPeople*10)/60 + " ч и "+(countPeople * 10) % 60+" минут");*/

            //------------------------------------------------
            /* Console.WriteLine("Как вас зовут?");
             string name = Console.ReadLine();
             Console.WriteLine("какой ваш знак зодиака?");
             string zodiac = Console.ReadLine();
             Console.WriteLine("Сколько вам лет");
             int age = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Где вы работаете?");
             string work = Console.ReadLine();

             Console.WriteLine($"Вас зовут {name}, вам {age}, вы {zodiac} и работаете в компании {work}.");
 */




        }
    }
}
