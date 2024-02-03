using Microsoft.AspNetCore.Mvc;
using ProjectName.Models; //change
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace ProjectName.Controllers;

public class ClassNameSController : Controller
{
  private readonly ProjectNameContext _db;
  public ClassNameSController(ProjectNameContext db)
  {
    _db = db;
  }
  public ActionResult Index()
  {
    return View();
    // List<ClassName> model = _db.Stylists.ToList();
    // return View(model);
  }
}
