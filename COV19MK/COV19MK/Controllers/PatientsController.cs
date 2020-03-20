using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COV19MK.Data.Entities;
using COV19MK.Services.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace COV19MK.Controllers
{
    public class PatientsController : Controller
    {
        private readonly IPatientsService _patientsService;

        public PatientsController(IPatientsService patientsService)
        {
            _patientsService = patientsService;
        }


        //Get Index
        public IActionResult Index()
        {
            var patientsList = _patientsService.GetAllPatients();
            return View(patientsList);
        }
        //Get Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Patients patients)
        {
            if (ModelState.IsValid)
            {
                _patientsService.Add(patients);
                return RedirectToAction(nameof(Index));
            }
            return View(patients);
        }
    }
}