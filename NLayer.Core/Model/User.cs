using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace NLayer.Core.Model
{
    public class User
    {
        public int Id { get; set; }
        public string UniqueName { get; set; }
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordHash { get; set; }



        public List<Tweet> Tweet{ get; set; } // Bir kullanıcının tweet'leri
        public List<Follower> Followers { get; set; } // Bir kullanıcının takipçileri
        public List<Follower> Following { get; set; } // Bir kullanıcının takip ettiği kişiler
     
    }
}
