﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sales.API.Data;
using Sales.Shared.Entities;

namespace Sales.API.Controllers;

[ApiController]
[Route("/api/countries")]
public class CoutriesController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public CoutriesController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetAsync()
    {
        return Ok(await _context.Countries.ToListAsync());
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync(Country country)
    {
        _context.Add(country);
        await _context.SaveChangesAsync();
        return Ok(country);
    }
}