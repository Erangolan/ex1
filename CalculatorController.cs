using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OnlineCalculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        // GET api/calculator/GetFiveRandomNumbers
        [HttpGet("GetFiveRandomNumbers")]
        public List<int> GetFiveRandomNumbers()
        {
            var numbers = new List<int>();
            var rnd = new Random();
            int count = 0;
            while (count < 5)
            {
                int newNum = rnd.Next(1, 21); // generate a random number between 1- 20
                if (!numbers.Contains(newNum))
                {
                    numbers.Add(newNum);
                    count++;
                }
            }
            return numbers;
        }

        // GET api/calculator/ReverseSentence //number 2
        [HttpGet("ReverseSentence")]
        public string ReverseSentence(string data)
        {
            string result = " ";
            string[] words = data.Split(' ');
            foreach (string word in words)
            {
                result = result.Insert(0, word);
                result = result.Insert(word.Length, " ");
            }
            return result;
        }

        // GET api/calculator/Equals //number 5
        [HttpGet("Equals")]
        public bool Equals(string data1, string data2)
        {
            data1 = data1.ToLower();
            data2 = data2.ToLower();
            return data1.Equals(data2);
        }

        // GET api/calculator/Combine //number 8
        [HttpGet("Combine")]
        public string Combine(string data1, string data2)
        {
            return data1 + " " + data2;
        }

        // GET api/calculator/Number9 //number 9
        [HttpGet("Number9")]
        public string Number9(string data1)
        {
            string data2 = "";
            for (int i = 0; i < data1.Length; i++)
            {
                data2 += (char)(data1[i] + 1);
            }
            return data2;
        }

        // GET api/calculator/Before //number 19
        [HttpGet("Before")]
        public List<int> Before(int num)
        {
            var numbers = new List<int>();
            for(int i = 1; i < num; i++)
                numbers.Add(i);
            return numbers;
        }
    }
}
