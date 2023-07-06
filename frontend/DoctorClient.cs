using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace frontend
{
   public class DoctorClient
   {
      private readonly JsonSerializerOptions options = new JsonSerializerOptions()
      {
         PropertyNameCaseInsensitive = true,
         PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
      };

      private readonly HttpClient client;
      private readonly ILogger<DoctorClient> _logger;

      public DoctorClient(HttpClient client, ILogger<DoctorClient> logger)
      {
         this.client = client;
         this._logger = logger;
      }

      public async Task<Doctores[]> GetDoctcliAsync()
      {
         try {
            var responseMessage = await this.client.GetAsync("/pizzainfo/doctores");
            
            if(responseMessage!=null)
            {
               var stream = await responseMessage.Content.ReadAsStreamAsync();
               return await JsonSerializer.DeserializeAsync<Doctores[]>(stream, options);
            }
         }
         catch(HttpRequestException ex)
         {
            _logger.LogError(ex.Message);
            throw;
         }
         return new Doctores[] {};

      }
   }
}