namespace Trade.Model
{
    public class LoginResult
    {
        public LoginResultFlags Result { get; set; }
        public string LastAddress { get; set; }
        public string LastTime { get; set; }
    }

    public enum LoginResultFlags
    {
        Success,
        NullUser,
        ErrorName,
        ErrorPWD,
        ErrorCode,
        ErrorNet,
        ErrorService
    }
}