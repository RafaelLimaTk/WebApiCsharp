﻿using GeekShopping.ProductApi.Model;
using GeekShopping.ProductApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.ProductApi.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private IProductRepository _repository;

    public ProductController(IProductRepository repository)
    {
        _repository = repository ?? throw new 
            ArgumentNullException(nameof(repository));
    }
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Product>>> FindAll()
    {
        var products = await _repository.FindAll();

        return Ok(products);
    }
    [HttpGet("{id}")]
    public async Task<ActionResult> FindById(long id)
    {
        var product = await _repository.FindById(id);
        if (product == null) return NotFound();

        return Ok(product);
    }
}