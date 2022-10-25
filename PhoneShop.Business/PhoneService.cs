using PhoneShop.Domain;
using PhoneShop.Domain.Interfaces;

namespace PhoneShop.Business;

public class PhoneService : IPhoneService
{
    private readonly List<Phone> _phones = new()
    {
        new Phone { Id = 1, Brand = "Apple", Type = "IPhone 11" },
        new Phone { Id = 2, Brand = "Huawei", Type = "SpyPhone 1984" },
    };

    public IEnumerable<Phone> Get() => _phones;

    public Phone GetById(int id) => _phones.First(x => x.Id == id);
}