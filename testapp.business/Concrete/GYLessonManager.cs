using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testapp.business.Abstract;
using testapp.data.Abstract;
using testapp.entity.Concrete;

namespace testapp.business.Concrete
{
    public class GYLessonManager : IGYLessonService
    {
        IGYLessonDal _gyDal;
        public GYLessonManager(IGYLessonDal gyDal)
        {
            _gyDal=gyDal;
        }

        public void TAdd(GYLesson t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(GYLesson t)
        {
            throw new NotImplementedException();
        }

        public GYLesson TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<GYLesson> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(GYLesson t)
        {
            throw new NotImplementedException();
        }
    }
}