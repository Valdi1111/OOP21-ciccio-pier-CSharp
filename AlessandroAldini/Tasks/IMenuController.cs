using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tasks
{
    /// <summary>
    /// This class is the controller of the users and menu
    /// </summary>
    public interface IMenuController
    {
        /// <summary>
        /// This function is called to load the users from the json file and update their levels if they are missing using
        /// <see cref="User.SetLevelScore"/> called after any update to the users and after the creation of
        /// <see cref="MainMenuController"/> 
        /// </summary>
        Task LoadUsers();

        /// <summary>
        /// This function is called whenever a change in a user is made and updates the json file with the new information
        /// </summary>
        void UpdateUsers();

        /// <summary>
        /// This function creates a new {@link User} using default values and the username if is not found
        /// among the saved users
        /// </summary>
        /// <param name="username"></param>
        /// <returns>The user that was just created</returns>
        User CreateUser(string username);

        /// <summary>
        /// Represents the active player instance
        /// </summary>
        User Player { get; }

        /// <summary>
        /// Represents the list containing all the users loaded from the json file
        /// </summary>
        List<User> Users { get; }

        /// <summary>
        /// This function loads  the players settings
        /// </summary>
        void LoadPlayer();
    }
}