using System;
using System.Globalization;

namespace ImpostoCS
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.Write("Renda anual com salário: ");
            double anualWorkRevenue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.Write("Renda anual com prestação de serviços: ");
            double anualServicesRevenue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Renda anual com ganho de capital: ");
            double anualCapitalGainRevenue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Gastos médicos: ");
            double medicalExpenses = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Gastos educacionais: ");
            double educacionalExpenses = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double totalExpenses = medicalExpenses + educacionalExpenses;

            double salaryRevenueTax;
            double servicesRevenueTax = 0.15;
            double capitalGainRevenueTax = 0.2;

            if((anualWorkRevenue / 12) < 3000.00)
            {
                salaryRevenueTax = 0;
            } else if((anualWorkRevenue / 12) >= 3000.00 && (anualWorkRevenue / 12) < 5000.00)
            {
                salaryRevenueTax = 0.1;
            } else
            {
                salaryRevenueTax = 0.2;
            }

            double salaryTax = anualWorkRevenue * salaryRevenueTax;
            double servicesTax = anualServicesRevenue * servicesRevenueTax;
            double capitalGainTax = anualCapitalGainRevenue * capitalGainRevenueTax;

            double maximumTaxDeduction = (salaryTax + servicesTax + capitalGainTax) * 0.3;
            double deductableTax = medicalExpenses + educacionalExpenses;

            double grossTax = salaryTax + servicesTax + capitalGainTax;
            double totalTaxDeduction;
            
            if(maximumTaxDeduction < deductableTax)
            {
                totalTaxDeduction = maximumTaxDeduction;
            } else
            {
                totalTaxDeduction = deductableTax;
            }

            double netTax = grossTax - totalTaxDeduction;

                Console.WriteLine();
            Console.WriteLine("RELATÓRIO DE IMPOSTO DE RENDA");
            Console.WriteLine();

            Console.WriteLine("CONSOLIDADO DE RENDA:");

            Console.WriteLine("Imposto sobre salário: " + salaryTax.ToString("F2"));
            Console.WriteLine("Imposto sobre serviços: " + servicesTax.ToString("F2"));
            Console.WriteLine("Imposto sobre ganho de capital: " + capitalGainTax.ToString("F2"));

            Console.WriteLine();
            Console.WriteLine("DEDUÇÕES:");
            Console.WriteLine("Máximo dedutível: " + maximumTaxDeduction.ToString("F2"));
            Console.WriteLine("Gastos dedutíveis: " + deductableTax.ToString("F2"));

            Console.WriteLine();
            Console.WriteLine("RESUMO");
            Console.WriteLine("Imposto bruto total: " + grossTax.ToString("F2"));
            Console.WriteLine("Abatimento: " + totalTaxDeduction.ToString("F2"));
            Console.WriteLine("Imposto devido: " + netTax.ToString("F2"));
        }
        
    }
}