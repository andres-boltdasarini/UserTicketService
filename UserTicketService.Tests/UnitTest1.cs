using Moq;

[TestFixture]
public class UserRepositoryTests
{
    [Test]
    public void FindAllMustReturnCorrectValue()
    {
        var list = new List<User> {
      new User()
      {
        Name = "�����"
      },
      new User()
      {
        Name = "����"
      },
      new User()
      {
        Name = "�������"
      },
    };
        Mock<IUserRepository> mock = new Mock<IUserRepository>();

        mock.Setup(v => v.FindAll()).Returns(list);

        Assert.That(mock.Object.FindAll().Any(user => user.Name == "�����"));
        Assert.That(mock.Object.FindAll().Any(user => user.Name == "����"));
        Assert.That(mock.Object.FindAll().Any(user => user.Name == "�������"));
    }
}