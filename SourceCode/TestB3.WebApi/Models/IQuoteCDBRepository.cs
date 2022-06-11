namespace TestB3.WebApi.Models
{
    using System;

    public interface IQuoteCDBRepository
    {
        QuoteCDB Calculate(QuoteCDB quoteCDB);
    }
}