using System;
using System.Collections.Generic;

namespace LtiCalculation
{
    public class FaceValueBasedOnPlanType
    {
        List<LtiPlanTypes> planType1 = new List<LtiPlanTypes>()
                                        {LtiPlanTypes.StockOptions,
                                         LtiPlanTypes.PerformanceShares,
                                         LtiPlanTypes.RestrictedShares,
                                         LtiPlanTypes.CoInvestment,
                                         LtiPlanTypes.OtherLti};
        LtiPlanTypes planType2 = LtiPlanTypes.LongTermCash;
        LtiPlanTypes planType3 = LtiPlanTypes.DeferredBonusMatch;


        public decimal? CalculateValueBasedOnType(ICalculateValue calc,
                                                  IncentiveAward ia,
                                                  ExecutiveReportingInfo sc,
                                                  decimal? annualBonusTotalAmountValue)

        /// <summary>
        /// Calculates the Face Value depending on the plan type.
        /// </summary>
        {
            if (planType1.Contains(ia.IncentivePlanType))
            {
                return calc.CalculateType1(ia);
            }
            else if (ia.IncentivePlanType == planType2)
            {
                return calc.CalculateType2(ia);
            }
            else if (ia.IncentivePlanType == planType3)
            {
                return calc.CalculateType3(ia, sc, annualBonusTotalAmountValue);
            }
            return null;
        }
    }


    //Test updatee test 
    public class ActualFaceValueCalculation : FirstLevelFaceValue, ICalculateValue
    /// <summary>
    /// This is the Face Value Type that will be used to calculate 
    /// the WTW Expectec Values.
    /// This is returned as an amount.
    /// </summary>

    {
        public decimal? CalculateType1(IncentiveAward ia, 
                                       decimal? policyBaseSalary = null)
        /// <summary>
        /// This method calculates the Face Value for the following plan types:
        /// - (Phantom) Performance Shares
        /// - (Phantom) Stock Options
        /// - (Phantom) Restricted Stocks
        /// - Co-Investment Plan
        /// - Other
        /// </summary>
        {
            return ActualFaceValueAsAmount(ia.FaceValue)
                   ?? FaceValueBasedOnNumberOfSharesAsAmount(
                                                    ia.NumberGranted,
                                                    ia.StockPriceGrantDate);
        }

        public decimal? CalculateType2(IncentiveAward ia, 
                                       decimal? policyBaseSalary = null)
        /// <summary>
        /// This method calculates the Face Value for the following plan types:
        /// - Long-Term Cash
        /// </summary>
        {
            return FaceValueBasedOnLtcTargetAsAmount(ia.TargetForLTC)
                   ?? FaceValueBasedOnLtcMaxAsAmount(ia.MaxForLTC);
        }

        public decimal? CalculateType3(IncentiveAward ia,
                                       ExecutiveReportingInfo sc,
                                       decimal? annualBonusTotalAmountValue, 
                                       decimal? policyBaseSalary = null)
        /// <summary>
        /// This method calculates the Face Value for the following plan types:
        /// - Deferred Bonus Match
        /// </summary>
        {
            return ActualFaceValueAsAmount(ia.FaceValue)
                   ?? FaceValueBasedOnNumberOfSharesAsAmount(
                                                    ia.NumberGranted,
                                                    ia.StockPriceGrantDate)
                   ?? FaceValueBasedOnDbmActualBonusAsAmount(
                                          annualBonusTotalAmountValue,
                                          ia.MaxMatchPercentCompulsory,
                                          ia.MaxMatchPercentVoluntary,
                                          sc.AnnualBonusPercentCompulsorilyDeferred,
                                          sc.AnnualBonusPercentVoluntaryDeferred);
        }
    }


    public class PolicyFaceValueCalculationPercent : FirstLevelFaceValue, ICalculateValue
    /// <summary>
    /// Policy Face Value. This is returned as a percentage.
    /// </summary>

    {
        public decimal? CalculateType1(IncentiveAward ia, 
                                       decimal? policyBaseSalary)
        /// <summary>
        /// This method calculates the Face Value for the following plan types:
        /// - (Phantom) Performance Shares
        /// - (Phantom) Stock Options
        /// - (Phantom) Restricted Stocks
        /// - Co-Investment Plan
        /// - Other
        /// </summary>
        {
            return  PolicyFaceValueAsPercent(ia.AwardFaceValuePercentBase)
                    ?? ActualFaceValueAsPercent(ia.FaceValue, policyBaseSalary)
                    ?? FaceValueBasedOnNumberOfSharesAsPercent(
                                                    ia.NumberGranted,
                                                    ia.StockPriceGrantDate,
                                                    policyBaseSalary);
        }

        public decimal? CalculateType2(IncentiveAward ia, 
                                       decimal? policyBaseSalary)
        /// <summary>
        /// This method calculates the Face Value for the following plan types:
        /// - Long-Term Cash
        /// </summary>
        {
            return PolicyFaceValueAsPercent(ia.AwardFaceValuePercentBase)
                   ?? FaceValueBasedOnLtcTargetAsPercent(ia.TargetForLTC, 
                                                         policyBaseSalary)
                   ?? FaceValueBasedOnLtcMaximumAsPercent(ia.MaxForLTC, 
                                                          policyBaseSalary);
        }

        public decimal? CalculateType3(IncentiveAward ia,
                                       ExecutiveReportingInfo sc,
                                       decimal? annualBonusTotalAmountValue, 
                                       decimal? policyBaseSalary)
        /// <summary>
        /// This method calculates the Face Value for the following plan types:
        /// - Deferred Bonus Match
        /// </summary>
        {
            return  PolicyFaceValueAsPercent(ia.AwardFaceValuePercentBase)
                    ?? FaceValueBasedOnDbmMaxBonusAsPercent(
                                            sc.AnnualBonusMaxPercent,
                                            ia.MaxMatchPercentCompulsory,
                                            ia.MaxMatchPercentVoluntary,
                                            sc.AnnualBonusPercentCompulsorilyDeferred,
                                            sc.AnnualBonusPercentVoluntaryDeferred)
                    ?? FaceValueBasedOnDbmActualAsPercent(
                                          annualBonusTotalAmountValue,
                                          ia.MaxMatchPercentCompulsory,
                                          ia.MaxMatchPercentVoluntary,
                                          sc.AnnualBonusPercentCompulsorilyDeferred,
                                          sc.AnnualBonusPercentVoluntaryDeferred,
                                          policyBaseSalary)
                   ?? ActualFaceValueAsPercent(ia.FaceValue,
                                          policyBaseSalary)
                   ?? FaceValueBasedOnNumberOfSharesAsPercent(
                                                    ia.NumberGranted,
                                                    ia.StockPriceGrantDate,
                                                    policyBaseSalary);
        }
    }

}
