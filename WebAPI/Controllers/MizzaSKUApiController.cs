using ADOWebApplication.ADORepositories;
using ADOWebApplication.DataModels;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class MizzaSKUApiController : ApiController
    {
        MizzaRepo<MizzaSKU> _mizzaRepo;
        public MizzaSKUApiController()
        {
            _mizzaRepo = new MizzaRepo<MizzaSKU>();
        }
        // GET: api/MizzaSKUApi
        public List<MizzaSKU> Get()
        {
            return _mizzaRepo.GetRecords("GetMizzaSKU", "MizzaItemDbConnect");
        }

        // GET: api/MizzaSKUApi/5
        public MizzaSKU Get(int id)
        {
            var list = _mizzaRepo.GetRecords("GetMizzaSKU", "MizzaItemDbConnect", id);
            return list.FirstOrDefault();
        }

        // POST: api/MizzaSKUApi
        public void Post(MizzaSKU inputMizzaSKU)
        {
            _mizzaRepo.InsertRecords(inputMizzaSKU, "AddMizzaSKU", "MizzaItemDbConnect");
        }

        // PUT: api/MizzaSKUApi/5
        public void Put(int id, MizzaSKU inputMizzaSKU)
        {
            _mizzaRepo.UpdateRecords(inputMizzaSKU, "UpdateMizzaSKU", "MizzaItemDbConnect", id);
        }

        // DELETE: api/MizzaSKUApi/5
        public void Delete(int id)
        {
            _mizzaRepo.RemoveRecords("RemoveMizzaSKU", "MizzaItemDbConnect", id);
        }
    }
}
