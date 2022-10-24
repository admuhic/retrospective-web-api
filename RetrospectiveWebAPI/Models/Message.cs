namespace RetrospectiveWebAPI.Models
{
    /// <summary>
    /// This class contains user properties
    /// </summary>
    public class Message
    {
        /// <summary>
        /// Text message
        /// </summary>
        public string Text { get; set; } = String.Empty;

        /// <summary>
        /// User object
        /// </summary>
        public User User { get; set; }
    }
}
