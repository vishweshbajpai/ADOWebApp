using ADOWebApplication.ADORepositories;
using ADOWebApplication.DataModels;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class MizzaSKUStockApiController : ApiController
    {
        MizzaRepo<MizzaSKUStock> _mizzaRepo;
        public MizzaSKUStockApiController()
        {
            _mizzaRepo = new MizzaRepo<MizzaSKUStock>();
        }
        // GET: api/MizzaSKUStockApi
        public List<MizzaSKUStock> Get()
        {
            return _mizzaRepo.GetRecords("GetMizzaSKUStock", "MizzaItemDbConnect");
        }

        // GET: api/MizzaSKUStockApi/5
        public MizzaSKUStock Get(int id)
        {
            var list = _mizzaRepo.GetRecords("GetMizzaSKUStock", "MizzaItemDbConnect", id);
            return list.FirstOrDefault();
        }

        // POST: api/MizzaSKUStockApi
        public void Post(MizzaSKUStock inputMizzaSKUStock)
        {
            _mizzaRepo.InsertRecords(inputMizzaSKUStock, "AddMizzaSKUStock", "MizzaItemDbConnect");
        }

        // PUT: api/MizzaSKUStockApi/5
        public void Put(int id, MizzaSKUStock inputMizzaSKUStock)
        {
            _mizzaRepo.UpdateRecords(inputMizzaSKUStock, "UpdateMizzaSKUStock", "MizzaItemDbConnect", id);
        }

        // DELETE: api/MizzaSKUStockApi/5
        public void Delete(int id)
        {
            _mizzaRepo.RemoveRecords("RemoveMizzaSKUStock", "MizzaItemDbConnect", id);
        }
    }
}
