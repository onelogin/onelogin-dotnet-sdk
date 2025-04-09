namespace OneLogin.Requests
{
    public class VerifyEnrollmentRequest
    {
        /// <summary>
        /// One-Time-Password (OTP) that was sent to the user based on the chosen factor. OneLogin SMS and OneLogin Email support this OTP code.
        /// </summary>
        [JsonPropertyName("otp")]
        public required long? Otp { get; set; }

    }
}