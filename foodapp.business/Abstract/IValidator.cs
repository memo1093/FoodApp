namespace foodapp.business.Abstract
{
    public interface IValidator<T>
    {
         string ErrorMessage{get; set;}
         bool Validation(T entity);
    }
}