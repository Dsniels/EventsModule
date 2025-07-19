
namespace events.Notifications;

public class NotificationEvent
{

  public string SenderName { get; set; }
  public string SenderId { get; set; }
  public string SenderImage { get; set; }
  public string Content { get; set; }
  public DateTime Date { get; set; }
  public IList<string> RecipientIds { get; set; }
  public NotificationEvent(string content, string senderName, string senderId, string senderImage, IList<string> recipientIds)
  {
    Content = content;
    SenderName = senderName;
    SenderId = senderId;
    SenderImage = senderImage;
    Date = DateTime.UtcNow;
    RecipientIds = recipientIds;
  }

}
