using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
    public class DeleteTagScreen
    {
        public static void Load()
        {

            Console.Clear();
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("-----               Excluir uma Tag                 -----");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine();

            Console.Write("Qual o Id da Tag que deseja excluir: ");
            var id = int.Parse(Console.ReadLine());

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine();

            Delete(id);

            Console.ReadKey();
            MenuTagScreen.Load();
        }

        private static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Tag>(DataBase.Connection);
                repository.Delete(id);
                Console.WriteLine("Tag excluíuda com sucesso ...");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível excluir Tag ...");
                Console.WriteLine(ex.Message);
            }
        }
    }
}