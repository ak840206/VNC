namespace VNC.Core.DomainServices
{
    public interface ILookupItem<T>
    {
        T Id { get; set; }

        // TODO(crhodes)
        // Think through name of this property
        // Should it be value?
        // Go look at SMARTS and see if we want to add a type and fields for different types
        // Seems bad now.
        string DisplayMember { get; set; }
    }
}
