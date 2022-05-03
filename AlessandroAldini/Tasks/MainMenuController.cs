#nullable enable
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace Tasks
{
    /// <summary>
    /// <inheritdoc cref="IMenuController"/>
    /// </summary>
    public class MainMenuController : IMenuController
    {
        public readonly string Directory = AppContext.BaseDirectory + "/users";
        private FileStream? _usersFile;
        public User? Player { get; set; }
        public List<User> Users { get; private set; } = new List<User>();

        /// <summary>
        /// <inheritdoc cref="IMenuController.LoadUsers"/>
        /// </summary>
        public async Task LoadUsers()
        {
            if (File.Exists(Directory))
            {
                _usersFile = File.OpenRead(Directory);
                UsersFile userFile = await JsonSerializer.DeserializeAsync<UsersFile>(_usersFile);
                Users = userFile.Users;
                Player = Users.Find(user => user.Username == userFile.LastUser);
            }
            else
            {
                _usersFile = File.Create(Directory);
                Users = new List<User>();
                Player = null;
            }

            _usersFile.Close();
        }

        /// <summary>
        /// <inheritdoc cref="IMenuController.UpdateUsers"/>
        /// </summary>
        public void UpdateUsers()
        {
            UsersFile usersFile = new UsersFile
            {
                Users = Users,
                LastUser = Player?.Username
            };
            string jsonString = JsonSerializer.Serialize(usersFile);
            File.WriteAllText(Directory, jsonString);
        }

        /// <summary>
        /// <inheritdoc cref="IMenuController.CreateUser"/>
        /// </summary>
        public User CreateUser(string username)
        {
            User user = new User(username);
            Users.Add(user);
            UpdateUsers();
            return user;
        }

        /// <summary>
        /// <inheritdoc cref="IMenuController.LoadPlayer"/>
        /// </summary>
        public void LoadPlayer()
        {
            Console.WriteLine(Player?.ToString());
        }
    }
}