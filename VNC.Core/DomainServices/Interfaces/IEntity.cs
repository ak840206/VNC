namespace VNC.Core.DomainServices
{
    public interface IEntity<TIdentity>
    {
        TIdentity Id { get; }
    }
}
