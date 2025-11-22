using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MovieProjectMVC.Controllers;

public class CastController:Controller
{
    private readonly ICastService _castService;
    public CastController(ICastService castService)
    {
        _castService = castService;
    }
    public IActionResult CastDetails(int id)
    {
        Cast cast = _castService.GetCastDetails(id);
        return View(cast);
    }
}