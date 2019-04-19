using System;

namespace LtiCalculation
{
    public class FirstLevelFaceValue
    {
        /// <summary>
        /// This provides methods for all the different possibilities we have to 
        /// calculate a face value with the information coming from the database.
        /// Each of those can be expressed as a value amount or a percentage.
        /// </summary>

        public void Main()
        {

        }

        #region // FY Generic Face Value Calculations - As Amounts

        public decimal? PolicyFaceValueAsAmount(
                                            decimal? faceValuePercent,
                                            decimal? policyBaseSalaryFY)
        {
            return faceValuePercent / 100m * policyBaseSalaryFY;
        }

        public decimal? ActualFaceValueAsAmount(
                                        decimal? faceValue)
        {
            return faceValue;
        }

        public decimal? FaceValueBasedOnNumberOfSharesAsAmount(
                                        decimal? numberOfSharesGranted,
                                        decimal? stockPriceAtGrantDate)
        {
            return numberOfSharesGranted * stockPriceAtGrantDate;
        }

        public decimal? FaceValueBasedOnLtcTargetAsAmount(
                                                decimal? ltcTarget)
        {
            return ltcTarget;
        }

        public decimal? FaceValueBasedOnLtcMaxAsAmount(
                                        decimal? ltcMaximum)
        {
            return ltcMaximum;
        }

        public decimal? FaceValueBasedOnDbmActualBonusAsAmount(
                                decimal? annualBonusTotalAmountValue,
                                decimal? maxMatchPercentCompulsory,
                                decimal? maxMatchPercentVoluntary,
                                decimal? annualBonusPercentCompulsorilyDeferred,
                                decimal? annualBonusPercentVoluntaryDeferred)
        {
            return annualBonusTotalAmountValue *
                    ((maxMatchPercentCompulsory ?? 0) / 100m
                    * (annualBonusPercentCompulsorilyDeferred ?? 0) / 100m
                    + (maxMatchPercentVoluntary ?? 0) / 100m
                    * (annualBonusPercentVoluntaryDeferred ?? 0) / 100m);
        }

        public decimal? FaceValueBasedOnDbmMaxBonusAsAmount(
                                decimal? annualBonusMaximumPercent,
                                decimal? policyBaseSalaryFY,
                                decimal? maxMatchPercentCompulsory,
                                decimal? maxMatchPercentVoluntary,
                                decimal? annualBonusPercentCompulsorilyDeferred,
                                decimal? annualBonusPercentVoluntaryDeferred)
        {
            return (policyBaseSalaryFY
                    * annualBonusMaximumPercent / 100m)
                    * ((maxMatchPercentCompulsory ?? 0) / 100m
                    * (annualBonusPercentCompulsorilyDeferred ?? 0) / 100m
                    + (maxMatchPercentVoluntary ?? 0) / 100m
                    * (annualBonusPercentVoluntaryDeferred ?? 0) / 100m);
        }
        #endregion

        #region // FY Generic Face Value Calculations - As Percentages

        public decimal? PolicyFaceValueAsPercent(
                                                decimal? faceValuePercent)
        {
            return faceValuePercent / 100m;
        }

        public decimal? ActualFaceValueAsPercent(
                                                decimal? faceValue,
                                                decimal? policyBaseSalaryFY)
        {
            if (policyBaseSalaryFY != 0)
            {
                return faceValue / policyBaseSalaryFY;
            }
            return null;
        }

        public decimal? FaceValueBasedOnNumberOfSharesAsPercent(
                                                decimal? numberOfSharesGranted,
                                                decimal? stockPriceAtGrantDate,
                                                decimal? policyBaseSalaryFY)
        {
            if (policyBaseSalaryFY != 0)
            {
                return FaceValueBasedOnNumberOfSharesAsAmount(
                                                        numberOfSharesGranted,
                                                        stockPriceAtGrantDate)
                                / policyBaseSalaryFY;
            }
            return null;

        }

        public decimal? FaceValueBasedOnLtcTargetAsPercent(
                                                decimal? ltcTarget,
                                                decimal? policyBaseSalaryFY)
        {
            if (policyBaseSalaryFY != 0)
            {
                return ltcTarget / policyBaseSalaryFY;
            }

            return null;
        }

        public static decimal? FaceValueBasedOnLtcMaximumAsPercent(
                                                decimal? ltcMaximum,
                                                decimal? policyBaseSalaryFY)
        {
            if (policyBaseSalaryFY != 0)
            {
                return ltcMaximum / policyBaseSalaryFY;
            }
            return null;
        }

        public decimal? FaceValueBasedOnDbmActualAsPercent(
                                decimal? annualBonusTotalAmountValue,
                                decimal? maxMatchPercentCompulsory,
                                decimal? maxMatchPercentVoluntary,
                                decimal? annualBonusPercentCompulsorilyDeferred,
                                decimal? annualBonusPercentVoluntaryDeferred,
                                decimal? policyBaseSalaryFY)
        {
            if (policyBaseSalaryFY != 0)
            {
                return annualBonusTotalAmountValue *
                        ((maxMatchPercentCompulsory ?? 0) / 100m
                        * (annualBonusPercentCompulsorilyDeferred ?? 0) / 100m
                        + (maxMatchPercentVoluntary ?? 0) / 100m
                        * (annualBonusPercentVoluntaryDeferred ?? 0) / 100m)
                        / policyBaseSalaryFY;
            }
            return null;
        }

        public decimal? FaceValueBasedOnDbmMaxBonusAsPercent(
                                decimal? annualBonusMaximumPercent,
                                decimal? maxMatchPercentCompulsory,
                                decimal? maxMatchPercentVoluntary,
                                decimal? annualBonusPercentCompulsorilyDeferred,
                                decimal? annualBonusPercentVoluntaryDeferred)
        {
            return annualBonusMaximumPercent
                        * ((maxMatchPercentCompulsory ?? 0) / 100m
                        * (annualBonusPercentCompulsorilyDeferred ?? 0) / 100m
                        + (maxMatchPercentVoluntary ?? 0) / 100m
                        * (annualBonusPercentVoluntaryDeferred ?? 0) / 100m
                      );
        }
        #endregion

        #region // FL Generic Face Value Calculations - As Amount
        #endregion

        #region // FL Generic Face Value Calculations - As Percentages
        #endregion

    }
}
