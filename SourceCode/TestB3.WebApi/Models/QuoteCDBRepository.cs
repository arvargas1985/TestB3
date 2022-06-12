namespace TestB3.WebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class QuoteCDBRepository : IQuoteCDBRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="quoteCDB"></param>
        /// <returns></returns>
        public QuoteCDB Calculate(QuoteCDB quoteCDB)
        {
            decimal initialValue = quoteCDB.Value;
            decimal finalValue = 0m;
            decimal percentageTaxes = this.GetTaxPercentage(
                quoteCDB.QuantityMonths);

            for (int i = 1; i < quoteCDB.QuantityMonths; i++)
            //for (int i = 0; i < quoteCDB.QuantityMonths; i++)
            {
                finalValue = initialValue * (1 + (Constants.CDI * Constants.TB));

                initialValue = finalValue;
            }

            decimal valueTaxes = Math.Round(
                finalValue * percentageTaxes,
                2,
                MidpointRounding.AwayFromZero);

            quoteCDB.BruteResult = Math.Round(
                finalValue,
                2,
                MidpointRounding.AwayFromZero);

            quoteCDB.Taxes = valueTaxes;

            quoteCDB.LiquidResult = quoteCDB.BruteResult - quoteCDB.Taxes;

            return quoteCDB;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="quantityMonths"></param>
        /// <returns></returns>
        private decimal GetTaxPercentage(int quantityMonths)
        {
            if (quantityMonths > 6 && quantityMonths <= 12)
            {
                return 0.200m;
            }
            else if (quantityMonths > 12 && quantityMonths <= 24)
            {
                return 0.175m;
            }
            else if (quantityMonths > 24)
            {
                return 0.17m;
            }

            return 0.225m;
        }
    }
}