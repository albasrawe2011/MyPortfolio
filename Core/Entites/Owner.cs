using System;

namespace Core.Entites
{
    public class Owner : EntityBase
    {
        public string FullName { get; set; }
        public String Avatar { get; set; }
        public String Profil { get; set; }

        public Address Address { get; set; }
    }
}
