//Patrick McKee
//May 26, 2022
//Classes Practice Assignment

// See https://aka.ms/new-console-template for more information
using Week_8_class_practice_assignment;

Console.WriteLine("Hello, Professor Huitsing!");

Person person = new Person();
person.FirstName = "Patrick";
person.LastName = "McKee";
person.Email = "patrickmckee52@gmail.com";
person.Job = "Executive Customer Relations Specialist at Amazon Web Services.";
person.DisplayName();
person.DisplayEmail();
person.DisplayJob();

var person2 = new Person();
var person3 = new Person();

person2.FirstName = "Eric";
person2.LastName = "Gintz";
person2.Email = "idk101@madeupemail.net";
person2.Job = "Private Pricing Contracts Specialist at Amazon Web Services.";
person2.DisplayName();
person2.DisplayEmail();
person2.DisplayJob();

person3.FirstName = "Renly";
person3.LastName = "Barkratheon";
person3.Email = "spoiled_husky_puppy@madeupemail.net";
person3.Job = "The Reason My Dads Keep Their Jobs at home";
person3.DisplayName();
person3.DisplayEmail();
person3.DisplayJob();

Console.WriteLine("");