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
  public  class DiscountManager : IDiscountService
    {
        private readonly IDiscountDAL _discountDAL;

        public void TDelete(Discount entity)
        {
           _discountDAL.Delete(entity);
        }

        public List<Discount> TGetAll()
        {
           var data=_discountDAL.GetAll();
            if (data == null || !data.Any())
            {
                throw new Exception("No Discount records found");
            }
            return data;    
        }

        public Discount TGetById(int id)
        {
           var datum=_discountDAL.GetById(id);
            if (datum == null)
            {
                throw new Exception("Discount not found");
            }
            return datum;   
        }

        public void TInsert(Discount entity)
        {
            _discountDAL.Insert(entity);
        }

        public void TUpdate(Discount entity)
        {
           _discountDAL.Update(entity);
        }
    }
}
