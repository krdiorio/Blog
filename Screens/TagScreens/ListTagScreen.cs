using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
    public class ListTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("-----               Lista de Tags                   -----");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine();
            List();
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine();
            System.Console.Write("Pressione qualquer tecla para voltar ...");
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        private static void List()
        {
            var repositorio = new Repository<Tag>(DataBase.Connection);
            var tags = repositorio.Get();
            foreach (var item in tags)
            {
                Console.WriteLine($"{item.Id} - {item.Name} - {item.Slug}");
            }
        }
    }
}