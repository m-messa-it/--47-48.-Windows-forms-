using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using PostServiceFormsApp.Models;

namespace PostServiceFormsApp.Services
{
    public class PostServiceClient
    {
        private readonly HttpClient _httpClient;
        public string BaseUrl { get; set; } = "http://localhost:5000/postings";

        // Локальний кеш / демо-дані на випадок відсутності підключення до бекенду
        private static readonly List<Posting> _mockPostings = new()
        {
            new Posting { Id = 101, From = "Київ", To = "Львів", Content = "Документи та договори", DeliveryType = 1, Weight = 0.5m, Width = 30m, Height = 2m, Depth = 21m, Value = 150m, Price = 90m },
            new Posting { Id = 102, From = "Рівне", To = "Луцьк", Content = "Подарунковий набір", DeliveryType = 0, Weight = 2.5m, Width = 25m, Height = 15m, Depth = 20m, Value = 750m, Price = 135m },
            new Posting { Id = 103, From = "Одеса", To = "Харків", Content = "Одяг та взуття", DeliveryType = 0, Weight = 4.2m, Width = 40m, Height = 20m, Depth = 30m, Value = 1200m, Price = 175m },
            new Posting { Id = 104, From = "Дніпро", To = "Полтава", Content = "Комп'ютерні аксесуари", DeliveryType = 1, Weight = 1.8m, Width = 20m, Height = 10m, Depth = 15m, Value = 2500m, Price = 160m }
        };

        public bool IsUsingMock { get; private set; } = false;

        public PostServiceClient()
        {
            _httpClient = new HttpClient
            {
                Timeout = TimeSpan.FromSeconds(3)
            };
        }

        // Отримати всі відправлення (GET /postings)
        public async Task<List<Posting>> GetAllAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync(BaseUrl);
                if (response.IsSuccessStatusCode)
                {
                    var items = await response.Content.ReadFromJsonAsync<List<Posting>>();
                    IsUsingMock = false;
                    return items ?? new List<Posting>();
                }
            }
            catch
            {
                // Сервер офлайн - переходимо на демонстраційний локальний режим
                IsUsingMock = true;
            }

            return new List<Posting>(_mockPostings);
        }

        // Створити нове відправлення (POST /postings)
        public async Task<Posting> CreateAsync(Posting posting)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync(BaseUrl, posting);
                if (response.IsSuccessStatusCode)
                {
                    var created = await response.Content.ReadFromJsonAsync<Posting>();
                    if (created != null) return created;
                }
                else
                {
                    var error = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Помилка сервера ({response.StatusCode}): {error}");
                }
            }
            catch (Exception ex) when (!ex.Message.StartsWith("Помилка сервера"))
            {
                // Якщо сервер недоступний - додаємо в локальний список
                IsUsingMock = true;
                int newId = _mockPostings.Count > 0 ? _mockPostings.Max(p => p.Id) + 1 : 101;
                posting.Id = newId;
                _mockPostings.Add(posting);
                return posting;
            }

            return posting;
        }

        // Оновити відправлення (PUT /postings/{id})
        public async Task<bool> UpdateAsync(int id, Posting posting)
        {
            posting.Id = id;
            try
            {
                var response = await _httpClient.PutAsJsonAsync($"{BaseUrl}/{id}", posting);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    var error = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Помилка сервера ({response.StatusCode}): {error}");
                }
            }
            catch (Exception ex) when (!ex.Message.StartsWith("Помилка сервера"))
            {
                // Локальне оновлення
                IsUsingMock = true;
                var existing = _mockPostings.FirstOrDefault(p => p.Id == id);
                if (existing != null)
                {
                    existing.From = posting.From;
                    existing.To = posting.To;
                    existing.Content = posting.Content;
                    existing.DeliveryType = posting.DeliveryType;
                    existing.Weight = posting.Weight;
                    existing.Width = posting.Width;
                    existing.Height = posting.Height;
                    existing.Depth = posting.Depth;
                    existing.Value = posting.Value;
                    existing.Price = posting.Price;
                    return true;
                }
                return false;
            }
        }

        // Видалити відправлення (DELETE /postings/{id})
        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                var response = await _httpClient.DeleteAsync($"{BaseUrl}/{id}");
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception($"Помилка видалення на сервері: {response.StatusCode}");
                }
            }
            catch (Exception ex) when (!ex.Message.StartsWith("Помилка видалення"))
            {
                // Локальне видалення
                IsUsingMock = true;
                _mockPostings.RemoveAll(p => p.Id == id);
                return true;
            }
        }
    }
}
