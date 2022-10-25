using PhoneShop.Domain;

namespace PhoneShop.Business.Tests.PhoneServiceTests;

public class Get : Base
{
    [Fact]
    public void Should_return_both_phones()
    {
        // act
        IEnumerable<Phone> phones = PhoneService.Get();

        // assert
        Assert.Equal(3, phones.Count());
    }
}