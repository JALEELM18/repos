﻿using MVCDemo.Models;
using System.Xml.Linq;

namespace MVCDemo.Services
{
    public class FriendService
    {
        static List<Friend> Friends { get; }
        static int nextId = 4;
        static FriendService()
        {
            Friends = new List<Friend>
                {
                    new Friend { FriendId = 1, FriendName = "Yash", Place="Gujarat" },
                    new Friend { FriendId = 2, FriendName = "Ananya", Place="Bangalore" },
                    new Friend {FriendId = 3, FriendName = "Sabyata", Place="UP" }
                };
        }

        public static List<Friend> GetAll() => Friends;

        public static Friend? Get(int id) => Friends.FirstOrDefault(f => f.FriendId == id);

        public static void Add(Friend friend)
        {
            friend.FriendId = nextId++;
            Friends.Add(friend);
        }

        public static void Delete(int id)
        {
            var friend = Get(id);
            if (friend is null)
                return;

            Friends.Remove(friend);
        }

        public static void Update(Friend friend)
        {
            var index = Friends.FindIndex(f => f.FriendId == friend.FriendId);
            if (index == -1)
                return;

            Friends[index] = friend;
        }

    }
}
