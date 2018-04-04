namespace SlackAPI
{
  [RequestPath("dialog.open")]
  public class OpenDialogResponse : Response
  {
    public string message_ts;
  }
}
