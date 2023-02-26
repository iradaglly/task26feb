let opertor = '+';
let number1 = 35, number2 = 7;
    switch (opertor)
    {
        case '+':
          console.log("Addition of two numbers is: " + (number1 + number2));
            break;
        case '-':
            console.log("Subtraction of two numbers is: " + (number1 - number2));
            break;           
        case '*':
            console.log("Multiplication of two numbers is: " + (number1 * number2));
            break;
        case '/':
            console.log("Division of two numbers is: " + (number1 / number2));
            break;
        default:
            console.log("invalid input");
    }
