using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;

namespace GalantisShop.RandomRestApiTests
{
    [TestClass]
    public class RandomRestApiTests
    {
        RestApiMethods restApiMethods = new RestApiMethods();
        RestApiMethods methods = new RestApiMethods();

        [TestMethod]
        public void UsersStatusCode200_ShouldPass()
        {
            methods.GetUsersStatus200();
        }

        [TestMethod]
        public void AssertApiResponse_ShouldPass()
        {            
            methods.AssertUsersApiResponse();
        }
        
        [TestMethod]
        public void AssertDataResponse_ShouldPass()
        {
            methods.AssertUsersDataResponse();
        }
    }
}