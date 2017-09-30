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
    /// Test of Volume.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class VolumeTestsBase
    {
        protected abstract double AuTablespoonsInOneCubicMeter { get; }
        protected abstract double CentilitersInOneCubicMeter { get; }
        protected abstract double CubicCentimetersInOneCubicMeter { get; }
        protected abstract double CubicDecimetersInOneCubicMeter { get; }
        protected abstract double CubicFeetInOneCubicMeter { get; }
        protected abstract double CubicInchesInOneCubicMeter { get; }
        protected abstract double CubicKilometersInOneCubicMeter { get; }
        protected abstract double CubicMetersInOneCubicMeter { get; }
        protected abstract double CubicMicrometersInOneCubicMeter { get; }
        protected abstract double CubicMilesInOneCubicMeter { get; }
        protected abstract double CubicMillimetersInOneCubicMeter { get; }
        protected abstract double CubicYardsInOneCubicMeter { get; }
        protected abstract double DecilitersInOneCubicMeter { get; }
        protected abstract double HectolitersInOneCubicMeter { get; }
        protected abstract double ImperialBeerBarrelsInOneCubicMeter { get; }
        protected abstract double ImperialGallonsInOneCubicMeter { get; }
        protected abstract double ImperialOuncesInOneCubicMeter { get; }
        protected abstract double LitersInOneCubicMeter { get; }
        protected abstract double MetricCupsInOneCubicMeter { get; }
        protected abstract double MetricTeaspoonsInOneCubicMeter { get; }
        protected abstract double MicrolitersInOneCubicMeter { get; }
        protected abstract double MillilitersInOneCubicMeter { get; }
        protected abstract double OilBarrelsInOneCubicMeter { get; }
        protected abstract double TablespoonsInOneCubicMeter { get; }
        protected abstract double TeaspoonsInOneCubicMeter { get; }
        protected abstract double UkTablespoonsInOneCubicMeter { get; }
        protected abstract double UsBeerBarrelsInOneCubicMeter { get; }
        protected abstract double UsCustomaryCupsInOneCubicMeter { get; }
        protected abstract double UsGallonsInOneCubicMeter { get; }
        protected abstract double UsLegalCupsInOneCubicMeter { get; }
        protected abstract double UsOuncesInOneCubicMeter { get; }
        protected abstract double UsTablespoonsInOneCubicMeter { get; }
        protected abstract double UsTeaspoonsInOneCubicMeter { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double AuTablespoonsTolerance { get { return 1e-5; } }
        protected virtual double CentilitersTolerance { get { return 1e-5; } }
        protected virtual double CubicCentimetersTolerance { get { return 1e-5; } }
        protected virtual double CubicDecimetersTolerance { get { return 1e-5; } }
        protected virtual double CubicFeetTolerance { get { return 1e-5; } }
        protected virtual double CubicInchesTolerance { get { return 1e-5; } }
        protected virtual double CubicKilometersTolerance { get { return 1e-5; } }
        protected virtual double CubicMetersTolerance { get { return 1e-5; } }
        protected virtual double CubicMicrometersTolerance { get { return 1e-5; } }
        protected virtual double CubicMilesTolerance { get { return 1e-5; } }
        protected virtual double CubicMillimetersTolerance { get { return 1e-5; } }
        protected virtual double CubicYardsTolerance { get { return 1e-5; } }
        protected virtual double DecilitersTolerance { get { return 1e-5; } }
        protected virtual double HectolitersTolerance { get { return 1e-5; } }
        protected virtual double ImperialBeerBarrelsTolerance { get { return 1e-5; } }
        protected virtual double ImperialGallonsTolerance { get { return 1e-5; } }
        protected virtual double ImperialOuncesTolerance { get { return 1e-5; } }
        protected virtual double LitersTolerance { get { return 1e-5; } }
        protected virtual double MetricCupsTolerance { get { return 1e-5; } }
        protected virtual double MetricTeaspoonsTolerance { get { return 1e-5; } }
        protected virtual double MicrolitersTolerance { get { return 1e-5; } }
        protected virtual double MillilitersTolerance { get { return 1e-5; } }
        protected virtual double OilBarrelsTolerance { get { return 1e-5; } }
        protected virtual double TablespoonsTolerance { get { return 1e-5; } }
        protected virtual double TeaspoonsTolerance { get { return 1e-5; } }
        protected virtual double UkTablespoonsTolerance { get { return 1e-5; } }
        protected virtual double UsBeerBarrelsTolerance { get { return 1e-5; } }
        protected virtual double UsCustomaryCupsTolerance { get { return 1e-5; } }
        protected virtual double UsGallonsTolerance { get { return 1e-5; } }
        protected virtual double UsLegalCupsTolerance { get { return 1e-5; } }
        protected virtual double UsOuncesTolerance { get { return 1e-5; } }
        protected virtual double UsTablespoonsTolerance { get { return 1e-5; } }
        protected virtual double UsTeaspoonsTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void CubicMeterToVolumeUnits()
        {
            Volume cubicmeter = Volume.FromCubicMeters(1);
            AssertEx.EqualTolerance(AuTablespoonsInOneCubicMeter, cubicmeter.AuTablespoons, AuTablespoonsTolerance);
            AssertEx.EqualTolerance(CentilitersInOneCubicMeter, cubicmeter.Centiliters, CentilitersTolerance);
            AssertEx.EqualTolerance(CubicCentimetersInOneCubicMeter, cubicmeter.CubicCentimeters, CubicCentimetersTolerance);
            AssertEx.EqualTolerance(CubicDecimetersInOneCubicMeter, cubicmeter.CubicDecimeters, CubicDecimetersTolerance);
            AssertEx.EqualTolerance(CubicFeetInOneCubicMeter, cubicmeter.CubicFeet, CubicFeetTolerance);
            AssertEx.EqualTolerance(CubicInchesInOneCubicMeter, cubicmeter.CubicInches, CubicInchesTolerance);
            AssertEx.EqualTolerance(CubicKilometersInOneCubicMeter, cubicmeter.CubicKilometers, CubicKilometersTolerance);
            AssertEx.EqualTolerance(CubicMetersInOneCubicMeter, cubicmeter.CubicMeters, CubicMetersTolerance);
            AssertEx.EqualTolerance(CubicMicrometersInOneCubicMeter, cubicmeter.CubicMicrometers, CubicMicrometersTolerance);
            AssertEx.EqualTolerance(CubicMilesInOneCubicMeter, cubicmeter.CubicMiles, CubicMilesTolerance);
            AssertEx.EqualTolerance(CubicMillimetersInOneCubicMeter, cubicmeter.CubicMillimeters, CubicMillimetersTolerance);
            AssertEx.EqualTolerance(CubicYardsInOneCubicMeter, cubicmeter.CubicYards, CubicYardsTolerance);
            AssertEx.EqualTolerance(DecilitersInOneCubicMeter, cubicmeter.Deciliters, DecilitersTolerance);
            AssertEx.EqualTolerance(HectolitersInOneCubicMeter, cubicmeter.Hectoliters, HectolitersTolerance);
            AssertEx.EqualTolerance(ImperialBeerBarrelsInOneCubicMeter, cubicmeter.ImperialBeerBarrels, ImperialBeerBarrelsTolerance);
            AssertEx.EqualTolerance(ImperialGallonsInOneCubicMeter, cubicmeter.ImperialGallons, ImperialGallonsTolerance);
            AssertEx.EqualTolerance(ImperialOuncesInOneCubicMeter, cubicmeter.ImperialOunces, ImperialOuncesTolerance);
            AssertEx.EqualTolerance(LitersInOneCubicMeter, cubicmeter.Liters, LitersTolerance);
            AssertEx.EqualTolerance(MetricCupsInOneCubicMeter, cubicmeter.MetricCups, MetricCupsTolerance);
            AssertEx.EqualTolerance(MetricTeaspoonsInOneCubicMeter, cubicmeter.MetricTeaspoons, MetricTeaspoonsTolerance);
            AssertEx.EqualTolerance(MicrolitersInOneCubicMeter, cubicmeter.Microliters, MicrolitersTolerance);
            AssertEx.EqualTolerance(MillilitersInOneCubicMeter, cubicmeter.Milliliters, MillilitersTolerance);
            AssertEx.EqualTolerance(OilBarrelsInOneCubicMeter, cubicmeter.OilBarrels, OilBarrelsTolerance);
            AssertEx.EqualTolerance(TablespoonsInOneCubicMeter, cubicmeter.Tablespoons, TablespoonsTolerance);
            AssertEx.EqualTolerance(TeaspoonsInOneCubicMeter, cubicmeter.Teaspoons, TeaspoonsTolerance);
            AssertEx.EqualTolerance(UkTablespoonsInOneCubicMeter, cubicmeter.UkTablespoons, UkTablespoonsTolerance);
            AssertEx.EqualTolerance(UsBeerBarrelsInOneCubicMeter, cubicmeter.UsBeerBarrels, UsBeerBarrelsTolerance);
            AssertEx.EqualTolerance(UsCustomaryCupsInOneCubicMeter, cubicmeter.UsCustomaryCups, UsCustomaryCupsTolerance);
            AssertEx.EqualTolerance(UsGallonsInOneCubicMeter, cubicmeter.UsGallons, UsGallonsTolerance);
            AssertEx.EqualTolerance(UsLegalCupsInOneCubicMeter, cubicmeter.UsLegalCups, UsLegalCupsTolerance);
            AssertEx.EqualTolerance(UsOuncesInOneCubicMeter, cubicmeter.UsOunces, UsOuncesTolerance);
            AssertEx.EqualTolerance(UsTablespoonsInOneCubicMeter, cubicmeter.UsTablespoons, UsTablespoonsTolerance);
            AssertEx.EqualTolerance(UsTeaspoonsInOneCubicMeter, cubicmeter.UsTeaspoons, UsTeaspoonsTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, Volume.From(1, VolumeUnit.AuTablespoon).AuTablespoons, AuTablespoonsTolerance);
            AssertEx.EqualTolerance(1, Volume.From(1, VolumeUnit.Centiliter).Centiliters, CentilitersTolerance);
            AssertEx.EqualTolerance(1, Volume.From(1, VolumeUnit.CubicCentimeter).CubicCentimeters, CubicCentimetersTolerance);
            AssertEx.EqualTolerance(1, Volume.From(1, VolumeUnit.CubicDecimeter).CubicDecimeters, CubicDecimetersTolerance);
            AssertEx.EqualTolerance(1, Volume.From(1, VolumeUnit.CubicFoot).CubicFeet, CubicFeetTolerance);
            AssertEx.EqualTolerance(1, Volume.From(1, VolumeUnit.CubicInch).CubicInches, CubicInchesTolerance);
            AssertEx.EqualTolerance(1, Volume.From(1, VolumeUnit.CubicKilometer).CubicKilometers, CubicKilometersTolerance);
            AssertEx.EqualTolerance(1, Volume.From(1, VolumeUnit.CubicMeter).CubicMeters, CubicMetersTolerance);
            AssertEx.EqualTolerance(1, Volume.From(1, VolumeUnit.CubicMicrometer).CubicMicrometers, CubicMicrometersTolerance);
            AssertEx.EqualTolerance(1, Volume.From(1, VolumeUnit.CubicMile).CubicMiles, CubicMilesTolerance);
            AssertEx.EqualTolerance(1, Volume.From(1, VolumeUnit.CubicMillimeter).CubicMillimeters, CubicMillimetersTolerance);
            AssertEx.EqualTolerance(1, Volume.From(1, VolumeUnit.CubicYard).CubicYards, CubicYardsTolerance);
            AssertEx.EqualTolerance(1, Volume.From(1, VolumeUnit.Deciliter).Deciliters, DecilitersTolerance);
            AssertEx.EqualTolerance(1, Volume.From(1, VolumeUnit.Hectoliter).Hectoliters, HectolitersTolerance);
            AssertEx.EqualTolerance(1, Volume.From(1, VolumeUnit.ImperialBeerBarrel).ImperialBeerBarrels, ImperialBeerBarrelsTolerance);
            AssertEx.EqualTolerance(1, Volume.From(1, VolumeUnit.ImperialGallon).ImperialGallons, ImperialGallonsTolerance);
            AssertEx.EqualTolerance(1, Volume.From(1, VolumeUnit.ImperialOunce).ImperialOunces, ImperialOuncesTolerance);
            AssertEx.EqualTolerance(1, Volume.From(1, VolumeUnit.Liter).Liters, LitersTolerance);
            AssertEx.EqualTolerance(1, Volume.From(1, VolumeUnit.MetricCup).MetricCups, MetricCupsTolerance);
            AssertEx.EqualTolerance(1, Volume.From(1, VolumeUnit.MetricTeaspoon).MetricTeaspoons, MetricTeaspoonsTolerance);
            AssertEx.EqualTolerance(1, Volume.From(1, VolumeUnit.Microliter).Microliters, MicrolitersTolerance);
            AssertEx.EqualTolerance(1, Volume.From(1, VolumeUnit.Milliliter).Milliliters, MillilitersTolerance);
            AssertEx.EqualTolerance(1, Volume.From(1, VolumeUnit.OilBarrel).OilBarrels, OilBarrelsTolerance);
            AssertEx.EqualTolerance(1, Volume.From(1, VolumeUnit.Tablespoon).Tablespoons, TablespoonsTolerance);
            AssertEx.EqualTolerance(1, Volume.From(1, VolumeUnit.Teaspoon).Teaspoons, TeaspoonsTolerance);
            AssertEx.EqualTolerance(1, Volume.From(1, VolumeUnit.UkTablespoon).UkTablespoons, UkTablespoonsTolerance);
            AssertEx.EqualTolerance(1, Volume.From(1, VolumeUnit.UsBeerBarrel).UsBeerBarrels, UsBeerBarrelsTolerance);
            AssertEx.EqualTolerance(1, Volume.From(1, VolumeUnit.UsCustomaryCup).UsCustomaryCups, UsCustomaryCupsTolerance);
            AssertEx.EqualTolerance(1, Volume.From(1, VolumeUnit.UsGallon).UsGallons, UsGallonsTolerance);
            AssertEx.EqualTolerance(1, Volume.From(1, VolumeUnit.UsLegalCup).UsLegalCups, UsLegalCupsTolerance);
            AssertEx.EqualTolerance(1, Volume.From(1, VolumeUnit.UsOunce).UsOunces, UsOuncesTolerance);
            AssertEx.EqualTolerance(1, Volume.From(1, VolumeUnit.UsTablespoon).UsTablespoons, UsTablespoonsTolerance);
            AssertEx.EqualTolerance(1, Volume.From(1, VolumeUnit.UsTeaspoon).UsTeaspoons, UsTeaspoonsTolerance);
        }

        [Fact]
        public void As()
        {
            var cubicmeter = Volume.FromCubicMeters(1);
            AssertEx.EqualTolerance(AuTablespoonsInOneCubicMeter, cubicmeter.As(VolumeUnit.AuTablespoon), AuTablespoonsTolerance);
            AssertEx.EqualTolerance(CentilitersInOneCubicMeter, cubicmeter.As(VolumeUnit.Centiliter), CentilitersTolerance);
            AssertEx.EqualTolerance(CubicCentimetersInOneCubicMeter, cubicmeter.As(VolumeUnit.CubicCentimeter), CubicCentimetersTolerance);
            AssertEx.EqualTolerance(CubicDecimetersInOneCubicMeter, cubicmeter.As(VolumeUnit.CubicDecimeter), CubicDecimetersTolerance);
            AssertEx.EqualTolerance(CubicFeetInOneCubicMeter, cubicmeter.As(VolumeUnit.CubicFoot), CubicFeetTolerance);
            AssertEx.EqualTolerance(CubicInchesInOneCubicMeter, cubicmeter.As(VolumeUnit.CubicInch), CubicInchesTolerance);
            AssertEx.EqualTolerance(CubicKilometersInOneCubicMeter, cubicmeter.As(VolumeUnit.CubicKilometer), CubicKilometersTolerance);
            AssertEx.EqualTolerance(CubicMetersInOneCubicMeter, cubicmeter.As(VolumeUnit.CubicMeter), CubicMetersTolerance);
            AssertEx.EqualTolerance(CubicMicrometersInOneCubicMeter, cubicmeter.As(VolumeUnit.CubicMicrometer), CubicMicrometersTolerance);
            AssertEx.EqualTolerance(CubicMilesInOneCubicMeter, cubicmeter.As(VolumeUnit.CubicMile), CubicMilesTolerance);
            AssertEx.EqualTolerance(CubicMillimetersInOneCubicMeter, cubicmeter.As(VolumeUnit.CubicMillimeter), CubicMillimetersTolerance);
            AssertEx.EqualTolerance(CubicYardsInOneCubicMeter, cubicmeter.As(VolumeUnit.CubicYard), CubicYardsTolerance);
            AssertEx.EqualTolerance(DecilitersInOneCubicMeter, cubicmeter.As(VolumeUnit.Deciliter), DecilitersTolerance);
            AssertEx.EqualTolerance(HectolitersInOneCubicMeter, cubicmeter.As(VolumeUnit.Hectoliter), HectolitersTolerance);
            AssertEx.EqualTolerance(ImperialBeerBarrelsInOneCubicMeter, cubicmeter.As(VolumeUnit.ImperialBeerBarrel), ImperialBeerBarrelsTolerance);
            AssertEx.EqualTolerance(ImperialGallonsInOneCubicMeter, cubicmeter.As(VolumeUnit.ImperialGallon), ImperialGallonsTolerance);
            AssertEx.EqualTolerance(ImperialOuncesInOneCubicMeter, cubicmeter.As(VolumeUnit.ImperialOunce), ImperialOuncesTolerance);
            AssertEx.EqualTolerance(LitersInOneCubicMeter, cubicmeter.As(VolumeUnit.Liter), LitersTolerance);
            AssertEx.EqualTolerance(MetricCupsInOneCubicMeter, cubicmeter.As(VolumeUnit.MetricCup), MetricCupsTolerance);
            AssertEx.EqualTolerance(MetricTeaspoonsInOneCubicMeter, cubicmeter.As(VolumeUnit.MetricTeaspoon), MetricTeaspoonsTolerance);
            AssertEx.EqualTolerance(MicrolitersInOneCubicMeter, cubicmeter.As(VolumeUnit.Microliter), MicrolitersTolerance);
            AssertEx.EqualTolerance(MillilitersInOneCubicMeter, cubicmeter.As(VolumeUnit.Milliliter), MillilitersTolerance);
            AssertEx.EqualTolerance(OilBarrelsInOneCubicMeter, cubicmeter.As(VolumeUnit.OilBarrel), OilBarrelsTolerance);
            AssertEx.EqualTolerance(TablespoonsInOneCubicMeter, cubicmeter.As(VolumeUnit.Tablespoon), TablespoonsTolerance);
            AssertEx.EqualTolerance(TeaspoonsInOneCubicMeter, cubicmeter.As(VolumeUnit.Teaspoon), TeaspoonsTolerance);
            AssertEx.EqualTolerance(UkTablespoonsInOneCubicMeter, cubicmeter.As(VolumeUnit.UkTablespoon), UkTablespoonsTolerance);
            AssertEx.EqualTolerance(UsBeerBarrelsInOneCubicMeter, cubicmeter.As(VolumeUnit.UsBeerBarrel), UsBeerBarrelsTolerance);
            AssertEx.EqualTolerance(UsCustomaryCupsInOneCubicMeter, cubicmeter.As(VolumeUnit.UsCustomaryCup), UsCustomaryCupsTolerance);
            AssertEx.EqualTolerance(UsGallonsInOneCubicMeter, cubicmeter.As(VolumeUnit.UsGallon), UsGallonsTolerance);
            AssertEx.EqualTolerance(UsLegalCupsInOneCubicMeter, cubicmeter.As(VolumeUnit.UsLegalCup), UsLegalCupsTolerance);
            AssertEx.EqualTolerance(UsOuncesInOneCubicMeter, cubicmeter.As(VolumeUnit.UsOunce), UsOuncesTolerance);
            AssertEx.EqualTolerance(UsTablespoonsInOneCubicMeter, cubicmeter.As(VolumeUnit.UsTablespoon), UsTablespoonsTolerance);
            AssertEx.EqualTolerance(UsTeaspoonsInOneCubicMeter, cubicmeter.As(VolumeUnit.UsTeaspoon), UsTeaspoonsTolerance);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            Volume cubicmeter = Volume.FromCubicMeters(1);
            AssertEx.EqualTolerance(1, Volume.FromAuTablespoons(cubicmeter.AuTablespoons).CubicMeters, AuTablespoonsTolerance);
            AssertEx.EqualTolerance(1, Volume.FromCentiliters(cubicmeter.Centiliters).CubicMeters, CentilitersTolerance);
            AssertEx.EqualTolerance(1, Volume.FromCubicCentimeters(cubicmeter.CubicCentimeters).CubicMeters, CubicCentimetersTolerance);
            AssertEx.EqualTolerance(1, Volume.FromCubicDecimeters(cubicmeter.CubicDecimeters).CubicMeters, CubicDecimetersTolerance);
            AssertEx.EqualTolerance(1, Volume.FromCubicFeet(cubicmeter.CubicFeet).CubicMeters, CubicFeetTolerance);
            AssertEx.EqualTolerance(1, Volume.FromCubicInches(cubicmeter.CubicInches).CubicMeters, CubicInchesTolerance);
            AssertEx.EqualTolerance(1, Volume.FromCubicKilometers(cubicmeter.CubicKilometers).CubicMeters, CubicKilometersTolerance);
            AssertEx.EqualTolerance(1, Volume.FromCubicMeters(cubicmeter.CubicMeters).CubicMeters, CubicMetersTolerance);
            AssertEx.EqualTolerance(1, Volume.FromCubicMicrometers(cubicmeter.CubicMicrometers).CubicMeters, CubicMicrometersTolerance);
            AssertEx.EqualTolerance(1, Volume.FromCubicMiles(cubicmeter.CubicMiles).CubicMeters, CubicMilesTolerance);
            AssertEx.EqualTolerance(1, Volume.FromCubicMillimeters(cubicmeter.CubicMillimeters).CubicMeters, CubicMillimetersTolerance);
            AssertEx.EqualTolerance(1, Volume.FromCubicYards(cubicmeter.CubicYards).CubicMeters, CubicYardsTolerance);
            AssertEx.EqualTolerance(1, Volume.FromDeciliters(cubicmeter.Deciliters).CubicMeters, DecilitersTolerance);
            AssertEx.EqualTolerance(1, Volume.FromHectoliters(cubicmeter.Hectoliters).CubicMeters, HectolitersTolerance);
            AssertEx.EqualTolerance(1, Volume.FromImperialBeerBarrels(cubicmeter.ImperialBeerBarrels).CubicMeters, ImperialBeerBarrelsTolerance);
            AssertEx.EqualTolerance(1, Volume.FromImperialGallons(cubicmeter.ImperialGallons).CubicMeters, ImperialGallonsTolerance);
            AssertEx.EqualTolerance(1, Volume.FromImperialOunces(cubicmeter.ImperialOunces).CubicMeters, ImperialOuncesTolerance);
            AssertEx.EqualTolerance(1, Volume.FromLiters(cubicmeter.Liters).CubicMeters, LitersTolerance);
            AssertEx.EqualTolerance(1, Volume.FromMetricCups(cubicmeter.MetricCups).CubicMeters, MetricCupsTolerance);
            AssertEx.EqualTolerance(1, Volume.FromMetricTeaspoons(cubicmeter.MetricTeaspoons).CubicMeters, MetricTeaspoonsTolerance);
            AssertEx.EqualTolerance(1, Volume.FromMicroliters(cubicmeter.Microliters).CubicMeters, MicrolitersTolerance);
            AssertEx.EqualTolerance(1, Volume.FromMilliliters(cubicmeter.Milliliters).CubicMeters, MillilitersTolerance);
            AssertEx.EqualTolerance(1, Volume.FromOilBarrels(cubicmeter.OilBarrels).CubicMeters, OilBarrelsTolerance);
            AssertEx.EqualTolerance(1, Volume.FromTablespoons(cubicmeter.Tablespoons).CubicMeters, TablespoonsTolerance);
            AssertEx.EqualTolerance(1, Volume.FromTeaspoons(cubicmeter.Teaspoons).CubicMeters, TeaspoonsTolerance);
            AssertEx.EqualTolerance(1, Volume.FromUkTablespoons(cubicmeter.UkTablespoons).CubicMeters, UkTablespoonsTolerance);
            AssertEx.EqualTolerance(1, Volume.FromUsBeerBarrels(cubicmeter.UsBeerBarrels).CubicMeters, UsBeerBarrelsTolerance);
            AssertEx.EqualTolerance(1, Volume.FromUsCustomaryCups(cubicmeter.UsCustomaryCups).CubicMeters, UsCustomaryCupsTolerance);
            AssertEx.EqualTolerance(1, Volume.FromUsGallons(cubicmeter.UsGallons).CubicMeters, UsGallonsTolerance);
            AssertEx.EqualTolerance(1, Volume.FromUsLegalCups(cubicmeter.UsLegalCups).CubicMeters, UsLegalCupsTolerance);
            AssertEx.EqualTolerance(1, Volume.FromUsOunces(cubicmeter.UsOunces).CubicMeters, UsOuncesTolerance);
            AssertEx.EqualTolerance(1, Volume.FromUsTablespoons(cubicmeter.UsTablespoons).CubicMeters, UsTablespoonsTolerance);
            AssertEx.EqualTolerance(1, Volume.FromUsTeaspoons(cubicmeter.UsTeaspoons).CubicMeters, UsTeaspoonsTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            Volume v = Volume.FromCubicMeters(1);
            AssertEx.EqualTolerance(-1, -v.CubicMeters, CubicMetersTolerance);
            AssertEx.EqualTolerance(2, (Volume.FromCubicMeters(3)-v).CubicMeters, CubicMetersTolerance);
            AssertEx.EqualTolerance(2, (v + v).CubicMeters, CubicMetersTolerance);
            AssertEx.EqualTolerance(10, (v*10).CubicMeters, CubicMetersTolerance);
            AssertEx.EqualTolerance(10, (10*v).CubicMeters, CubicMetersTolerance);
            AssertEx.EqualTolerance(2, (Volume.FromCubicMeters(10)/5).CubicMeters, CubicMetersTolerance);
            AssertEx.EqualTolerance(2, Volume.FromCubicMeters(10)/Volume.FromCubicMeters(5), CubicMetersTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            Volume oneCubicMeter = Volume.FromCubicMeters(1);
            Volume twoCubicMeters = Volume.FromCubicMeters(2);

            Assert.True(oneCubicMeter < twoCubicMeters);
            Assert.True(oneCubicMeter <= twoCubicMeters);
            Assert.True(twoCubicMeters > oneCubicMeter);
            Assert.True(twoCubicMeters >= oneCubicMeter);

            Assert.False(oneCubicMeter > twoCubicMeters);
            Assert.False(oneCubicMeter >= twoCubicMeters);
            Assert.False(twoCubicMeters < oneCubicMeter);
            Assert.False(twoCubicMeters <= oneCubicMeter);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            Volume cubicmeter = Volume.FromCubicMeters(1);
            Assert.Equal(0, cubicmeter.CompareTo(cubicmeter));
            Assert.True(cubicmeter.CompareTo(Volume.Zero) > 0);
            Assert.True(Volume.Zero.CompareTo(cubicmeter) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            Volume cubicmeter = Volume.FromCubicMeters(1);
            Assert.Throws<ArgumentException>(() => cubicmeter.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            Volume cubicmeter = Volume.FromCubicMeters(1);
            Assert.Throws<ArgumentNullException>(() => cubicmeter.CompareTo(null));
        }


        [Fact]
        public void EqualityOperators()
        {
            Volume a = Volume.FromCubicMeters(1);
            Volume b = Volume.FromCubicMeters(2);

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
            Volume v = Volume.FromCubicMeters(1);
            Assert.True(v.Equals(Volume.FromCubicMeters(1)));
            Assert.False(v.Equals(Volume.Zero));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Volume cubicmeter = Volume.FromCubicMeters(1);
            Assert.False(cubicmeter.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            Volume cubicmeter = Volume.FromCubicMeters(1);
            Assert.False(cubicmeter.Equals(null));
        }
    }
}
