// Copyright (c) 2017 Ultraschall. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ultraschall.Deamon.Data;
using Ultraschall.Deamon.Data.Models;

namespace Ultraschall.Deamon.Controllers
{
    [Produces("application/json")]
    [Route("api/Values")]
    public class ValuesController : Controller
    {
        private readonly ApplicationDbContext context;

        public ValuesController(ApplicationDbContext context)
        {
            this.context = context;
        }

        // GET: api/Values
        [HttpGet]
        public IEnumerable<Value> GetValues()
        {
            return this.context.Values;
        }

        // GET: api/Values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetValue([FromRoute] string id)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var value = await this.context.Values.SingleOrDefaultAsync(m => m.Id == id);

            if (value == null)
            {
                return this.NotFound();
            }

            return this.Ok(value);
        }

        // PUT: api/Values/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutValue([FromRoute] string id, [FromBody] Value value)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            if (id != value.Id)
            {
                return this.BadRequest();
            }

            this.context.Entry(value).State = EntityState.Modified;

            try
            {
                await this.context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!this.ValueExists(id))
                {
                    return this.NotFound();
                }
                else
                {
                    throw;
                }
            }

            return this.NoContent();
        }

        // POST: api/Values
        [HttpPost]
        public async Task<IActionResult> PostValue([FromBody] Value value)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            this.context.Values.Add(value);
            await this.context.SaveChangesAsync();

            return this.CreatedAtAction("GetValue", new { id = value.Id }, value);
        }

        // DELETE: api/Values/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteValue([FromRoute] string id)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var value = await this.context.Values.SingleOrDefaultAsync(m => m.Id == id);
            if (value == null)
            {
                return this.NotFound();
            }

            this.context.Values.Remove(value);
            await this.context.SaveChangesAsync();

            return this.Ok(value);
        }

        private bool ValueExists(string id)
        {
            return this.context.Values.Any(e => e.Id == id);
        }
    }
}
