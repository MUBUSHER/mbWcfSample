using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Core;

namespace mbWcfSample
{    
    public class Users : IUsers
    {
        public IEnumerable<User> GetAllActiveUsers()
        {
            return new List<User>() { 
                new User() { Id = 92, FirstName = "Mahya", LastName = "Dalir", Email = "", Mobile = ""  },
                new User() { Id = 131, FirstName = "Mohsin Iftikhar", LastName = "Baig", Email = "", Mobile = ""  },
                new User() { Id = 132, FirstName = "Bilal", LastName = "Yousaf", Email = "", Mobile = ""  },
                new User() { Id = 342, FirstName = "Daryhl", LastName = "Maniquis", Email = "", Mobile = ""  },
                new User() { Id = 345, FirstName = "Mahmoud", LastName = "Hbobati", Email = "", Mobile = ""  },
                new User() { Id = 404, FirstName = "Mohammad", LastName = "Mubusher", Email = "", Mobile = ""  },
                new User() { Id = 424, FirstName = "Alejandro", LastName = "Silva", Email = "", Mobile = ""  },
                new User() { Id = 535, FirstName = "Azzam", LastName = "Mazen Issa", Email = "", Mobile = ""  },
                new User() { Id = 557, FirstName = "Omar", LastName = "Diaa", Email = "", Mobile = ""  },
                new User() { Id = 568, FirstName = "Karim Mohamed", LastName = "Abdallah", Email = "", Mobile = ""  },
                new User() { Id = 569, FirstName = "Sharifa", LastName = "Taimur", Email = "", Mobile = ""  },
                new User() { Id = 574, FirstName = "Loree Lai", LastName = "Lagunilla", Email = "", Mobile = ""  },ss
            };
        }
    }
}
