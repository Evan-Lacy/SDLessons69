using _11_RestaurantRater.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace _11_RestaurantRater.Controllers
{

    public class RestaurantController : ApiController
    {
        private readonly RestaurantDbContext _context = new RestaurantDbContext();

        //Create

        //POST
        [HttpPost]//necessary
        public async Task<IHttpActionResult> PostRestaurant(Restaurant model)
        {
            if (ModelState.IsValid)
            {
                _context.Restaurants.Add(model);
                await _context.SaveChangesAsync();

                return Ok();
            }
            return BadRequest(ModelState);//400
        }

        //Read

        //GET ALL

        [HttpGet]//not always needed
        public async Task<IHttpActionResult> Get()
        {
            List<Restaurant> restaurants = await _context.Restaurants.ToListAsync();

            return Ok(restaurants);
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetById(int id)
        {
            Restaurant restaurant = await _context.Restaurants.FindAsync(id);

            if (restaurant != null)
            {
                return Ok(restaurant);//200
            }

            return BadRequest(ModelState); //400 error - Bad request
        }

        //Update
        [HttpPut]
        public async Task<IHttpActionResult> UpdateRestaurant([FromUri] int id, [FromBody] Restaurant model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); //400
            }

            Restaurant restaurant = await _context.Restaurants.FindAsync(id);

            if (restaurant == null)
            {
                return NotFound(); //404
            }

            restaurant.Name = model.Name;
            restaurant.Address = model.Address;
            restaurant.Rating = model.Rating;

            if (await _context.SaveChangesAsync() == 1)
            {
                return Ok(); //200
            }

            return InternalServerError(); //500

            //403 = forbidden (not authorized)
        }

        //Delete
        [HttpDelete]
        public async Task<IHttpActionResult> DeleteRestaurantById(int id)
        {
            Restaurant restaurant = await _context.Restaurants.FindAsync(id); //find restaurant by id provided

            if (restaurant == null) //if not found
            {
                return NotFound();//404
            }

            _context.Restaurants.Remove(restaurant); //if found, remove from C# sharp context

            if (await _context.SaveChangesAsync() == 1) //Save that change to actual SQL db
            {
                return Ok();// 200
            }

            return InternalServerError(); // 500
        }

    }
}
