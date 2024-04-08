using CalculatorWebAPI.DTO;
using CalculatorWebAPI.Models;
using CalculatorWebAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;

namespace CalculatorWebAPI.Controllers
{
    [Route("api")]
    [ApiController]

    public class MonkeysWebAPI : ControllerBase
    {
        [HttpGet("monkeys")]
        public IActionResult GetMonkeys()
        {
            try
            {
                MonkeyList l = new MonkeyList();
                MonkeyListDto ret = new MonkeyListDto();
                for (int i = 0; i < l.Monkeys.Count; i++)
                {
                    MonkeyDto m = new MonkeyDto
                    {
                        Name = l.Monkeys[i].Name,
                        Location = l.Monkeys[i].Location,
                        Details = l.Monkeys[i].Details,
                        ImageUrl = l.Monkeys[i].ImageUrl,
                        IsFavorite = l.Monkeys[i].IsFavorite
                    };
                    ret.Monkeys.Add(m);
                }
                return Ok(ret);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("monkeyname")]
        public IActionResult ReadMonkey([FromQuery] string name)
        {
            try
            {
                MonkeyList l = new MonkeyList();
                bool found = false;
                for (int i = 0; i < l.Monkeys.Count; i++)
                {
                    if (found == false && l.Monkeys[i].Name == name)
                    {
                            m.Name = l.Monkeys[i].Name,
                            m.Location = l.Monkeys[i].Location,
                            m.Details = l.Monkeys[i].Details,
                            m.ImageUrl = l.Monkeys[i].ImageUrl,
                            m.IsFavorite = l.Monkeys[i].IsFavorite


                        found = true;
                    }
                }
                if (found == false)
                {
                    return NotFound();
                }
                else
                {
                    MonkeyDto ret = new MonkeyDto()
                    {
                        Name = m.Name,
                        Location = m.Location,
                        Details = m.Details,
                        ImageUrl = m.ImageUrl,
                        IsFavorite = m.IsFavorite
                    };
                    return Ok(ret);

                }
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("monkey")]
        public IActionResult AddMonkey([FromQuery] MonkeyDto monkey)
        {
            monkey m = new monkey
            {
                Name = monkey.Name,
                Location = monkey.Location,
                Details = monkey.Details,
                ImageUrl = monkey.ImageUrl,
                IsFavorite = monkey.IsFavorite
            };
            MonkeyList list = new MonkeyList();
            bool nameExist = false;
            for(int i = 0;i<list.Monkeys.Count;i++)
            {
                if (list.Monkeys[i].Name == m.Name)
                {
                    nameExist = true;
                }
                if (nameExist != true)
                {
                    list.Monkeys.Add(m);
                    return Ok();

                }
                else
                {

                }
            }
        }

    }
}
