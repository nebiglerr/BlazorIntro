using BlazorIntro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorIntro.Services
{
    public class MyApi : IApiService
    {
        private HttpClient _http;

        public MyApi(HttpClient http)
        {
            _http = http;
        }
        public Task<TodoItem[]> GetTodos()
        {
            //_http.GetJsonAsync<TodoItem[]>("https://jsonplaceholder.typicode.com/todos?id=2")
            return null;

        }
       
    }
}
