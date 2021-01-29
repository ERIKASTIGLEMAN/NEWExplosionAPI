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
    public class ExplosionController : ControllerBase
    {
        [HttpGet]
        public string Explosion(string s)
        {
            var explosionString = "";

            for (var i = 0; i < s.Length; i++)
            {
                var numChar = s[i].ToString();

                var num = int.Parse(numChar);

                for (var j = 0; j < num; j++)
                {
                    explosionString += numChar;
                }
            }
            return explosionString;
        }


        // This endpoint method will take the string passed to it, manipulate according to the kata https://www.codewars.com/kata/digits-explosion and return the result
    }
}