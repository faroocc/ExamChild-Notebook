using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testapp.business.Abstract;
using testapp.data.Abstract;
using testapp.entity.Concrete;

namespace testapp.business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _user;
        public UserManager(IUserDal user)
        {
            _user=user;
        }

        public void TAdd(AppUser t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(AppUser t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(AppUser t)
        {
            throw new NotImplementedException();
        }

        AppUser IGenericService<AppUser>.TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        List<AppUser> IGenericService<AppUser>.TGetList()
        {
            return _user.GetList();
        }
    }
}