using System;

namespace api_chatroom.Models {
    public class Message {
        public User user { get; set; }
        public int status { get; set; }
        public string message { get; set; }
        public DateTime date { get; set; }
    }
}
