using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvc.Models;
using mvc.Services;

namespace mvc.Controllers
{
    public class SellersController : Controller
    {

        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }
        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }
      //  public IActionResult Crete()
      //  {
      //      return View();
      //  }

        
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost] //Anotation -> indica que e acao de post e nao de get
        [ValidateAntiForgeryToken] //Previne ataques CSRF (Envio de dados maliciosos)
        public IActionResult Create(Seller seller)
        {
            _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index)); //Melhora manutencao do sistema, pois caso string Index mude, nao precisa corrigir aqui
        }
    }
}