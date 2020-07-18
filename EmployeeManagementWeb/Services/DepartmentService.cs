using EmployeeManagementModels.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace EmployeeManagementWeb.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly HttpClient _httpClient;

        public DepartmentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<Department> GetDepartment(int id)
        {
            return await _httpClient.GetJsonAsync<Department>($"api/departments/{id}");
        }

        public async Task<IEnumerable<Department>> GetDepartments()
        {
            return await _httpClient.GetJsonAsync<Department[]>("api/departments");
        }
    }
}
