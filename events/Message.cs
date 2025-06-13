using System;

namespace events;

public class Message
{

    public string Sender { get; set; }
    public string Image { get; set; }
    public string Content { get; set; }

    public Message(string content, string image, string sender){
      this.Sender = sender;
      this.Content = content;
      this.Image = image;
    }

}
