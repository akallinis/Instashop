﻿using Instashop.Handlers.API.Login;
using Instashop.Handlers.API.Products;

namespace Instashop.Services.Interfaces;

public interface IStoreManager
{
    Task<ApiLoginResponse> LoginAsync(string username, string password);
    Task<ApiProductsResponse> GetProductsAsync();
    Task<ApiProductDetailsResponse> GetProductDetailsAsync(int productId);
    Task<ApiSalesResponse> GetSalesAsync();
}
