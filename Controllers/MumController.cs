using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NEWExplosionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MumController : ControllerBase
    {
        [HttpGet]
        public string Mumbling(string s)
        {
            return String.Join("-", s.ToLower().Select((character, index) => new String(character, index + 1))
                .Select(subString => subString.Substring(0, 1).ToUpper() + subString.Substring(1)));
        }
    }
}