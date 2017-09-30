﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\UnitClasses\MyUnit.extra.cs files to add code to generated unit classes.
//     Add Extensions\MyUnitExtensions.cs to decorate unit classes with new behavior.
//     Add UnitDefinitions\MyUnit.json and run GeneratUnits.bat to generate new units or unit classes.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2007 Andreas Gullberg Larsen (angularsen@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of Acceleration.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class AccelerationTestsBase
    {
        protected abstract double CentimeterPerSecondSquaredInOneMeterPerSecondSquared { get; }
        protected abstract double DecimeterPerSecondSquaredInOneMeterPerSecondSquared { get; }
        protected abstract double KilometerPerSecondSquaredInOneMeterPerSecondSquared { get; }
        protected abstract double MeterPerSecondSquaredInOneMeterPerSecondSquared { get; }
        protected abstract double MicrometerPerSecondSquaredInOneMeterPerSecondSquared { get; }
        protected abstract double MillimeterPerSecondSquaredInOneMeterPerSecondSquared { get; }
        protected abstract double NanometerPerSecondSquaredInOneMeterPerSecondSquared { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CentimeterPerSecondSquaredTolerance { get { return 1e-5; } }
        protected virtual double DecimeterPerSecondSquaredTolerance { get { return 1e-5; } }
        protected virtual double KilometerPerSecondSquaredTolerance { get { return 1e-5; } }
        protected virtual double MeterPerSecondSquaredTolerance { get { return 1e-5; } }
        protected virtual double MicrometerPerSecondSquaredTolerance { get { return 1e-5; } }
        protected virtual double MillimeterPerSecondSquaredTolerance { get { return 1e-5; } }
        protected virtual double NanometerPerSecondSquaredTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void MeterPerSecondSquaredToAccelerationUnits()
        {
            Acceleration meterpersecondsquared = Acceleration.FromMeterPerSecondSquared(1);
            AssertEx.EqualTolerance(CentimeterPerSecondSquaredInOneMeterPerSecondSquared, meterpersecondsquared.CentimeterPerSecondSquared, CentimeterPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(DecimeterPerSecondSquaredInOneMeterPerSecondSquared, meterpersecondsquared.DecimeterPerSecondSquared, DecimeterPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(KilometerPerSecondSquaredInOneMeterPerSecondSquared, meterpersecondsquared.KilometerPerSecondSquared, KilometerPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(MeterPerSecondSquaredInOneMeterPerSecondSquared, meterpersecondsquared.MeterPerSecondSquared, MeterPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(MicrometerPerSecondSquaredInOneMeterPerSecondSquared, meterpersecondsquared.MicrometerPerSecondSquared, MicrometerPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(MillimeterPerSecondSquaredInOneMeterPerSecondSquared, meterpersecondsquared.MillimeterPerSecondSquared, MillimeterPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(NanometerPerSecondSquaredInOneMeterPerSecondSquared, meterpersecondsquared.NanometerPerSecondSquared, NanometerPerSecondSquaredTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, Acceleration.From(1, AccelerationUnit.CentimeterPerSecondSquared).CentimeterPerSecondSquared, CentimeterPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(1, Acceleration.From(1, AccelerationUnit.DecimeterPerSecondSquared).DecimeterPerSecondSquared, DecimeterPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(1, Acceleration.From(1, AccelerationUnit.KilometerPerSecondSquared).KilometerPerSecondSquared, KilometerPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(1, Acceleration.From(1, AccelerationUnit.MeterPerSecondSquared).MeterPerSecondSquared, MeterPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(1, Acceleration.From(1, AccelerationUnit.MicrometerPerSecondSquared).MicrometerPerSecondSquared, MicrometerPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(1, Acceleration.From(1, AccelerationUnit.MillimeterPerSecondSquared).MillimeterPerSecondSquared, MillimeterPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(1, Acceleration.From(1, AccelerationUnit.NanometerPerSecondSquared).NanometerPerSecondSquared, NanometerPerSecondSquaredTolerance);
        }

        [Fact]
        public void As()
        {
            var meterpersecondsquared = Acceleration.FromMeterPerSecondSquared(1);
            AssertEx.EqualTolerance(CentimeterPerSecondSquaredInOneMeterPerSecondSquared, meterpersecondsquared.As(AccelerationUnit.CentimeterPerSecondSquared), CentimeterPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(DecimeterPerSecondSquaredInOneMeterPerSecondSquared, meterpersecondsquared.As(AccelerationUnit.DecimeterPerSecondSquared), DecimeterPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(KilometerPerSecondSquaredInOneMeterPerSecondSquared, meterpersecondsquared.As(AccelerationUnit.KilometerPerSecondSquared), KilometerPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(MeterPerSecondSquaredInOneMeterPerSecondSquared, meterpersecondsquared.As(AccelerationUnit.MeterPerSecondSquared), MeterPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(MicrometerPerSecondSquaredInOneMeterPerSecondSquared, meterpersecondsquared.As(AccelerationUnit.MicrometerPerSecondSquared), MicrometerPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(MillimeterPerSecondSquaredInOneMeterPerSecondSquared, meterpersecondsquared.As(AccelerationUnit.MillimeterPerSecondSquared), MillimeterPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(NanometerPerSecondSquaredInOneMeterPerSecondSquared, meterpersecondsquared.As(AccelerationUnit.NanometerPerSecondSquared), NanometerPerSecondSquaredTolerance);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            Acceleration meterpersecondsquared = Acceleration.FromMeterPerSecondSquared(1);
            AssertEx.EqualTolerance(1, Acceleration.FromCentimeterPerSecondSquared(meterpersecondsquared.CentimeterPerSecondSquared).MeterPerSecondSquared, CentimeterPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(1, Acceleration.FromDecimeterPerSecondSquared(meterpersecondsquared.DecimeterPerSecondSquared).MeterPerSecondSquared, DecimeterPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(1, Acceleration.FromKilometerPerSecondSquared(meterpersecondsquared.KilometerPerSecondSquared).MeterPerSecondSquared, KilometerPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(1, Acceleration.FromMeterPerSecondSquared(meterpersecondsquared.MeterPerSecondSquared).MeterPerSecondSquared, MeterPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(1, Acceleration.FromMicrometerPerSecondSquared(meterpersecondsquared.MicrometerPerSecondSquared).MeterPerSecondSquared, MicrometerPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(1, Acceleration.FromMillimeterPerSecondSquared(meterpersecondsquared.MillimeterPerSecondSquared).MeterPerSecondSquared, MillimeterPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(1, Acceleration.FromNanometerPerSecondSquared(meterpersecondsquared.NanometerPerSecondSquared).MeterPerSecondSquared, NanometerPerSecondSquaredTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            Acceleration v = Acceleration.FromMeterPerSecondSquared(1);
            AssertEx.EqualTolerance(-1, -v.MeterPerSecondSquared, MeterPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(2, (Acceleration.FromMeterPerSecondSquared(3)-v).MeterPerSecondSquared, MeterPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(2, (v + v).MeterPerSecondSquared, MeterPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(10, (v*10).MeterPerSecondSquared, MeterPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(10, (10*v).MeterPerSecondSquared, MeterPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(2, (Acceleration.FromMeterPerSecondSquared(10)/5).MeterPerSecondSquared, MeterPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(2, Acceleration.FromMeterPerSecondSquared(10)/Acceleration.FromMeterPerSecondSquared(5), MeterPerSecondSquaredTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            Acceleration oneMeterPerSecondSquared = Acceleration.FromMeterPerSecondSquared(1);
            Acceleration twoMeterPerSecondSquared = Acceleration.FromMeterPerSecondSquared(2);

            Assert.True(oneMeterPerSecondSquared < twoMeterPerSecondSquared);
            Assert.True(oneMeterPerSecondSquared <= twoMeterPerSecondSquared);
            Assert.True(twoMeterPerSecondSquared > oneMeterPerSecondSquared);
            Assert.True(twoMeterPerSecondSquared >= oneMeterPerSecondSquared);

            Assert.False(oneMeterPerSecondSquared > twoMeterPerSecondSquared);
            Assert.False(oneMeterPerSecondSquared >= twoMeterPerSecondSquared);
            Assert.False(twoMeterPerSecondSquared < oneMeterPerSecondSquared);
            Assert.False(twoMeterPerSecondSquared <= oneMeterPerSecondSquared);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            Acceleration meterpersecondsquared = Acceleration.FromMeterPerSecondSquared(1);
            Assert.Equal(0, meterpersecondsquared.CompareTo(meterpersecondsquared));
            Assert.True(meterpersecondsquared.CompareTo(Acceleration.Zero) > 0);
            Assert.True(Acceleration.Zero.CompareTo(meterpersecondsquared) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            Acceleration meterpersecondsquared = Acceleration.FromMeterPerSecondSquared(1);
            Assert.Throws<ArgumentException>(() => meterpersecondsquared.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            Acceleration meterpersecondsquared = Acceleration.FromMeterPerSecondSquared(1);
            Assert.Throws<ArgumentNullException>(() => meterpersecondsquared.CompareTo(null));
        }


        [Fact]
        public void EqualityOperators()
        {
            Acceleration a = Acceleration.FromMeterPerSecondSquared(1);
            Acceleration b = Acceleration.FromMeterPerSecondSquared(2);

// ReSharper disable EqualExpressionComparison
            Assert.True(a == a);
            Assert.True(a != b);

            Assert.False(a == b);
            Assert.False(a != a);
// ReSharper restore EqualExpressionComparison
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            Acceleration v = Acceleration.FromMeterPerSecondSquared(1);
            Assert.True(v.Equals(Acceleration.FromMeterPerSecondSquared(1)));
            Assert.False(v.Equals(Acceleration.Zero));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Acceleration meterpersecondsquared = Acceleration.FromMeterPerSecondSquared(1);
            Assert.False(meterpersecondsquared.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            Acceleration meterpersecondsquared = Acceleration.FromMeterPerSecondSquared(1);
            Assert.False(meterpersecondsquared.Equals(null));
        }
    }
}
