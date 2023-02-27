using ConnectingDbEmail.Db;
using ConnectingDbEmail.Helper;
using ConnectingDbEmail.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConnectingDbEmail;

[Route("api/[controller]")]
[ApiController]
public class MailController : ControllerBase
{
    [HttpPost]
    public void Register(Email emails)
    {
        DemoDbContext demoDbContext = new DemoDbContext();
        demoDbContext.Emails.Add(emails);
        demoDbContext.SaveChanges();
        Helperclass obj = new Helperclass();
        obj.GetEmail(email,Otp);
        obj.GetOtp();

    }
    [HttpPost]
    public void Login()
    {

    }
}  


