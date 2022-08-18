using ADOWebApplication.ADORepositories;
using ADOWebApplication.DataModels;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class MizzaSkuBasePriceApiController : ApiController
    {
        MizzaRepo<MizzaSkuBasePrice> _mizzaRepo;
        public MizzaSkuBasePriceApiController()
        {
            _mizzaRepo = new MizzaRepo<MizzaSkuBasePrice>();
        }
        // GET: api/MizzaSkuBasePriceApi
        public List<MizzaSkuBasePrice> Get()
        {
            return _mizzaRepo.GetRecords("GetMizzaSkuBasePrice", "MizzaItemDbConnect");
        }

        // GET: api/MizzaSkuBasePriceApi/5
        public MizzaSkuBasePrice Get(int id)
        {
            var list = _mizzaRepo.GetRecords("GetMizzaSkuBasePrice", "MizzaItemDbConnect", id);
            return list.FirstOrDefault();
        }

        // POST: api/MizzaSkuBasePriceApi
        public void Post(MizzaSkuBasePrice inputMizzaSkuBasePrice)
        {
            _mizzaRepo.InsertRecords(inputMizzaSkuBasePrice, "AddMizzaSkuBasePrice", "MizzaItemDbConnect");
        }

        // PUT: api/MizzaSkuBasePriceApi/5
        public void Put(int id, MizzaSkuBasePrice inputMizzaSkuBasePrice)
        {
            _mizzaRepo.UpdateRecords(inputMizzaSkuBasePrice, "UpdateMizzaSkuBasePrice", "MizzaItemDbConnect", id);
        }

        // DELETE: api/MizzaSkuBasePriceApi/5
        public void Delete(int id)
        {
            _mizzaRepo.RemoveRecords("RemoveMizzaSkuBasePrice", "MizzaItemDbConnect", id);
        }
    }
}
