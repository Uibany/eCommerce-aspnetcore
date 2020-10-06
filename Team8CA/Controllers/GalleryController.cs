﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PagedList;
using Team8CA.DataAccess;
using Team8CA.Models;
using Team8CA.Services;
//using Team8CA.Services;

namespace Team8CA.Controllers
{
    public class GalleryController : Controller
    {

        protected AppDbContext db;
        public IActionResult Index()
        {

            List<Products> product = db.Products.ToList();

            ViewData["product"] = product;

            return View();
        }

        //public GalleryController(int ID, string ProductName, double ProductPrice, bool ProductAvailability, string ProductDescription)
        //{ 

        //}


        public IActionResult AntivirusAndSecurity()
        {
            return View();
        }



        public IActionResult BusinessAndOffice()
        {
            return View();

        }

        public IActionResult DesignAndIllustration()
        {
            return View();
        }

        public IActionResult AddToCart([FromServices] CartRelatedService srv, int prdId)
        {
            var customerId = HttpContext.Session.GetInt32("customerId") ?? 0;
            //if (customerId == 0)
            //{
            //    AddToCartForSession(srv, prdId, 1);
            //}
            //else
            //{
            ViewData["ItemCount"] = srv.AddProductsToCart(customerId, prdId, 1);
            //}
            return PartialView("_CartIcon");
        }

        public GalleryController(AppDbContext db)
        {
            this.db = db;
        }
        public List<Products> GetProducts(string query)
        {
            List<Products> products = db.Products.ToList();
            {
                if (query == "" || query == null)
                {
                    return db.Products.ToList();
                }

                return db.Products.Where(p =>
                        p.ProductName.ToLower().Contains(query.ToLower()) ||
                        p.ProductDescription.ToLower().Contains(query.ToLower()))
                    .ToList();
            }
        }


        //Link to productDetailPage
        public IActionResult ProductDetailPage(int id)
        {
            Products product = db.Products.First(p => p.Id == id);
            ViewData["product"] = product;
            return View("ProductDetailPage");
        }


    }
}