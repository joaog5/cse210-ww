using System;

class Program
{
    static void Main(string[] args)
    {
        // Endereços
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");

        // Clientes
        Customer customer1 = new Customer("Alice Johnson", address1);
        Customer customer2 = new Customer("Bob Smith", address2);

        // Produtos
        Product product1 = new Product("Laptop", "P001", 1200.0, 1);
        Product product2 = new Product("Mouse", "P002", 25.0, 2);
        Product product3 = new Product("Keyboard", "P003", 45.0, 1);
        Product product4 = new Product("Monitor", "P004", 300.0, 2);

        // Pedido 1
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        // Pedido 2
        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Exibir informações
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}\n");
    }
}