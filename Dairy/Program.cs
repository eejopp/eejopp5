using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dairy
{
    internal class Program
    {
        static List<Tag> tags = new List<Tag>();

        static void Init()
        {
            //Дата 1
            Tag tag = new Tag();
            tag.dateTime = new DateTime(2023, 10, 12);

            tag.notes = new List<Describe>();

            Describe describe = new Describe();
            describe.text = "Сходить на учебу";
            describe.info = "МПТ, Бритиш колледж";
            tag.notes.Add(describe);

            describe = new Describe();
            describe.text = "Сходить в магазин";
            describe.info = "Купить картошки";
            tag.notes.Add(describe);
            tags.Add(tag);
            //Дата 2
            tag = new Tag();
            tag.dateTime = new DateTime(2023, 10, 13);

            tag.notes = new List<Describe>();

            describe = new Describe();
            describe.text = "Отдохнуть";
            describe.info = "Сходить в кино";
            tag.notes.Add(describe);

            describe = new Describe();
            describe.text = "Поспать";
            describe.info = "Не забыть закрыть окно";
            tag.notes.Add(describe);
            tags.Add(tag);
            //Дата 3
            tag = new Tag();
            tag.dateTime = new DateTime(2023, 10, 14);

            tag.notes = new List<Describe>();

            describe = new Describe();
            describe.text = "Посмотреть сериал";
            describe.info = "Включить телевизор";
            tag.notes.Add(describe);

            describe = new Describe();
            describe.text = "Зайти в книжный";
            describe.info = "Купить концелярию";
            tag.notes.Add(describe);
            tags.Add(tag);

        }

        static void ShowArrow(int position)
        {
            Console.SetCursorPosition(0, position+1);
            Console.WriteLine("->");
        }
        static void Menu()
        {
            int current = 0;
            int position=0;
            ConsoleKeyInfo key;
            do
            {
                Console.WriteLine("Выбрана дата " + tags[current].dateTime.ToShortDateString());
                foreach (Describe describe in tags[current].notes)
                    Console.WriteLine("  "+describe.text);
                ShowArrow(position);

                key = Console.ReadKey();
                if (key.Key==ConsoleKey.Enter)
                {
                    Console.Clear();
                    Console.WriteLine(tags[current].notes[position].text);
                    Console.WriteLine("==========================");
                    Console.WriteLine("Описание:"+tags[current].notes[position].info);
                    Console.WriteLine("Дата " + tags[current].dateTime.ToShortDateString());
                    Console.ReadKey();
                }
                if (key.Key == ConsoleKey.UpArrow)
                {
                    if (position > 0)
                        position--;
                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    if (position < tags[current].notes.Count-1)
                        position++;
                }

                if (key.Key == ConsoleKey.LeftArrow)
                {
                    if (current > 0)
                        current--;
                }
                if (key.Key == ConsoleKey.RightArrow)
                {
                    if (current < tags.Count-1)
                        current++;
                }
                Console.Clear();
            }
            while (key.Key != ConsoleKey.Escape);
        }
        static void Main()
        {

            Init();
            Menu();
            Console.ReadKey();

        }
    }
}
