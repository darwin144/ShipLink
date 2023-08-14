using Client_Shiplink.Repository.Interface;
using Client_Shiplink.ViewModel.Response;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Security.Claims;

namespace Client_Shiplink.Repository
{
    public class GeneralRepository<Tentity, Tid> : IGeneralRepository<Tentity, Tid> where Tentity : class
    {
        public readonly string _request;
        public readonly IHttpContextAccessor _contextAccessor;
        public readonly HttpClient httpClient;

        public GeneralRepository(string request)
        {
            _request = request;
            _contextAccessor = new HttpContextAccessor();
            this.httpClient = new HttpClient {
                BaseAddress = new Uri("https://localhost:7272/API-Shiplink/")
            };
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", _contextAccessor.HttpContext.Session.GetString("JWToken"));
        }

        public async Task<ResponseMessageVM> Deletes(Guid guid)
        {
            ResponseMessageVM entityVM = null;
            using (var response = httpClient.DeleteAsync(_request + guid).Result)
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                entityVM = JsonConvert.DeserializeObject<ResponseMessageVM>(apiResponse);
            }
            return entityVM;

        }

        public IEnumerable<Claim> ExtractClaims(string jwtToken)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseListVM<Tentity>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseVM<Tentity>> Get(Guid guid)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseMessageVM> Post(Tentity entity)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseMessageVM> Put(Tentity entity)
        {
            throw new NotImplementedException();
        }
    }
}
