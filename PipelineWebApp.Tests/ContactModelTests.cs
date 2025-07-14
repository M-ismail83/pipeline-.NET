using MyFirstWebApp.Pages;
using Xunit;

public class ContactModelTests
{
    [Fact]
    public void OnPost_Sets_Message_Correctly()
    {
        // Arrange
        var model = new ContactModel();
        var testName = "Mahmut";
        var testEmail = "mahmut@example.com";

        // Act
        model.OnPost(testName, testEmail);

        // Assert
        Assert.Equal($"Thank you, {testName}! We have received your email.", model.Message);
    }
}