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
    /// Test of Angle.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class AngleTestsBase
    {
        protected abstract double ArcminutesInOneDegree { get; }
        protected abstract double ArcsecondsInOneDegree { get; }
        protected abstract double CentiradiansInOneDegree { get; }
        protected abstract double DeciradiansInOneDegree { get; }
        protected abstract double DegreesInOneDegree { get; }
        protected abstract double GradiansInOneDegree { get; }
        protected abstract double MicrodegreesInOneDegree { get; }
        protected abstract double MicroradiansInOneDegree { get; }
        protected abstract double MillidegreesInOneDegree { get; }
        protected abstract double MilliradiansInOneDegree { get; }
        protected abstract double NanodegreesInOneDegree { get; }
        protected abstract double NanoradiansInOneDegree { get; }
        protected abstract double RadiansInOneDegree { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double ArcminutesTolerance { get { return 1e-5; } }
        protected virtual double ArcsecondsTolerance { get { return 1e-5; } }
        protected virtual double CentiradiansTolerance { get { return 1e-5; } }
        protected virtual double DeciradiansTolerance { get { return 1e-5; } }
        protected virtual double DegreesTolerance { get { return 1e-5; } }
        protected virtual double GradiansTolerance { get { return 1e-5; } }
        protected virtual double MicrodegreesTolerance { get { return 1e-5; } }
        protected virtual double MicroradiansTolerance { get { return 1e-5; } }
        protected virtual double MillidegreesTolerance { get { return 1e-5; } }
        protected virtual double MilliradiansTolerance { get { return 1e-5; } }
        protected virtual double NanodegreesTolerance { get { return 1e-5; } }
        protected virtual double NanoradiansTolerance { get { return 1e-5; } }
        protected virtual double RadiansTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void DegreeToAngleUnits()
        {
            Angle degree = Angle.FromDegrees(1);
            AssertEx.EqualTolerance(ArcminutesInOneDegree, degree.Arcminutes, ArcminutesTolerance);
            AssertEx.EqualTolerance(ArcsecondsInOneDegree, degree.Arcseconds, ArcsecondsTolerance);
            AssertEx.EqualTolerance(CentiradiansInOneDegree, degree.Centiradians, CentiradiansTolerance);
            AssertEx.EqualTolerance(DeciradiansInOneDegree, degree.Deciradians, DeciradiansTolerance);
            AssertEx.EqualTolerance(DegreesInOneDegree, degree.Degrees, DegreesTolerance);
            AssertEx.EqualTolerance(GradiansInOneDegree, degree.Gradians, GradiansTolerance);
            AssertEx.EqualTolerance(MicrodegreesInOneDegree, degree.Microdegrees, MicrodegreesTolerance);
            AssertEx.EqualTolerance(MicroradiansInOneDegree, degree.Microradians, MicroradiansTolerance);
            AssertEx.EqualTolerance(MillidegreesInOneDegree, degree.Millidegrees, MillidegreesTolerance);
            AssertEx.EqualTolerance(MilliradiansInOneDegree, degree.Milliradians, MilliradiansTolerance);
            AssertEx.EqualTolerance(NanodegreesInOneDegree, degree.Nanodegrees, NanodegreesTolerance);
            AssertEx.EqualTolerance(NanoradiansInOneDegree, degree.Nanoradians, NanoradiansTolerance);
            AssertEx.EqualTolerance(RadiansInOneDegree, degree.Radians, RadiansTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, Angle.From(1, AngleUnit.Arcminute).Arcminutes, ArcminutesTolerance);
            AssertEx.EqualTolerance(1, Angle.From(1, AngleUnit.Arcsecond).Arcseconds, ArcsecondsTolerance);
            AssertEx.EqualTolerance(1, Angle.From(1, AngleUnit.Centiradian).Centiradians, CentiradiansTolerance);
            AssertEx.EqualTolerance(1, Angle.From(1, AngleUnit.Deciradian).Deciradians, DeciradiansTolerance);
            AssertEx.EqualTolerance(1, Angle.From(1, AngleUnit.Degree).Degrees, DegreesTolerance);
            AssertEx.EqualTolerance(1, Angle.From(1, AngleUnit.Gradian).Gradians, GradiansTolerance);
            AssertEx.EqualTolerance(1, Angle.From(1, AngleUnit.Microdegree).Microdegrees, MicrodegreesTolerance);
            AssertEx.EqualTolerance(1, Angle.From(1, AngleUnit.Microradian).Microradians, MicroradiansTolerance);
            AssertEx.EqualTolerance(1, Angle.From(1, AngleUnit.Millidegree).Millidegrees, MillidegreesTolerance);
            AssertEx.EqualTolerance(1, Angle.From(1, AngleUnit.Milliradian).Milliradians, MilliradiansTolerance);
            AssertEx.EqualTolerance(1, Angle.From(1, AngleUnit.Nanodegree).Nanodegrees, NanodegreesTolerance);
            AssertEx.EqualTolerance(1, Angle.From(1, AngleUnit.Nanoradian).Nanoradians, NanoradiansTolerance);
            AssertEx.EqualTolerance(1, Angle.From(1, AngleUnit.Radian).Radians, RadiansTolerance);
        }

        [Fact]
        public void As()
        {
            var degree = Angle.FromDegrees(1);
            AssertEx.EqualTolerance(ArcminutesInOneDegree, degree.As(AngleUnit.Arcminute), ArcminutesTolerance);
            AssertEx.EqualTolerance(ArcsecondsInOneDegree, degree.As(AngleUnit.Arcsecond), ArcsecondsTolerance);
            AssertEx.EqualTolerance(CentiradiansInOneDegree, degree.As(AngleUnit.Centiradian), CentiradiansTolerance);
            AssertEx.EqualTolerance(DeciradiansInOneDegree, degree.As(AngleUnit.Deciradian), DeciradiansTolerance);
            AssertEx.EqualTolerance(DegreesInOneDegree, degree.As(AngleUnit.Degree), DegreesTolerance);
            AssertEx.EqualTolerance(GradiansInOneDegree, degree.As(AngleUnit.Gradian), GradiansTolerance);
            AssertEx.EqualTolerance(MicrodegreesInOneDegree, degree.As(AngleUnit.Microdegree), MicrodegreesTolerance);
            AssertEx.EqualTolerance(MicroradiansInOneDegree, degree.As(AngleUnit.Microradian), MicroradiansTolerance);
            AssertEx.EqualTolerance(MillidegreesInOneDegree, degree.As(AngleUnit.Millidegree), MillidegreesTolerance);
            AssertEx.EqualTolerance(MilliradiansInOneDegree, degree.As(AngleUnit.Milliradian), MilliradiansTolerance);
            AssertEx.EqualTolerance(NanodegreesInOneDegree, degree.As(AngleUnit.Nanodegree), NanodegreesTolerance);
            AssertEx.EqualTolerance(NanoradiansInOneDegree, degree.As(AngleUnit.Nanoradian), NanoradiansTolerance);
            AssertEx.EqualTolerance(RadiansInOneDegree, degree.As(AngleUnit.Radian), RadiansTolerance);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            Angle degree = Angle.FromDegrees(1);
            AssertEx.EqualTolerance(1, Angle.FromArcminutes(degree.Arcminutes).Degrees, ArcminutesTolerance);
            AssertEx.EqualTolerance(1, Angle.FromArcseconds(degree.Arcseconds).Degrees, ArcsecondsTolerance);
            AssertEx.EqualTolerance(1, Angle.FromCentiradians(degree.Centiradians).Degrees, CentiradiansTolerance);
            AssertEx.EqualTolerance(1, Angle.FromDeciradians(degree.Deciradians).Degrees, DeciradiansTolerance);
            AssertEx.EqualTolerance(1, Angle.FromDegrees(degree.Degrees).Degrees, DegreesTolerance);
            AssertEx.EqualTolerance(1, Angle.FromGradians(degree.Gradians).Degrees, GradiansTolerance);
            AssertEx.EqualTolerance(1, Angle.FromMicrodegrees(degree.Microdegrees).Degrees, MicrodegreesTolerance);
            AssertEx.EqualTolerance(1, Angle.FromMicroradians(degree.Microradians).Degrees, MicroradiansTolerance);
            AssertEx.EqualTolerance(1, Angle.FromMillidegrees(degree.Millidegrees).Degrees, MillidegreesTolerance);
            AssertEx.EqualTolerance(1, Angle.FromMilliradians(degree.Milliradians).Degrees, MilliradiansTolerance);
            AssertEx.EqualTolerance(1, Angle.FromNanodegrees(degree.Nanodegrees).Degrees, NanodegreesTolerance);
            AssertEx.EqualTolerance(1, Angle.FromNanoradians(degree.Nanoradians).Degrees, NanoradiansTolerance);
            AssertEx.EqualTolerance(1, Angle.FromRadians(degree.Radians).Degrees, RadiansTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            Angle v = Angle.FromDegrees(1);
            AssertEx.EqualTolerance(-1, -v.Degrees, DegreesTolerance);
            AssertEx.EqualTolerance(2, (Angle.FromDegrees(3)-v).Degrees, DegreesTolerance);
            AssertEx.EqualTolerance(2, (v + v).Degrees, DegreesTolerance);
            AssertEx.EqualTolerance(10, (v*10).Degrees, DegreesTolerance);
            AssertEx.EqualTolerance(10, (10*v).Degrees, DegreesTolerance);
            AssertEx.EqualTolerance(2, (Angle.FromDegrees(10)/5).Degrees, DegreesTolerance);
            AssertEx.EqualTolerance(2, Angle.FromDegrees(10)/Angle.FromDegrees(5), DegreesTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            Angle oneDegree = Angle.FromDegrees(1);
            Angle twoDegrees = Angle.FromDegrees(2);

            Assert.True(oneDegree < twoDegrees);
            Assert.True(oneDegree <= twoDegrees);
            Assert.True(twoDegrees > oneDegree);
            Assert.True(twoDegrees >= oneDegree);

            Assert.False(oneDegree > twoDegrees);
            Assert.False(oneDegree >= twoDegrees);
            Assert.False(twoDegrees < oneDegree);
            Assert.False(twoDegrees <= oneDegree);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            Angle degree = Angle.FromDegrees(1);
            Assert.Equal(0, degree.CompareTo(degree));
            Assert.True(degree.CompareTo(Angle.Zero) > 0);
            Assert.True(Angle.Zero.CompareTo(degree) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            Angle degree = Angle.FromDegrees(1);
            Assert.Throws<ArgumentException>(() => degree.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            Angle degree = Angle.FromDegrees(1);
            Assert.Throws<ArgumentNullException>(() => degree.CompareTo(null));
        }


        [Fact]
        public void EqualityOperators()
        {
            Angle a = Angle.FromDegrees(1);
            Angle b = Angle.FromDegrees(2);

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
            Angle v = Angle.FromDegrees(1);
            Assert.True(v.Equals(Angle.FromDegrees(1)));
            Assert.False(v.Equals(Angle.Zero));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Angle degree = Angle.FromDegrees(1);
            Assert.False(degree.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            Angle degree = Angle.FromDegrees(1);
            Assert.False(degree.Equals(null));
        }
    }
}
