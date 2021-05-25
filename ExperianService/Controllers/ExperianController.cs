using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL;
using DAL.Models;
using Microsoft.AspNetCore.Authorization;

namespace ExperianService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ExperianController : Controller
    {
        dal d = new dal();

        [HttpGet]
        
        public JsonResult GetUserDetails(string id)
        {
            Models.ExpDb e = new Models.ExpDb();
            List<Models.ExpDb> user = new List<Models.ExpDb>();
            try
            {
                var userDetails = d.GetUserDetails();
                if (userDetails != null)
                {
                    foreach (var u in userDetails) {
                        user.Add(new Models.ExpDb
                        {
                            Id = u.Id,
                            Name = u.Name,
                            Address = u.Address
                        });
                    }
                }
                return Json(user);
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }

        }
    }
}
