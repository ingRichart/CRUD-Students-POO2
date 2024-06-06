using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CRUD_Students_POO2.Models;
using CRUD_Students_POO2.Entities;

namespace CRUD_Students_POO2.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDbContext _context;

    public HomeController(ILogger<HomeController> logger
    , ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
    // PARA INSERTAR -- INSERT 
        Student estudiante = new Student();
        estudiante.Id = new Guid();
        estudiante.Name = "Aurora";
        estudiante.LastName = "Bazan";
        estudiante.Tetra = 3;
        estudiante.Cuota = 1000;
        this._context.Students.Add(estudiante);
        this._context.SaveChanges();

        return View();
    }

    public IActionResult Privacy()
    {
        // // PARA INSERTAR -- INSERT 
        // Student estudiante = new Student();
        // estudiante.Id = new Guid();
        // estudiante.Name = "Jesed";
        // estudiante.LastName = "Lagunes";
        // estudiante.Tetra = 1;
        // estudiante.Cuota = 300;

        // this._context.Students.Add(estudiante);
        // this._context.SaveChanges();

        // // PARA ACTUALIZAR -- UPDATE 
        // Student estudianteActualiza = this._context.Students
        //     .Where(c => c.Id == new Guid("841A8E08-C78F-4234-9578-08DC84FFF51F"))
        //     .First();
        // estudianteActualiza.Name = "Ricky";
        // estudianteActualiza.LastName = "Garcia";
        // this._context.Students.Update(estudianteActualiza);
        // this._context.SaveChanges();


        // // PARA BORRAR -- DELETE
        // Student estudianteBorrado = this._context.Students
        //     .Where(c => c.Id == new Guid("9D5A5CDE-257C-4A92-9577-08DC84FFF51F"))
        //     .First();

        // this._context.Students.Remove(estudianteBorrado);
        // this._context.SaveChanges();

        //PARA CARGAR INFORMACUIN = SELECT 
        List<StudentModel> list = 
        _context.Students.Select(s => new StudentModel()
        {
            Id = s.Id,
            Name = s.Name,
            LastName = s.LastName,
            Tetra = s.Tetra,
            Cuota = s.Cuota
        }).ToList();


        return View(list);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
