namespace AssessmentProject.Repositories.GenericRepo
{
    public interface IGenericRepo<T> where T:class
    {
        public Task<IEnumerable<T>> GetAll();
        public Task<T> GetById(int id);
        public Task Update(T item);
        public Task Delete(T item);
        public Task Save();
    }
}