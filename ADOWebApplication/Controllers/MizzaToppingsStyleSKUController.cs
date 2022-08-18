using ADOWebApplication.ADORepositories;
using ADOWebApplication.DataModels;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ADOWebApplication.Controllers
{
    public class MizzaToppingsStyleSKUController : Controller
    {
        HttpConnectRepo<MizzaToppingsStyleSKU> _httpConnectRepo;
        public MizzaToppingsStyleSKUController()
        {
            _httpConnectRepo = new HttpConnectRepo<MizzaToppingsStyleSKU>();
        }
        // GET: MizzaToppingsStyleSKU
        public async Task<ActionResult> Index()
        {
            var list = await _httpConnectRepo.GetRequest("api/MizzaToppingsStyleSKUApi/");
            return View(list);
        }

        // GET: MizzaToppingsStyleSKU/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MizzaToppingsStyleSKU/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MizzaToppingsStyleSKU/Create
        [HttpPost]
        public ActionResult Create(MizzaToppingsStyleSKU inputMizzaToppingsStyleSKU)
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

        // GET: MizzaToppingsStyleSKU/Edit/5
        public ActionResult Edit(int id1, int id2)
        {
            return View();
        }

        // POST: MizzaToppingsStyleSKU/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, MizzaToppingsStyleSKU inputMizzaToppingsStyleSKU)
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

        // GET: MizzaToppingsStyleSKU/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MizzaToppingsStyleSKU/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, MizzaToppingsStyleSKU inputMizzaToppingsStyleSKU)
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
