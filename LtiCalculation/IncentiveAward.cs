using System;

namespace LtiCalculation
{
    public class IncentiveAward    
    {
        public int Id { get; set; }
        public int RegionId { get; set; }
        public int ExecutiveId { get; set; }
        public decimal? GrantDatePVAsReported { get; set; }
        public decimal? ExercisePrice { get; set; }
        public DateTime? GrantDate { get; set; }
        public decimal? NumberGranted { get; set; }
        public decimal? StockPriceGrantDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public decimal? MaximumAmount { get; set; }
        public decimal? MaximumNumber { get; set; }
        public string Metric { get; set; }
        public string OptionOrSecurityTicker { get; set; }
        public decimal? PerformancePeriodYrs { get; set; }
        public int? AwardVehicleId { get; set; }
        public int? AwardFeatureId { get; set; }
        public int? AwardPerformanceId { get; set; }
        public int? SpecialFeatureId { get; set; }
        public int? AwardPeriodId { get; set; }
        public int? VestingScheduleId { get; set; }
        public decimal? VestingPeriod { get; set; }
        public decimal? TargetAmount { get; set; }
        public decimal? TargetNumber { get; set; }
        public decimal? Term { get; set; }
        public decimal? ThresholdAmount { get; set; }
        public decimal? ThresholdNumber { get; set; }
        public string TransactionComment { get; set; }
        public int? IncentivePlanTypeId { get; set; }
        public LtiPlanTypes IncentivePlanType { get; set; } // Added by KK 
        public string PlanName { get; set; }
        public int? PayoutVehicleId { get; set; }
        public int? CurrencyId { get; set; }
        public decimal? AwardFaceValuePercentBase { get; set; }
        public decimal? FaceValue { get; set; }
        public decimal? LTIFactor { get; set; }
        public decimal? AccountingFairValue { get; set; }
        public decimal? AccountingValuePerUnit { get; set; }
        public decimal? AccrualsProvisions { get; set; }
        public decimal? OtherValue { get; set; }
        public decimal? TargetForLTC { get; set; }
        public decimal? MaxForLTC { get; set; }
        public decimal? CompulsoryInvestmentPercentBase { get; set; }
        public decimal? VoluntaryInvestmentPercentBase { get; set; }
        public decimal? MaxMatchPercentCompulsory { get; set; }
        public decimal? MaxMatchPercentVoluntary { get; set; }
        public decimal? AwardFaceValuePercentBaseFL { get; set; }
        public decimal? LTIFactorFL { get; set; }
        public decimal? VestingPercent { get; set; }
        public int? VestingPayoutVehicleId { get; set; }
        public int? ValueOfAwardVestingCurrencyId { get; set; }
        public decimal? ValueOfAwardVesting { get; set; }
        public string VestingScheduleDescription { get; set; }
        public int? PlanScopeId { get; set; }
        public bool? HasPerformanceConditionsForVesting { get; set; }
        public string PerformanceConditionsForVestingNote { get; set; }
        public decimal? OptionTerms { get; set; }
        public int? ExercisePriceCurrencyId { get; set; }
        public int? FairValueCurrencyId { get; set; }
        public string LTINotes { get; set; }
        public int? ValuationModelId { get; set; }
        public decimal? Volatility { get; set; }
        public decimal? ExpectedLife { get; set; }
        public decimal? DividendYieldPercent { get; set; }
        public decimal? RiskFreeRate { get; set; }
        public string ValuationModelNote { get; set; }
        public int? GrantCriteriaId { get; set; }
        public decimal? ThresholdPercent { get; set; }
        public decimal? MinimumPercent { get; set; }
        public decimal? MaximumPercent { get; set; }
        public decimal? TargetPercent { get; set; }
        public decimal? PerformancePeriodYears { get; set; }
        public int? Tranche { get; set; }
        public decimal? SharePriceOnGrantDate { get; set; }
        public decimal? ShareFairValueDisclosed { get; set; }
        public string Notes { get; set; }
        public byte[] DataHash { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTimeOffset? ModifiedDate { get; set; }
        public int? ModifiedByUserId { get; set; }
    }
}
