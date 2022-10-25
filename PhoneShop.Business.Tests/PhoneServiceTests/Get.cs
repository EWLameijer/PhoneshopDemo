using PhoneShop.Domain;

namespace PhoneShop.Business.Tests.PhoneServiceTests;

public class Get : Base
{
    [Fact]
    private void Should_return_both_phones()
    {
        IEnumerable<Phone> phones = PhoneService.Get();

        Assert.Equal(2, phones.Count());
    }
}