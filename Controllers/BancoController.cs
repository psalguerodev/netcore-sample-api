using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using bank_app.Models;


namespace bank_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BancoController : ControllerBase
    {

        // GET api/banco
        [HttpGet]
        public ActionResult<IEnumerable<Banco>> Get()
        {
            return Banco.listBanks;
        }

        // GET api/banco/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value" + id;
        }

        // POST api/banco
        [HttpPost]
        public void Post([FromBody] Banco _banco)
        {
            Console.WriteLine("BANCO >>>> {0}", _banco.Name);
            Banco.listBanks.Add(_banco);
            Console.WriteLine("LISTADO >> {0}", Banco.listBanks.Count);
        }

        // PUT api/banco/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            Console.WriteLine("CUERPO {0}", value);
            Console.WriteLine("ID RECURSO {0}", id);
        }

        // DELETE api/banco/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Console.WriteLine("ID DELETE {0}", id);
        }
    }
}
