using ElevenNote.models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElevenNote.Web.Controllers
{
    public class NotesController : Controller
    {
        // GET: Notes
        public ActionResult Index()
        {

            var notes = new List<NoteListViewModel>();
            notes.Add(new NoteListViewModel()
            {
                Id = 0,
                DateCreated = DateTime.UtcNow.AddMonths(-1),
                DateModified = DateTime.UtcNow,
                IsFavorite = true,
                Title = "Title One"
            });

            notes.Add(new NoteListViewModel()
            {
                Id = 1,
                DateCreated = DateTime.UtcNow.AddMonths(-2),
                DateModified = DateTime.UtcNow,
                IsFavorite = false,
                Title = "Title Two"
            });

            notes.Add(new NoteListViewModel()
            {
                Id = 2,
                DateCreated = DateTime.UtcNow.AddMonths(-3),
                DateModified = DateTime.UtcNow,
                IsFavorite = false,
                Title = "Title Three"
            });

            return View(notes);
        }
    }
}