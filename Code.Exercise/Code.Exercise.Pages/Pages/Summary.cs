using Code.Exercise.Elements.Elements;
using Code.Exercise.Helper.Attributes;
using Code.Exercise.Helper.Enums;

namespace Code.Exercise.Pages
{
    [Page("Summary")]
    public class Summary
    {
        [Element("Remove Blouse", ElementType.CellTable)]
        [Locator(LocatorType.XPath, "*//table/descendant::tr[td[contains(., 'Blouse')]]//a[@title='Delete']")]
        public CellTable RemoveBlouse { get; }

        [Element("Total Amount to Pay", ElementType.CellTable)]
        [Locator(LocatorType.XPath, "//tfoot//*[@id='total_price_container']/span")]
        public CellTable TotalAmountToPay { get; }
    }
}
