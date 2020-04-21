
using System;
using System.Collections.Generic;

namespace addressbook{
  public class Contact{
    public string FirstName  {get; set;}
    public string LastName  {get; set;}
    public string Email  {get; set;}
    public string Address  {get; set;}

    public string FullName {
      get{
      return $"{FirstName}+{LastName}";
      }
    }
    // public Contact (string first, string last, string email, string address){
    //   FirstName = first;
    //   LastName = last;
    //   Email=email;
    //   Address=address;
    // }

  }
}