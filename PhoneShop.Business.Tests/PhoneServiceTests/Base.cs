using PhoneShop.Domain;

namespace PhoneShop.Business.Tests.PhoneServiceTests;

public class Base
{
    protected static readonly List<Phone> TestPhones = new()
    {
        new Phone { Id = 1, Brand = "Apple", Type = "iPhone 12" },
        new Phone { Id = 2, Brand = "Google", Type = "Pixel 7" },
        new Phone { Id = 3, Brand = "Apple", Type = "iPhone 13" },
    };

    protected PhoneService PhoneService = new(TestPhones);
}