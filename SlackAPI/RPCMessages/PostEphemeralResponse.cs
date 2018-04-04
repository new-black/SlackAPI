namespace SlackAPI
{
    [RequestPath("chat.postEphemeral")]
    public class PostEphemeralResponse : Response
    {
        public string message_ts;

    }
}
