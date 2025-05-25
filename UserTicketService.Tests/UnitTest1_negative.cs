namespace UserTicketService.Tests
{
    [TestFixture]
    public class Class2
    {
        [Test]
        public void Subtraction_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Subtraction(300, 10) == 20);
        }
    }
}