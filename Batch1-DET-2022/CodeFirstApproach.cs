using Batch1_DET_2022.Models;
using Microsoft.EntityFrameworkCore;
//using Batch1_DET_2022.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class CodeFirstApproach
    {
        public static void Main()
        {
            //DeleteNewBook();
            //AddNewBook();
            //UpdateNewBook();
            //AddNewBook2();
            //AddNewBook1();
            //StoredProcedure();
            //AddnewcustomerAndOrder();
           // GetAllCustomersWithOrder_EagerLoading();
            //GetAllCustomersWithOrder_ExplicitLoading();
            Disconnectedarchitecture();
            //AddOrderForCust();
            Console.ReadLine();
        }

        private static void GetAllCustomersWithOrder_EagerLoading()
        {
            //Eager loading means that the related data is loaded 
            //from the database as part of the initial query.
            var ctx = new BookContext();
            try
            {
                var customers = ctx.Customers.Include("Orders");

                //var customers = ctx.Customers.Include(o => o.Orders);                   

                foreach (var customer in customers)
                {
                    Console.WriteLine(customer.Name);
                    Console.WriteLine("----->");


                    foreach (var order in customer.Orders)
                    {
                        Console.WriteLine(order.Amount.ToString() + " " + order.Order_ID);
                    }
                    Console.WriteLine("-----");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        private static void GetAllCustomersWithOrder_ExplicitLoading()
        {
            //Explicit loading means that the related data is
            //explicitly loaded from the database at a later time.
            //Needs MARS to be set to TRUE in connection string
            var ctx = new BookContext();
            try
            {
                var customers = ctx.Customers;

                foreach (var customer in customers)
                {
                    Console.WriteLine(customer.Name);
                    Console.WriteLine("----->");

                    ctx.Entry(customer).Collection(o => o.Orders).Load();

                    foreach (var order in customer.Orders)
                    {
                        Console.WriteLine(order.Amount.ToString() + "  " + order.OrderDate.ToString());

                    }
                    Console.WriteLine("-----");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void Disconnectedarchitecture()
        {
            var ctx = new BookContext();

            var customer = ctx.Customers.Where(c => c.ID == 1).SingleOrDefault();

            ctx.Dispose();

            UpdateCustomerName(customer);

        }
        private static void UpdateCustomerName(Customer customer)
        {
            var ctx = new BookContext();
            customer.Name = "Mike";
            Console.WriteLine(ctx.Entry(customer).State.ToString());
            //ctx.Update<Customer>(customer);
            //OR
            ctx.Update(customer);
            //OR
            //ctx.Customers.Update(customer);
            //OR

            //  ctx.Attach(customer).State = EntityState.Modified;
            ctx.SaveChanges();
            Console.WriteLine("customer name is updated via disconnected mode");

        }


        private static void AddOrderForCust()
        {
            var ctx = new BookContext();

            var customer = ctx.Customers.Where(c => c.ID == 1).SingleOrDefault();
            Order ord = new Order();
            ord.Order_ID = 100000;
            ord.Amount = 9850;
            ord.OrderDate = DateTime.Now;
            ord.cust = customer;
            try
            {
                ctx.Orders.Add(ord);
                ctx.SaveChanges();
                Console.WriteLine("New Order Added");



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }



        }

        private static void AddnewcustomerAndOrder()
        {
            var ctx = new BookContext();

            Customer customer = new Customer();
            customer.ID = 1;
            customer.Name = "Sheela";
            customer.Age = 35;

            Order ord = new Order();
            ord.Order_ID = 100;
            ord.Amount = 2000;
            ord.OrderDate = DateTime.Now;

            //list<Order> myorders = new List<Order>();
            //myorders.Add(ord);
            //customer.Orders=myorders;

            ord.cust = customer;
            try
            {
                // ctx.Customers.Add(customer); //orders
                ctx.Orders.Add(ord);
                ctx.SaveChanges();
                Console.WriteLine("Customer and order is created");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
            }
        }
        #region "SELECT"

        private static void StoredProcedure()
        {
            var ctx = new BookContext();
            var book = ctx.Books.FromSqlRaw("BookName").ToList();

            foreach (var e in book)
            {
                Console.WriteLine(e.BookName);
            }
        }


        #endregion

        #region "UPDATE"
        private static void UpdateNewBook()
        {
            var ctx = new BookContext();
            var Books = ctx.Books.Where(b => b.BookID == 3).SingleOrDefault();
            try
            {

                Books.BookName = "Asp.Net";
                ctx.Update(Books);
                ctx.SaveChanges();
                Console.WriteLine("One Book Updated Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }
        #endregion

        #region "DELETE"
        private static void DeleteNewBook()
        {
            var ctx = new BookContext();
            var Books = ctx.Books.Where(b => b.BookID == 3).SingleOrDefault();
            try
            {
                ctx.Remove(Books);
                ctx.SaveChanges();
                Console.WriteLine("One Book Deleted Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }

        #endregion

        #region "BOOK2"
        private static void AddNewBook2()
        {
            var ctx = new BookContext();
            Book book = new Book();
            book.BookID = 3;
            book.BookName = "C++";
            book.author = "Rajesh";
            book.price = 300;

            try
            {
                ctx.Books.Add(book);
                ctx.SaveChanges();
                Console.WriteLine("New Book 2 Added Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }
        #endregion

        #region "BOOK1"
        private static void AddNewBook1()
        {
            var ctx = new BookContext();
            Book book = new Book();
            book.BookID = 2;
            book.BookName = "Programming";
            book.author = "Wilson";
            book.price = 200;

            try
            {
                ctx.Books.Add(book);
                ctx.SaveChanges();
                Console.WriteLine("New Book 1 Added Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }
        #endregion
        private static void AddNewBook()
        {
            var ctx = new BookContext();
            Book book = new Book();
            book.BookID = 1;
            book.BookName = "EF Core";
            book.author = "Jack";
            book.price = 100;

            try
            {
                ctx.Books.Add(book);
                ctx.SaveChanges();
                Console.WriteLine("New Book Added Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }

        private static object Add(Book book)
        {
            throw new NotImplementedException();
        }
    }
}