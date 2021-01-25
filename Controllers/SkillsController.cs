using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillsTracker.Controllers
{
    // GET: /<controller>/
    public class SkillsController : Controller
    {
        [HttpGet]
        [Route("/skills")]
        public IActionResult Index()
        {
            string html = "<h1>Skills Tracker</h1>" +
                "<h2>Coding Skills to learn</h2>" +
                "<ol>" +
                    "<li>C#</li>" +
                    "<li>JavaScript</li>" +
                    "<li>Python</li>" +
                "</ol>";

            return Content(html, "text/html");
        }

        // GET: /skills/forms
        [HttpGet]
        [Route("/skills/forms")]
        public IActionResult Forms()
        {
            string html = 
                "<form method='post' action='/skills/form'>" +
                    "<div>" +
                        "<label>" +
                            "Date" +
                            "<input type = 'date' name = 'date'/>" +
                        "</label>" +
                    "</div>" +
                    "<div>" +
                        "<label>" +
                            "C#:" +
                            "<br>" +
                            "<select name = 'csharpSkill'>" +
                                "<option value = 'basic'>Basic</option>" +
                                "<option value = 'moderate'>Moderate</option>" +
                                "<option value = 'advanced' >Advanced</option>" +
                            "</select>" +
                        "</label>" +
                    "</div>" +
                    "<div>" +
                        "<label>" +
                            "JavaScript:" +
                            "<br>" +
                            "<select name = 'javaScriptSkill'>" +
                                "<option value = 'basic'>Basic</option>" +
                                "<option value = 'moderate'>Moderate</option>" +
                                "<option value = 'advanced'>Advanced</option >" +
                            "</select>" +
                        "</label>" +
                    "</div>" +
                    "<div>" +
                        "<label>" +
                            "Python:" +
                            "<br>" +
                            "<select name = 'pythonSkill'>" +
                                "<option value = 'basic'> Basic </option>" +
                                "<option value = 'moderate'> Moderate </option>" +
                                "<option value = 'advanced'> Advanced </option>" +
                            "</select>" +
                        "</label>" + 
                    "</div>" +
                "<input type = 'submit' value = 'Submit'>" + 
            "</form>";

            return Content(html, "text/html");
        }
    }
}
