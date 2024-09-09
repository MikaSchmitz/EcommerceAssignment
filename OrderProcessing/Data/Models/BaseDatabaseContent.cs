using OrderProcessing.Data.Interfaces;

namespace OrderProcessing.Data.Models
{
    public abstract class BaseDatabaseContent : IDatabaseContent
    {
        /// <summary>
        /// The primary key of the entity
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The UTC date and time on which the entity was created
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Base constructor sets the default and initial values of the base entity
        /// </summary>
        protected BaseDatabaseContent()
        {
            Id = Guid.NewGuid();
            CreatedOn = DateTime.UtcNow;
        }
    }
}
