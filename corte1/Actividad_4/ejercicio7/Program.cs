using System;

namespace PUNTO_7
{
    class Program
    {
        static void Main(string[] args)
        {
		    const int Dimens = 12;

		    double[] Final_score = new double[Dimens];
			string[] Names = new string[Dimens];

		    FillArrays(Final_score, Names);

		    string[] answer = ShowData(Final_score);

		    showArrays(Names, Final_score, answer);
	    }

	    public static void FillArrays(double[] Final_score, string[] Names)
	    {
		    for (int i = 0;i < Final_score.Length;i++)
		    {
			    Console.WriteLine("Introduce el nombre del alumno " + (i + 1));
                Names[i] = Console.ReadLine();

			    double score;

			    do
			    {
				    Console.WriteLine("Introduce la nota del alumno " + (i + 1));
                    string text = Console.ReadLine();

				    score = double.Parse(text);
				    Console.WriteLine(score <= 1 || score >= 10);
			    }while (score <= 1 || score >= 10);

			    Final_score[i] = score;
		    }
	    }

	    public static void showArrays(string[] Names, double[] Final_score, string[] answer)
	    {
		    for (int i = 1;i < Names.Length;i++)
		    {
			    Console.Write("El alumno " + Names[i] + " tiene una nota de " + Final_score[i] + ", por lo que su resultado es " + answer[i]);
		    }
	    }

	    public static string[] ShowData(double[] Final_score)
	    {

		    string[] answer = new string[Final_score.Length];
		    for (int i = 1;i < Final_score.Length;i++)
		    {
			    switch ((int)Final_score[i])
			    {
				    case 1:
					    answer[i] = "INEFICIENTE";
					    break;
				    case 2:
					    answer[i] = "ACEPTABLE";
					    break;
				    case 3:
					    answer[i] = "SOBRESALIENTE";
					    break;
				    case 4:
					    answer[i] = "EXCELENTE";
					    break;
			    }
		    }
		    return answer;
	    }
    }
}