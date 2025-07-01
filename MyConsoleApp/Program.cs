using System;
using System.Runtime.CompilerServices;

namespace HelloApp{

class Project{

		static void Main()
		{
			string studentName = "Sophia Johnson";
			string course1name = "English 101";
			string course2name = "Algebra 101";
			string course3name = "Biology 101";
			string course4name = "Computer Science I";
			string course5name = "Psychology 101";

			int gradeA = 4;
            int gradeB = 3;

			int course1Credit = 3;
			int course2Credit = 3;
			int course3Credit = 4;
			int course4Credit = 4;
			int course5Credit = 3;

			int course1Grade = gradeA;
			int course2Grade = gradeB;
			int course3Grade = gradeB;
			int course4Grade = gradeB;
			int course5Grade = gradeA;
			//double GPA = (course1Grade + course2Grade + course3Grade + course4Grade + course5Grade) / 5d;
			
			int totalCreditHours = 0;
			totalCreditHours += course1Credit;
			totalCreditHours += course2Credit;
			totalCreditHours += course3Credit;
			totalCreditHours += course4Credit;
			totalCreditHours += course5Credit;
			//totalCreditHours = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;

			int totalGradePoints = 0;
			totalGradePoints += course1Credit * course1Grade;
			totalGradePoints += course2Credit * course2Grade;
			totalGradePoints += course3Credit * course3Grade;
			totalGradePoints += course4Credit * course4Grade;
			totalGradePoints += course5Credit * course5Grade;

			decimal gradePointAverage = (decimal)totalGradePoints / totalCreditHours;

			int leadingDigit =(int) gradePointAverage;
			int firstDigit = (int)(gradePointAverage * 10) / 10;
			int secondDigit = (int) (gradePointAverage * 100 ) % 10;

			System.Console.WriteLine($"Student: {studentName}");
			System.Console.WriteLine("Course\t\t\t\tGrade\tCredit Hours\tGrade Points");
			System.Console.WriteLine($"{course1name}\t\t\t{course1Grade}\t{course1Credit}");
			System.Console.WriteLine($"{course2name}\t\t\t{course2Grade}\t{course2Credit}");
			System.Console.WriteLine($"{course3name}\t\t\t{course3Grade}\t{course3Credit}");
			System.Console.WriteLine($"{course4name}\t\t{course4Grade}\t{course4Credit}");
			System.Console.WriteLine($"{course5name}\t\t\t{course5Grade}\t{course5Credit}");
			//System.Console.WriteLine($"\nFinal GPA:\t\t{GPA}");
			System.Console.WriteLine($"\nFinal GPA:\t\t\t{leadingDigit}.{firstDigit}{secondDigit}");
		}

	}


}

