using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BlazeAPI.IRepository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Used to get data from table by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TEntity Get(Guid id);

        /// <summary>
        /// Used to get all records from table
        /// </summary>
        /// <returns></returns>
        IEnumerable<TEntity> GetAll();

        /// <summary>
        /// Used to join two tables
        /// </summary>
        /// <param name="Table"></param>
        /// <returns></returns>
        IEnumerable<TEntity> GetAll(string Table);

        /// <summary>
        /// used to find the records
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// used to get the single record
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// insert record into table
        /// </summary>
        /// <param name="entity"></param>
        void Add(TEntity entity);

        /// <summary>
        /// insert record into table async
        /// </summary>
        /// <param name="entity"></param>
        Task AddAsync(TEntity entity);

        /// <summary>
        /// insert records into table
        /// </summary>
        /// <param name="entities"></param>
        void AddRange(IEnumerable<TEntity> entities);

        /// <summary>
        /// remove record from table 
        /// </summary>
        /// <param name="entity"></param>
        void Remove(TEntity entity);

        /// <summary>
        /// remove records from table
        /// </summary>
        /// <param name="entities"></param>
        void RemoveRange(IEnumerable<TEntity> entities);

        /// <summary>
        /// used to save the record
        /// </summary>
        void SaveChanges();
        /// <summary>
        /// used to save the record async
        /// </summary>
        Task SaveChangesAsync();

        /// <summary>
        /// update record from table 
        /// </summary>
        /// <param name="entity"></param>
        void Update(TEntity entity);

        /// <summary>
        /// update record from table async
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task UpdateAsync(TEntity entity);
    }
}
