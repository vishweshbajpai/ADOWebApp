using ADOWebApplication.ADORepositories;
using ADOWebApplication.DataModels;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ADOWebApplication.Controllers
{
    public class MizzaSKUStockController : Controller
    {
        HttpConnectRepo<MizzaSKUStock> _httpConnectRepo;
        public MizzaSKUStockController()
        {
            _httpConnectRepo = new HttpConnectRepo<MizzaSKUStock>();
        }
        // GET: MizzaSKUStock
        public async Task<ActionResult> Index()
        {
            var list = await _httpConnectRepo.GetRequest("api/MizzaSKUStockApi/");
            return View(list);
        }

        // GET: MizzaSKUStock/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var list = await _httpConnectRepo.GetRequest("api/MizzaSKUStockApi/", id);
            return View(list.FirstOrDefault());
        }

        // GET: MizzaSKUStock/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MizzaSKUStock/Create
        [HttpPost]
        public async Task<ActionResult> Create(MizzaSKUStock inputMizzaSKUStock)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool check = await _httpConnectRepo.PostRequest("api/MizzaSKUStockApi/", inputMizzaSKUStock);
                    if (check)
                    {
                        ViewBag.Message = "MizzaSKUStock details added successfully";
                    }
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MizzaSKUStock/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var list = await _httpConnectRepo.GetRequest("api/MizzaSKUStockApi/", id);
            return View(list.FirstOrDefault());
        }

        // POST: MizzaSKUStock/Edit/5
        [HttpPost]
        public async Task<ActionResult> Edit(int id, MizzaSKUStock inputMizzaSKUStock)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    bool check = await _httpConnectRepo.PutRequest("api/MizzaSKUStockApi/", id, inputMizzaSKUStock);
                    if (check)
                    {
                        ViewBag.Message = "MizzaSKUStock details edited successfully";
                    }
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MizzaSKUStock/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var list = await _httpConnectRepo.GetRequest("api/MizzaSKUStockApi/", id);
            return View(list.FirstOrDefault());
        }

        // POST: MizzaSKUStock/Delete/5
        [HttpPost]
        public async Task<ActionResult> Delete(int id, MizzaSKUStock inputMizzaSKUStock)
        {
            try
            {
                bool check = await _httpConnectRepo.DeleteRequest("api/MizzaSKUStockApi/", id);
                if (check)
                {
                    ViewBag.Message = "MizzaSKUStock details deleted successfully";
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
