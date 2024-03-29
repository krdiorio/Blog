using System;

namespace Blog.Screens.TagScreens
{
    public class MenuTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("-----                 Gestão Tags                   -----");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("     <1> - Listar Tags");
            Console.WriteLine("     <2> - Cadatrar Tags");
            Console.WriteLine("     <3> - Atualizar Tags");
            Console.WriteLine("     <4> - Excluir Tags");
            Console.WriteLine("     <0> - Voltar");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("");
            Console.Write("Escolha uma opção: ");
            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 1:
                    ListTagScreen.Load();
                    break;
                case 2:
                    CreateTagScreen.Load();
                    break;
                case 3:
                    UpdateTagScreen.Load();
                    break;
                case 4:
                    DeleteTagScreen.Load();
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
