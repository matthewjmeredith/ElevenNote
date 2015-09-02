using ElevenNote.models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using ElevenNote.models.ViewModel;

namespace ElevenNote.Web.Controllers
{
    [Authorize]
    public class NotesController : Controller
    {
        // GET: Notes
        public ActionResult Index()
        {
            if (TempData["Result"] != null)
            {
                ViewBag.Success = TempData["Result"];
                TempData.Remove("Result");
            }
            var noteService = new ElevenNote.Services.NoteService();
            var notes = noteService.GetAllForUser(Guid.Parse(User.Identity.GetUserId())); // must parse guid otherwise returns string.
             return View(notes);
        }

        [HttpGet]
        [ActionName("Create")]

        public ActionResult CreateGet()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Create")]

        public ActionResult CreatePost(NoteEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var noteService = new ElevenNote.Services.NoteService();
                var userID = Guid.Parse(User.Identity.GetUserId());
                var result = noteService.Create(model, userID);
                TempData.Add("Result", result ? "Note Added." : "Note not added.");

                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}