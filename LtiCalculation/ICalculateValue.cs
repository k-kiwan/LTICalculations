using System;

namespace LtiCalculation
{
    public interface ICalculateValue
    {
        decimal? CalculateType1(IncentiveAward ia, 
                                decimal? policyBaseSalary = null);
        /// <summary>
        /// This method calculates the Face Value for the following plan types:
        /// - (Phantom) Performance Shares
        /// - (Phantom) Stock Options
        /// - (Phantom) Restricted Stocks
        /// - Co-Investment Plan
        /// - Other
        /// </summary>

        decimal? CalculateType2(IncentiveAward ia,
                                decimal? policyBaseSalary = null);
        /// <summary>
        /// This method calculates the Face Value for the following plan types:
        /// - Long-Term Cash
        /// </summary>

        decimal? CalculateType3(IncentiveAward ia,
                                ExecutiveReportingInfo sc,
                                decimal? annualBonusTotalAmountValue = null,
                                decimal? policyBaseSalary = null);
        /// <summary>
        /// This method calculates the Face Value for the following plan types:
        /// - Deferred Bonus Match
        /// </summary>

    }
}
