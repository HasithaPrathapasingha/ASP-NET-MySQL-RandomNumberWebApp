using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RandomNumberWebApp.Data;
using RandomNumberWebApp.Models;
using System;

namespace RandomNumberWebApp.Controllers;


public class HomeController(ApplicationDbContext context) : Controller{
    public IActionResult Index(){
        return View();
    }
    private readonly ApplicationDbContext _context = context;

    [HttpPost]
    public IActionResult Generate(){
        Random rnd = new();
        int number = rnd.Next(1, 101);

        var randomNumber = new RandomNumber{
            Value = number,
            GeneratedAt = DateTime.Now
        };

        _context.RandomNumbers.Add(randomNumber);
        _context.SaveChanges();
        ViewBag.RandomNumber = number;
        return View("Index");
    }
}
