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
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDAL _testimonialDAL;

        public TestimonialManager(ITestimonialDAL testimonialDAL)
        {
            _testimonialDAL = testimonialDAL;
        }

        public void TDelete(Testimonial entity)
        {
           _testimonialDAL.Delete(entity);
        }

        public List<Testimonial> TGetAll()
        {
            var data = _testimonialDAL.GetAll();
            if (data == null || !data.Any())
            {
                throw new Exception("No Testimonial records found");
            }
            return data;
        }

        public Testimonial TGetById(int id)
        {
           var datum = _testimonialDAL.GetById(id);
            if (datum == null)
            {
                throw new Exception("Testimonial not found");
            }
            return datum;
        }

        public void TInsert(Testimonial entity)
        {
           _testimonialDAL.Insert(entity);

        }

        public void TUpdate(Testimonial entity)
        {
           _testimonialDAL.Update(entity);
        }
    }
}
