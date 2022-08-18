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
    public class MizzaToppingSKUPriceApiController : ApiController
    {
        MizzaRepo<MizzaToppingSKUPrice> _mizzaRepo;
        public MizzaToppingSKUPriceApiController()
        {
            _mizzaRepo = new MizzaRepo<MizzaToppingSKUPrice>();
        }
        // GET: api/MizzaToppingSKUPrice
        public List<MizzaToppingSKUPrice> Get()
        {
            return _mizzaRepo.GetRecords("GetMizzaToppingSKUPrice", "MizzaToppingDbConnect");
        }

        // GET: api/MizzaToppingSKUPrice/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/MizzaToppingSKUPrice
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/MizzaToppingSKUPrice/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/MizzaToppingSKUPrice/5
        public void Delete(int id)
        {
        }
    }
}
