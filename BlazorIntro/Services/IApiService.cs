using BlazorIntro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorIntro.Services
{
    public interface IApiService
    {
        Task<TodoItem[]> GetTodos();
    }
}
