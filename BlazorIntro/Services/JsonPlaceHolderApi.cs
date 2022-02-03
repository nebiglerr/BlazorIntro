using BlazorIntro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
namespace BlazorIntro.Services
{
    public class JsonPlaceHolderApi:IApiService
    {
        private HttpClient _http;

        public JsonPlaceHolderApi(HttpClient http)
        {
            _http = http;
        }

        public Task<TodoItem[]> GetTodos()
        {
            //_http.GetAsync<TodoItem[]>("https://jsonplaceholder.typicode.com/todos")
            return null;
        }
       
    }
}
