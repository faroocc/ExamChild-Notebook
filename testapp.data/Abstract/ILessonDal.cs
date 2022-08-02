using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testapp.entity.Concrete;

namespace testapp.data.Abstract
{
    public interface ILessonDal: IGenericDal<Lesson>
    {
        
    }
}