using AssessmentProject.Data;
using AssessmentProject.Models;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.EntityFrameworkCore;

namespace AssessmentProject.Repositories.GenericRepo
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        private readonly AppDbContext _dbSet;
        public GenericRepo(AppDbContext dbSet)
        {
            _dbSet = dbSet;
        }
        public async Task<IEnumerable<T>> GetAll()
        {
            
            return await _dbSet.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _dbSet.Set<T>().FindAsync(id);
        }

        public async Task Delete(T item)
        {
            _dbSet.Set<T>().Remove(item);
        }

        public async Task Save()
        {
           await _dbSet.SaveChangesAsync();
        }

        public async Task Update(T item)
        {
            _dbSet.Set<T>().Update(item);
        }
    }
}
