using AppContactBlazro.Data.DTOs;
using System.Net.Http.Json;

namespace AppContactBlazro.Data.Service
{
    public class ContactosService
    {
        private readonly HttpClient _httpClient;

        public ContactosService(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("AgendaApi");
        }

        // Obtener todos los contactos
        public async Task<List<ContactDTO>> GetContactsAsync()
        {
            var lista = await _httpClient.GetFromJsonAsync<List<ContactDTO>>("contactos");

            if (lista != null)
                return lista;
            else
                return new List<ContactDTO>();
        }

        // Crear un nuevo contacto
        public async Task<ContactDTO> CreatePostAsync(ContactDTO contacto)
        {
           
            var response = await _httpClient.PostAsJsonAsync("contactos", contacto);
            response.EnsureSuccessStatusCode();
            var postResult = await response.Content.ReadFromJsonAsync<ContactDTO>();
            if (postResult != null)
                return postResult;
            else
                return new  ContactDTO();
        }

        // Actualizar contacto
        public async Task UpdateContactAsync(ContactDTO contact)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/contactos/{contact.Id}", contact);
            response.EnsureSuccessStatusCode();
        }

        // Eliminar contacto
        public async Task DeleteContactAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/contactos/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}