namespace IINVT.Interfaces
{
    public interface IGeneric<T> where T : class
    {
        public IEnumerable<T> GetAll();

        public T GetById(int id);

        public void Add(T entity);

        public void Update(T entity);

        public void Delete(T entity);
    }
}
