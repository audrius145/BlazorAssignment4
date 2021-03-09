using System.Linq;
using System.Threading.Tasks;
using Assignment3API.Data;
using Assignment3API.Model;
using Assignment3API.Persistence;

namespace Assignment3API.Service
{
    public class UserRepo : IUserRepo
    {
        private Assignment4DBContext ctx;

        public UserRepo(Assignment4DBContext ctx)
        {
            this.ctx = ctx;
        }
        public async Task<User> ValidateUser(string userName, string passWord)
        {
            User user =  ctx.Users.FirstOrDefault(u => u.UserName.Equals(userName) && u.Password.Equals(passWord));
            return user;
        }
    }
}