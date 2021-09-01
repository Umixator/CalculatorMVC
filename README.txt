How to use Calculator:

1. Enter a calculation in to the input line by your keyboard.
You can only put 2 arguments in to calculation and do one of operations:
+
-
*
/
Also you can delete your input by pressing "Backspace" on your keyboard.

2. Press "Enter" key on your keyboard to see the result.
Your result will be displayed on the same input line and you can continue make your calculations.



Program structure:

Application is based on monolithic architecture.
Used MVC development patter.
In Models used CalculatorModel class, in Views - Calculator => Index view model,
in Controllers - CalculatorController class.

CalculatorController contains next methods:

ActionResult - returns View;
Calculation - returns calculation between two variables;
TakeArgs - returns result in to user's input.