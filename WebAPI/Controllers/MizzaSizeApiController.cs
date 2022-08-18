using ADOWebApplication.ADORepositories;
using ADOWebApplication.DataModels;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class MizzaSizeApiController : ApiController
    {
        MizzaRepo<MizzaSize> _mizzaRepo;
        public MizzaSizeApiController()
        {
            _mizzaRepo = new MizzaRepo<MizzaSize>();
        }
        // GET: api/MizzaSize
        public List<MizzaSize> Get()
        {
            return _mizzaRepo.GetRecords("GetMizzaSize", "MizzaItemDbConnect");
        }

        // GET: api/MizzaSize/5
        public MizzaSize Get(int id)
        {
            var list = _mizzaRepo.GetRecords("GetMizzaSize", "MizzaItemDbConnect", id);
            return list.FirstOrDefault();
        }

        // POST: api/MizzaSize
        public void Post(MizzaSize inputMizzaSize)
        {
            _mizzaRepo.InsertRecords(inputMizzaSize, "AddMizzaSize", "MizzaItemDbConnect");
        }

        // PUT: api/MizzaSize/5
        public void Put(int id, MizzaSize inputMizzaSize)
        {
            _mizzaRepo.UpdateRecords(inputMizzaSize, "UpdateMizzaSize", "MizzaItemDbConnect", id);
        }

        // DELETE: api/MizzaSize/5
        public void Delete(int id)
        {
            _mizzaRepo.RemoveRecords("RemoveMizzaSize", "MizzaItemDbConnect", id);
        }
    }
}
