using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class InstructorManager : IInstructorService
    {
        IInstructorDal _ınstructorDal;

        public InstructorManager(IInstructorDal ınstructorDal)
        {
            _ınstructorDal = ınstructorDal;
        }

        public void Add(Instructor instructor)
        {
            _ınstructorDal.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            _ınstructorDal.Delete(instructor);
        }

        public Instructor Get(int instructorId)
        {
            return _ınstructorDal.Get(instructorId);
        }

        public List<Instructor> GetAll()
        {
            return _ınstructorDal.GetAll();
        }

        public void Update(Instructor instructor)
        {
            _ınstructorDal.Update(instructor);
        }
    }
}
