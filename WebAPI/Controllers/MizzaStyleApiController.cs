using ADOWebApplication.ADORepositories;
using ADOWebApplication.DataModels;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class MizzaStyleApiController : ApiController
    {
        MizzaRepo<MizzaStyle> _mizzaRepo;
        public MizzaStyleApiController()
        {
            _mizzaRepo = new MizzaRepo<MizzaStyle>();
        }
        // GET: api/MizzaStyleApi
        public List<MizzaStyle> Get()
        {
            return _mizzaRepo.GetRecords("GetMizzaStyle", "MizzaItemDbConnect");
        }

        // GET: api/MizzaStyleApi/5
        public MizzaStyle Get(int id)
        {
            var list = _mizzaRepo.GetRecords("GetMizzaStyle", "MizzaItemDbConnect", id);
            return list.FirstOrDefault();
        }

        // POST: api/MizzaStyleApi
        public void Post(MizzaStyle inputMizzaStyle)
        {
            _mizzaRepo.InsertRecords(inputMizzaStyle, "AddMizzaStyle", "MizzaItemDbConnect");
        }

        // PUT: api/MizzaStyleApi/5
        public void Put(int id, MizzaStyle inputMizzaStyle)
        {
            _mizzaRepo.UpdateRecords(inputMizzaStyle, "UpdateMizzaStyle", "MizzaItemDbConnect", id);
        }

        // DELETE: api/MizzaStyleApi/5
        public void Delete(int id)
        {
            _mizzaRepo.RemoveRecords("RemoveMizzaStyle", "MizzaItemDbConnect", id);
        }
    }
}
