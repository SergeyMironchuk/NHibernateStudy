using System.Linq;
using System.Web.Mvc;
using ATB.RPO.NHibernateStudy.Models.Domain.ITConfig;

namespace ATB.RPO.NHibernateStudy.Controllers
{
    public class HomeController : Controller
    {
        protected IRepository Repository { get; set; }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Values()
        {
            return Json(Repository.GetEssences()
                .Take(2)
                .ToList()
                .Select(e => e.CloneWithoutReferences()), JsonRequestBehavior.AllowGet)
                ;
        }
    }
}
