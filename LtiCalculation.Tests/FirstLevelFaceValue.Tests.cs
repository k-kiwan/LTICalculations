using System;
using Xunit;
using LtiCalculation;

namespace LtiCalculation.Tests
{
    public class FirstLevelFaceValueTest
    {
        FirstLevelFaceValue flfv = new FirstLevelFaceValue();

        #region // Actual Face Value - As Amount

        [Fact]
        public void ActualFaceValueAsAmountCase1()
        {
            Assert.Equal(1500000m,
                flfv.ActualFaceValueAsAmount(1500000m));
        }

        [Fact]
        public void ActualFaceValueAsAmountCase2()
        {
            Assert.Null(
                flfv.ActualFaceValueAsAmount(null));
        }
        #endregion

        #region // Policy Face Value - As Amount
        [Fact]
        public void PolicyFaceValueAsAmountCase1()
        {
            Assert.Equal(200000m,
                flfv.PolicyFaceValueAsAmount(
                                faceValuePercent: 200m,
                                policyBaseSalaryFY: 100000m));
        }

        [Fact]
        public void PolicyFaceValueAsAmountCase2()
        {
            Assert.Null(
                flfv.PolicyFaceValueAsAmount(
                                faceValuePercent: null,
                                policyBaseSalaryFY: 100000m));
        }

        [Fact]
        public void PolicyFaceValueAsAmountCase3()
        {
            Assert.Null(
                flfv.PolicyFaceValueAsAmount(
                                faceValuePercent: 200m,
                                policyBaseSalaryFY: null));
        }
        #endregion

        #region // Face Value Based On DBM Max - As Percent

        [Fact]
        public void FaceValueBasedOnDbmMaxBonusAsPercentCase1()
        {
            Assert.Equal(100,
                flfv.FaceValueBasedOnDbmMaxBonusAsPercent(
                                annualBonusMaximumPercent: 200,
                                maxMatchPercentCompulsory: 100,
                                maxMatchPercentVoluntary: null,
                                annualBonusPercentCompulsorilyDeferred: 50,
                                annualBonusPercentVoluntaryDeferred: null));
        }

        [Fact]
        public void FaceValueBasedOnDbmMaxBonusAsPercentCase2()
        {
            Assert.Equal(100,
                flfv.FaceValueBasedOnDbmMaxBonusAsPercent(
                                annualBonusMaximumPercent: 200,
                                maxMatchPercentCompulsory: null,
                                maxMatchPercentVoluntary: 100,
                                annualBonusPercentCompulsorilyDeferred: 50,
                                annualBonusPercentVoluntaryDeferred: 50));
        }

        #endregion

    }
}
