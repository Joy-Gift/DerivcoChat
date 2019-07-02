using LiteDB;
using Microsoft.AspNetCore.Razor.Language;
using System;
using System.IO;

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

            User [] ChatUsers = new User[5] ;

            Shailen.ID = 0001;
            Shailen.NickName = "Shailen";
            Shailen.Password = "Shailen31";

            Micaylin.ID = 0002;
            Micaylin.NickName = "Micaylin";
            Micaylin.Password = "Micaylin14";

            Micaylin.ID = 0003;
            Micaylin.NickName = "Thabo";
            Micaylin.Password = "Thabo14";

            Micaylin.ID = 0004;
            Micaylin.NickName = "Sharad";
            Micaylin.Password = "Sharad10";

            Micaylin.ID = 0005;
            Micaylin.NickName = "Jayden";
            Micaylin.Password = "Jayden12";

            ChatUsers[0] = Shailen;
            ChatUsers[1] = Micaylin;
            ChatUsers[2] = Thabo ;
            ChatUsers[3] = Sharad;
            ChatUsers[4] = Jayden;


            //Chat Rooms 

            ChatChannel[] ChatChannels = new ChatChannel[5];

            Lobby.chatID = 0001;
            Lobby.chatName = "Lobby";
            Lobby.Topic = "Join a Channel";
           
            Anime.chatID = 0002;
            Anime.chatName = "#MangaPanda";
            Anime.Topic = "Anime - Latest Anime discussions";

            Games.chatID = 0003;
            Games.chatName = "#Game-On";
            Games.Topic = "Gaming - Steam Summer sale";

            Movies.chatID = 0004;
            Movies.chatName = "#BlockBusterz";
            Movies.Topic = "What we watching today?";

            Comics.chatID = 0005;
            Comics.chatName = "#Comic-Con";
            Comics.Topic = "Maybe about Superheros?";


            ChatChannels[0] = Lobby;
            ChatChannels[1] = Anime;
            ChatChannels[2] = Games;
            ChatChannels[3] = Movies;
            ChatChannels[4] = Comics;

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
