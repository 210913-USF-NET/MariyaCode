using System.Collections.Generic;
using Models;

namespace StoreBL
{
    public interface IBL
    {
        // List<Customer> GetAllCustomers();
        Customer AddCustomer(Customer newCustomer);
        List<Customer> FindOneCustomer(string qryString);
         List<Inventory> GetInventoryByStoreID(Customer newCustomer);
        List<StoreFront> GetStoreFronts();
        List<Product> ProductsList();
        StoreFront GetMyStore(Customer cust);
        Product GetProduct(int input);
        Order AddNewOrder(Order newOrd);
        void AddLineItems(List <LineItem> items);
        void InventorToUpdate(List<Models.Inventory> items);
        List<Order> ListOfOrdersByCust(Customer cust);
        // Inventory UpdateStoreInventory(Inventory newInventory);
        // LineItem AddLineItem(LineItem newItem);
        // List<LineItem> GetAllLineItems(int input);
        // Order AddOrder(Order newOrder);
        // List<Order> GetAllOrders();

    }
}