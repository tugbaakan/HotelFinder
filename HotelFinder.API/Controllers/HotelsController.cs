using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelFinder.Business.Abstract;
using HotelFinder.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelFinder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private IHotelService _hotelService;

        public HotelsController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var hotels = await _hotelService.GetAllHotel();
            return Ok(hotels);
        }

        [HttpGet("{id}")]
        [Route("[action]/{id}]")]
        public async Task<IActionResult> GetHotelById(int id )
        {
            var hotel = await _hotelService.GetHotelById(id);
            if(hotel != null)
            {
                return Ok(hotel);
            }
            return NotFound();    
        }
    }
}
