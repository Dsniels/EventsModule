
namespace events.Notifications;

public class NotificationEvent {

  public string Content {get; set;}
  public DateTime Date {get; set;}

  public NotificationEvent(string content){
    this.Content = content;
    this.Date = DateTime.UtcNow;
  }

}
