using System;

namespace LtiCalculation
{
    public enum LtiEligibilities
    {
        NoAwardMade = 1691,
        NotEligible = 1692,
        NotDisclosed = 1693,
        AwardMade = 1690
    }

    public enum LtiPlanTypes
    {
        StockOptions = 1656,
        PerformanceShares = 1657,
        RestrictedShares = 1658,
        CoInvestment = 1661,
        OtherLti = 1662,
        LongTermCash = 1659,
        DeferredBonusMatch = 1660
    }
}
