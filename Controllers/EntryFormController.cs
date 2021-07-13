using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UmbracoInternal.Models;
using Umbraco.Web.Mvc;

namespace UmbracoInternal.Controllers
{
    public class EntryFormController : SurfaceController
    {
        public const string PARTIAL_VIEW_FOLDER = "~/Views/Partials/EntryForm/";
        public ActionResult RenderForm()
        {
            EntryFormModel model = new EntryFormModel();
            model.userName = "Vijay";
            model.EmailID = "vijay@gmail.com";
            model.PolicyNo = "33343";
            model.DOB = "3rdOct2020";
            ViewData["Data"] = model;
            return PartialView(PARTIAL_VIEW_FOLDER + "RenderForm.cshtml");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitForm(EntryFormModel model)
        {
            if (ModelState.IsValid)            {
                
                TempData["ContactSuccess"] = true;
                return RedirectToCurrentUmbracoPage();
            }
            return CurrentUmbracoPage();
        }
    }
}