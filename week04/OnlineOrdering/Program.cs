using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Javier Prado Este", "La Molina", "Lima", "Perú");
        Address address2 = new Address("Kensington", "Maryland", "Washington D.C.", "USA");
        Address address3 = new Address("Hirao Johsui", "Fukuoka-Shi", "Fukuoka", "Japan");
        Address address4 = new Address("420 W 200 S", "Vernal", "Utah", "USA");

        Customer customer1 = new Customer("Xavier Romero", address1);
        Customer customer2 = new Customer("Neal Faramir", address2);
        Customer customer3 = new Customer("Dunia Puga", address3);
        Customer customer4 = new Customer("Sue Storn", address4);

        Product product1 = new Product("Book of Mormon", "AR20250001", 15, 50);
        Product product2 = new Product("Bible Videos", "AR20250002", 15, 30);
        Product product3 = new Product("Scripture Stories", "AR20250003", 8, 110);
        Product product4 = new Product("Women's Dry Stretch Open Sleeve Chemise", "AR20250004", 3.62, 80);
        Product product5 = new Product("Women's Dry Stretch Natural Waist Knee Length", "AR20250005", 4.17, 120);
        Product product6 = new Product("Men's Dry Stretch Open Sleeve Round Neck", "AR20250006", 4.45, 150);
        Product product7 = new Product("Men's Dry Stretch Support Brief", "AR20250007", 5.01, 200);
        Product product8 = new Product("Women's Light Nylon Full Slip", "AR20250008", 5.01, 60);
        Product product9 = new Product("Women's Light Nylon Half Slip", "AR20250009", 3.34, 80);
        Product product10 = new Product("Hymns", "AR20250010", 5, 50);
        Product product11 = new Product("Temple Recommend Holder (pack of 500)", "AR20250011", 40.66, 4);
        Product product12 = new Product("Name Badge Clip", "AR20250012", 3.46, 30);
        Product product13 = new Product("Clipboard with White Vinyl Folder, Letter Size", "AR20250013", 13, 25);
        Product product14 = new Product("Blank Pocket-Style Name Badge (pack of 2)", "AR20250014", 2.12, 50);
        Product product15 = new Product("Temples of The Church of Jesus Christ of Latter-day Saints", "AR20250015", 1.71, 40);
        Product product16 = new Product("Jesus the Christ", "AR20250016", 17.01, 30);
        Product product17 = new Product("Thumb-indexed Simulated Leather Bible", "AR20250017", 50.11, 30);
        Product product18 = new Product("Thumb-indexed Simulated Leather Triple Combination", "AR20250018", 40.97, 40);
        Product product19 = new Product("Aquamira WaterBasics Redline Water Bottle with Filter", "AR20250019", 48.69, 30);
        Product product20 = new Product("WaterBasics RED Line Extra Filter", "AR20250020", 22.78, 30);
        Product product21 = new Product("Instructions for Issuing Recommends to Enter a Temple", "AR20250021", 2.88, 30);
        Product product22 = new Product("Recommends to Enter a Temple Binder", "AR20250022", 4.73, 20);
        Product product23 = new Product("Tabbed Divider Pages", "AR20250023", 4.44, 25);
        Product product24 = new Product("Patriarchal Blessing Recommend", "AR20250024", 10.48, 20);
        Product product25 = new Product("Adjusting to Missionary Life", "AR20250025", 6.65, 20);
        Product product26 = new Product("Our Search for Happiness", "AR20250026", 14.71, 30);

        Order order1 = new Order(customer1);
        order1.AddProduct(product16);
        order1.AddProduct(product19);
        order1.AddProduct(product20);
        order1.AddProduct(product21);
        order1.AddProduct(product23);
        order1.AddProduct(product22);

        Order order2 = new Order(customer2);
        order2.AddProduct(product24);
        order2.AddProduct(product25);
        order2.AddProduct(product26);

        Order order3 = new Order(customer3);
        order3.AddProduct(product4);
        order3.AddProduct(product1);
        order3.AddProduct(product17);
        order3.AddProduct(product18);
        order3.AddProduct(product13);
        order3.AddProduct(product14);
        order3.AddProduct(product15);
        order3.AddProduct(product10);
        order3.AddProduct(product6);
        order3.AddProduct(product9);

        Order order4 = new Order(customer4);
        order4.AddProduct(product2);
        order4.AddProduct(product3);
        order4.AddProduct(product5);
        order4.AddProduct(product7);
        order4.AddProduct(product8);
        order4.AddProduct(product11);
        order4.AddProduct(product12);
        order4.AddProduct(product19);
        order4.AddProduct(product13);
        order4.AddProduct(product21);
        order4.AddProduct(product22);
        order4.AddProduct(product17);
        order4.AddProduct(product25);

        Console.WriteLine("------------------ Order N°1 ------------------------\n");

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine(order1.CalculateTotalCost());

        Console.WriteLine("------------------ Order N°2 ------------------------\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine(order2.CalculateTotalCost());

        Console.WriteLine("------------------ Order N°3 ------------------------\n");

        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine(order3.CalculateTotalCost());

        Console.WriteLine("------------------ Order N°4 ------------------------\n");

        Console.WriteLine(order4.GetPackingLabel());
        Console.WriteLine(order4.GetShippingLabel());
        Console.WriteLine(order4.CalculateTotalCost());
    }
}