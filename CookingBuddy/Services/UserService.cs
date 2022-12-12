using System;
using CookingBuddy.Views;
using CookingBuddy.Models;
using Newtonsoft.Json;

namespace CookingBuddy.Services
{
	public class UserService {

        public static UserInfoGlobalClass user { get; set; }
        public static List<UserInfoGlobalClass> users { get; set; }

        public async Task<bool> GetUsersAsync()
        {
            using var stream = await FileSystem.OpenAppPackageFileAsync("users.json");
            using var reader = new StreamReader(stream);

            UserService.users = JsonConvert.DeserializeObject<List<UserInfoGlobalClass>>(reader.ReadToEnd());
            return true;
        }

        public UserInfoGlobalClass GetUser(string Email, string Password)
        {
            if (users == null) return null;
            UserService.user = UserService.users.Find(x => x.Email == Email && x.Password == Password);
            Console.WriteLine($"Active User - {UserService.user.Email}");
            return UserService.user;
        }

        public async Task<RegisterView> CreateUserAsync(
            RegisterView paramUser)
        {
            UserInfoGlobalClass userInfoGlobalClass = new UserInfoGlobalClass();
            userInfoGlobalClass.UserName = $"{paramUser.FirstName} {paramUser.LastName}";
            userInfoGlobalClass.Email = paramUser.Email;
            userInfoGlobalClass.Password = paramUser.Password;
            Console.WriteLine($"Success: Email - {paramUser.Email}: Password - {paramUser.Password}");
            using var writer = new StreamWriter("users.json", true);
            Console.WriteLine(JsonConvert.SerializeObject(userInfoGlobalClass));
            await writer.WriteAsync(JsonConvert.SerializeObject(userInfoGlobalClass));
            return paramUser;
        }
    }
}
