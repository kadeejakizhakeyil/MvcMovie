﻿using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{

    public IActionResult Index()
    {
        return View();
    }
    // GET: /HelloWorld/
    //public string Index()
    //{
    //    return "This is my default action...";
    //}
    // GET: /HelloWorld/Welcome/ 
    //public string Welcome()
    //{
    //    return "This is the Welcome action method...";
    //}
    // GET: /HelloWorld/Welcome/ 
    // Requires using System.Text.Encodings.Web;
    //public string Welcome(string name, int numTimes = 1)
    //{
    //    return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
    //}
    //public IActionResult Welcome(string name, int numTimes = 1)
    //{
    //    ViewData["Message"] = "Hello " + name;
    //    ViewData["NumTimes"] = numTimes;
    //    return View();
    //}
    public IActionResult Welcome()
    {
        string name = "Kadeeja Kizhakeyil";
        int numTimes = 5;
        ViewData["Message"] = "Hello " + name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }
    //public string Welcome()
    //{
    //    string name= "Kadeeja Kizhakeyil";
    //    int ID = 0856685;
    //    return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
    //}
}
