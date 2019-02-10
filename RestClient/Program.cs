using RestClient.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestClient
{
    class Program
    {
        private const string todoService_Get = "https://jsonplaceholder.typicode.com/todos/1";
        private const string todosService_Get = "https://jsonplaceholder.typicode.com/todos";
        private const string usersService_Get = "https://reqres.in/api/users?page=2";
        private const string userService_Post = "https://reqres.in/api/users";

        static async Task Main(string[] args)
        {
            ToDo todoService_response = await RestUtility.CallServiceAsync<ToDo>(todoService_Get, string.Empty, null, "GET", string.Empty,
                string.Empty) as ToDo;

            IList<ToDo> lst_TodoService_response = await RestUtility.CallServiceAsync<IList<ToDo>>(todosService_Get, string.Empty, null, "GET",
                string.Empty, string.Empty) as IList<ToDo>;

            Users users = await RestUtility.CallServiceAsync<Users>(usersService_Get, string.Empty, null, "GET", string.Empty,
                string.Empty) as Users;

            UserPayload userPayload = new UserPayload()
            {
                Name = "John Doe",
                Job = "Software Engineer"
            };

            UserResponse userResponse = await RestUtility.CallServiceAsync<UserResponse>(userService_Post, string.Empty, userPayload, "POST", 
                string.Empty, string.Empty) as UserResponse;

            Console.ReadKey();
        }
    }
}
