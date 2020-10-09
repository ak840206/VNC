namespace VNC.Core.DomainServices
{
    public interface IOptimistic
    {
        byte[] RowVersion { get; set; }
    }
}
