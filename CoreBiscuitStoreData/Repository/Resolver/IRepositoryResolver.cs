using CoreBiscuitStoreData.Repository.Interfaces;

namespace CoreBiscuitStoreData.Repository.Resolver
{
    public interface IRepositoryResolver
    {
        /// <summary>
        /// Gets the concrete implementation of IRepository for the type passed.
        /// </summary>
        /// <typeparam name="T">Entity type to get repository for</typeparam>
        /// <exception cref="NotFoundException">Thrown if no repository is found for type</exception>
        /// <returns>Implemetation of a repository for type T</returns>
        IRepository<T> GetRepository<T>();
    }
}