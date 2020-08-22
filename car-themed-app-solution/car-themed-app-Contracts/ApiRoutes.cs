namespace car_themed_app_Contracts
{
    public static class ApiRoutes
    {
        private static readonly string BaseUrl = "http://localhost:44354/api/";

        public static class Dealers
        {
            private static readonly string _dealersControllerUrl = string.Concat(BaseUrl, "dealers");
    
            public static string GetAll = _dealersControllerUrl;

            public static string Get = string.Concat(_dealersControllerUrl, "/{dealerId}");

            public static string Delete = string.Concat(_dealersControllerUrl, "/{dealerId}");

            public static string Create = _dealersControllerUrl;

            public static string Update = _dealersControllerUrl;
        }

    }
}
