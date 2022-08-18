using ADOWebApplication.ADORepositories;
using ADOWebApplication.DataModels;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ADOWebApplication.Controllers
{
    public class MizzaToppingSKUStockController : Controller
    {
        HttpConnectRepo<MizzaToppingSKUStock> _httpConnectRepo;
        public MizzaToppingSKUStockController()
        {
            _httpConnectRepo = new HttpConnectRepo<MizzaToppingSKUStock>();
        }
        // GET: MizzaToppingSKUStock
        public async Task<ActionResult> Index()
        {
            var list = await _httpConnectRepo.GetRequest("api/MizzaToppingSKUStockApi/");
            return View(list);
        }

        // GET: MizzaToppingSKUStock/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MizzaToppingSKUStock/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MizzaToppingSKUStock/Create
        [HttpPost]
        public ActionResult Create(MizzaToppingSKUStock inputMizzaToppingSKUStock)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MizzaToppingSKUStock/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MizzaToppingSKUStock/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, MizzaToppingSKUStock inputMizzaToppingSKUStock)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MizzaToppingSKUStock/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MizzaToppingSKUStock/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, MizzaToppingSKUStock inputMizzaToppingSKUStock)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
