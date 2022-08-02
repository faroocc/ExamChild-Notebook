using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testapp.data.Abstract;
using testapp.data.Concrete;
using testapp.data.Repository;
using testapp.entity.Concrete;

namespace testapp.data.EntityFrameCore
{
    public class EfKpssResultDal : GenericRepository<KpssResult>, IKpssResultDal
    {
       
    }
}