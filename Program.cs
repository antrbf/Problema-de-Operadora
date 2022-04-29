using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using Teste.Language;
using Teste.Mapping;
using Teste.Models;

namespace Teste
{
    public static class Program
    {
        public static void Main()
        {
            string file = "data.json";
            string json = File.ReadAllText(file);

            try
            {
                Root root = JsonConvert.DeserializeObject<Root>(json);

                List<Plan> plan = root.Plans.OrderBy(x => x.Localidade.Prioridade).ToList();

                List<Plan> plano = Mapper.GetPlan(plan, root.Aparelho);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

            Console.WriteLine("\n\n Até a próxima!");
        }
    }
}