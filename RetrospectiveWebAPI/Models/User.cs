using static RetrospectiveWebAPI.Models.Enums.Character;

namespace RetrospectiveWebAPI.Models
{
    /// <summary>
    /// This class contains user properties
    /// </summary>
    public class User
    {
        /// <summary>
        /// User ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// User name
        /// </summary>
        public string Name { get; set; } = String.Empty;

        /// <summary>
        /// A character connected to the user
        /// </summary>
        public Characters Character { get; set; }
    }
}
