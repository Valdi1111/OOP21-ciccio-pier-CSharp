using System.Diagnostics;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tasks;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        private readonly MainMenuController _menuController = new MainMenuController();

        [TestMethod]
        public void TestMethod1()
        {
            File.Delete(_menuController.Directory);
            Assert.IsFalse(File.Exists(_menuController.Directory), "The file already exist");
#pragma warning disable CS4014
            _menuController.LoadUsers();
#pragma warning restore CS4014
            Assert.IsTrue(File.Exists(_menuController.Directory), "The file wasn't created");
            Assert.IsNull(_menuController.Player, "the user isn't initialized null");
            Assert.IsNull(_menuController.Users.Find(user => user.Username == "sho"));
            _menuController.Player = _menuController.CreateUser("sho");
            Assert.AreEqual("sho", _menuController.Player.Username, "the username is not right");
            Assert.IsNotNull(_menuController.Users.Find(user => user.Username == "sho"));
            _menuController.LoadPlayer();
            Debug.Assert(_menuController.Player != null, "_menuController.Player != null");
            Assert.AreEqual(50, _menuController.Player.MusicVolume, "music volume is not initialized correctly");
            Assert.AreEqual(50, _menuController.Player.SoundVolume, "sound volume is not initialized correctly");
            _menuController.Player.MusicVolume = 70;
            _menuController.Player.SoundVolume = 10;
            _menuController.UpdateUsers();
#pragma warning disable CS4014
            _menuController.LoadUsers();
#pragma warning restore CS4014
            Debug.Assert(_menuController.Player != null, "_menuController.Player != null");
            Assert.AreEqual(70, _menuController.Player.MusicVolume, "music volume is not modified correctly");
            Assert.AreEqual(10, _menuController.Player.SoundVolume, "sound volume is not modified correctly");
        }
    }
}