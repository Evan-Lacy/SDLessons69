using _11_RestaurantRater.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace _11_RestaurantRater.Controllers
{
    public class RatingController : ApiController
    {
        private readonly RestaurantDbContext _context = new RestaurantDbContext();

        //Create 

        //POST
        [HttpPost]//necessary
        public async Task<IHttpActionResult> PostRating(Rating rating)
        {
            if (ModelState.IsValid)
            {
                Restaurant restaurant = await _context.Restaurants.FindAsync(rating.RestaurantId);
                if(restaurant == null)
                {
                    return BadRequest("There is no restaurant with that ID");//400
                }

                _context.Ratings.Add(rating);
                await _context.SaveChangesAsync();

                return Ok();
            }
            return BadRequest(ModelState);//400
        }

        //Read

        //GET ALL

        [HttpGet]//not always needed
        public async Task<IHttpActionResult> GetAll()
        {
            List<Rating> ratings = await _context.Ratings.ToListAsync();

            return Ok(ratings);
        }

        //Get Ratings by Restaurant
        [HttpGet]//not always needed
        public async Task<IHttpActionResult> Get(int id)
        {
            List<Rating> ratings = await _context.Ratings.Where(
                r => r.RestaurantId == id
                ).ToListAsync();
            return Ok(ratings);
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetById(int id)
        {
            Rating rating = await _context.Ratings.FindAsync(id);

            if (rating != null)
            {
                return Ok(rating);//200
            }

            return BadRequest(ModelState); //400 error - Bad request
        }
    }
}
