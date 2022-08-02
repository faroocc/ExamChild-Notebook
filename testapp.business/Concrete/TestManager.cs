using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testapp.business.Abstract;
using testapp.data.Abstract;
using testapp.entity.Concrete;

namespace testapp.business.Concrete
{
    public class TestManager : ITestService
    {
        ITestDal _testDal;
        public TestManager(ITestDal testDal)
        {
            _testDal=testDal;
        }
        public void TAdd(Test t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Test t)
        {
            throw new NotImplementedException();
        }

        public Test TGetByID(int id)
        {
            return _testDal.GetByID(id);
        }

        public List<Test> TGetList()
        {
            return _testDal.GetList();
        }

        public void TUpdate(Test t)
        {
            throw new NotImplementedException();
        }
    }
}