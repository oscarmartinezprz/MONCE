﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeQuiz.Models;


namespace EmployeQuiz.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        [HttpGet] //metodo para ejecutar una consulta 
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Employee emp)
        {
            //creo el objeto del modelo de datos
            PayrollDm nomina = new PayrollDm(
                @"C:\Users\Lilianzhita\Documents\Visual Studio 2013\Projects\DAW\Lilianzhita\lirio\EmployeQuiz\Models\base.csv");
               
            //busco el empleado dado su id
            var empleado = nomina.GetEmployeedById(emp.Id);

            return View("WorkerView", empleado);
        }
    }
}
