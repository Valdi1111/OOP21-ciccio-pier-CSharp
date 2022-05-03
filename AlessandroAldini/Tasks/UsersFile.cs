using System.Collections.Generic;

namespace Tasks
{
    public class UsersFile
    {
        /// <summary>
        /// This method gets and sets the last logged user
        /// </summary>
        public string LastUser { get; set; }

        /// <summary>
        /// This method gets and sets the list of users
        /// </summary>
        public List<User> Users { get; set; }
    }
}