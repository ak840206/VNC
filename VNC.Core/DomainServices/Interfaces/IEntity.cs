namespace VNC.Core.DomainServices
{
    public interface IEntity<TIdentity>
    {
        /// <summary>Gets the ID of the entity. </summary>
        TIdentity Id { get; }
    }
}
