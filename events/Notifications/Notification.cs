
namespace events.Notifications;

public class Notification{

  public string Content {get; set;}
  public DateTime Date {get; set;}

  public Notification(string content){
    this.Content = content;
    this.Date = DateTime.UtcNow;
  }

}
