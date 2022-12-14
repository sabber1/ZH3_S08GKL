using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ZH3_asp.ReceptModels;

namespace ZH3_asp.Controllers
{
    [Route("api/recept/")]
    [ApiController]
    public class ReceptController : ControllerBase
    {
        [HttpGet]
        [Route("recept/{id}")]
        public IActionResult M1(int id)
        {
            ReceptContext context = new ReceptContext();

            var result = (from x in context.Recepteks
                          where x.ReceptId == id
                          select x).FirstOrDefault();
            if (result == null)
                return BadRequest("Nincs találat");
            return new JsonResult(result);
        }
        [HttpGet]
        [Route("fogas/{id}")]
        public IActionResult M2(int id)
        {
            ReceptContext context = new ReceptContext();

            var result = (from x in context.Fogasoks
                          where x.FogasId == id
                          select x).FirstOrDefault();
            if (result == null)
                return BadRequest("Nincs találat");
            return new JsonResult(result);
        }
        [HttpGet]
        [Route("receptek")]
        public IActionResult M3()
        {
            ReceptContext context = new ReceptContext();

            var result = from x in context.Recepteks
                         select x;

            return new JsonResult(result);
        }
        [HttpPost]
        [Route("add-nye")]
        public IActionResult M4([FromBody] Nyersanyagok nyersanyag)
        {
            ReceptContext context = new ReceptContext();

            try
            {
                context.Nyersanyagoks.Add(nyersanyag);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }
        [HttpPost]
        [Route("mod-recept")]
        public IActionResult M5([FromBody] Receptek recept)
        {
            ReceptContext context = new ReceptContext();

            var toDelete = (from x in context.Recepteks
                            where x.ReceptId == recept.ReceptId
                            select x).FirstOrDefault();
            if (toDelete == null)
                return NotFound(recept);
            try
            {
                context.Recepteks.Remove(toDelete);
                context.Recepteks.Add(recept);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }
        [HttpPost]
        [Route("mod-fogas")]
        public IActionResult M6([FromBody] Fogasok fogas)
        {
            ReceptContext context = new ReceptContext();

            var toDelete = (from x in context.Fogasoks
                            where x.FogasId == fogas.FogasId
                            select x).FirstOrDefault();

            if (toDelete == null)
                return NotFound(fogas);
            try
            {
                context.Fogasoks.Remove(toDelete);
                context.Fogasoks.Add(fogas);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }
        [HttpDelete]
        [Route("del-recept/{id}")]
        public IActionResult M7(int id)
        {
            ReceptContext context = new ReceptContext();

            var toDelete = (from x in context.Recepteks
                            where x.ReceptId == id
                            select x).FirstOrDefault();
            if (toDelete == null)
                return NotFound(id);

            try
            {
                context.Recepteks.Remove(toDelete);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();


        }
    }
}
