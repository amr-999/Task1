Q1 : Explanation of the Output :

In the given C# code, the :C format specifier is used inside string interpolation. The C stands for 
Currency. It formats the numeric result according to the system's current culture settings. Since the 
culture uses the dollar sign ($) and two decimal places, the result of 10 + 20 becomes $30.00. 

Q2 : Benefit of Using Format Specifiers :

Format specifiers make output more readable and professional. They automatically handle number 
formatting such as currency symbols, decimal places, percentages, and date/time formats without 
extra code. This is especially useful in financial applications and user interfaces. 

Q3 : Another Example (Percentage Specifier) :

double rate = 0.25;

Console.WriteLine($"Rate: {rate:P}");

The P specifier formats the number as a percentage, so 0.25 becomes 25%.

 Output :
 
 Rate: 25.00%

