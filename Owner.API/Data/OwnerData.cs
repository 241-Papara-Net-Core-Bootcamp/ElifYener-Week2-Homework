using System;
using System.Collections.Generic;
using System.Reflection;

namespace Owner.API.Data
{
    public class OwnerData
    {
        public List<Models.Owner> GetAllOwners()
        {
            return new List<Models.Owner>
            {
                new Models.Owner
                {
                    Id = 1,
                    Name = "Elif",
                    Surname = "Yener",
                    Date = new DateTime(1999,11,26),
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    Type = "Student"
                },
                new Models.Owner
                {
                    Id = 2,
                    Name = "Samet",
                    Surname = "Kayıkçı",
                    Date = new DateTime(2022,9,18),
                    Description = "Proin viverra varius aliquam.",
                    Type = "Teacher"
                },
                new Models.Owner
                {
                    Id = 3,
                    Name = "Beşir",
                    Surname = "Gündüz",
                    Date = new DateTime(2022,10,5),
                    Description = "Pellentesque nulla neque, auctor at nulla eu, ultricies ullamcorper mauris.",
                    Type = "Assistant"
                },
                new Models.Owner
                {
                    Id = 4,
                    Name = "Nuray",
                    Surname = "Kılıç",
                    Date = new DateTime(2022,10,6),
                    Description = "Fusce facilisis arcu felis, vitae lacinia tellus mattis vitae.",
                    Type = "Assistant"
                },
                new Models.Owner
                {
                    Id = 5,
                    Name = "Uğurcan",
                    Surname = "Gürsu",
                    Date = new DateTime(2021,12,7),
                    Description = "Integer laoreet purus non nulla tempor feugiat.",
                    Type = "Assistant"
                }                
            };
         }
    }
}
