using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserRetrieval
    {
        public HMOEntities db { get; set; } = HMOEntities.Instance;
        public List<User> GetUsers()
        {
            return db.User.ToList();
        }

        public User getBuID(string id)
        {
            return this.db.User.FirstOrDefault(x => x.ID_user == id);
        }
    }
}
