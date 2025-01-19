using Microsoft.AspNetCore.Mvc;
using Performance_Monitoring_Dashboard.Models;

namespace Performance_Monitoring_Dashboard.Controllers
{
    public class MetricsController : Controller
    {
        private readonly PerformanceDbContext _context;

        public MetricsController(PerformanceDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var metrics = _context.Metrics.ToList();
            return View(metrics);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Metric metric)
        {
            if (ModelState.IsValid)
            {
                _context.Metrics.Add(metric);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(metric);
        }
    }
}
