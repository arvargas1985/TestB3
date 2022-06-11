namespace TestB3.WebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class QuoteCDBRepository : IQuoteCDBRepository
    {
        public QuoteCDB Calculate(QuoteCDB quoteCDB)
        {
            return quoteCDB;
        }
    }
}