// Thuan (Trae) Tran ID: 113437456
// MIS 3033 HW 1 Task 2

/*
 Create an application that will keep prompting the user to input all 3 of their exam 
grades (using a For loop).  Calculate the average of their exam scores and output the 
result.  When you display the result, make sure to use a Format Specifier for 
percentages.
 */

int count = 0; //starting count
double sum = 0; // initialized
double userExamGradeInput; //initialized

for (int i = 1 /* 1st */ ; i <= 3 /* 2nd */ ; i = i + 1 /* counter is 4th*/) //starts at 1, loops until 3
{ // loop body 3rd

    Console.WriteLine($"Input exam grade {i}"); // prompt
    
    userExamGradeInput = Convert.ToDouble(Console.ReadLine()); // user input converted to double

    sum = sum + userExamGradeInput; // sums all grades til loop ends
                                    // ex:  sum = 0 + 100
                                    //      sum = 100 + 100
                                    //      sum = 200 + 0
    count++; //count = count + 1
    // counter
    

}

double average = sum/ count;
Console.WriteLine($"{average/100:P2}"); // result of the sum divided the total count = average