using DesignPatterns.Models.Data;
using DesignPatterns.Repository;
using DesignPatternsAsp.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DesignPatternsAsp.Controllers; 
public class BeerController : Controller {
    private readonly IUnitOfWork _unitOfWork;
    
    public BeerController(IUnitOfWork unitOfWork) {
        _unitOfWork = unitOfWork;
    }

    public IActionResult Index() {
        IEnumerable<BeerViewModel> beers = from d in _unitOfWork.Beers.Get()
                                           select new BeerViewModel {
                                               Id = d.BeerId,
                                               Name = d.Name,
                                               Style = d.Style
                                           };

        return View("Index", beers);
    }

    [HttpGet]
    public IActionResult Add() {
        var brands = _unitOfWork.Brands.Get();
        ViewBag.Brands = new SelectList(brands, "BrandId", "Name");

        return View();
    }

    [HttpPost]
    public IActionResult Add(FormBeerViewModel formBeerViewModel) {
        if (!ModelState.IsValid) {
            var brands = _unitOfWork.Brands.Get();
            ViewBag.Brands = new SelectList(brands, "BrandId", "Name");
            return View("Add", formBeerViewModel);
        }

        var beer = new Beer();
        beer.Name = formBeerViewModel.Name;
        beer.Style = formBeerViewModel.Style;

        if(formBeerViewModel is null) {
            var brand = new Brand();
            brand.Name = formBeerViewModel.OtherBrand;
            brand.BrandId = Guid.NewGuid();
            beer.BrandId = brand.BrandId;
            _unitOfWork.Brands.Add(brand);
        } else {
            beer.BrandId = (Guid)formBeerViewModel.BrandId;
        }

        _unitOfWork.Beers.Add(beer);
        _unitOfWork.Save();

        return RedirectToAction("Index");
    }
}

// Quedamos en el minuto 10 de la clase 17. Guardando el 2 tablas
