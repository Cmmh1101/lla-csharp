using Microsoft.AspNetCore.Mvc;
using LearningLanguageApp.Models;
//using LearningLanguageApp.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LearningLanguageApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly LearningLanguageContext _context;

    }

}