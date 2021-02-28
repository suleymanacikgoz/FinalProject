using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResults<List<Product>> GetAll();
        IDataResults<List<Product>> GetAllByCategoryId(int id);
        IDataResults<List<Product>> GetByUnitPrice(decimal min, decimal max);
        IDataResults<List<ProductDetailDto>> GetProductDetails();
        IResult Add(Product product);
        IDataResults<Product>GetById(int productId);
        IResult Update(Product product);

    }
}
