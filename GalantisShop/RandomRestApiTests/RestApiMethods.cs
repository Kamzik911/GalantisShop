using Newtonsoft.Json;
using OpenQA.Selenium.DevTools.V129.Page;

namespace GalantisShop.RandomRestApiTests
{    
    public class RestApiMethods
    {
        private readonly Settings settings = new Settings();
        private readonly RestClient client = new RestClient();              
        private readonly Properties properties = new Properties();
        
        public void GetUsersStatus200()
        {
            var request = new RestRequest($"{settings.restApiUrl}/{settings.usersEndpoint}", Method.Get);
            var response = client.Execute(request);                        
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            
        }
        public void AssertUsersApiResponse()
        {
            var request = new RestRequest($"{settings.restApiUrl}/{settings.usersEndpoint}", Method.Get);
            var response = client.Execute(request);
            var jsonResponse = JsonConvert.DeserializeObject<Properties.ApiResponse>(response.Content);            
            Assert.IsNotNull(jsonResponse.page);
            Assert.AreEqual(2, jsonResponse.page);
            Assert.AreEqual(6, jsonResponse.Per_Page);
            Assert.AreEqual(12, jsonResponse.total);
            Assert.AreEqual(2, jsonResponse.total_Pages);
        }

        public void AssertUsersDataResponse()
        {
            var request = new RestRequest($"{settings.restApiUrl}/{settings.usersEndpoint}", Method.Get);
            var response = client.Execute(request);
            var userResponse = JsonConvert.DeserializeObject<Properties.UserListResponse>(response.Content).data.FirstOrDefault();            
            Assert.IsNotNull(userResponse.id);
            Assert.IsNotNull(userResponse.email);
            Assert.IsNotNull(userResponse.first_name);
            Assert.IsNotNull(userResponse.last_name);
            Assert.IsNotNull(userResponse.avatar);
        }
    }
}
