namespace OrderProcessing.Data.Interfaces
{
    /// <summary>
    /// The base class for each database repository
    /// </summary>
    /// <typeparam name="TEntity">
    /// The class which repository will be accessed
    /// </typeparam>
    public interface IRepository<TEntity> where TEntity : IDatabaseContent
    {
        /// <summary>
        /// Gets entity by ID, may return null if none are found
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TEntity?> GetByIdAsync(Guid id);

        /// <summary>
        /// Start building a search query that will execute on ToList()
        /// </summary>
        /// <returns></returns>
        IQueryable<TEntity> QueryAll();

        /// <summary>
        /// Add entity to database
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task AddAsync(TEntity entity);

        /// <summary>
        /// Update entity in database
        /// </summary>
        /// <param name="entity"></param>
        void Update(TEntity entity);

        /// <summary>
        /// Delete entity from database
        /// </summary>
        /// <param name="entity"></param>
        void Delete(TEntity entity);

        /// <summary>
        /// Save changes made to the database
        /// </summary>
        Task SaveAllChangesAsync();
    }
}
