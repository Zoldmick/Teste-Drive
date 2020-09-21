using System;

namespace backend.Models.Response
{
    public class LoginResponse
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public int NivelLogin { get; set; }
    }
}