using CoreMigration.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMigration.Controllers
{
    public class EvenementController : Controller
    {
        private readonly ConnectionDbClass _context;

        public EvenementController(ConnectionDbClass context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult lastArticle()
        {
            var model = _context.activites.Where(u => u.state.Equals("enable")).OrderByDescending(e => e.id).ToList();
            return PartialView("~/Views/Shared/_EvenementLayoutPage.cshtml", model);
        }

        public ActionResult events_img()
        {
            ViewData["activitie"] = GetActivities();
            return View(_context.activites.Where(u => u.state.Equals("enable")).ToList());
        }

        public ActionResult gallerie(int id)
        {
            ViewData["id"] = id;
            ViewData["titre"] = _context.activites.Find(id).titre;
            ViewData["gallerie"] = GetGallerie();

            return View(_context.activites.Where(u => u.state.Equals("enable")).ToList());
        }
        public ActionResult page_home()
        {
            int last_id = _context.activites.Where(e => e.state.Equals("enable")).OrderByDescending(u => u.id).FirstOrDefault().id;
            Activite act = _context.activites.Find(last_id);
            ViewData["newactivite"] = act;
            ViewData["nbrEvents"] = _context.activites.Count();
            ViewData["nbrImages"] = _context.galleries.Count();
            ViewData["nbrLauriat"] = _context.laureats.Count();

            ViewData["nbrLauriatGi"] = _context.laureats.Where(u => u.filiere1.nom.Equals("gi")).Count() * 15;
            ViewData["nbrLauriatGind"] = _context.laureats.Where(u => u.filiere1.nom.Equals("gind")).Count() * 15;
            ViewData["nbrLauriatGtr"] = _context.laureats.Where(u => u.filiere1.nom.Equals("gtr")).Count() * 15;
            ViewData["nbrLauriatGpmc"] = _context.laureats.Where(u => u.filiere1.nom.Equals("gpmc")).Count() * 15;

            return View(_context.activites.Where(u => u.state.Equals("enable")).ToList());
        }

        public ActionResult activitie(int id)
        {
            ViewData["date"] = _context.activites.Find(id).date.ToString("dd/MM/yyyy");
            ViewData["img"] = _context.activites.Find(id).piece_joint;
            ViewData["desc"] = _context.activites.Find(id).description;
            //ViewData["resp"] = db.Responsables.Find(db.activites.Find(id).responsable).nom;
            ViewData["titre"] = _context.activites.Find(id).titre;
            ViewData["activitie"] = GetActivities();
            ViewData["gallerie"] = GetGallerie();
            return View();
        }


        private List<Activite> GetActivities()
        {
            List<Activite> teachers = _context.activites.Where(u => u.state.Equals("enable")).ToList();
            return teachers;
        }
        private List<gallerie> GetGallerie()
        {
            List<gallerie> teachers = _context.galleries.ToList();
            return teachers;
        }
        public ActionResult Login()
        {
            if (!string.IsNullOrEmpty(HttpContext.Session.GetString("Admin")))
            {
                return Redirect("/HOME/index");
            }
            return View();
        }
        [HttpPost]
        public ActionResult Login(string username, string mp)
        {
            var x = _context.admins.ToList();

            if (!string.IsNullOrEmpty(username) && string.IsNullOrEmpty(mp))
            {
                return RedirectToAction("Login");
            }
            foreach (admin ad in x)
            {
                if (ad.username == username && ad.mdp == mp)
                {
                    HttpContext.Session.SetString("Admin", username);
                    ViewBag.MySession = HttpContext.Session.GetString("Admin");
                    return Redirect("/HOME/index");
                }
            }
            ViewBag.MyMsg = "mot de pass ou l'email est pas correct";
            return View();

        }
        public ActionResult actualite(int id)
        {

            Model1 db = new Model1();
            ViewData["date"] = db.actualites.Find(id).date.ToString("dd/MM/yyyy");
            ViewData["img"] = db.actualites.Find(id).piece_joint;
            ViewData["desc"] = db.actualites.Find(id).description;
            //ViewData["resp"] = db.Responsables.Find(db.activites.Find(id).responsable).nom;
            ViewData["titre"] = db.actualites.Find(id).titre;
            ViewData["activitie"] = GetActivities();
            lastArticle();
            return View();
        }
    }
}
