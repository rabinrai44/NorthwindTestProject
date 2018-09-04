using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AddNumber.Models
{
    public class Test
    {
        [Range(1, 100, ErrorMessage = "The Number must be between 1-100.")]
        public int Number1 { get; set; }
        [Range(1, 100, ErrorMessage = "The Number must be between 1-100.")]
        public int Number2 { get; set; }

        public int GetSum(int num1, int num2)
        {
            num1 = Number1;
            num2 = Number2;;
            return num1 + num2;
        }

        public int GetSum()
        {
            return GetSum();
        }
    }
}