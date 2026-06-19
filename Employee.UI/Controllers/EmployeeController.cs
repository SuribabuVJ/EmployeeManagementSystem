using Employee.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Json;

namespace Employee.UI.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly HttpClient _httpClient;

        public EmployeeController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
        }

        public async Task<IActionResult> Index()
        {
            var employees =
                await _httpClient.GetFromJsonAsync<List<EmployeeViewModel>>
                ("https://localhost:7193/api/Employee");

            return View(employees);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(EmployeeViewModel employee)
        {
            var response = await _httpClient.PostAsJsonAsync(
                "https://localhost:7193/api/Employee",
                employee);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(employee);
        }

        // GET: Employee/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var employee =
                await _httpClient.GetFromJsonAsync<EmployeeViewModel>(
                $"https://localhost:7193/api/Employee/{id}");

            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Employee/Edit
        [HttpPost]
        public async Task<IActionResult> Edit(EmployeeViewModel employee)
        {
            var response = await _httpClient.PutAsJsonAsync(
                "https://localhost:7193/api/Employee",
                employee);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(employee);
        }

        // GET: Employee/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            await _httpClient.DeleteAsync(
                $"https://localhost:7193/api/Employee/{id}");

            return RedirectToAction(nameof(Index));
        }
    }
}