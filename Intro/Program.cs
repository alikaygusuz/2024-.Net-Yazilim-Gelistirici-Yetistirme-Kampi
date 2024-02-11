﻿// See https://aka.ms/new-console-template for more information
using Intro.Business;
using Intro.Entities;

Console.WriteLine("Hello, World!");

string message1 = "Krediler";
int term = 12;
double amount = 100000;

//variables -->camelCase
bool isAuthenticated = true;
Console.WriteLine(message1);

//condition
if (isAuthenticated)
{
    Console.WriteLine("Buton-->Hoşgeldin Engin");
}
else
{
    Console.WriteLine("Buton-->Sisteme giriş yap");
}

string[] loans = { "Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5", "Kredi 6" };//dbden gelecek
                                                                                      //string[] loans2 = new string[6];
                                                                                      //loans2[0] = "Kredi 1";

//start    condition        //increment
for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}



CourseManager courseManager = new();
Course[] courses2 = courseManager.GetAll();
for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}


Console.WriteLine("kod bitti");

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12345678922";
customer1.FirstName = "Ali";
customer1.LastName = "Kaygusuz";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.NationalIdentity = "12345678923";
customer2.FirstName = "Firdevs";
customer2.Id = 2;
customer2.LastName = "Dönmez";
customer2.CustomerNumber = "123457";

CoorporateCustomer customer3 = new CoorporateCustomer();
customer3.Id = 3;
customer3.Name = "Ulimac";
customer3.CustomerNumber = "123458";
customer3.TaxNumber = "1234567890";

CoorporateCustomer customer4 = new CoorporateCustomer();
customer4.Id = 4;
customer4.Name = "Kodcular";
customer4.CustomerNumber = "123459";
customer4.TaxNumber = "1234567891";

BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };
foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}