using System.Text;

namespace knightmoves;

public class Person {
   private string firstName;
   private string lastName;

   public Person(string firstName, string lastName){
      this.firstName = firstName;
      this.lastName = lastName;
   }
   string getFullName(){
      return this.firstName + " " + this.lastName;
   }
   public string BuildFullName(){
      StringBuilder sb = new StringBuilder();
      sb.Append(this.firstName);
      sb.Append(" ");
      sb.Append(this.lastName);
      return sb.ToString();
   }
   public string getFirstName(){
      return this.firstName;
   }
   public string getLastName(){
      return this.lastName;
   }
}