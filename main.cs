using System;

class Program {
  public static void Main (string[] args) {
//4)	A jornada de trabalho semanal de um funcionário é de 40 horas. O funcionário que trabalhar mais de 40 horas receberá hora extra, cujo cálculo é o valor da hora regular com um acréscimo de 50%. Escreva um algoritmo que leia o número de horas trabalhadas em um mês, o salário por hora e escreva o salário total do funcionário, que deverá ser acrescido das horas extras, caso tenham sido trabalhadas (considere que o mês possua 4 semanas exatas).


Double salario_horas, horas_trabalhadas, horas_extras, salario_horas_extra, salario_extra, salaria_final;
String entrada;  

    
Console.WriteLine("horas trabalhadas mês"); 
entrada = Console.ReadLine();
    horas_trabalhadas = Double.Parse(entrada);

    
Console.WriteLine("Salário por hora de trabalho: "); 
entrada = Console.ReadLine();
    salario_horas = Double.Parse(entrada);

    horas_extras = horas_trabalhadas - 160.0;
    salario_horas_extra = salario_horas * 1.5;

    salario_extra = salario_horas_extra * horas_extras;
    salaria_final = (salario_horas_extra * horas_extras);


 Console.WriteLine ("Salário: " + 160.0*salario_horas);   
 Console.WriteLine ("salario das horas extra" + salario_extra);
 Console.WriteLine ("salario final:" + salaria_final);
    
  }
}