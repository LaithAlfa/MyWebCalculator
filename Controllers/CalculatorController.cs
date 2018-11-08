using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyWebCalculator.Models;

using MathLibrary;

namespace MyWebCalculator.Controllers
{
    public class CalculatorController : Controller
    {
       public string Add(decimal left, decimal right)
       {
           return $"{left} plus {right} is: {MyMathRoutines.Add(left,right)}";
       }
       public string Subtract(decimal left, decimal right)
       {
           return $"{left} minus {right} is: {MyMathRoutines.Subtract(left,right)}";
       }
       public string Multiply(decimal left, decimal right)
       {
           return $"{left} multiplied by {right} is: {MyMathRoutines.Multiply(left, right)}";
       }
       public string Divide(decimal left, decimal right)
       {
           return $"{left} divided by {right} is: {MyMathRoutines.Divide(left, right)}";
       }
       public string Powers(double left, double right)
       {
           return $"{left} to the power of {right} is: {MyMathRoutines.Power(left, right)}";
       }
       public string Ceiling(decimal number)
       {
           return $"The ceiling of {number} is: {MyMathRoutines.Ceiling(number)}";
       }
       public string Floor(decimal number)
       {
           return $"The floor of {number} is: {MyMathRoutines.Floor(number)};";
}
      
    }
}
