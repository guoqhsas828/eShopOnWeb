using System;

namespace Microsoft.eShopWeb.ApplicationCore.Entities.OrderAggregate
{
  public class Address // ValueObject
  {
    private Address()
    {
      City = "Summit";
      State = "NJ";
      Country = "US";
      ZipCode = "07901";
      Street = "582 Springfield Ave";
    }

    public String Street { get; set; }

    public String City { get; private set; }

    public String State { get; private set; }

    public String Country { get; private set; }

    public String ZipCode { get; private set; }

    public Address(string street) : this()
    {
      Street = street;
    }
  }
}
