using System;
using System.ComponentModel.DataAnnotations;

namespace AlbumsWebApp.Models
{
    internal class CheckValidYear : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            int year = (int)value;
            if (year < 1960)
            {
                ErrorMessage = "No good album was created before the year 1960"; //this is just wrong, plain and simple
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}