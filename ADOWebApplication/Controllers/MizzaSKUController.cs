using ADOWebApplication.ADORepositories;
using ADOWebApplication.DataModels;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ADOWebApplication.Controllers
{
    public class MizzaSKUController : Controller
    {
        HttpConnectRepo<MizzaSKU> _httpConnectRepo;
        public MizzaSKUController()
        {
            _httpConnectRepo = new HttpConnectRepo<MizzaSKU>();
        }
        // GET: MizzaSku
        public async Task<ActionResult> Index()
        {
            var list = await _httpConnectRepo.GetRequest("api/MizzaSKUApi/");
            return View(list);
        }

        // GET: MizzaSku/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var list = await _httpConnectRepo.GetRequest("api/MizzaSKUApi/", id);
            return View(list.FirstOrDefault());
        }

        // GET: MizzaSku/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MizzaSku/Create
        [HttpPost]
        public async Task<ActionResult> Create(MizzaSKU inputMizzaSKU)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool check = await _httpConnectRepo.PostRequest("api/MizzaSKUApi/", inputMizzaSKU);
                    if (check)
                    {
                        ViewBag.Message = "MizzaSKU details added successfully";
                    }
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MizzaSku/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var list = await _httpConnectRepo.GetRequest("api/MizzaSKUApi/", id);
            return View(list.FirstOrDefault());
        }

        // POST: MizzaSku/Edit/5
        [HttpPost]
        public async Task<ActionResult> Edit(int id, MizzaSKU inputMizzaSKU)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    bool check = await _httpConnectRepo.PutRequest("api/MizzaSKUApi/", id, inputMizzaSKU);
                    if (check)
                    {
                        ViewBag.Message = "MizzaSKU details edited successfully";
                    }
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MizzaSku/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var list = await _httpConnectRepo.GetRequest("api/MizzaSKUApi/", id);
            return View(list.FirstOrDefault());
        }

        // POST: MizzaSku/Delete/5
        [HttpPost]
        public async Task<ActionResult> Delete(int id, MizzaSKU inputMizzaSKU)
        {
            try
            {
                bool check = await _httpConnectRepo.DeleteRequest("api/MizzaSKUApi/", id);
                if (check)
                {
                    ViewBag.Message = "MizzaSKU details deleted successfully";
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
