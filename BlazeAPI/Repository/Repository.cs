using BlazeAPI.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BlazeAPI.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Context
        /// </summary>
        public DbContext Context { get; }

        /// <summary>
        /// Repository
        /// </summary>
        /// <param name="context"></param>
        public Repository(DbContext context)
        {
            Context = context;
        }

        /// <summary>
        /// Used to get data from table by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TEntity Get(Guid id)
        {
            return Context.Set<TEntity>().Find(id);
        }

        /// <summary>
        /// Used to get all records from table
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TEntity> GetAll()
        {
            return Context.Set<TEntity>().ToList();
        }

        /// <summary>
        /// Used to join two tables
        /// </summary>
        /// <param name="Table"></param>
        /// <returns></returns>
        public IEnumerable<TEntity> GetAll(string Table)
        {
            return Context.Set<TEntity>().Include(Table).ToList();
        }

        /// <summary>
        /// Used to join two tables
        /// </summary>
        /// <param name="Table1"></param>
        /// <param name="Table2"></param>
        /// <returns></returns>
        public IEnumerable<TEntity> GetAll(string Table1, string Table2)
        {
            return Context.Set<TEntity>().Include(Table1).Include(Table2).ToList();
        }

        /// <summary>
        /// used to find the records
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().Where(predicate);
        }
        //public IEnumerable<TEntity> GetRelatedEntites(IQueryable<TEntity> source)
        //{
        //    return Context.Set<TEntity>().Include(source);
        //}

        /// <summary>
        /// used to get the single record
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().SingleOrDefault(predicate);
        }

        /// <summary>
        /// update record into table
        /// </summary>
        /// <param name="entity"></param>
        public void Update(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            SaveChanges();
        }

        /// <summary>
        /// insert record into table
        /// </summary>
        /// <param name="entity"></param>
        public void Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
            SaveChanges();
        }

        /// <summary>
        /// insert records into table
        /// </summary>
        /// <param name="entities"></param>
        public void AddRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().AddRange(entities);
            SaveChanges();
        }

        /// <summary>
        /// remove record into table
        /// </summary>
        /// <param name="entity"></param>
        public void Remove(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
            SaveChanges();
        }

        /// <summary>
        /// remove records into table
        /// </summary>
        /// <param name="entities"></param>
        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().RemoveRange(entities);
            SaveChanges();
        }

        /// <summary>
        /// Save Changes
        /// </summary>
        public void SaveChanges()
        {
            Context.SaveChanges();
        }

        /// <summary>
        /// insert record into table async
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task AddAsync(TEntity entity)
        {
            await Context.Set<TEntity>().AddAsync(entity);
            await SaveChangesAsync();
        }

        /// <summary>
        /// Save Changes async
        /// </summary>
        /// <returns></returns>
        public async Task SaveChangesAsync()
        {
            await Context.SaveChangesAsync();
        }

        /// <summary>
        /// Update record into table async
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task UpdateAsync(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            await SaveChangesAsync();
        }
    }

}
