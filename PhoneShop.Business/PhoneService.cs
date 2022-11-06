using PhoneShop.Domain;
using PhoneShop.Domain.Interfaces;

namespace PhoneShop.Business;

public class PhoneService : IPhoneService
{
    private readonly List<Phone> _phones = new()
    {
        new Phone { Id = 3, Brand = "Apple", Type = "IPhone 11" },
        new Phone { Id = 1, Brand = "Huawei", Type = "SpyPhone 1984" },
        new Phone { Id = 4, Brand = "Google", Type = "Pixel 8" },
        new Phone { Id = 2, Brand = "Samsung", Type = "Galaxy A53" },
    };

    public PhoneService(List<Phone>? phones = null)
    {
        if (phones != null) _phones = phones;
    }

    public IEnumerable<Phone> Get() => _phones.Take(2);

    public Phone GetById(int id) => _phones.First(x => x.Id == id);
}