using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testapp.business.Abstract;
using testapp.data.Abstract;
using testapp.entity.Concrete;

namespace testapp.business.Concrete
{
    public class LessonManager : ILessonService
    {
        ILessonDal _lessonDal;
        public LessonManager(ILessonDal lessonDal)
        {
            _lessonDal=lessonDal;
        }

        public void TAdd(Lesson t)
        {
            _lessonDal.Insert(t);
        }

        public void TDelete(Lesson t)
        {
            throw new NotImplementedException();
        }

        public Lesson TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Lesson> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Lesson t)
        {
            throw new NotImplementedException();
        }
    }
}