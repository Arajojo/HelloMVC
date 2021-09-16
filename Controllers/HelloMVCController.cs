using HelloMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloMVC.Controllers
{
    public class HelloMVCController : Controller
    {
        // GET: HelloMVC
        public ActionResult Index()
        {
            List<HelloMVCModel> model = new List<HelloMVCModel>();
            
            model.Add(new HelloMVCModel()
            {
                Nome = "Leozao",
                Idade = 16,
                BomAluno = true
            });

            model.Add(new HelloMVCModel()
            {
                Nome = "Parxceiro",
                Idade = 17,
                BomAluno = true
            });

            model.Add(new HelloMVCModel()
            {
                Nome = "Parxceiro",
                Idade = 17,
                BomAluno = true
            });

            model.Add(new HelloMVCModel()
            {
                Nome = "Parxceiro",
                Idade = 17,
                BomAluno = true
            });

            model.Add(new HelloMVCModel()
            {
                Nome = "Parxceiro",
                Idade = 17,
                BomAluno = true
            });

            model.Add(new HelloMVCModel()
            {
                Nome = "Parxceiro",
                Idade = 17,
                BomAluno = true
            });

            model.Add(new HelloMVCModel()
            {
                Nome = "Parxceiro",
                Idade = 17,
                BomAluno = true
            });

            model.Add(new HelloMVCModel()
            {
                Nome = "Parxceiro",
                Idade = 17,
                BomAluno = true
            });

            return View(model);
        }
    }
}