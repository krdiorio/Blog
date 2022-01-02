using System;
using Blog.Screens.TagScreens;
using Microsoft.Data.SqlClient;

namespace Blog
{
    class Program
    {

        private static string CONNECTION_STRING = @"Server=localhost,1433;DataBase=Blog;User ID=sa;Password=bru12051";


        static void Main(string[] args)
        {

            DataBase.Connection = new SqlConnection(CONNECTION_STRING);
            DataBase.Connection.Open();
            Load();
            Console.ReadKey();
            DataBase.Connection.Close();
        }

        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("-----                 Menu Principal                -----");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("           <1> - Gestão Usuários");
            Console.WriteLine("           <2> - Gestão Perfil");
            Console.WriteLine("           <3> - Gestão Categoria");
            Console.WriteLine("           <4> - Gestão Tags");
            Console.WriteLine("           <5> - Vincular perfil / usuário");
            Console.WriteLine("           <6> - Vincular post/tag");
            Console.WriteLine("           <7> - Relatorios");
            Console.WriteLine("           <0> - Sair");
            Console.WriteLine("---------------------------------------------------------");
            Console.Write("Escolha uma opção: ");
            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 1:
                    Console.Clear();
                    Load();
                    break;
                case 2:
                    Load();
                    break;
                case 3:
                    Load();
                    break;
                case 4:
                    MenuTagScreen.Load();
                    break;
                case 5:
                    Load();
                    break;
                case 6:
                    Load();
                    break;
                case 7:
                    Load();
                    break;
                case 0:

                    break;
                default:
                    Load();
                    break;
            }
        }

    }
}

