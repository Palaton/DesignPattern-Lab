using System.Collections.Generic;
using System.Linq;
using MVP.Example.WinForm.Model.Entity;

namespace MVP.Example.WinForm.Model
{
    public class UserModel:IUserModel
    {
        private readonly List<User> _users = new List<User>();

        /// <summary>
        /// add an item to the data
        /// </summary>
        /// <param name="user"></param>
        public void AddItem(User user)
        {
            _users.Add(user);
        }

        public List<User> GetUsers()
        {
            return _users;
        }

        public User SelectUser(string userName)
        {
            return _users.Where(x => x.Name.Equals(userName)).FirstOrDefault();
        }
    }
}
