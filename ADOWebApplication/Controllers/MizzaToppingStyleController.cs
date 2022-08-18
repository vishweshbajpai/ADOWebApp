using ADOWebApplication.ADORepositories;
using ADOWebApplication.DataModels;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ADOWebApplication.Controllers
{
    public class MizzaToppingStyleController : Controller
    {
        HttpConnectRepo<MizzaToppingStyle> _httpConnectRepo;
        public MizzaToppingStyleController()
        {
            _httpConnectRepo = new HttpConnectRepo<MizzaToppingStyle>();
        }
        // GET: MizzaToppingStyle
        public async Task<ActionResult> Index()
        {
            var list = await _httpConnectRepo.GetRequest("api/MizzaToppingStyleApi/");
            return View(list);
        }

        // GET: MizzaToppingStyle/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var list = await _httpConnectRepo.GetRequest("api/MizzaToppingStyleApi/", id);
            return View(list.FirstOrDefault());
        }

        // GET: MizzaToppingStyle/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MizzaToppingStyle/Create
        [HttpPost]
        public async Task<ActionResult> Create(MizzaToppingStyle inputMizzaToppingStyle)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool check = await _httpConnectRepo.PostRequest("api/MizzaToppingStyleApi/", inputMizzaToppingStyle);
                    if (check)
                    {
                        ViewBag.Message = "MizzaToppingStyle details added successfully";
                    }
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MizzaToppingStyle/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var list = await _httpConnectRepo.GetRequest("api/MizzaToppingStyleApi/", id);
            return View(list.FirstOrDefault());
        }

        // POST: MizzaToppingStyle/Edit/5
        [HttpPost]
        public async Task<ActionResult> Edit(int id, MizzaToppingStyle inputMizzaToppingStyle)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    bool check = await _httpConnectRepo.PutRequest("api/MizzaToppingStyleApi/", id, inputMizzaToppingStyle);
                    if (check)
                    {
                        ViewBag.Message = "MizzaToppingStyle details edited successfully";
                    }
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MizzaToppingStyle/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var list = await _httpConnectRepo.GetRequest("api/MizzaToppingStyleApi/", id);
            return View(list.FirstOrDefault());
        }

        // POST: MizzaToppingStyle/Delete/5
        [HttpPost]
        public async Task<ActionResult> Delete(int id, MizzaToppingStyle inputMizzaToppingStyle)
        {
            try
            {
                bool check = await _httpConnectRepo.DeleteRequest("api/MizzaToppingStyleApi/", id);
                if (check)
                {
                    ViewBag.Message = "MizzaToppingStyle details deleted successfully";
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
