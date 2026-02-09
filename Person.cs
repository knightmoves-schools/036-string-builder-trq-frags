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
   StringBuilder getFullNameBuilder(){
      StringBuilder sb = new StringBuilder();
      sb.Append(this.firstName);
      sb.Append(" ");
      sb.Append(this.lastName);
      return sb;
   }
   public string getFirstName(){
      return this.firstName;
   }
   public string getLastName(){
      return this.lastName;
   }
}