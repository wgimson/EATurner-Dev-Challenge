using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EATurnerDevChallenge.Models;
using EATurnerDevChallenge.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EATurnerDevChallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TitlesController : ControllerBase
    {
        private readonly TitleService _titleService;

        public TitlesController(TitleService titleService)
        {
            _titleService = titleService;
        }

        public ActionResult<List<Title>> Get() =>
            _titleService.Get();

        [HttpGet("{titleName}", Name ="GetByTitleName")]
        public ActionResult<List<Title>> Get(string titleName)
        {
            var titles = _titleService.GetByTitle(titleName);

            if (titles == null || titles.Count() < 1)
            {
                return NotFound();
            }

            return titles;
        }

        [HttpGet("GetTitleById/{id}")]
        public ActionResult<Title> GetById(int id)
        {
            var title = _titleService.GetById(id);

            if (title == null)
            {
                return NotFound();
            }

            return title;
        }

        [HttpPost]
        public ActionResult<Title> Create(Title title)
        {
            _titleService.Create(title);

            return CreatedAtRoute("GetTitle", new { id = title.Id.ToString() }, title);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Title titleIn)
        {
            var title = _titleService.Get(id);

            if (title == null)
            {
                return NotFound();
            }

            _titleService.Update(id, titleIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var title = _titleService.Get(id);

            if (title == null)
            {
                return NotFound();
            }

            _titleService.Remove(title.Id);

            return NoContent();
        }
    }
}