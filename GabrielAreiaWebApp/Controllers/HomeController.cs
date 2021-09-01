using GabrielAreiaAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GabrielAreiaWebApp.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            ViewBag.Root = "https://gabrielareia-resume.herokuapp.com";
            ViewBag.Text = UpdatePageText();

            var client = new HttpClient();
            HttpResponseMessage response =
                await client.GetAsync(ViewBag.Root + "/api/resume/all");

            response.EnsureSuccessStatusCode();

            string resumeJson = await response.Content.ReadAsStringAsync();

            Resume[] allResumes = JsonConvert.DeserializeObject<Resume[]>(resumeJson);
            string lang = Program.Language;

            Resume modelSorted = allResumes
                .Where(r => r.FullName == "Gabriel Coutinho Areia" && r.Language == lang)
                .DefaultIfEmpty(allResumes[0])
                .FirstOrDefault();

            modelSorted.Abilities = modelSorted.Abilities.OrderBy(i => i.Order).ToArray();
            modelSorted.Achievements = modelSorted.Achievements.OrderBy(i => i.Order).ToArray();
            modelSorted.Courses = modelSorted.Courses.OrderBy(i => i.Order).ToArray();
            modelSorted.Experiences = modelSorted.Experiences.OrderBy(i => i.Order).ToArray();

            return View(modelSorted);
        }

        [NonAction]
        public Dictionary<string, string> UpdatePageText()
        {
            if (Program.Language == "pt")
            {
                //Portuguese
                return new Dictionary<string, string>()
                {
                    {"Home", "Início" },
                    {"Source Code", "Código Fonte" },
                    //
                    {"Where to find me", "Minhas Redes" },
                    //
                    {"About me", "Sobre mim" },
                    {"Courses", "Cursos" },
                    {"Abilities", "Habilidades" },
                    {"Achievements", "Conquistas" },
                    {"Goals", "Objetivos" },
                    {"Contact Information", "Informações de Contato" },
                    {"Cellphone", "Celular" },
                    //
                    {"Institution", "Instituição" },
                    {"Go to website", "Visite o site" },
                    {"Start", "Início" },
                    {"End", "Conclusão" },
                    {"See Certificate", "Ver certificado" },
                    {"Experience", "Experiência" },
                    {"Year", "Ano" },
                };
            }
            else
            {
                //English
                return new Dictionary<string, string>()
                {
                    {"Home", "Home" },
                    {"Source Code", "Source Code" },
                    //
                    {"Where to find me", "Where to Find Me" },
                    //
                    {"About me", "About me" },
                    {"Courses", "Courses" },
                    {"Abilities", "Abilities" },
                    {"Achievements", "Achievements" },
                    {"Goals", "Goals" },
                    {"Contact Information", "Contact Information" },
                    {"Cellphone", "Cellphone" },
                    //
                    {"Institution", "Institution" },
                    {"Go to website", "Go to website" },
                    {"Start", "Start" },
                    {"End", "End" },
                    {"See Certificate", "See Certificate" },
                    {"Experience", "Experience" },
                    {"Year", "Year" },
                };
            }
        }

    }
}
