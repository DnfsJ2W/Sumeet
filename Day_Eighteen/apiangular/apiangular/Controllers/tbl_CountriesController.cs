using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using apiangular.Models;

namespace apiangular.Controllers
{
    public class tbl_CountriesController : ApiController
    {
        private countryEntities1 db = new countryEntities1();

        // GET: api/tbl_Countries
        public IQueryable<tbl_Countries> Gettbl_Countries()
        {
            return db.tbl_Countries;
        }

        // GET: api/tbl_Countries/5
        [ResponseType(typeof(tbl_Countries))]
        public IHttpActionResult Gettbl_Countries(int id)
        {
            tbl_Countries tbl_Countries = db.tbl_Countries.Find(id);
            if (tbl_Countries == null)
            {
                return NotFound();
            }

            return Ok(tbl_Countries);
        }

        // PUT: api/tbl_Countries/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Puttbl_Countries(int id, tbl_Countries tbl_Countries)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_Countries.CountryID)
            {
                return BadRequest();
            }

            db.Entry(tbl_Countries).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tbl_CountriesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/tbl_Countries
        [ResponseType(typeof(tbl_Countries))]
        public IHttpActionResult Posttbl_Countries(tbl_Countries tbl_Countries)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tbl_Countries.Add(tbl_Countries);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (tbl_CountriesExists(tbl_Countries.CountryID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = tbl_Countries.CountryID }, tbl_Countries);
        }

        // DELETE: api/tbl_Countries/5
        [ResponseType(typeof(tbl_Countries))]
        public IHttpActionResult Deletetbl_Countries(int id)
        {
            tbl_Countries tbl_Countries = db.tbl_Countries.Find(id);
            if (tbl_Countries == null)
            {
                return NotFound();
            }

            db.tbl_Countries.Remove(tbl_Countries);
            db.SaveChanges();

            return Ok(tbl_Countries);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tbl_CountriesExists(int id)
        {
            return db.tbl_Countries.Count(e => e.CountryID == id) > 0;
        }
    }
}