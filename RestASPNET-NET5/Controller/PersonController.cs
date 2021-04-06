using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace RestASPNET_NET5.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var firstDecimal = ConvertToDecimal(firstNumber);
                var secondDecimal = ConvertToDecimal(secondNumber);

                var sum = firstDecimal + secondDecimal;
                return Ok(sum.ToString());
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("sub/{firstNumber}/{secondNumber}")]
        public IActionResult Sub(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var firstDecimal = ConvertToDecimal(firstNumber);
                var secondDecimal = ConvertToDecimal(secondNumber);
                var sub = firstDecimal - secondDecimal;

                return Ok(sub.ToString());
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("multi/{firstNumber}/{secondNumber}")]
        public IActionResult Multi(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var firstDecimal = ConvertToDecimal(firstNumber);
                var secondDecimal = ConvertToDecimal(secondNumber);
                var multi = firstDecimal * secondDecimal;

                return Ok(multi.ToString());
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("div/{firstNumber}/{secondNumber}")]
        public IActionResult Div(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var firstDecimal = ConvertToDecimal(firstNumber);
                var secondDecimal = ConvertToDecimal(secondNumber);

                var div = firstDecimal / secondDecimal;
                return Ok(div.ToString());
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("md/{firstNumber}/{secondNumber}")]
        public IActionResult Md(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var firstDecimal = ConvertToDecimal(firstNumber);
                var secondDecimal = ConvertToDecimal(secondNumber);

                var med = (firstDecimal * secondDecimal) / 2;
                return Ok(med.ToString());
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("sqrt/{firstNumber}")]
        public IActionResult Sqrt(string firstNumber)
        {
            if (IsNumeric(firstNumber))
            {
                var firstDecimal = ConvertToDecimal(firstNumber);

                var sqrt = Math.Sqrt((double)firstDecimal);
                return Ok(sqrt.ToString());
            }
            return BadRequest("Invalid Input");
        }

        private bool IsNumeric(string strNumber)
        {
            double number;
            bool isNumber = double.TryParse(strNumber, NumberStyles.Any, 
                NumberFormatInfo.InvariantInfo, out number);
            return isNumber;
        }

        private decimal ConvertToDecimal(string strNumber)
        {
            decimal decimalValue;
            if (decimal.TryParse(strNumber, out decimalValue))
            {
                return decimalValue;
            }
            return 0;
        }
    }
}
