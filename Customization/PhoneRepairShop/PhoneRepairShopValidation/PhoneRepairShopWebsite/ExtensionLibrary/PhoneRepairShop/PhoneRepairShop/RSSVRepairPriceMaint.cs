using System;
using System.Linq;
using PhoneRepairShop.DAC;
using PX.Data;
using PX.Data.BQL.Fluent;
using PX.Objects.CT;
using PX.Objects.IN;
using PhoneRepairShop;

namespace PhoneRepairShop
{

    public class RSSVRepairPriceMaint : PXGraph<RSSVRepairPriceMaint>
    {
        public SelectFrom<RSSVRepairPrice>.View RepairPrices;

    }
}