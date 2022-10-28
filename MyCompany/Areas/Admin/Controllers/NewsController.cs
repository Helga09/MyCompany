using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCompany.Domain;
using MyCompany.Domain.Entities;
using MyCompany.Servise;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace MyCompany.Areas.Admin.Controllers
{


    [Area("Admin")]
    public class NewsController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostingEnvironment;

        public NewsController(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
        {
            this.dataManager = dataManager;
            this.hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Edit(Guid id)
        {
            var entity = id == default ? new News() : dataManager.News.GetNewsById(id);
            return View(entity);
        }

        public IActionResult EditNotPublish(Guid id)
        {
            var entity = dataManager.News.GetNewsById(id);
            return View(entity);
        }

        [AcceptVerbs("Get", "Post")]
        public IActionResult CheckTitle(string title)
        {
            foreach (News news in dataManager.News.GetPublishNews())
            {
                if (title == news.Title)
                    return Json(false);
            }
            return Json(true);
        }

        [HttpPost]
        public IActionResult Edit(News model, IFormFile titleImageFile)
        {
            if (ModelState.IsValid)
            {
                if (titleImageFile != null)
                {
                    model.TitleImagePath = titleImageFile.FileName;
                    using (var stream = new FileStream(Path.Combine(hostingEnvironment.WebRootPath, "images/", titleImageFile.FileName), FileMode.Create))
                    {
                        titleImageFile.CopyTo(stream);
                    }
                }
                dataManager.News.SaveNews(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.News.DeleteNews(id);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }

        [HttpPost]
        public IActionResult Publish(News model)
        {
            SendEmailAsync(model.Email, "Ваша новина пройшла рецензію та буде опублікована на сайті", model.Title, model.DateAdded).GetAwaiter();
            model.Publish = true;
            dataManager.News.SaveNews(model);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }

        [HttpPost]
        public IActionResult NotPublish(News model, string message)
        {
            SendEmailAsync(model.Email, message, model.Title, model.DateAdded).GetAwaiter();
            dataManager.News.DeleteNews(model.Id);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }

        async Task SendEmailAsync(string email, string messegetext, string newsName, DateTime date)
        {
            MailAddress from = new MailAddress(Config.CompanyEmail);
            MailAddress to = new MailAddress(email);
            MailMessage m = new MailMessage(from, to);
            m.Subject = "Рецензія";
            m.Body = messegetext + "\nВідповідь на новину: '" + newsName + "' від " + date;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential(Config.CompanyEmail, Config.EmailPassword);
            smtp.EnableSsl = true;
            await smtp.SendMailAsync(m);
        }


    }
}
