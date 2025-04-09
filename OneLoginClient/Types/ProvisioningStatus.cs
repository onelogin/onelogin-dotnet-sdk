namespace OneLogin.Types
{
    /// <summary>
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
