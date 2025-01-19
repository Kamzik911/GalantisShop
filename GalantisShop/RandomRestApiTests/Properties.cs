namespace GalantisShop.RandomRestApiTests
{
    public class Properties
    {
        public class ApiResponse
        {         
            public int page { get; set; }
                     
            public int Per_Page { get; set; }
            
            public int total { get; set; }
            
            public int total_Pages { get; set; }            
        }

        public class User
        {
            public int id { get; set; }
                        
            public string email { get; set; }

            public string first_name { get; set; }
            
            public string last_name { get; set; }
            
            public string avatar { get; set; }            
        }

        public class Support
        {
            public string url { get; set; }
            
            public string text { get; set; }
        }

        public class UserListResponse
        {
            public ApiResponse meta { get; set; }

            public List<User> data { get; set; }

            public Support support { get; set; }
                        
        }
    }
}

