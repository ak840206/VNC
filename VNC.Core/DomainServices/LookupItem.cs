namespace VNC.Core.DomainServices
{
    public class LookupItem : ILookupItem<int>
    {
        public int Id { get; set; }

        public string DisplayMember { get; set; }
    }
}
