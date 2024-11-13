
using EnumTypeExamples;

var name = AccountType.Admin;
Console.WriteLine(name + " " + (int)name);

User user = new User();
user.Name = "Irfan";
user.Password = "hello";
user._AccountType = AccountType.VIP;

int x = (int)user._AccountType;
Console.WriteLine(x);

AccountType accountType = (AccountType)x;
Console.WriteLine(accountType.ToString());

var dateTime = new DateTime(2024, 10, 17, 3, 55, 20, 05);
var startDate = DateTime.Now;
var formattedStartDate = startDate.AddDays(60);
Console.WriteLine(dateTime.ToLongDateString());