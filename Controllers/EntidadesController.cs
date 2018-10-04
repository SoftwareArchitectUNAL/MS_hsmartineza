using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EntidadesApi.Model;

namespace EntidadesApi.Controllers
{
    [Route("api/[controller]")]
    public class EntidadesController : Controller
    {



        private readonly IEntidadRepository  _repository;
        public EntidadesController(IEntidadRepository repository)
        {
            _repository = repository;

        }


        [HttpGet]
        // // GET api/values/5
        public IEnumerable<Entidad> Get()
        {
            return _repository.Get();
        }

        [HttpGet ("{id}")]
        public Entidad GetEntidad(int Id){
            
            return _repository.GetEntidad(Id);
        }


        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
