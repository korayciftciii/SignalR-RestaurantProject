using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.DataAccessLayer.Abstract;
using Web.EntityLayer.Entities;
using Web.ServiceLayer.Abstract;

namespace Web.ServiceLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDAL _aboutDAL;

        public AboutManager(IAboutDAL aboutDAL)
        {
            _aboutDAL = aboutDAL;
        }

        public void TDelete(About entity)
        {
            _aboutDAL.Delete(entity);
        }

        public List<About> TGetAll()
        {
            var data = _aboutDAL.GetAll();
            if (data == null || !data.Any())
            {
                throw new Exception("No About records found");
            }
            return data;
        }

        public About TGetById(int id)
        {
          var datum=_aboutDAL.GetById(id);
            if (datum == null)
            {
                throw new Exception("About not found");
            }
            return datum;
        }

        public void TInsert(About entity)
        {
         _aboutDAL.Insert(entity);
        }

        public void TUpdate(About entity)
        {
           _aboutDAL.Update(entity);
        }
    }
}
