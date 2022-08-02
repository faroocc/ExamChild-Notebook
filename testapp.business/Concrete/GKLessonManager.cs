using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testapp.business.Abstract;
using testapp.data.Abstract;
using testapp.entity.Concrete;

namespace testapp.business.Concrete
{
    public class GKLessonManager : IGKLessonService
    {
        IGKLessonDal _gkDal;
        public GKLessonManager(IGKLessonDal gkDal)
        {
            _gkDal=gkDal;
        }

        public void TAdd(GKLesson t)
        {
            _gkDal.Insert(t);
        }

        public void TDelete(GKLesson t)
        {
            throw new NotImplementedException();
        }

        public GKLesson TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<GKLesson> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(GKLesson t)
        {
            throw new NotImplementedException();
        }
    }
}