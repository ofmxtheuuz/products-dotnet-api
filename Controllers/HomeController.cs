﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Products_API.useCases.Repositories.Interfaces;

namespace Products_API.Controllers;

[Route("products/v1")]
public class HomeController : Controller
{
    private readonly IProductRepository _Repository;
    public HomeController(IProductRepository IRepository) {
        this._Repository = IRepository;
    }
    
    [HttpGet()]
    public List<Product> GetAll()
    {
        return this._Repository.GetAll();
    }

}
