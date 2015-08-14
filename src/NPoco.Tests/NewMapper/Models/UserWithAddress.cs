using System;

namespace NPoco.Tests.NewMapper.Models
{
    public class UserWithAddress
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public MyAddress Address { get; set; }

        public class MyAddress
        {
            public int StreetNo { get; set; }
            public string StreetName { get; set; }
            public DateTime MovedInOn { get; set; }
        }
    }
}