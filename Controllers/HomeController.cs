using Intex_Remix.Models;
using Intex_Remix.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Intex_Remix.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IBurialRepository _repository;

        //the following is the context method, not best practice
        //private BurialDbContext context { get; set; }
        public int PageSize = 10;

        public HomeController(ILogger<HomeController> logger, IBurialRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Admin()
        {
            return View();
        }

        [Authorize(Roles = "Researcher,Admin")]
        public IActionResult Researcher()
        {
            return View();
        }

        [Authorize]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //Migrating things from Regular project to project with security
        public IActionResult DesertShaftBurials(string? id, string? burialId, int pageNum = 1)
        {
            var filters = new Filters(id);

            //viewbags containing what will be inserted in the drop-down lists
            ViewBag.Filters = filters;
            ViewBag.HairColors = _repository.Burials.Select(b => b.HairColor).Distinct().ToList();
            ViewBag.Genders = _repository.Burials.Select(b => b.GenderBodyCol).Distinct().ToList();
            ViewBag.Locations = _repository.Burials.Select(b => b.BurialId).Distinct().ToList();
            ViewBag.HeadDirections = _repository.Burials.Select(b => b.HeadDirection).Distinct().ToList();
            ViewBag.PreservationIndexes = _repository.Burials.Select(b => b.PreservationIndex).Distinct().ToList();

            //create iqueryable object to check parameters against
            IQueryable<Main> query = _repository.Burials;
            //.Include(b => b.HairColor).Include(b => b.GenderBodyCol).Include(b => b.BurialId).Include(b => b.HeadDirection).Include(b => b.PreservationIndex);

            //create queries based on what parameters are passed and add them to the query object
            if (filters.HasHair)
            {
                query = query.Where(b => b.HairColor == filters.HairKey);
            }
            if (filters.HasGender)
            {
                query = query.Where(b => b.GenderBodyCol == filters.GenderKey);
            }
            if (filters.HasLocation)
            {
                query = query.Where(b => b.BurialId == filters.LocationKey);
            }
            if (filters.HasHeadDirection)
            {
                query = query.Where(b => b.HeadDirection == filters.HeadDirectionKey);
            }
            if (filters.HasPreservationIndex)
            {
                query = query.Where(b => b.PreservationIndex == filters.PreservationKey);
            }

            //create burials list for filtered list and pass it to the view
            var burials = query
                .OrderBy(b => b.BurialId)
                .Skip((pageNum - 1) * PageSize)
                .Take(PageSize)
                .ToList();

            //pass all current main database entries and paging info to the desert burials page
            return View(new BurialListViewModel
            {
                //add burials object (query object with pagination set up) to view model
                Burials = burials,
                PageNumberingInfo = new PageNumberingInfo
                {
                    CurrentPage = pageNum,
                    NumItemsPerPage = PageSize,
                    TotalNumItems = query.Count()
                    //TotalNumItems = (burialId == null ? _repository.Burials.Count() :
                    //    _repository.Burials.Where(b => b.BurialId == burialId).Count())
                }
            }
            );
        }

        public IActionResult DesertShaftBurialFull(string burialId)
        {
            return View(_repository.Burials
                .Where(b => b.BurialId == burialId)
                .FirstOrDefault()
                );
        }

        //add a post action HERE that receives the filtering parameters and returns relevant records from _repository

        public IActionResult TombBurials(int pageNum = 1)
        {
            return View(new BurialListViewModel
            {


                PageNumberingInfo = new PageNumberingInfo
                {
                    CurrentPage = pageNum,
                    NumItemsPerPage = PageSize,
                    //TotalNumItems = (tombBurialId == null ? _repository.Burials.Count() :
                    //_repository.Burials.Where(b => b.TombBurialId == tombBurialId).Count())
                }
            });
        }



        //the following actions should only be callable by a researcher who has been authenticated by the system
        [Authorize(Roles = "Researcher,Admin")]
        [HttpGet]
        public IActionResult AddDesertBurial()
        {
            return View();
        }

        [Authorize(Roles = "Researcher,Admin")]
        [HttpPost]
        public IActionResult AddDesertBurial(Main addRecord)
        {
            if (ModelState.IsValid)
            {
                //Construct PK
                addRecord.BurialId = addRecord.BurialLocationNs + " " + addRecord.LowPairNs + " " + addRecord.BurialLocationEw + " " + addRecord.LowPairEw + " " + addRecord.BurialSubplot + " #" + addRecord.BurialNumber;

                //Assign record values to variables in database
                _repository.InsertRecord(addRecord);

                //Save changes to database
                _repository.Save();

                //Return Desert Burials page
                return View("AddConfirmation");
            }

            return View();
        }

        [Authorize(Roles = "Researcher,Admin")]
        [HttpGet]
        public IActionResult EditDesertBurial(string id)
        {
            Main record = _repository.GetRecordByID(id);

            return View("EditDesertBurial", record);
        }


        [Authorize(Roles = "Researcher,Admin")]
        [HttpPost]
        public IActionResult EditDesertBurial(Main record)
        {
            _repository.EditRecord(record);
            _repository.Save();
            return View("DesertShaftBurialFull", record);
        }
        //post methods of the above actions also needed

        [Authorize(Roles = "Researcher,Admin")]
        public IActionResult Delete(string id)
        {
            Main record = _repository.GetRecordByID(id);
            _repository.DeleteRecord(id);
            _repository.Save();

            return RedirectToAction("Index");
        }


        //same authentication required, but for tomb burials
        [Authorize(Roles = "Researcher,Admin")]
        public IActionResult AddTombBurial()
        {
            return View();
        }

        [Authorize(Roles = "Researcher,Admin")]
        public IActionResult EditTombBurial()
        {
            return View();
        }
        //post methods of the above actions also needed


        public IActionResult About()
        {
            return View();
        }

        public IActionResult Filter(string[] filter)
        {
            string id = string.Join('-', filter);
            return RedirectToAction("DesertShaftBurials", new { ID = id });
        }
    }
}
