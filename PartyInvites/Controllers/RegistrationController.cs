using PartyInvites.Core.Services.Db;
using PartyInvites.Core.Storage;
using PartyInvites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartyInvites.Core.Storage.Auth;

namespace PartyInvites.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(RegistrationResponse response)
        {
            // TODO: check validity of caught form.
            StorageManager.StoreUser(AutoMapper.Mapper.Map<ApplicationUser>(response));
            return View();
        }
    }
}