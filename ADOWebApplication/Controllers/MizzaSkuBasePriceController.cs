using ADOWebApplication.ADORepositories;
using ADOWebApplication.DataModels;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ADOWebApplication.Controllers
{
    public class MizzaSkuBasePriceController : Controller
    {
        HttpConnectRepo<MizzaSkuBasePrice> _httpConnectRepo;
        public MizzaSkuBasePriceController()
        {
            _httpConnectRepo = new HttpConnectRepo<MizzaSkuBasePrice>();
        }
        
        // GET: MizzaSkuBasePrice
        public async Task<ActionResult> Index()
        {
            var list = await _httpConnectRepo.GetRequest("api/MizzaSkuBasePriceApi/");
            return View(list);
        }

        // GET: MizzaSkuBasePrice/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var list = await _httpConnectRepo.GetRequest("api/MizzaSkuBasePriceApi/", id);
            return View(list.FirstOrDefault());
        }

        // GET: MizzaSkuBasePrice/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MizzaSkuBasePrice/Create
        [HttpPost]
        public async Task<ActionResult> Create(MizzaSkuBasePrice inputMizzaSkuBasePrice)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool check = await _httpConnectRepo.PostRequest("api/MizzaSkuBasePriceApi/", inputMizzaSkuBasePrice);
                    if (check)
                    {
                        ViewBag.Message = "MizzaSkuBasePrice details added successfully";
                    }
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MizzaSkuBasePrice/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var list = await _httpConnectRepo.GetRequest("api/MizzaSkuBasePriceApi/", id);
            return View(list.FirstOrDefault());
        }

        // POST: MizzaSkuBasePrice/Edit/5
        [HttpPost]
        public async Task<ActionResult> Edit(int id, MizzaSkuBasePrice inputMizzaSkuBasePrice)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    bool check = await _httpConnectRepo.PutRequest("api/MizzaSkuBasePriceApi/", id, inputMizzaSkuBasePrice);
                    if (check)
                    {
                        ViewBag.Message = "MizzaSkuBasePrice details edited successfully";
                    }
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MizzaSkuBasePrice/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var list = await _httpConnectRepo.GetRequest("api/MizzaSkuBasePriceApi/", id);
            return View(list.FirstOrDefault());
        }

        // POST: MizzaSkuBasePrice/Delete/5
        [HttpPost]
        public async Task<ActionResult> Delete(int id, MizzaSkuBasePrice inputMizzaSkuBasePrice)
        {
            try
            {
                bool check = await _httpConnectRepo.DeleteRequest("api/MizzaSkuBasePriceApi/", id);
                if (check)
                {
                    ViewBag.Message = "MizzaSkuBasePrice details deleted successfully";
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
