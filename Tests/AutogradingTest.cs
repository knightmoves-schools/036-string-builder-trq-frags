namespace Tests;

using knightmoves;
using Xunit;

public class AutogradingTest
{
    [Fact]
    public void Should_Have_A_Method_BuildFullName_That_Takes_No_Parameters_And_Uses_A_StringBuilder_To_Return_A_String_That_Contains_The_FirstName_And_The_LastName(){
      var person = new Person("mary", "smith");

      Assert.Contains("mary", person.BuildFullName());
      Assert.Contains("smith", person.BuildFullName());
    }
}