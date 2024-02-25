using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICourseServcice
    {
        List<Course> GetAll();
        Course Get(int courseId);
        void Add(Course  course);
        void Update(Course course);
        void Delete(Course course);
    }
}
