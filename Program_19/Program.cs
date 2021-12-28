using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_19
{
    class Comp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Frequency { get; set; }
        public string RAM { get; set; }
        public string HDD { get; set; }
        public string Video { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }

        public Comp(string name, string ram)
        {
            Name = name;
           RAM = ram;
        }

        public Comp()
        {
        }

        public override string ToString()
        {
            return $"{Id}\t {Name}\t {Type}\t {Frequency}\t {RAM}\t {HDD}\t {Video}\t {Price}\t {Count}";
        }

    }
    static class Program
    {
        static void Main(string[] args)
        {
            List<Comp> compList = new List<Comp>()
            {
                new Comp() {Id=1, Name="Intel", Type="Core i7", Frequency="3,0ГГц", RAM="32Гб", HDD="512Гб", Video="128Гб", Price=50000, Count=13},
                new Comp() {Id=2, Name="AMD", Type="Ryzen   ", Frequency="3,6ГГц", RAM="8Гб", HDD="512Гб", Video="512Гб", Price=60000, Count=2},
                new Comp() {Id=3, Name="Intel", Type="Xeon   ", Frequency="4,2ГГц", RAM="16Гб", HDD="1Тб", Video="512Гб", Price=70000, Count=45},
                new Comp() {Id=4, Name="AMD", Type="Athlon   ", Frequency="3,2ГГц", RAM="32Гб", HDD="3Тб", Video="1Тб", Price=80000, Count=22},
                new Comp() {Id=5, Name="Intel", Type="Core i7", Frequency="3,5ГГц", RAM="64Гб", HDD="1Тб", Video="264Гб", Price=90000, Count=19},
                new Comp() {Id=6, Name="Intel", Type="Core i9", Frequency="4,0ГГц", RAM="4Гб", HDD="2Тб", Video="1Тб", Price=100000, Count=35},
            };

            Console.Title = "ЗАДАНИЕ 19. LINQ";

            Console.WriteLine("\n\t\t\t\t\tСортировка по названию процессора\n");
            Console.Write("Введите название процессора: ");
            string name = Console.ReadLine();
            var sortName = compList.Where(x => x.Name == name);
            foreach (Comp x in sortName)
                Console.WriteLine(x);

            Console.WriteLine("\n\t\t\t\t\tСортировка по объему ОЗУ\n");
            Console.Write("Введите объём ОЗУ: ");
            string ram = Console.ReadLine();
            var sortRAM = compList.Where(x => x.RAM == ram);
            foreach (Comp x in sortRAM)
                Console.WriteLine(x);

            Console.WriteLine("\n\t\t\t\t\tСортировка по стоимости\n");
            var sortPrice = compList.OrderBy(x => x.Price);
            foreach (Comp x in sortPrice)
                Console.WriteLine(x);

            Console.WriteLine("\n\t\t\t\t\tГруппировка по типу процессора\n");
            var sortType = compList.GroupBy(x => x.Type);
            foreach (var type in sortType)
            {
                Console.WriteLine($"\nТип процессора: {type.Key}");
                foreach (var i in type)
                    Console.WriteLine(i);
            }

            Console.WriteLine("\n\t\t\t\t\tСамый дорогой и самый бюджетный\n");
            Console.WriteLine($"Самый дешевый компьютер {compList.OrderBy(x => x.Price).FirstOrDefault()}");
            Console.WriteLine($"Самый дорогой компьютер {compList.OrderByDescending(x => x.Price).FirstOrDefault()}");

            Console.WriteLine("\n\t\t\t\t\tСортировка по количеству\n");
            var sortCount = compList.Where(x => x.Count > 30);
            foreach (Comp x in sortCount)
                Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}

//1.Модель  компьютера характеризуется  кодом  и  названием  марки компьютера, типом  процессора, частотой  работы  процессора,
//объемом оперативной памяти, объемом жесткого диска, объемом памяти видеокарты, стоимостью компьютера в условных единицах и количеством экземпляров,
//имеющихся в наличии. Создать список, содержащий 6-10 записей с различным набором значений характеристик.

//Определить:

//-все компьютеры с указанным процессором. Название процессора запросить у пользователя;

//-все компьютеры с объемом ОЗУ не ниже, чем указано. Объем ОЗУ запросить у пользователя;

//-вывести весь список, отсортированный по увеличению стоимости;

//-вывести весь список, сгруппированный по типу процессора;

//-найти самый дорогой и самый бюджетный компьютер;

//-есть ли хотя бы один компьютер в количестве не менее 30 штук?
