using LiteDB;
using Microsoft.AspNetCore.Razor.Language;
using System;
using System.IO;

namespace ChatAppWinterSchool.DataAccess
{
    public class ChatSystemStore : IChatSystemStore
    {
        private const string ChatDatabase = @"Chat.db";
        private LiteDatabase _db;
        private LiteCollection<User> Users;
        public ChatSystemStore()
        {
            bool existingDb = File.Exists(ChatDatabase);

            if (!existingDb)
            {
                _db = new LiteDatabase(ChatDatabase);
                 Users = _db.GetCollection<User>("Users");

                var Shailen = new User
                {
                    NickName = "Shailen",
                    Password = "shailen31"
                };

                var Micaylin = new User
                {
                    NickName = "Micaylin",
                    Password = "Micaylin14"
                };

                Users.Insert(Shailen);
                Users.Insert(Micaylin);

            }
            
        }
        public bool ValidateUser(LoginCredentials credentials)
        {
            // if(Users.Exists(credentials.NickName))
            //  return true;
            return true;
        }
    }
}
