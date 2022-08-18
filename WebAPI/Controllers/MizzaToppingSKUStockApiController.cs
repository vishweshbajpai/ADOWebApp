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
    public class MizzaToppingSKUStockApiController : ApiController
    {
        MizzaRepo<MizzaToppingSKUStock> _mizzaRepo;
        public MizzaToppingSKUStockApiController()
        {
            _mizzaRepo = new MizzaRepo<MizzaToppingSKUStock>();
        }
        // GET: api/MizzaToppingSKUStockApi
        public List<MizzaToppingSKUStock> Get()
        {
            return _mizzaRepo.GetRecords("GetMizzaToppingSKUStock", "MizzaToppingDbConnect");
        }

        // GET: api/MizzaToppingSKUStockApi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/MizzaToppingSKUStockApi
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/MizzaToppingSKUStockApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/MizzaToppingSKUStockApi/5
        public void Delete(int id)
        {
        }
    }
}
