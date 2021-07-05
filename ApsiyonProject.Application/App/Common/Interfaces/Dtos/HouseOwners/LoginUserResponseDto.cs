using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonProject.Application.App.Common.Interfaces.Dtos.HouseOwners
{
    public class LoginUserResponseDto
    {
        public Guid Id { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public bool IsActive { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string TCNo { get; set; }
        public string Phone { get; set; }
    }
}
