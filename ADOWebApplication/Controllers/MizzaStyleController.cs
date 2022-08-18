using ADOWebApplication.ADORepositories;
using ADOWebApplication.DataModels;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ADOWebApplication.Controllers
{
    public class MizzaStyleController : Controller
    {
        HttpConnectRepo<MizzaStyle> _httpConnectRepo;
        public MizzaStyleController()
        {
            _httpConnectRepo = new HttpConnectRepo<MizzaStyle>();
        }
        // GET: MizzaStyle
        public async Task<ActionResult> Index()
        {
            var list = await _httpConnectRepo.GetRequest("api/MizzaStyleApi/");
            return View(list);
        }

        // GET: MizzaStyle/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var list = await _httpConnectRepo.GetRequest("api/MizzaStyleApi/", id);
            return View(list.FirstOrDefault());
        }

        // GET: MizzaStyle/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MizzaStyle/Create
        [HttpPost]
        public async Task<ActionResult> Create(MizzaStyle inputMizzaStyle)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool check = await _httpConnectRepo.PostRequest("api/MizzaStyleApi/", inputMizzaStyle);
                    if (check)
                    {
                        ViewBag.Message = "MizzaStyle details added successfully";
                    }
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MizzaStyle/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var list = await _httpConnectRepo.GetRequest("api/MizzaStyleApi/", id);
            return View(list.FirstOrDefault());
        }

        // POST: MizzaStyle/Edit/5
        [HttpPost]
        public async Task<ActionResult> Edit(int id, MizzaStyle inputMizzaStyle)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    bool check = await _httpConnectRepo.PutRequest("api/MizzaStyleApi/", id, inputMizzaStyle);
                    if (check)
                    {
                        ViewBag.Message = "MizzaStyle details edited successfully";
                    }
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MizzaStyle/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var list = await _httpConnectRepo.GetRequest("api/MizzaStyleApi/", id);
            return View(list.FirstOrDefault());
        }

        // POST: MizzaStyle/Delete/5
        [HttpPost]
        public async Task<ActionResult> Delete(int id, MizzaStyle inputMizzaStyle)
        {
            try
            {
                bool check = await _httpConnectRepo.DeleteRequest("api/MizzaStyleApi/", id);
                if (check)
                {
                    ViewBag.Message = "MizzaStyle details deleted successfully";
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
