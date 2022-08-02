using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testapp.entity.Concrete;

namespace testapp.business.Abstract
{
    public interface IKpssResultService:IGenericService<KpssResult>
    {
        List<KpssResult> GetListWithAppUser(int id);
        void DeleteFromResult(string userId,int kpssResultId);
    }
}