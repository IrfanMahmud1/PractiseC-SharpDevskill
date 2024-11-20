
using AdoNet_Example;

string connectionstring = "Server=.;Database=CSharpB18Irfan;User Id=csharpirfan;Password=123456;Trust Server Certificate=True";
AdonetUtility adonetUtility = new AdonetUtility(connectionstring);
string query = "insert into Employee (name,dateofbirth,ismarried) values(@name,@dateofbirth,@ismarried)";
Dictionary<string, object> parameter1 = new Dictionary<string, object>();
parameter1.Add("name", "Jui");
parameter1.Add("dateofbirth", "05/12/2003");
parameter1.Add("ismarried", 0);
adonetUtility.RunSql(query,parameter1);

string query1 = "select * from Employee where id < @ID";
Dictionary<string, object> parameter = new Dictionary<string, object>();
parameter.Add("ID", 10);
var result = adonetUtility.GetData(query1,parameter);


foreach (var item in result)
{
    foreach (var i in item)
    {
        Console.Write($"{i.Key} = {i.Value} ");
    }
    Console.WriteLine();
}
