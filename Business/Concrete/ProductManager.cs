using Business.Abstract;
using Entities.Concrete;
using DataAccess.Concrete.InMemory;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        ////Bu yeterli değil
        //InMemoryProductDal ınMemoryProductDal;

        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public InMemoryProductDal InMemoryProductDal { get; }

        public List<Product> GetAll()
        {
            //İş Kodları
            //Yetkisi var mı?

            return _productDal.GetAll();

        }
    }
}
