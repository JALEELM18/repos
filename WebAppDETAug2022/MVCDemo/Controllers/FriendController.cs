using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class FriendController : Controller
    {
        public List<Friend> friend { get; set; }

    }
}
