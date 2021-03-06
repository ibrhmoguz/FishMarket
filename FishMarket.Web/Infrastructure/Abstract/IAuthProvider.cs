﻿namespace FishMarket.Web.Infrastructure.Abstract
{
    public interface IAuthProvider
    {
        bool Authenticate(string username, string password);
        void SignOut();
    }
}
