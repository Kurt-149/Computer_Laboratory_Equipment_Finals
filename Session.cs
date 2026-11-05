namespace Computer_Laboratory_Equipment
{
    /// <summary>Holds who is currently logged in so every form can show/log it.</summary>
    internal static class Session
    {
        public static string Username { get; set; } = "";
        public static string DisplayName { get; set; } = "";
    }
}