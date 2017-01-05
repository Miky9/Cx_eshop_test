﻿namespace eShopOnContainers.Core
{
    public class GlobalSetting
    {
        private string _baseEndpoint;
        private static readonly GlobalSetting _instance = new GlobalSetting();

        public GlobalSetting()
        {
            AuthToken = "INSERT AUTHENTICATION TOKEN";
            BaseEndpoint = "http://10.106.144.28";
        }

        public static GlobalSetting Instance
        {
            get { return _instance; }
        }

        public string BaseEndpoint
        {
            get { return _baseEndpoint; }
            set
            {
                _baseEndpoint = value;
                UpdateEndpoint(_baseEndpoint);
            }
        }

        public string AuthToken { get; set; }

        public string RegisterWebsite { get; set; }

        public string CatalogEndpoint { get; set; }

        public string OrdersEndpoint { get; set; }

        public string BasketEndpoint { get; set; }

        public string IdentityEndpoint { get; set; }

        public string UserInfoEndpoint { get; set; }

        public string LogoutEndpoint { get; set; }

        public string IdentityCallback { get; set; }

        public string LogoutCallback { get; set; }

        private void UpdateEndpoint(string baseEndpoint)
        {
            RegisterWebsite = string.Format("{0}/Account/Register", baseEndpoint);
            CatalogEndpoint = string.Format("{0}:5101", baseEndpoint);
            OrdersEndpoint = string.Format("{0}:5102", baseEndpoint);
            BasketEndpoint = string.Format("{0}:5103", baseEndpoint);
            IdentityEndpoint = string.Format("{0}:5105/connect/authorize", baseEndpoint);
            UserInfoEndpoint = string.Format("{0}:5105/connect/userinfo", baseEndpoint);
            LogoutEndpoint = string.Format("{0}:5105/connect/endsession", baseEndpoint);
            IdentityCallback = "http://eshopxamarin/callback.html";
            LogoutCallback = "http://eshopxamarin/callback.html/index.html";
        }
    }
}