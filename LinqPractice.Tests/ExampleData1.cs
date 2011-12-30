using System;
using System.Collections.Generic;
using System.Linq;
using LinqPractice.Domain;

namespace LinqPractice.Tests
{
    public class ExampleData1 
    {
        public Client HejlsbergClient { get; private set; }
        public Client StallmanClient { get; private set; }
        public Client IcazaClient { get; private set; }
        public Client RossumClient { get; private set; }
        public Client HillClient { get; private set; }
        public Client AfriendClient { get; private set; }
        public Product LemonProduct { get; private set; }
        public Product OrangeProduct { get; private set; }
        public Product AppleProduct { get; private set; }
        public Product BananaProduct { get; private set; }
        public IEnumerable<Invoice> Invoices { get; private set; }
        public IEnumerable<Client> Clients { get; private set; }
        public IEnumerable<Product> Products { get; private set; }

        public Invoice GetInvoice(int number)
        {
            return Invoices.FirstOrDefault(x => x.Number == number);
        }
       
        public ExampleData1()
        {
            InitializeClients();
            InitializeProducts();
            InitializeInvoices();
        }

        private void InitializeInvoices()
        {
            Invoices = new[]
                           {
                               new Invoice()
                                   {
                                       Number = 1,
                                       Client = StallmanClient,
                                       Date = DateTime.Parse("2011-12-01"),
                                       Items = new[]
                                                   {
                                                       new InvoiceItem() { Product = OrangeProduct, Quantity = 3, Total = 6 },
                                                       new InvoiceItem() { Product = LemonProduct, Quantity = 1, Total = 2.5M },
                                                       new InvoiceItem() { Product = BananaProduct, Quantity = 2, Total = 5.2M },
                                                   }
                                   },
                               new Invoice()
                                   {
                                       Number = 2,
                                       Client = RossumClient,
                                       Date = DateTime.Parse("2011-12-02"),
                                       Items = new[]
                                                   {
                                                       new InvoiceItem() { Product = OrangeProduct, Quantity = 15, Total = 28 }
                                                   }
                                   },
                               new Invoice()
                                   {
                                       Number = 3,
                                       Client = StallmanClient,
                                       Date = DateTime.Parse("2011-12-03"),
                                       Items = new[]
                                                   {
                                                       new InvoiceItem() { Product = OrangeProduct, Quantity = 2, Total = 4 },
                                                       new InvoiceItem() { Product = LemonProduct, Quantity = 1, Total = 2.5M },
                                                       new InvoiceItem() { Product = BananaProduct, Quantity = 2, Total = 5.2M },
                                                   }
                                   },
                               new Invoice()
                                   {
                                       Number = 4,
                                       Client = RossumClient,
                                       Date = DateTime.Parse("2011-12-04"),
                                       Items = new[]
                                                   {
                                                       new InvoiceItem() { Product = OrangeProduct, Quantity = 1, Total = 2 },
                                                       new InvoiceItem() { Product = LemonProduct, Quantity = 1, Total = 2.5M },
                                                       new InvoiceItem() { Product = BananaProduct, Quantity = 1, Total = 2.6M },
                                                       new InvoiceItem() { Product = AppleProduct, Quantity = 1, Total = 2.25M },
                                                   }
                                   },
                               new Invoice()
                                   {
                                       Number = 5,
                                       Client = AfriendClient,
                                       Date = DateTime.Parse("2011-12-04"),
                                       Items = new[]
                                                   {
                                                       new InvoiceItem() { Product = OrangeProduct, Quantity = 20, Total = 30 },
                                                       new InvoiceItem() { Product = LemonProduct, Quantity = 20, Total = 40 },
                                                       new InvoiceItem() { Product = BananaProduct, Quantity = 20, Total = 40 },
                                                       new InvoiceItem() { Product = AppleProduct, Quantity = 20, Total = 40 },
                                                   }
                                   },
                            new Invoice()
                                   {
                                       Number = 6,
                                       Client = RossumClient,
                                       Date = DateTime.Parse("2011-12-05"),
                                       Items = new[]
                                                   {
                                                       new InvoiceItem() { Product = OrangeProduct, Quantity = .5M, Total = 1 },
                                                       new InvoiceItem() { Product = LemonProduct, Quantity = .5M, Total = 1.3M },
                                                       new InvoiceItem() { Product = BananaProduct, Quantity = .5M, Total = 1.3M },
                                                       new InvoiceItem() { Product = AppleProduct, Quantity = .5M, Total = 1.2M },
                                                   }
                                   },
                               new Invoice()
                                   {
                                       Number = 7,
                                       Client = IcazaClient,
                                       Date = DateTime.Parse("2011-12-05"),
                                       Items = new[]
                                                   {
                                                       new InvoiceItem() { Product = BananaProduct, Quantity = 2, Total = 5.2M },
                                                   }
                                   },
                               new Invoice()
                                   {
                                       Number = 8,
                                       Client = IcazaClient,
                                       Date = DateTime.Parse("2011-12-06"),
                                       Items = new[]
                                                   {
                                                       new InvoiceItem() { Product = OrangeProduct, Quantity = 2, Total = 4 }
                                                   }
                                   },
                            new Invoice()
                                   {
                                       Number = 9,
                                       Client = RossumClient,
                                       Date = DateTime.Parse("2011-12-06"),
                                       Items = new[]
                                                   {
                                                       new InvoiceItem() { Product = OrangeProduct, Quantity = .5M, Total = 1 },
                                                       new InvoiceItem() { Product = LemonProduct, Quantity = .5M, Total = 1.3M },
                                                       new InvoiceItem() { Product = BananaProduct, Quantity = .5M, Total = 1.3M },
                                                       new InvoiceItem() { Product = AppleProduct, Quantity = .5M, Total = 1.2M },
                                                   }
                                   },
                               new Invoice()
                                   {
                                       Number = 10,
                                       Client = IcazaClient,
                                       Date = DateTime.Parse("2011-12-06"),
                                       Items = new[]
                                                   {
                                                       new InvoiceItem() { Product = LemonProduct, Quantity = 1, Total = 2.5M }
                                                   }
                                   },
                               new Invoice()
                                   {
                                       Number = 11,
                                       Client = HejlsbergClient,
                                       Date = DateTime.Parse("2011-12-07"),
                                       Items = new[]
                                                   {
                                                       new InvoiceItem() { Product = OrangeProduct, Quantity = 1, Total = 2 }
                                                   }
                                   },
                               new Invoice()
                                   {
                                       Number = 12,
                                       Client = HejlsbergClient,
                                       Date = DateTime.Parse("2011-12-07"),
                                       Items = new[]
                                                   {
                                                       new InvoiceItem() { Product = BananaProduct, Quantity = 1, Total = 2.6M },
                                                   }
                                   },
                            new Invoice()
                                   {
                                       Number = 13,
                                       Client = RossumClient,
                                       Date = DateTime.Parse("2011-12-08"),
                                       Items = new[]
                                                   {
                                                       new InvoiceItem() { Product = OrangeProduct, Quantity = .5M, Total = 1 },
                                                       new InvoiceItem() { Product = LemonProduct, Quantity = .5M, Total = 1.3M },
                                                       new InvoiceItem() { Product = BananaProduct, Quantity = .5M, Total = 1.3M },
                                                       new InvoiceItem() { Product = AppleProduct, Quantity = .5M, Total = 1.2M },
                                                   }
                                   },
                            new Invoice()
                                   {
                                       Number = 14,
                                       Client = AfriendClient,
                                       Date = DateTime.Parse("2011-12-08"),
                                       Items = new[]
                                                   {
                                                       new InvoiceItem() { Product = OrangeProduct, Quantity = 10, Total = 15M }
                                                   }
                                   },
                            new Invoice()
                                   {
                                       Number = 15,
                                       Client = IcazaClient,
                                       Date = DateTime.Parse("2011-12-08"),
                                       Items = new[]
                                                   {
                                                       new InvoiceItem() { Product = BananaProduct, Quantity = .5M, Total = 1.5M },
                                                   }
                                   },
                            new Invoice()
                                   {
                                       Number = 16,
                                       Client = HejlsbergClient,
                                       Date = DateTime.Parse("2011-12-09"),
                                       Items = new[]
                                                   {
                                                       new InvoiceItem() { Product = OrangeProduct, Quantity = 3, Total = 6 },
                                                       new InvoiceItem() { Product = LemonProduct, Quantity = 3, Total = 7.5M },
                                                       new InvoiceItem() { Product = AppleProduct, Quantity = 3, Total = 6.5M },
                                                   }
                                   },
                            new Invoice()
                                   {
                                       Number = 17,
                                       Client = IcazaClient,
                                       Date = DateTime.Parse("2011-12-09"),
                                       Items = new[]
                                                   {
                                                       new InvoiceItem() { Product = OrangeProduct, Quantity = 1, Total = 2 },
                                                   }
                                   },
                            new Invoice()
                                   {
                                       Number = 18,
                                       Client = RossumClient,
                                       Date = DateTime.Parse("2011-12-10"),
                                       Items = new[]
                                                   {
                                                       new InvoiceItem() { Product = OrangeProduct, Quantity = .5M, Total = 1 },
                                                       new InvoiceItem() { Product = LemonProduct, Quantity = .5M, Total = 1.3M },
                                                       new InvoiceItem() { Product = BananaProduct, Quantity = .5M, Total = 1.3M },
                                                       new InvoiceItem() { Product = AppleProduct, Quantity = .5M, Total = 1.2M },
                                                   }
                                   },
                           };
        }

