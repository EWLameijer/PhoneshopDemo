namespace PhoneShop.Domain.Interfaces;

public interface IPhoneService
{
    IEnumerable<Phone> Get();

    Phone GetById(int id);
}
