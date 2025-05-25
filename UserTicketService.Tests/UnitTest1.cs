using Moq;

[TestFixture]
public class TicketServiceTests
{
    [Test]
    public void GetTicketPriceMustReturnExistingPrice()
    {
        var ticketServiceTest = new TicketService();
        //Assert.IsNotNull(ticketServiceTest.GetTicketPrice(1));
        var price = ticketServiceTest.GetTicketPrice(1);
        Assert.That(price >= 0);
    }

    [Test]
    public void GetTicketPriceMustThrowException()
    {
        var ticketServiceTest = new TicketService();
        Assert.Throws<TicketNotFoundException>(() => ticketServiceTest.GetTicketPrice(100));
    }

}
[TestFixture]
public class TicketPriceTests
{
    [Test]
    public void TicketPriceMustReturnNotNullableTicket()
    {
        var mockTicketService = new Mock<ITicketService>();
        mockTicketService.Setup(p => p.GetTicketPrice(1)).Returns(100);
        mockTicketService.Setup(p => p.GetTicketPrice(2)).Returns(500);
        mockTicketService.Setup(p => p.GetTicketPrice(3)).Returns(7800);

        var ticketPriceTest = new TicketPrice(mockTicketService.Object);
        Assert.That(ticketPriceTest.MakeTicketPrice(3) == 7800);
    }
}