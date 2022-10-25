using PhoneShop.Domain;

namespace PhoneShop.Business.Tests.PhoneServiceTests;

public class GetById : Base
{

    // gets the phone if it exists
    [Fact]
    private void Returns_the_phone_if_it_exists()
    {
        Phone phone = PhoneService.GetById(2)!;
        Assert.Equal("Huawei", phone.Brand);
        Assert.Equal("SpyPhone 1984", phone.Type);
    }


    // throws an ArgumentException if the phone does not exist
    [Fact]
    public void Throws_InvalidOperationException_if_phone_does_not_exist()
    {
        Func<Phone> action = () => PhoneService.GetById(-2);
        Assert.Throws<InvalidOperationException>(action);
    }
}
