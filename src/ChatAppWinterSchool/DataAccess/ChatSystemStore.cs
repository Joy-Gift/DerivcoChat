using System;
using System.Collections.Generic;

namespace ChatAppWinterSchool.DataAccess
{
    public class ChatSystemStore : IChatSystemStore
    {
        /* private const string ChatDatabase = @"Chat.db";
         private LiteDatabase _db;
         private LiteCollection<User> Users;
         */

        //Users
        private User Shailen;
        private User Micaylin;
        private User Sharad;
        private User Thabo;
        private User Jayden;

        // Chat Channels

        private ChatChannel Anime;
        private ChatChannel Games;
        private ChatChannel Comics;
        private ChatChannel Movies;
        private ChatChannel Lobby;


        public ChatSystemStore()
        {
            /*bool existingDb = File.Exists(ChatDatabase);

            if (!existingDb)
            {
                _db = new LiteDatabase(ChatDatabase);
                 Users = _db.GetCollection<User>("Users");

                 Shailen = new User
                {
                    NickName = "Shailen",
                    Password = "shailen31"
                };

                 Micaylin = new User
                {
                    NickName = "Micaylin",
                    Password = "Micaylin14"
                };

                Users.Insert(Shailen);
                Users.Insert(Micaylin);
            }
            */

            List<User> ChatUsers = new List<User>();

            Shailen = new User()
            {
                ID = 1,
                NickName = "Shailen",
                Password = "Shailen31"
            };
            ChatUsers.Add(Shailen);


            Micaylin = new User()
            {
                ID = 2,
                NickName = "Micaylin",
                Password = "Micaylin14"
            };
            ChatUsers.Add(Micaylin);

            Sharad = new User()
            {
                ID = 3,
                NickName = "Sharad",
                Password = "Sharad10"
            };
            ChatUsers.Add(Sharad);

            Thabo = new User()
            {
                ID = 4,
                NickName = "Thabo",
                Password = "Thabo14"
            };
            ChatUsers.Add(Thabo);

            Jayden = new User()
            {
                ID = 3,
                NickName = "Jayden",
                Password = "Jeyden19"
            };
            ChatUsers.Add(Jayden);

            //Chat Rooms 

            List<ChatChannel> ChatChannel = new List<ChatChannel>();

            Lobby = new ChatChannel()
            {
                chatID = 0001,
                chatName = "Lobby",
                Topic = "Join a Channel",
            };
            ChatChannel.Add(Lobby);

            Anime = new ChatChannel()
            {
                chatID = 0002,
                chatName = "#MangaPanda",
                Topic = "Anime - Latest Anime discussions"

            };
            ChatChannel.Add(Anime);

            Games = new ChatChannel()
            {
                chatID = 0003,
                chatName = "#Game-On",
                Topic = "Gaming - Steam Summer sale"

            };
            ChatChannel.Add(Games);

            Movies = new ChatChannel()
            {
                chatID = 0004,
                chatName = "#BlockBusterz",
                Topic = "What we watching today?"
            };
            ChatChannel.Add(Movies);

            Comics = new ChatChannel()
            {

                chatID = 0005,
                chatName = "#Comic-Con",
                Topic = "Maybe about Superheros?"
            };
            ChatChannel.Add(Comics);

        }
        public bool ValidateUser(LoginCredentials credentials)
        {

            if (credentials.NickName.Equals("Shailen"))
            {
                if (credentials.Password.Equals("shailen31"))
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Incorrect password , please try again :) ");
                    return false;
                }
            }



            if (credentials.NickName.Equals("Micaylin"))
            {
                if (credentials.Password.Equals("Micaylin14"))
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Incorrect password , please try again :) ");
                    return false;
                }
            }

            if (credentials.NickName.Equals("Thabo"))
            {
                if (credentials.Password.Equals("Thabo14"))
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Incorrect password , please try again :) ");
                    return false;
                }
            }

            if (credentials.NickName.Equals("Sharad"))
            {
                if (credentials.Password.Equals("Sharad10"))
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Incorrect password , please try again :) ");
                    return false;
                }
            }

            if (credentials.NickName.Equals("Jayden"))
            {
                if (credentials.Password.Equals("Jayden12"))
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Incorrect password , please try again :) ");
                    return false;
                }
            }


            Console.WriteLine("Incorrect User Name , please try again :)");
            return false;

        }



    }


}
