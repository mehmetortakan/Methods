// See https://aka.ms/new-console-template for more information


using Methods;

Customer customer1 = new Customer();
Customer customer2 = new Customer();
Customer customer3 = new Customer();
Customer customer4 = new Customer();

customer1.Id = 1;
customer2.Id = 2;
customer3.Id = 3;
customer4.Id = 4;

customer1.Name = "Mehmet";
customer2.Name = "Ahmet";
customer3.Name = "Veli";
customer4.Name = "Hasan";
customer1.LastName = "Ocak";
customer2.LastName = "Şubat";
customer3.LastName = "Mart";
customer4.LastName = "Nisan";

customer1.Country = "Türkiye";
customer2.Country = "Türkiye";
customer3.Country = "USA";
customer4.Country = "Almanya";
customer1.City = "Ankara";
customer2.City = "İstanbul";
customer3.City = "New York";
customer4.City = "Berlin";

CustomerManager customerManager = new CustomerManager();
Console.WriteLine("-----------------EKLEME------------------");
customerManager.Add(customer1);
customerManager.Add(customer2);
Console.WriteLine("-----------------SİLME------------------");
customerManager.Delete(customer3);
customerManager.Delete(customer4);
Console.WriteLine("-----------------GÜNCELLEME------------------");
customerManager.Update(customer2);
customerManager.Update(customer4);
Console.WriteLine("-----------------------------------");

