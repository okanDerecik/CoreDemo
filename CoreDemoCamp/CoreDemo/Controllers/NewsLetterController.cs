using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class NewsLetterController : Controller
    {
        NewsLetterManager nm = new NewsLetterManager(new EfNewsLetterRepository()); 

        [HttpGet]
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }
        [HttpPost]
        public JsonResult SubscribeMail (NewsLetter newsLetter)
        {
            newsLetter.MailStatus = true;
            nm.AddNewsLetter(newsLetter);
            return  Json(new
            {
                status = "Success",
                newsletter = newsLetter,
                message = "Mail Başarı ile Eklendi",
                errorMessage = "Hata oluştu. Mail eklenemedi.",
            }); 
        }
    }
}
