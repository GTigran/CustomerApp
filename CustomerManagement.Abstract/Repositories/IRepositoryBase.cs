namespace CustomerManagement.Core.Abstract.Repositories
{
    public interface IRepositoryBase<TContext>
    {
        TContext DbContext { get; set; }
        
    }
}
