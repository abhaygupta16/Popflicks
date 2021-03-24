using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace project.Models
{
    public class Roles
    {
        public int Id { get; set; }

        [Required]
        public string RoleName { get; set; }
    }
}
