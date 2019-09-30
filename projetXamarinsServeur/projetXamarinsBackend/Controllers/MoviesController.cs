using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using projetXamarinsBackend.Models;
using projetXamarinsBackend.Services;

namespace projetXamarinsBackend.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly MovieService movieService;

        public MoviesController(MovieService movieService)
        {
            this.movieService = movieService;
        }

        [HttpGet]
        public ActionResult<List<Movie>> Get() =>
            this.movieService.Get();

        [HttpGet("{id:length(24)}", Name = "GetMovie")]
        public ActionResult<Movie> Get(string id)
        {
            var movie = this.movieService.Get(id);

            if (movie == null)
            {
                return NotFound();
            }

            return movie;
        }

        [HttpPost]
        public ActionResult<Movie> Create(Movie movie)
        {
            this.movieService.Create(movie);

            return CreatedAtRoute("GetMovie", new { id = movie.Id.ToString() }, movie);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Movie movieIn)
        {
            var movie = this.movieService.Get(id);

            if (movie == null)
            {
                return NotFound();
            }

            this.movieService.Update(id, movieIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var movie = this.movieService.Get(id);

            if (movie == null)
            {
                return NotFound();
            }

            this.movieService.Remove(movie.Id);

            return NoContent();
        }
    }
}
