using Client_Shiplink.Models;
using Client_Shiplink.ViewModel;
using Client_Shiplink.ViewModel.Response;
using Newtonsoft.Json;
using System.Text;

namespace Client_Shiplink.Repository.Data
{
    public class HomeRepository : GeneralRepository<Account, int>
    {
        private readonly HttpClient httpClient;
        private readonly string request;
        private readonly IHttpContextAccessor _contextAccessor;

        public HomeRepository(string request = "") : base(request)
        {
            httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7272/API-Shiplink/")
            };
            this.request = request;

        }

        public async Task<ResponseVM<string>> Logins(LoginVM login)
        {
            ResponseVM<string> entityVM = null;
            StringContent content = new StringContent(JsonConvert.SerializeObject(login), Encoding.UTF8, "application/json");
            using (var response = httpClient.PostAsync(request + "Account/login", content).Result)
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                entityVM = JsonConvert.DeserializeObject<ResponseVM<string>>(apiResponse);
            }
            return entityVM;
        }

        public async Task<ResponseMessageVM> Registers(RegisterVM entity)
        {
            ResponseMessageVM entityVM = null;
            StringContent content = new StringContent(JsonConvert.SerializeObject(entity), Encoding.UTF8, "application/json");
            using (var response = httpClient.PostAsync(request + "Account/Register", content).Result)
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                entityVM = JsonConvert.DeserializeObject<ResponseMessageVM>(apiResponse);
            }
            return entityVM;
        }

    }


}

