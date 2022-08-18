using ADOWebApplication.ADORepositories;
using ADOWebApplication.DataModels;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ADOWebApplication.Controllers
{

    public class MizzaSizeController : Controller
    {
        HttpConnectRepo<MizzaSize> _httpConnectRepo;
        public MizzaSizeController()
        {
            _httpConnectRepo = new HttpConnectRepo<MizzaSize>();
        }
        // GET: MizzaSize
        public async Task<ActionResult> Index()
        {
            var list = await _httpConnectRepo.GetRequest("api/MizzaSizeApi/");
            return View(list);
        }

        // GET: MizzaSize/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var list = await _httpConnectRepo.GetRequest("api/MizzaSizeApi/", id);
            return View(list.FirstOrDefault());
        }

        // GET: MizzaSize/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MizzaSize/Create
        [HttpPost]
        public async Task<ActionResult> Create(MizzaSize inputMizzaSize)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool check = await _httpConnectRepo.PostRequest("api/MizzaSizeApi/", inputMizzaSize);
                    if (check)
                    {
                        ViewBag.Message = "MizzaSize details added successfully";
                    }
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MizzaSize/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var list = await _httpConnectRepo.GetRequest("api/MizzaSizeApi/", id);
            return View(list.FirstOrDefault());
        }

        // POST: MizzaSize/Edit/5
        [HttpPost]
        public async Task<ActionResult> Edit(int id, MizzaSize inputMizzaSize)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    bool check = await _httpConnectRepo.PutRequest("api/MizzaSizeApi/", id, inputMizzaSize);
                    if (check)
                    {
                        ViewBag.Message = "MizzaSize details edited successfully";
                    }
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MizzaSize/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var list = await _httpConnectRepo.GetRequest("api/MizzaSizeApi/", id);
            return View(list.FirstOrDefault());
        }

        // POST: MizzaSize/Delete/5
        [HttpPost]
        public async Task<ActionResult> Delete(int id, MizzaSize inputMizzaSize)
        {
            try
            {
                bool check = await _httpConnectRepo.DeleteRequest("api/MizzaSizeApi/", id);
                if (check)
                {
                    ViewBag.Message = "MizzaSize details deleted successfully";
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
