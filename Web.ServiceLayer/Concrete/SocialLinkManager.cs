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
    public class SocialLinkManager : ISocialLinkService
    {
        private readonly ISocialLinkDAL _socialLinkDAL;

        public SocialLinkManager(ISocialLinkDAL socialLinkDAL)
        {
            _socialLinkDAL = socialLinkDAL;
        }

        public void TDelete(SocialLink entity)
        {
           _socialLinkDAL.Delete(entity);
        }

        public List<SocialLink> TGetAll()
        {
            var data=_socialLinkDAL.GetAll();
            if (data == null || !data.Any())
            {
                throw new Exception("No SocialLink records found");
            }
            return data;
        }

        public SocialLink TGetById(int id)
        {
            var datum=_socialLinkDAL.GetById(id);
            if (datum == null)
            {
                throw new Exception("SocialLink not found");
            }
            return datum;
        }

        public void TInsert(SocialLink entity)
        {
           _socialLinkDAL.Insert(entity);
        }

        public void TUpdate(SocialLink entity)
        {
            _socialLinkDAL.Update(entity);
        }
    }
}
