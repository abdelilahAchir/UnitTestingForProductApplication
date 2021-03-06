using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Moq;
using ProductApplication;
using ProductApplication.Controller;
using ProductApplication.Models;
using ProductApplication.Repositories;
using Xunit;




namespace ProductApplicationTestProject
{
    public class UnitTest1
    {

        // Product
        // create Product-3 testcases-Indira
        //read Product-3 testcases-Tatjana
        //update Product-3 testcase-Abde
        //delete Product -4 testcase-Indira
        
            //Create Product

        [Fact]
        public void CreateProductSuccessValidation()
        {
                      
          ProductManagement productManagement = new ProductManagement();
          productManagement.CreateProduct();
          ProductRepository productRepository = new ProductRepository();
          var result1 =  productRepository.GetAllProducts();
          Assert.True(result1.Count() == 22,"No of Product count is not matched");
             

        }


        [Fact]
        public void CreateProductFailureValidation()
        {
            ProductManagement productManagement = new ProductManagement();
            productManagement.CreateProduct();
            ProductRepository productRepository = new ProductRepository();
            var result2 = productRepository.GetAllProducts();
            Assert.True(result2.Count() == 21, "No of Product count is not matched");


        }

        [Fact]
       
        public void CreateProductException()
        {
          var productManagement = new ProductManagement();
                     
            Assert.Throws<FileNotFoundException>(() => productManagement.CreateProduct());
            
        }


        [Fact]
        public void DeleteProductSuccessValidation()
        {

        }

        [Fact]
        public void DeleteProductFailureValidation()
        { 
        
        }

        [Fact]
        public void DeleteProductException()
        {

        }














    }

}

