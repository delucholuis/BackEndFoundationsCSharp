using System;
using BackEndFoundationsCSharp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BackEndFoundationsCSharp.Controllers
{
    [Route("api/Customers")]
    public class CustomersController : Controller
    {
        [HttpGet]
        public Customer Get(){
        Customer customer = new Customer();
        return customer;
        }
        [HttpPost]
        public Customer Post([FromForm] int id, [FromForm] string firstname, [FromForm] string lastname){
            Console.WriteLine($"Id: {id}, FirstName: {firstname}, LastName: {lastname}");
            Customer customer = new Customer()
            {
                Id = id;
                FirstName = firstname;
                LastName = lastname;
            };
            return Customer;
        }
    }
}