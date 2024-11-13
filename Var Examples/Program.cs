var y = "Irfan";
var x = 10;


double Calculate(params int[] num)
{
    return (num[0] + num[1] + num[2]) / 3; 
}

var res = Calculate(2, 3, 4);