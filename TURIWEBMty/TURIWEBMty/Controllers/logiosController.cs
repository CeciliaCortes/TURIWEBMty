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
using TURIWEBMty.Content;
using TURIWEBMty.Models;

namespace TURIWEBMty.Controllers
{
    public class logiosController : ApiController
    {
        private TuriContext db = new TuriContext();

        // GET: api/logios
        public IQueryable<logio> Getlogin()
        {
            return db.login;
        }

        // GET: api/logios/5
        [ResponseType(typeof(logio))]
        public IHttpActionResult Getlogio(int id)
        {
            logio logio = db.login.Find(id);
            if (logio == null)
            {
                return NotFound();
            }

            return Ok(logio);
        }

        // PUT: api/logios/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putlogio(int id, logio logio)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != logio.ID)
            {
                return BadRequest();
            }

            db.Entry(logio).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!logioExists(id))
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

        // POST: api/logios
        [ResponseType(typeof(logio))]
        public IHttpActionResult Postlogio(logio logio)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.login.Add(logio);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = logio.ID }, logio);
        }

        // DELETE: api/logios/5
        [ResponseType(typeof(logio))]
        public IHttpActionResult Deletelogio(int id)
        {
            logio logio = db.login.Find(id);
            if (logio == null)
            {
                return NotFound();
            }

            db.login.Remove(logio);
            db.SaveChanges();

            return Ok(logio);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool logioExists(int id)
        {
            return db.login.Count(e => e.ID == id) > 0;
        }
    }
}