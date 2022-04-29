using System.Collections.Generic;

namespace Teste.Models
{
    public class Root
    {
        public Aparelho Aparelho { get; set; }

        public List<Plan> Plans { get; set; }
    }
}