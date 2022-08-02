using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testapp.business.Abstract;
using testapp.data.Abstract;
using testapp.entity.Concrete;

namespace testapp.business.Concrete
{
    public class KpssResultManager : IKpssResultService
    {
        IKpssResultDal _kpssDal;
        public KpssResultManager(IKpssResultDal kpssDal)
        {
            _kpssDal=kpssDal;
        }

        public void DeleteFromResult(string userId, int kpssResultId)
        {
            throw new NotImplementedException();
        }

        public List<KpssResult> GetListWithAppUser(int id)
        {
           return _kpssDal.GetByFilter(x=>x.AppUserId ==id);
        }

        public void TAdd(KpssResult t)
        {
            _kpssDal.Insert(t);
        }

        public void TDelete(KpssResult t)
        {
            _kpssDal.Delete(t);
        }

        public KpssResult TGetByID(int id)
        {
            return _kpssDal.GetByID(id);
        }

        public List<KpssResult> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(KpssResult t)
        {
            throw new NotImplementedException();
        }
    }
}