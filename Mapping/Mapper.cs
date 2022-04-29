using System;
using System.Collections.Generic;
using Teste.Language;
using Teste.Models;

namespace Teste.Mapping
{
    public class Mapper
    {
        public static List<Plan> GetPlan(List<Plan> plan, Aparelho aparelho)
        {
            Console.WriteLine(TestMSG.MSG001);

            Console.WriteLine($"\nModelo do Aparelho: {aparelho.Name}\n");

            try
            {
                foreach (Plan plans in plan)
                {
                    if (plans.Schedule.StartDate <= DateTime.Today)
                    {
                        Console.WriteLine($"\nCONFIRA ESSE SUPER PLANO! \nId: {plans.Id}\nType: {plans.Type}\nName: {plans.Name}\nPhonePrice: {plans.PhonePrice}" +
                            $"\nPhonePriceOnPlan: {plans.PhonePriceOnPlan}\nInstallments: {plans.Installments}\nMonthly_fee: {plans.MonthlyFee}" +
                            $"\nSchedule: {plans.Schedule.StartDate}\nLocal: {plans.Localidade.Nome}\nPriority: {plans.Localidade.Prioridade}\n");

                        Console.WriteLine("\n"+TestMSG.MSG004+"\n");

                        continue;
                    }
                    Console.WriteLine($"\nCONFIRA ESSE SUPER PLANO! \nId: {plans.Id}\nType: {plans.Type}\nName: {plans.Name}\nPhonePrice: {plans.PhonePrice}" +
                            $"\nPhonePriceOnPlan: {plans.PhonePriceOnPlan}\nInstallments: {plans.Installments}\nMonthly_fee: {plans.MonthlyFee}" +
                            $"\nSchedule: {plans.Schedule.StartDate}\nLocal: {plans.Localidade.Nome}\nPriority: {plans.Localidade.Prioridade}\n");

                    Console.WriteLine(TestMSG.MSG005);

                    int.TryParse(Console.ReadLine(), out int plano1);

                    if (plano1 == 1)
                    {
                        Console.WriteLine(TestMSG.MSG002);
                        break;
                    }
                    if(plano1 == 2)
                    {
                        Console.WriteLine(TestMSG.MSG003);
                        continue;
                    }
                    else
                    {
                        throw new Exception(TestMSG.MSG006);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return plan;
        }
    }
}