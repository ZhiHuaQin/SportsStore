﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vic.SportsStore.Domain.Abstract;
using Vic.SportsStore.Domain.Concrete;

namespace Vic.SportsStore.WebApp.Controllers
{
    public class NavController : Controller
    {
        //private IProductsRepository repository;
        //public NavController(IProductsRepository repo)
        //{
        //    repository = repo;
        //}

        public IProductsRepository ProductsRepository { get; set; }
            = new EFProductRepository();
        public PartialViewResult Menu(string category=null)
        {
            ViewBag.SelectedCategory = category;

            IEnumerable<string> categories = ProductsRepository
            .Products
            .Select(x => x.Category)
            .Distinct()
            .OrderBy(x => x);

            return PartialView(categories);
        }
    }
}