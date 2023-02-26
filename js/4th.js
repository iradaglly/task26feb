let result = 0;
let number = 3123;
if(number<0){
    console.log(false);
}

result = Number(String(number).split('').reverse().join(''));

console.log("Reversed number is : "+result);