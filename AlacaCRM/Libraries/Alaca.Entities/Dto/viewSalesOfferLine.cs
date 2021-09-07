using Alaca.Entities.Concrete;

namespace Alaca.Entities.Dto
{
    public class viewSalesOfferLine : SalesOfferLine
    {
        public string StockName { get; set; }
        public string CurrencyName { get; set; }
        public string StockUnitName { get; set; }
    }
}
