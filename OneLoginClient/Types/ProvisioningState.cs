namespace OneLogin.Types
{
    /// <summary>
    /// Indicates whether a username and password has been stored on the login for the app and user.
    /// </summary>
    public enum ProvisioningState
    {
        Unknown=0,
        Provisioning=1,
        Modifying=2,
        Deleting=3,
        ProvisioningPendingApproval=4,
        DeletingPendingApprova=5,
        ModifyingPendingApproval=6,
        Linkin=7,
        Provisioned=8,
        Deleted=9,
        ModifyingFailed=10,
        ProvisioningFailed=11,
        DeletingFailed=12,
        LinkingFailed=13,
        Disabled=14,
        Nonexistent=15,
        ModifyingPendingApprovalThenDisabled=16
    }
}
