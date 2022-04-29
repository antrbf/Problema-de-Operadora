namespace Teste.Models
{
    public class Plan
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public int PhonePrice { get; set; }
        public int PhonePriceOnPlan { get; set; }
        public int Installments { get; set; }
        public double MonthlyFee { get; set; }
        public Schedule Schedule { get; set; }
        public Localidade Localidade { get; set; }
    }
}