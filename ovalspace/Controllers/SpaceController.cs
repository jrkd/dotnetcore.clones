using System.Linq;
using Microsoft.AspNetCore.Mvc;
using oval.models;

namespace oval.controllers{
    public class SpaceController : Controller
    {
        private OvalContext _context;
        public SpaceController(OvalContext context)
        {
            _context = context;
        }

        public IActionResult Index(){
            return View("SpaceList");
        }
        public IActionResult List(){
            return View("SpaceList", _context.Spaces);
        }

        public IActionResult Detail(int id){
            return View("SpaceDetail", _context.Spaces.FirstOrDefault(space => space.ID == id));
        }
    }
}