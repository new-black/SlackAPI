using System.Collections.Generic;

namespace SlackAPI
{

  public class DialogSubmission
  {
    public string callback_id;
    public Team team;
    public User user;
    public Channel channel;
    public string action_ts;
    public string token;
    public string response_url;

    public Dictionary<string, string> submission;

  }
  //See: https://api.slack.com/docs/attachments
  public class InteractiveMessage
  {
    public string callback_id;

    public AttachmentAction[] actions;


    public string trigger_id;
    public User user;
    public Channel channel;
    public string response_url;
  }


  public class Dialog
  {
    public string callback_id;

    public string title;
    public string submit_label;
    public DialogElement[] elements;


  }
  public class DialogElement
  {
    public string type;
    public string label;
    public string name;
    public string placeholder;
    public SelectOption[] options;
    public string subtype;
  }
  public class SelectOption
  {
    public string label;
    public string value;
  }
}
