namespace OrderProcessing.Data.Interfaces
{
    /// <summary>
    /// Content that can be saved to a database table
    /// </summary>
    public interface IDatabaseContent
    {
        /// <summary>
        /// The unique ID of the entity
        /// </summary>
        public Guid Id { get; set; }
    }
}
