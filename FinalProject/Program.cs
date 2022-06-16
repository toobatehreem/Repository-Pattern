using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.Model;
using FinalProject.Repository;
namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            /* IGenericRespository<Customer> customerRepository;
             customerRepository = new CustomerRepository();
             foreach (Customer i in customerRepository.Get())

             {
                 Console.WriteLine("ID: " + i.ID + " Name: " +  i.CustomerName + " Address: " + i.Address);
             }
             Console.WriteLine("\n\nDeleting a Customer");
             var del = customerRepository.Delete(1);
             if (del == true)
             {
                 Console.WriteLine("Customer deleted");
             }
             else
             {
                 Console.WriteLine("Can't delete this customer");
             }
             Console.WriteLine("The Customer List now look like this\n");
             foreach (Customer i in customerRepository.Get())

             {
                 Console.WriteLine("ID: " + i.ID + " Name: " + i.CustomerName + " Address: " + i.Address);
             }
             Console.WriteLine("\n\nUpdating a Customer");
             var updating = customerRepository.Update(2, new Customer { ID = 2, CustomerName = "Yahya", Address = "Lahore" });
             if (updating == true)
             {
                 Console.WriteLine("Customer updated");
             }
             else
             {
                 Console.WriteLine("Can't update this customer");
             }
             Console.WriteLine("The Customer List now look like this\n");
             foreach (Customer i in customerRepository.Get())

             {
                 Console.WriteLine("ID: " + i.ID + " Name: " + i.CustomerName + " Address: " + i.Address);

             }
             Console.WriteLine("\n\nAdding a Customer");
             var inserting = customerRepository.Insert(new Customer { ID = 3, CustomerName = "Abid", Address = "Turkey" });
             if (inserting == true)
             {
                 Console.WriteLine("Customer inserted");
             }
             else
             {
                 Console.WriteLine("Can't insert this customer");
             }
             Console.WriteLine("The Customer List now look like this\n");
             foreach (Customer i in customerRepository.Get())

             {
                 Console.WriteLine("ID: " + i.ID + " Name: " + i.CustomerName + " Address: " + i.Address);
             }



             Console.WriteLine("\n\nThe product types are as follows\n");

             IGenericRespository<ProductType> productTypeRepository;
             productTypeRepository = new ProductTypeRepository();
             foreach(ProductType i in productTypeRepository.Get())
             {
                 Console.WriteLine("ID: " + i.ID + " Product Type: " + i.Product_Type);
             }


             Console.WriteLine("\n\nThe products are as follows\n");
             IGenericRespository<Products> productsRepository;
             productsRepository = new ProductsRepository();
             foreach(Products i in productsRepository.Get())
             {
                 Console.WriteLine("ID: " + i.ID + " Product Name: " + i.ProductName + " Product Type " + productTypeRepository.Get()[i.Product_Type_ID - 1].Product_Type + " Price: " + i.Product_Price);
             }


             Console.WriteLine("\n\nThe orders are as follows\n");
             IGenericRespository<Orders> ordersRepository;
             ordersRepository = new OrdersRepository();
             foreach(Orders i in ordersRepository.Get())
             {
                 Console.WriteLine("ID: " + i.ID + " Customer Name: " + customerRepository.Get()[i.CustomerID - 1].CustomerName + " Date Time: " + i.DateTime);
             }

             Console.WriteLine("\n\nThe ordered items are as follows\n");
             IGenericRespository<OrderItems> orderItemsRepository;
             orderItemsRepository = new OrderItemsRepository();
             foreach (OrderItems i in orderItemsRepository.Get())
             {
                 Console.WriteLine("ID: " + i.ID + " OrderId: " + i.OrderID + " Product Name: " + productsRepository.Get()[i.ProductID - 1].ProductName + " Quantity: " + i.Quantity);
             }


             Console.WriteLine("\t\t\tRegistered Libraries");
             GenericRepository<Customer> customers = new CustomerRepository();
             foreach (Customer customer in customers.Get())
             {
                 Console.WriteLine("Library ID: " + customer.ID + "Name: " + customer.CustomerName + "Members: ");

             }*/

            /*  List<Customer> c = new List<Customer>();
              Customer c1 = new Customer(ID : 1,  CustomerName:"Owais", Address:"Karachi");
              Customer c2 = new Customer(2, "Hassan", "Lahore");
              Customer c3 = new Customer(3, "Fayaz", "Karachi");
              CustomerRepository repository = new CustomerRepository(c);
              c.Add(c1);
              c.Add(c2);
              c.Add(c3);
              repository.Insert(c);
               repository.Insert(c1);
               repository.Insert(c2);
               repository.Insert(c3);
              var a = repository.Get();

              foreach (Customer customer in a)
              {
                  Console.WriteLine(customer);
                  Console.WriteLine(customer.ID + "," + customer.CustomerName + "," + customer.Address );
              }*/


            List<Customer> c = new List<Customer>();
            c.Add(new Customer(1, "Tooba", "Karachi"));
            c.Add(new Customer(2, "Fasiha", "Karachi"));
            c.Add(new Customer(3, "Yahya", "Karachi"));

            CustomerRepository customerRepository = new CustomerRepository();
            customerRepository.Insert(c);
            List<Customer> a = customerRepository.Get();
            foreach (Customer customer in a)
            {
                Console.WriteLine(customer.ID + " " + customer.CustomerName + "  " + customer.Address);


            }

            List<ProductType> pt = new List<ProductType>();
            pt.Add(new ProductType(1, "Kurti"));
            pt.Add(new ProductType(2, "Trousers"));

            ProductTypeRepository productTypeRepository = new ProductTypeRepository();
            productTypeRepository.Insert(pt);
            List<ProductType> b = productTypeRepository.Get();
            foreach (ProductType productType in b)
            {
                Console.WriteLine(productType.ID + " " + productType.Product_Type);
            }


            List<Products> p = new List<Products>();
            p.Add(new Products(1, "Product1", 1, 2500));
            p.Add(new Products(2, "Product2", 2, 3500));
    

            ProductsRepository productRepository = new ProductsRepository();
            productRepository.Insert(p);
            List<Products> p1 = productRepository.Get();
            foreach (Products products in p1)
            {
                Console.WriteLine(products.ID + " " + products.ProductName + " " + products.Product_Type_ID + " " + products.Product_Price);
                Console.WriteLine(products.ID + " " + products.ProductName + " " + products.Product_Type_ID + " " + products.Product_Price);
            }
            Console.ReadLine();
       
            }

        
            }
        }




