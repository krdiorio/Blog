using System;
using Blog.Models;
using Blog.Repositories;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog
{
    class Program
    {

        private static string CONNECTION_STRING = @"Server=localhost,1433;DataBase=Blog;User ID=sa;Password=bru12051";

        static void Main(string[] args)
        {
            var connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();

            //            ReadUsers(connection);
            // ReadRoles(connection);
            //ReadTags(connection);

            ReadUserWithRole(connection);
            //CreateUsers(connection);

            connection.Close();
        }

        public static void CreateUsers(SqlConnection connection)
        {
            var user = new User()
            {
                Email = "email@balta.io",
                Bio = "bio",
                Image = "image",
                Nome = "Name",
                PassWordHash = "hash",
                Slug = "slug"
            };
            var repository = new Repository<User>(connection);
            repository.Create(user);

        }
        public static void ReadUserWithRole(SqlConnection connection)
        {
            var repository = new UserRepository(connection);
            var users = repository.GetWithRoles();

            foreach (var item in users)
            {
                System.Console.WriteLine(item.Nome);

                foreach (var role in item.Roles)
                {
                    System.Console.WriteLine($" - {role.Name}");
                }
            }


        }
        public static void ReadUsers(SqlConnection connection)
        {

            var repository = new Repository<User>(connection);
            var items = repository.Get();

            foreach (var item in items)
            {
                Console.WriteLine(item.Nome);

                foreach (var role in item.Roles)
                {
                    System.Console.WriteLine($" - {role.Name}");
                }
            }
        }
        public static void ReadRoles(SqlConnection connection)
        {

            var repostory = new Repository<Role>(connection);
            var items = repostory.Get();

            foreach (var item in items)
            {
                System.Console.WriteLine(item.Name);
            }

        }
        public static void ReadTags(SqlConnection connection)
        {

            var repostory = new Repository<Tag>(connection);
            var items = repostory.Get();

            foreach (var item in items)
            {
                System.Console.WriteLine(item.Name);
            }

        }
        public static void UpdateUsers(SqlConnection connection)
        {

            var repository = new Repository<User>(connection);
            var item = repository.Get(2);
            item.Slug = "equipe-balta-dev";
            repository.Update(item);
        }
        public static void UpdateRole(SqlConnection connection)
        {

            var repository = new Repository<Role>(connection);
            var item = repository.Get(2);
            item.Slug = "equipe-balta-dev";
            repository.Update(item);
        }
        public static void UpdateTag(SqlConnection connection)
        {

            var repository = new Repository<Tag>(connection);
            var item = repository.Get(2);
            item.Slug = "equipe-balta-dev";
            repository.Update(item);
        }



    }
}
