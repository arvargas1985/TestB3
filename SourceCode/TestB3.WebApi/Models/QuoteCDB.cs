namespace TestB3.WebApi.Models
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class QuoteCDB
    {
        [Description("Valor")]
        [DisplayName("Value")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a Value bigger than {1}.")]
        [Required]
        public decimal Value { get; set; }

        [Description("Quantidade de Meses")]
        [DisplayName("Quantity of Months")]
        [Range(2, int.MaxValue, ErrorMessage = "Please enter a Quantity of Months bigger than {1}.")]
        [Required]
        public int QuantityMonths { get; set; }

        public decimal? BruteResult { get; set; }

        public decimal? LiquidResult { get; set; }
    }
}