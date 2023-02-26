//verilmis 4reqemli natural ededin palindrom olmasini teyin et
let num = 3223;
let rem;
let rev = 0;
let temp = num;
while (num != 0)
{
    rem = num % 10;
    rev = rev * 10 + rem;
    num = num / 10;
}
num = temp;
if (num == rev)
{
    Console.log("yes");
}
else
{
    Console.log("no");
}