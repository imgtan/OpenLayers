using MapParcel_son.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MapParcel_son.Controllers
{
    [Route("api/ParcelModel")]
    [ApiController]
    public class ParcelController : ControllerBase
    {
        private ParcelContext parcelContext;

        public ParcelController(ParcelContext parcelContext)
        {
            this.parcelContext = parcelContext;
        }

        [HttpGet]
        [Route("getall")]
        public IActionResult GetAll()
        {
            var data = parcelContext.Parcels.ToList();
            return Ok(data);
        }

        [HttpPost]
        [Route("add")]
        public IActionResult AddParcel(ParcelModel parcel)
        {
            parcelContext.Parcels.Add(parcel);
            parcelContext.SaveChanges();
            return Ok(parcel.ParcelID);
        }

        [HttpPost]
        [Route("update")]
        public IActionResult UpdateParcel(ParcelModel parcel)
        {
            parcelContext.Update(parcel);
            parcelContext.SaveChanges();
            return Ok(parcel.ParcelID);
        }

        [HttpPost]
        [Route("delete")]
        public IActionResult Delete(ParcelModel parcel)
        {
            var data = parcelContext.Parcels.Where(x => x.ParcelID == parcel.ParcelID).FirstOrDefault();
            

            if (data == null)
            {
                return NotFound();
            }

            parcelContext.Parcels.Remove(data);
            parcelContext.SaveChanges();

            return NoContent();
        }
    }
}

