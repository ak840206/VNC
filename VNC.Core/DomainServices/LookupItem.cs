namespace VNC.Core.DomainServices
{
    // TODO(crhodes)
    // SHould this be in DomainServices or Domain?
    public class LookupItem : ILookupItem<int>
    {
        public int Id { get; set; }

        public string DisplayMember { get; set; }
    }
}
