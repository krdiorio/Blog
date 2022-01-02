using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
    public class UpdateTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("-----             Atualizando uma Tag               -----");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine();

            Console.Write("Id: ");
            var id = Console.ReadLine();

            Console.Write("Name: ");
            var name = Console.ReadLine();

            System.Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine();

            Update(new Tag
            {
                Id = int.Parse(id),
                Name = name,
                Slug = slug
            });

            Console.ReadKey();
            MenuTagScreen.Load();
        }

        private static void Update(Tag tag)
        {
            try
            {
                var repository = new Repository<Tag>(DataBase.Connection);
                repository.Update(tag);
                Console.WriteLine("Tag atualizada com sucesso ...");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar Tag ...");
                Console.WriteLine(ex.Message);


            }

        }
    }
}
