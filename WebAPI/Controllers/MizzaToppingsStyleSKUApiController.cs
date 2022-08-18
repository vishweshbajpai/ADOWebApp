using ADOWebApplication.ADORepositories;
using ADOWebApplication.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class MizzaToppingsStyleSKUApiController : ApiController
    {
        MizzaRepo<MizzaToppingsStyleSKU> _mizzaRepo;
        public MizzaToppingsStyleSKUApiController()
        {
            _mizzaRepo = new MizzaRepo<MizzaToppingsStyleSKU>();
        }
        // GET: api/MizzaToppingsStyleSKU
        public List<MizzaToppingsStyleSKU> Get()
        {
            return _mizzaRepo.GetRecords("GetMizzaToppingsStyleSKU", "MizzaToppingDbConnect");
        }

        // GET: api/MizzaToppingsStyleSKU/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/MizzaToppingsStyleSKU
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/MizzaToppingsStyleSKU/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/MizzaToppingsStyleSKU/5
        public void Delete(int id)
        {
        }
    }
}
