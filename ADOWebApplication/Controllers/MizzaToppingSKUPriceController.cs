using ADOWebApplication.ADORepositories;
using ADOWebApplication.DataModels;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ADOWebApplication.Controllers
{
    public class MizzaToppingSKUPriceController : Controller
    {
        HttpConnectRepo<MizzaToppingSKUPrice> _httpConnectRepo;
        public MizzaToppingSKUPriceController()
        {
            _httpConnectRepo = new HttpConnectRepo<MizzaToppingSKUPrice>();
        }
        // GET: MizzaToppingSKUPrice
        public async Task<ActionResult> Index()
        {
            var list = await _httpConnectRepo.GetRequest("api/MizzaToppingSKUPriceApi/");
            return View(list);
        }

        // GET: MizzaToppingSKUPrice/Details/5
        public ActionResult Details(int id1, int id2)
        {
            return View();
        }

        // GET: MizzaToppingSKUPrice/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MizzaToppingSKUPrice/Create
        [HttpPost]
        public ActionResult Create(MizzaToppingSKUPrice inputMizzaToppingSKUPrice)
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

        // GET: MizzaToppingSKUPrice/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MizzaToppingSKUPrice/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, MizzaToppingSKUPrice inputMizzaToppingSKUPrice)
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

        // GET: MizzaToppingSKUPrice/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MizzaToppingSKUPrice/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, MizzaToppingSKUPrice inputMizzaToppingSKUPrice)
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
