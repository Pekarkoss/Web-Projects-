using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _user = new();


        static Repository()
        {
            _user.Add(new UserInfo() { Id = 1 ,Name = "A", Email = "A@gmail.com", Phone = 123, WillAttend = true });
            _user.Add(new UserInfo() { Id = 2 ,Name = "B", Email = "AB@gmail.com", Phone = 123, WillAttend = true });
            _user.Add(new UserInfo() { Id = 3 ,Name = "C", Email = "AC@gmail.com", Phone = 123, WillAttend = true });
            _user.Add(new UserInfo() { Id = 4, Name = "D", Email = "AD@gmail.com", Phone = 123, WillAttend = false });
        }

        public static List<UserInfo> Users
        {
            get
            {
                return _user;
            }
        }
        public static void CreateUser(UserInfo user)
        {
            user.Id = Users.Count() + 1;
            _user.Add(user);
        }
        public static UserInfo? GetById(int id){
            return _user.FirstOrDefault(user => user.Id == id  );
        }
    }
}