using System;
using System.ComponentModel.DataAnnotations;

namespace jwt.API.Dtos
{
    public class UserForRegisterDto
    {
    
        [Required]
        public string Username { get; set; }

         [Required]
        public string Password { get; set; }

       

       

    

       
    }
}
    