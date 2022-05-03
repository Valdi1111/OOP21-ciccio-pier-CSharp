using System.Collections.Generic;

namespace Tasks
{
    public class MainMenuController : IMenuController
    {
        public void Load()
        {
            throw new System.NotImplementedException();
        }

        public void LoadUsers()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateUsers()
        {
            throw new System.NotImplementedException();
        }

        public User CreateUser(string username)
        {
            throw new System.NotImplementedException();
        }

        public string Username { get; }
        public User Player { get; }
        public List<User> Users { get; }

        public void LoadPlayer()
        {
            throw new System.NotImplementedException();
        }
    }
}