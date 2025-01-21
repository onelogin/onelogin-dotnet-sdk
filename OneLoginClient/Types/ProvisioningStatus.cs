namespace OneLogin.Types
{
    /// <summary>
    /// Indicates whether a username and password has been stored on the login for the app and user.
    /// </summary>
    public enum ProvisioningStatus
    {
        Enabling=0,
        Disabling=1,
        EnablingPendingApproval=2,
        DisablingPendingApproval=3,
        Enabled=4,
        Disabled=5,
        DisablingFailed=6,
        EnablingFailed=7
    }
}
