using Business.Concrete;
using Entities.Concrete;


Person person1 = new Person();
person1.FirstName = "İsim1";
person1.LastName = "Soyisim1";
person1.DateOfBirthYear = 1995;
person1.NationalIdentity = 123;

Person person2 = new Person();
person1.FirstName = "İsim2";
person1.LastName = "Soyisim2";
person1.DateOfBirthYear = 1995;
person1.NationalIdentity = 123;



PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);