        private void InitializeProducts()
        {
            LemonProduct = new Product()
                                {
                                    Id = Guid.NewGuid(),
                                    Description = "Lemon",
                                    SugestedPrice = 2.5M,
                                    CurrentCost = 1.4M,
                                    Tax = .21M
                                };
            OrangeProduct = new Product()
                                 {
                                     Id = Guid.NewGuid(),
                                     Description = "Orange",
                                     SugestedPrice = 2,
                                     CurrentCost = 1.3M,
                                     Tax = .21M
                                 };
            AppleProduct = new Product()
                                {
                                    Id = Guid.NewGuid(),
                                    Description = "Apple",
                                    SugestedPrice = 2.25M,
                                    CurrentCost = 1.6M,
                                    Tax = .1M
                                };
            BananaProduct = new Product()
                                 {
                                     Id = Guid.NewGuid(),
                                     Description = "Banana",
                                     SugestedPrice = 2.6M,
                                     CurrentCost = 1.7M,
                                     Tax = .1M
                                 };
            Products = new[]
                           {
                               LemonProduct,
                               OrangeProduct,
                               AppleProduct,
                               BananaProduct,
                           };
        }

        private void InitializeClients()
        {
            StallmanClient = new Client()
                                  {
                                      Id = Guid.NewGuid(),
                                      FirstName = "Richard",
                                      LatsName = "Stallman",
                                      IsClientSince = DateTime.Parse("2002-01-01")
                                  };
            HejlsbergClient = new Client()
                                   {
                                       Id = Guid.NewGuid(),
                                       FirstName = "Anders",
                                       LatsName = "Hejlsberg",
                                       IsClientSince = DateTime.Parse("2002-02-02")
                                   };
            IcazaClient = new Client()
                               {
                                   Id = Guid.NewGuid(),
                                   FirstName = "Miguel",
                                   LatsName = "de Icaza",
                                   IsClientSince = DateTime.Parse("2003-03-03")
                               };
            RossumClient = new Client()
                                {
                                    Id = Guid.NewGuid(),
                                    FirstName = "Guido",
                                    LatsName = "van Rossum",
                                    IsClientSince = DateTime.Parse("2003-04-04")
                                };
            HillClient = new Client()
                              {
                                  Id = Guid.NewGuid(),
                                  FirstName = "Bill",
                                  LatsName = "Hill",
                                  IsClientSince = DateTime.Parse("2003-05-05")
                              };
            AfriendClient = new Client()
                                {
                                    Id = Guid.NewGuid(),
                                    FirstName = "A.",
                                    LatsName = "Friend",
                                    IsClientSince = DateTime.Parse("2004-06-06")
                                };
            Clients = new[]
                          {
                              StallmanClient,
                              HejlsbergClient,
                              IcazaClient,
                              RossumClient,
                              HillClient,
                              AfriendClient
                          };
        }
    }
}
