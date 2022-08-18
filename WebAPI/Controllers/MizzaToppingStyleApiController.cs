using ADOWebApplication.ADORepositories;
using ADOWebApplication.DataModels;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class MizzaToppingStyleApiController : ApiController
    {
        MizzaRepo<MizzaToppingStyle> _mizzaRepo;
        public MizzaToppingStyleApiController()
        {
            _mizzaRepo = new MizzaRepo<MizzaToppingStyle>();
        }
        // GET: api/MizzaToppingStyleApi
        public List<MizzaToppingStyle> Get()
        {
            return _mizzaRepo.GetRecords("GetMizzaToppingStyle", "MizzaToppingDbConnect");
        }

        // GET: api/MizzaToppingStyleApi/5
        public MizzaToppingStyle Get(int id)
        {
            var list = _mizzaRepo.GetRecords("GetMizzaToppingStyle", "MizzaToppingDbConnect", id);
            return list.FirstOrDefault();
        }

        // POST: api/MizzaToppingStyleApi
        public void Post(MizzaToppingStyle inputMizzaToppingStyle)
        {
            _mizzaRepo.InsertRecords(inputMizzaToppingStyle, "AddMizzaToppingStyle", "MizzaToppingDbConnect");
        }

        // PUT: api/MizzaToppingStyleApi/5
        public void Put(int id, MizzaToppingStyle inputMizzaToppingStyle)
        {
            _mizzaRepo.UpdateRecords(inputMizzaToppingStyle, "UpdateMizzaToppingStyle", "MizzaToppingDbConnect", id);
        }

        // DELETE: api/MizzaToppingStyleApi/5
        public void Delete(int id)
        {
            _mizzaRepo.RemoveRecords("RemoveMizzaToppingStyle", "MizzaToppingDbConnect", id);
        }
    }
}
