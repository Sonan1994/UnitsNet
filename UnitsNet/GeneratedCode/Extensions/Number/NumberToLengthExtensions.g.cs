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

// Windows Runtime Component does not support extension methods and method overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
namespace UnitsNet.Extensions.NumberToLength
{
    public static class NumberToLengthExtensions
    {
        #region Centimeter

        /// <inheritdoc cref="Length.FromCentimeters(double)"/>
        public static Length Centimeters(this int value) => Length.FromCentimeters(value);

        /// <inheritdoc cref="Length.FromCentimeters(double?)"/>
        public static Length? Centimeters(this int? value) => Length.FromCentimeters(value);

        /// <inheritdoc cref="Length.FromCentimeters(double)"/>
        public static Length Centimeters(this long value) => Length.FromCentimeters(value);

        /// <inheritdoc cref="Length.FromCentimeters(double?)"/>
        public static Length? Centimeters(this long? value) => Length.FromCentimeters(value);

        /// <inheritdoc cref="Length.FromCentimeters(double)"/>
        public static Length Centimeters(this double value) => Length.FromCentimeters(value);

        /// <inheritdoc cref="Length.FromCentimeters(double?)"/>
        public static Length? Centimeters(this double? value) => Length.FromCentimeters(value);

        /// <inheritdoc cref="Length.FromCentimeters(double)"/>
        public static Length Centimeters(this float value) => Length.FromCentimeters(value);

        /// <inheritdoc cref="Length.FromCentimeters(double?)"/>
        public static Length? Centimeters(this float? value) => Length.FromCentimeters(value);

        /// <inheritdoc cref="Length.FromCentimeters(double)"/>
        public static Length Centimeters(this decimal value) => Length.FromCentimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="Length.FromCentimeters(double?)"/>
        public static Length? Centimeters(this decimal? value) => Length.FromCentimeters(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Decimeter

        /// <inheritdoc cref="Length.FromDecimeters(double)"/>
        public static Length Decimeters(this int value) => Length.FromDecimeters(value);

        /// <inheritdoc cref="Length.FromDecimeters(double?)"/>
        public static Length? Decimeters(this int? value) => Length.FromDecimeters(value);

        /// <inheritdoc cref="Length.FromDecimeters(double)"/>
        public static Length Decimeters(this long value) => Length.FromDecimeters(value);

        /// <inheritdoc cref="Length.FromDecimeters(double?)"/>
        public static Length? Decimeters(this long? value) => Length.FromDecimeters(value);

        /// <inheritdoc cref="Length.FromDecimeters(double)"/>
        public static Length Decimeters(this double value) => Length.FromDecimeters(value);

        /// <inheritdoc cref="Length.FromDecimeters(double?)"/>
        public static Length? Decimeters(this double? value) => Length.FromDecimeters(value);

        /// <inheritdoc cref="Length.FromDecimeters(double)"/>
        public static Length Decimeters(this float value) => Length.FromDecimeters(value);

        /// <inheritdoc cref="Length.FromDecimeters(double?)"/>
        public static Length? Decimeters(this float? value) => Length.FromDecimeters(value);

        /// <inheritdoc cref="Length.FromDecimeters(double)"/>
        public static Length Decimeters(this decimal value) => Length.FromDecimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="Length.FromDecimeters(double?)"/>
        public static Length? Decimeters(this decimal? value) => Length.FromDecimeters(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region DtpPica

        /// <inheritdoc cref="Length.FromDtpPicas(double)"/>
        public static Length DtpPicas(this int value) => Length.FromDtpPicas(value);

        /// <inheritdoc cref="Length.FromDtpPicas(double?)"/>
        public static Length? DtpPicas(this int? value) => Length.FromDtpPicas(value);

        /// <inheritdoc cref="Length.FromDtpPicas(double)"/>
        public static Length DtpPicas(this long value) => Length.FromDtpPicas(value);

        /// <inheritdoc cref="Length.FromDtpPicas(double?)"/>
        public static Length? DtpPicas(this long? value) => Length.FromDtpPicas(value);

        /// <inheritdoc cref="Length.FromDtpPicas(double)"/>
        public static Length DtpPicas(this double value) => Length.FromDtpPicas(value);

        /// <inheritdoc cref="Length.FromDtpPicas(double?)"/>
        public static Length? DtpPicas(this double? value) => Length.FromDtpPicas(value);

        /// <inheritdoc cref="Length.FromDtpPicas(double)"/>
        public static Length DtpPicas(this float value) => Length.FromDtpPicas(value);

        /// <inheritdoc cref="Length.FromDtpPicas(double?)"/>
        public static Length? DtpPicas(this float? value) => Length.FromDtpPicas(value);

        /// <inheritdoc cref="Length.FromDtpPicas(double)"/>
        public static Length DtpPicas(this decimal value) => Length.FromDtpPicas(Convert.ToDouble(value));

        /// <inheritdoc cref="Length.FromDtpPicas(double?)"/>
        public static Length? DtpPicas(this decimal? value) => Length.FromDtpPicas(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region DtpPoint

        /// <inheritdoc cref="Length.FromDtpPoints(double)"/>
        public static Length DtpPoints(this int value) => Length.FromDtpPoints(value);

        /// <inheritdoc cref="Length.FromDtpPoints(double?)"/>
        public static Length? DtpPoints(this int? value) => Length.FromDtpPoints(value);

        /// <inheritdoc cref="Length.FromDtpPoints(double)"/>
        public static Length DtpPoints(this long value) => Length.FromDtpPoints(value);

        /// <inheritdoc cref="Length.FromDtpPoints(double?)"/>
        public static Length? DtpPoints(this long? value) => Length.FromDtpPoints(value);

        /// <inheritdoc cref="Length.FromDtpPoints(double)"/>
        public static Length DtpPoints(this double value) => Length.FromDtpPoints(value);

        /// <inheritdoc cref="Length.FromDtpPoints(double?)"/>
        public static Length? DtpPoints(this double? value) => Length.FromDtpPoints(value);

        /// <inheritdoc cref="Length.FromDtpPoints(double)"/>
        public static Length DtpPoints(this float value) => Length.FromDtpPoints(value);

        /// <inheritdoc cref="Length.FromDtpPoints(double?)"/>
        public static Length? DtpPoints(this float? value) => Length.FromDtpPoints(value);

        /// <inheritdoc cref="Length.FromDtpPoints(double)"/>
        public static Length DtpPoints(this decimal value) => Length.FromDtpPoints(Convert.ToDouble(value));

        /// <inheritdoc cref="Length.FromDtpPoints(double?)"/>
        public static Length? DtpPoints(this decimal? value) => Length.FromDtpPoints(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Fathom

        /// <inheritdoc cref="Length.FromFathoms(double)"/>
        public static Length Fathoms(this int value) => Length.FromFathoms(value);

        /// <inheritdoc cref="Length.FromFathoms(double?)"/>
        public static Length? Fathoms(this int? value) => Length.FromFathoms(value);

        /// <inheritdoc cref="Length.FromFathoms(double)"/>
        public static Length Fathoms(this long value) => Length.FromFathoms(value);

        /// <inheritdoc cref="Length.FromFathoms(double?)"/>
        public static Length? Fathoms(this long? value) => Length.FromFathoms(value);

        /// <inheritdoc cref="Length.FromFathoms(double)"/>
        public static Length Fathoms(this double value) => Length.FromFathoms(value);

        /// <inheritdoc cref="Length.FromFathoms(double?)"/>
        public static Length? Fathoms(this double? value) => Length.FromFathoms(value);

        /// <inheritdoc cref="Length.FromFathoms(double)"/>
        public static Length Fathoms(this float value) => Length.FromFathoms(value);

        /// <inheritdoc cref="Length.FromFathoms(double?)"/>
        public static Length? Fathoms(this float? value) => Length.FromFathoms(value);

        /// <inheritdoc cref="Length.FromFathoms(double)"/>
        public static Length Fathoms(this decimal value) => Length.FromFathoms(Convert.ToDouble(value));

        /// <inheritdoc cref="Length.FromFathoms(double?)"/>
        public static Length? Fathoms(this decimal? value) => Length.FromFathoms(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Foot

        /// <inheritdoc cref="Length.FromFeet(double)"/>
        public static Length Feet(this int value) => Length.FromFeet(value);

        /// <inheritdoc cref="Length.FromFeet(double?)"/>
        public static Length? Feet(this int? value) => Length.FromFeet(value);

        /// <inheritdoc cref="Length.FromFeet(double)"/>
        public static Length Feet(this long value) => Length.FromFeet(value);

        /// <inheritdoc cref="Length.FromFeet(double?)"/>
        public static Length? Feet(this long? value) => Length.FromFeet(value);

        /// <inheritdoc cref="Length.FromFeet(double)"/>
        public static Length Feet(this double value) => Length.FromFeet(value);

        /// <inheritdoc cref="Length.FromFeet(double?)"/>
        public static Length? Feet(this double? value) => Length.FromFeet(value);

        /// <inheritdoc cref="Length.FromFeet(double)"/>
        public static Length Feet(this float value) => Length.FromFeet(value);

        /// <inheritdoc cref="Length.FromFeet(double?)"/>
        public static Length? Feet(this float? value) => Length.FromFeet(value);

        /// <inheritdoc cref="Length.FromFeet(double)"/>
        public static Length Feet(this decimal value) => Length.FromFeet(Convert.ToDouble(value));

        /// <inheritdoc cref="Length.FromFeet(double?)"/>
        public static Length? Feet(this decimal? value) => Length.FromFeet(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Inch

        /// <inheritdoc cref="Length.FromInches(double)"/>
        public static Length Inches(this int value) => Length.FromInches(value);

        /// <inheritdoc cref="Length.FromInches(double?)"/>
        public static Length? Inches(this int? value) => Length.FromInches(value);

        /// <inheritdoc cref="Length.FromInches(double)"/>
        public static Length Inches(this long value) => Length.FromInches(value);

        /// <inheritdoc cref="Length.FromInches(double?)"/>
        public static Length? Inches(this long? value) => Length.FromInches(value);

        /// <inheritdoc cref="Length.FromInches(double)"/>
        public static Length Inches(this double value) => Length.FromInches(value);

        /// <inheritdoc cref="Length.FromInches(double?)"/>
        public static Length? Inches(this double? value) => Length.FromInches(value);

        /// <inheritdoc cref="Length.FromInches(double)"/>
        public static Length Inches(this float value) => Length.FromInches(value);

        /// <inheritdoc cref="Length.FromInches(double?)"/>
        public static Length? Inches(this float? value) => Length.FromInches(value);

        /// <inheritdoc cref="Length.FromInches(double)"/>
        public static Length Inches(this decimal value) => Length.FromInches(Convert.ToDouble(value));

        /// <inheritdoc cref="Length.FromInches(double?)"/>
        public static Length? Inches(this decimal? value) => Length.FromInches(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Kilometer

        /// <inheritdoc cref="Length.FromKilometers(double)"/>
        public static Length Kilometers(this int value) => Length.FromKilometers(value);

        /// <inheritdoc cref="Length.FromKilometers(double?)"/>
        public static Length? Kilometers(this int? value) => Length.FromKilometers(value);

        /// <inheritdoc cref="Length.FromKilometers(double)"/>
        public static Length Kilometers(this long value) => Length.FromKilometers(value);

        /// <inheritdoc cref="Length.FromKilometers(double?)"/>
        public static Length? Kilometers(this long? value) => Length.FromKilometers(value);

        /// <inheritdoc cref="Length.FromKilometers(double)"/>
        public static Length Kilometers(this double value) => Length.FromKilometers(value);

        /// <inheritdoc cref="Length.FromKilometers(double?)"/>
        public static Length? Kilometers(this double? value) => Length.FromKilometers(value);

        /// <inheritdoc cref="Length.FromKilometers(double)"/>
        public static Length Kilometers(this float value) => Length.FromKilometers(value);

        /// <inheritdoc cref="Length.FromKilometers(double?)"/>
        public static Length? Kilometers(this float? value) => Length.FromKilometers(value);

        /// <inheritdoc cref="Length.FromKilometers(double)"/>
        public static Length Kilometers(this decimal value) => Length.FromKilometers(Convert.ToDouble(value));

        /// <inheritdoc cref="Length.FromKilometers(double?)"/>
        public static Length? Kilometers(this decimal? value) => Length.FromKilometers(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Meter

        /// <inheritdoc cref="Length.FromMeters(double)"/>
        public static Length Meters(this int value) => Length.FromMeters(value);

        /// <inheritdoc cref="Length.FromMeters(double?)"/>
        public static Length? Meters(this int? value) => Length.FromMeters(value);

        /// <inheritdoc cref="Length.FromMeters(double)"/>
        public static Length Meters(this long value) => Length.FromMeters(value);

        /// <inheritdoc cref="Length.FromMeters(double?)"/>
        public static Length? Meters(this long? value) => Length.FromMeters(value);

        /// <inheritdoc cref="Length.FromMeters(double)"/>
        public static Length Meters(this double value) => Length.FromMeters(value);

        /// <inheritdoc cref="Length.FromMeters(double?)"/>
        public static Length? Meters(this double? value) => Length.FromMeters(value);

        /// <inheritdoc cref="Length.FromMeters(double)"/>
        public static Length Meters(this float value) => Length.FromMeters(value);

        /// <inheritdoc cref="Length.FromMeters(double?)"/>
        public static Length? Meters(this float? value) => Length.FromMeters(value);

        /// <inheritdoc cref="Length.FromMeters(double)"/>
        public static Length Meters(this decimal value) => Length.FromMeters(Convert.ToDouble(value));

        /// <inheritdoc cref="Length.FromMeters(double?)"/>
        public static Length? Meters(this decimal? value) => Length.FromMeters(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Microinch

        /// <inheritdoc cref="Length.FromMicroinches(double)"/>
        public static Length Microinches(this int value) => Length.FromMicroinches(value);

        /// <inheritdoc cref="Length.FromMicroinches(double?)"/>
        public static Length? Microinches(this int? value) => Length.FromMicroinches(value);

        /// <inheritdoc cref="Length.FromMicroinches(double)"/>
        public static Length Microinches(this long value) => Length.FromMicroinches(value);

        /// <inheritdoc cref="Length.FromMicroinches(double?)"/>
        public static Length? Microinches(this long? value) => Length.FromMicroinches(value);

        /// <inheritdoc cref="Length.FromMicroinches(double)"/>
        public static Length Microinches(this double value) => Length.FromMicroinches(value);

        /// <inheritdoc cref="Length.FromMicroinches(double?)"/>
        public static Length? Microinches(this double? value) => Length.FromMicroinches(value);

        /// <inheritdoc cref="Length.FromMicroinches(double)"/>
        public static Length Microinches(this float value) => Length.FromMicroinches(value);

        /// <inheritdoc cref="Length.FromMicroinches(double?)"/>
        public static Length? Microinches(this float? value) => Length.FromMicroinches(value);

        /// <inheritdoc cref="Length.FromMicroinches(double)"/>
        public static Length Microinches(this decimal value) => Length.FromMicroinches(Convert.ToDouble(value));

        /// <inheritdoc cref="Length.FromMicroinches(double?)"/>
        public static Length? Microinches(this decimal? value) => Length.FromMicroinches(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Micrometer

        /// <inheritdoc cref="Length.FromMicrometers(double)"/>
        public static Length Micrometers(this int value) => Length.FromMicrometers(value);

        /// <inheritdoc cref="Length.FromMicrometers(double?)"/>
        public static Length? Micrometers(this int? value) => Length.FromMicrometers(value);

        /// <inheritdoc cref="Length.FromMicrometers(double)"/>
        public static Length Micrometers(this long value) => Length.FromMicrometers(value);

        /// <inheritdoc cref="Length.FromMicrometers(double?)"/>
        public static Length? Micrometers(this long? value) => Length.FromMicrometers(value);

        /// <inheritdoc cref="Length.FromMicrometers(double)"/>
        public static Length Micrometers(this double value) => Length.FromMicrometers(value);

        /// <inheritdoc cref="Length.FromMicrometers(double?)"/>
        public static Length? Micrometers(this double? value) => Length.FromMicrometers(value);

        /// <inheritdoc cref="Length.FromMicrometers(double)"/>
        public static Length Micrometers(this float value) => Length.FromMicrometers(value);

        /// <inheritdoc cref="Length.FromMicrometers(double?)"/>
        public static Length? Micrometers(this float? value) => Length.FromMicrometers(value);

        /// <inheritdoc cref="Length.FromMicrometers(double)"/>
        public static Length Micrometers(this decimal value) => Length.FromMicrometers(Convert.ToDouble(value));

        /// <inheritdoc cref="Length.FromMicrometers(double?)"/>
        public static Length? Micrometers(this decimal? value) => Length.FromMicrometers(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Mil

        /// <inheritdoc cref="Length.FromMils(double)"/>
        public static Length Mils(this int value) => Length.FromMils(value);

        /// <inheritdoc cref="Length.FromMils(double?)"/>
        public static Length? Mils(this int? value) => Length.FromMils(value);

        /// <inheritdoc cref="Length.FromMils(double)"/>
        public static Length Mils(this long value) => Length.FromMils(value);

        /// <inheritdoc cref="Length.FromMils(double?)"/>
        public static Length? Mils(this long? value) => Length.FromMils(value);

        /// <inheritdoc cref="Length.FromMils(double)"/>
        public static Length Mils(this double value) => Length.FromMils(value);

        /// <inheritdoc cref="Length.FromMils(double?)"/>
        public static Length? Mils(this double? value) => Length.FromMils(value);

        /// <inheritdoc cref="Length.FromMils(double)"/>
        public static Length Mils(this float value) => Length.FromMils(value);

        /// <inheritdoc cref="Length.FromMils(double?)"/>
        public static Length? Mils(this float? value) => Length.FromMils(value);

        /// <inheritdoc cref="Length.FromMils(double)"/>
        public static Length Mils(this decimal value) => Length.FromMils(Convert.ToDouble(value));

        /// <inheritdoc cref="Length.FromMils(double?)"/>
        public static Length? Mils(this decimal? value) => Length.FromMils(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Mile

        /// <inheritdoc cref="Length.FromMiles(double)"/>
        public static Length Miles(this int value) => Length.FromMiles(value);

        /// <inheritdoc cref="Length.FromMiles(double?)"/>
        public static Length? Miles(this int? value) => Length.FromMiles(value);

        /// <inheritdoc cref="Length.FromMiles(double)"/>
        public static Length Miles(this long value) => Length.FromMiles(value);

        /// <inheritdoc cref="Length.FromMiles(double?)"/>
        public static Length? Miles(this long? value) => Length.FromMiles(value);

        /// <inheritdoc cref="Length.FromMiles(double)"/>
        public static Length Miles(this double value) => Length.FromMiles(value);

        /// <inheritdoc cref="Length.FromMiles(double?)"/>
        public static Length? Miles(this double? value) => Length.FromMiles(value);

        /// <inheritdoc cref="Length.FromMiles(double)"/>
        public static Length Miles(this float value) => Length.FromMiles(value);

        /// <inheritdoc cref="Length.FromMiles(double?)"/>
        public static Length? Miles(this float? value) => Length.FromMiles(value);

        /// <inheritdoc cref="Length.FromMiles(double)"/>
        public static Length Miles(this decimal value) => Length.FromMiles(Convert.ToDouble(value));

        /// <inheritdoc cref="Length.FromMiles(double?)"/>
        public static Length? Miles(this decimal? value) => Length.FromMiles(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Millimeter

        /// <inheritdoc cref="Length.FromMillimeters(double)"/>
        public static Length Millimeters(this int value) => Length.FromMillimeters(value);

        /// <inheritdoc cref="Length.FromMillimeters(double?)"/>
        public static Length? Millimeters(this int? value) => Length.FromMillimeters(value);

        /// <inheritdoc cref="Length.FromMillimeters(double)"/>
        public static Length Millimeters(this long value) => Length.FromMillimeters(value);

        /// <inheritdoc cref="Length.FromMillimeters(double?)"/>
        public static Length? Millimeters(this long? value) => Length.FromMillimeters(value);

        /// <inheritdoc cref="Length.FromMillimeters(double)"/>
        public static Length Millimeters(this double value) => Length.FromMillimeters(value);

        /// <inheritdoc cref="Length.FromMillimeters(double?)"/>
        public static Length? Millimeters(this double? value) => Length.FromMillimeters(value);

        /// <inheritdoc cref="Length.FromMillimeters(double)"/>
        public static Length Millimeters(this float value) => Length.FromMillimeters(value);

        /// <inheritdoc cref="Length.FromMillimeters(double?)"/>
        public static Length? Millimeters(this float? value) => Length.FromMillimeters(value);

        /// <inheritdoc cref="Length.FromMillimeters(double)"/>
        public static Length Millimeters(this decimal value) => Length.FromMillimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="Length.FromMillimeters(double?)"/>
        public static Length? Millimeters(this decimal? value) => Length.FromMillimeters(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Nanometer

        /// <inheritdoc cref="Length.FromNanometers(double)"/>
        public static Length Nanometers(this int value) => Length.FromNanometers(value);

        /// <inheritdoc cref="Length.FromNanometers(double?)"/>
        public static Length? Nanometers(this int? value) => Length.FromNanometers(value);

        /// <inheritdoc cref="Length.FromNanometers(double)"/>
        public static Length Nanometers(this long value) => Length.FromNanometers(value);

        /// <inheritdoc cref="Length.FromNanometers(double?)"/>
        public static Length? Nanometers(this long? value) => Length.FromNanometers(value);

        /// <inheritdoc cref="Length.FromNanometers(double)"/>
        public static Length Nanometers(this double value) => Length.FromNanometers(value);

        /// <inheritdoc cref="Length.FromNanometers(double?)"/>
        public static Length? Nanometers(this double? value) => Length.FromNanometers(value);

        /// <inheritdoc cref="Length.FromNanometers(double)"/>
        public static Length Nanometers(this float value) => Length.FromNanometers(value);

        /// <inheritdoc cref="Length.FromNanometers(double?)"/>
        public static Length? Nanometers(this float? value) => Length.FromNanometers(value);

        /// <inheritdoc cref="Length.FromNanometers(double)"/>
        public static Length Nanometers(this decimal value) => Length.FromNanometers(Convert.ToDouble(value));

        /// <inheritdoc cref="Length.FromNanometers(double?)"/>
        public static Length? Nanometers(this decimal? value) => Length.FromNanometers(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region NauticalMile

        /// <inheritdoc cref="Length.FromNauticalMiles(double)"/>
        public static Length NauticalMiles(this int value) => Length.FromNauticalMiles(value);

        /// <inheritdoc cref="Length.FromNauticalMiles(double?)"/>
        public static Length? NauticalMiles(this int? value) => Length.FromNauticalMiles(value);

        /// <inheritdoc cref="Length.FromNauticalMiles(double)"/>
        public static Length NauticalMiles(this long value) => Length.FromNauticalMiles(value);

        /// <inheritdoc cref="Length.FromNauticalMiles(double?)"/>
        public static Length? NauticalMiles(this long? value) => Length.FromNauticalMiles(value);

        /// <inheritdoc cref="Length.FromNauticalMiles(double)"/>
        public static Length NauticalMiles(this double value) => Length.FromNauticalMiles(value);

        /// <inheritdoc cref="Length.FromNauticalMiles(double?)"/>
        public static Length? NauticalMiles(this double? value) => Length.FromNauticalMiles(value);

        /// <inheritdoc cref="Length.FromNauticalMiles(double)"/>
        public static Length NauticalMiles(this float value) => Length.FromNauticalMiles(value);

        /// <inheritdoc cref="Length.FromNauticalMiles(double?)"/>
        public static Length? NauticalMiles(this float? value) => Length.FromNauticalMiles(value);

        /// <inheritdoc cref="Length.FromNauticalMiles(double)"/>
        public static Length NauticalMiles(this decimal value) => Length.FromNauticalMiles(Convert.ToDouble(value));

        /// <inheritdoc cref="Length.FromNauticalMiles(double?)"/>
        public static Length? NauticalMiles(this decimal? value) => Length.FromNauticalMiles(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region PrinterPica

        /// <inheritdoc cref="Length.FromPrinterPicas(double)"/>
        public static Length PrinterPicas(this int value) => Length.FromPrinterPicas(value);

        /// <inheritdoc cref="Length.FromPrinterPicas(double?)"/>
        public static Length? PrinterPicas(this int? value) => Length.FromPrinterPicas(value);

        /// <inheritdoc cref="Length.FromPrinterPicas(double)"/>
        public static Length PrinterPicas(this long value) => Length.FromPrinterPicas(value);

        /// <inheritdoc cref="Length.FromPrinterPicas(double?)"/>
        public static Length? PrinterPicas(this long? value) => Length.FromPrinterPicas(value);

        /// <inheritdoc cref="Length.FromPrinterPicas(double)"/>
        public static Length PrinterPicas(this double value) => Length.FromPrinterPicas(value);

        /// <inheritdoc cref="Length.FromPrinterPicas(double?)"/>
        public static Length? PrinterPicas(this double? value) => Length.FromPrinterPicas(value);

        /// <inheritdoc cref="Length.FromPrinterPicas(double)"/>
        public static Length PrinterPicas(this float value) => Length.FromPrinterPicas(value);

        /// <inheritdoc cref="Length.FromPrinterPicas(double?)"/>
        public static Length? PrinterPicas(this float? value) => Length.FromPrinterPicas(value);

        /// <inheritdoc cref="Length.FromPrinterPicas(double)"/>
        public static Length PrinterPicas(this decimal value) => Length.FromPrinterPicas(Convert.ToDouble(value));

        /// <inheritdoc cref="Length.FromPrinterPicas(double?)"/>
        public static Length? PrinterPicas(this decimal? value) => Length.FromPrinterPicas(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region PrinterPoint

        /// <inheritdoc cref="Length.FromPrinterPoints(double)"/>
        public static Length PrinterPoints(this int value) => Length.FromPrinterPoints(value);

        /// <inheritdoc cref="Length.FromPrinterPoints(double?)"/>
        public static Length? PrinterPoints(this int? value) => Length.FromPrinterPoints(value);

        /// <inheritdoc cref="Length.FromPrinterPoints(double)"/>
        public static Length PrinterPoints(this long value) => Length.FromPrinterPoints(value);

        /// <inheritdoc cref="Length.FromPrinterPoints(double?)"/>
        public static Length? PrinterPoints(this long? value) => Length.FromPrinterPoints(value);

        /// <inheritdoc cref="Length.FromPrinterPoints(double)"/>
        public static Length PrinterPoints(this double value) => Length.FromPrinterPoints(value);

        /// <inheritdoc cref="Length.FromPrinterPoints(double?)"/>
        public static Length? PrinterPoints(this double? value) => Length.FromPrinterPoints(value);

        /// <inheritdoc cref="Length.FromPrinterPoints(double)"/>
        public static Length PrinterPoints(this float value) => Length.FromPrinterPoints(value);

        /// <inheritdoc cref="Length.FromPrinterPoints(double?)"/>
        public static Length? PrinterPoints(this float? value) => Length.FromPrinterPoints(value);

        /// <inheritdoc cref="Length.FromPrinterPoints(double)"/>
        public static Length PrinterPoints(this decimal value) => Length.FromPrinterPoints(Convert.ToDouble(value));

        /// <inheritdoc cref="Length.FromPrinterPoints(double?)"/>
        public static Length? PrinterPoints(this decimal? value) => Length.FromPrinterPoints(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Shackle

        /// <inheritdoc cref="Length.FromShackles(double)"/>
        public static Length Shackles(this int value) => Length.FromShackles(value);

        /// <inheritdoc cref="Length.FromShackles(double?)"/>
        public static Length? Shackles(this int? value) => Length.FromShackles(value);

        /// <inheritdoc cref="Length.FromShackles(double)"/>
        public static Length Shackles(this long value) => Length.FromShackles(value);

        /// <inheritdoc cref="Length.FromShackles(double?)"/>
        public static Length? Shackles(this long? value) => Length.FromShackles(value);

        /// <inheritdoc cref="Length.FromShackles(double)"/>
        public static Length Shackles(this double value) => Length.FromShackles(value);

        /// <inheritdoc cref="Length.FromShackles(double?)"/>
        public static Length? Shackles(this double? value) => Length.FromShackles(value);

        /// <inheritdoc cref="Length.FromShackles(double)"/>
        public static Length Shackles(this float value) => Length.FromShackles(value);

        /// <inheritdoc cref="Length.FromShackles(double?)"/>
        public static Length? Shackles(this float? value) => Length.FromShackles(value);

        /// <inheritdoc cref="Length.FromShackles(double)"/>
        public static Length Shackles(this decimal value) => Length.FromShackles(Convert.ToDouble(value));

        /// <inheritdoc cref="Length.FromShackles(double?)"/>
        public static Length? Shackles(this decimal? value) => Length.FromShackles(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Twip

        /// <inheritdoc cref="Length.FromTwips(double)"/>
        public static Length Twips(this int value) => Length.FromTwips(value);

        /// <inheritdoc cref="Length.FromTwips(double?)"/>
        public static Length? Twips(this int? value) => Length.FromTwips(value);

        /// <inheritdoc cref="Length.FromTwips(double)"/>
        public static Length Twips(this long value) => Length.FromTwips(value);

        /// <inheritdoc cref="Length.FromTwips(double?)"/>
        public static Length? Twips(this long? value) => Length.FromTwips(value);

        /// <inheritdoc cref="Length.FromTwips(double)"/>
        public static Length Twips(this double value) => Length.FromTwips(value);

        /// <inheritdoc cref="Length.FromTwips(double?)"/>
        public static Length? Twips(this double? value) => Length.FromTwips(value);

        /// <inheritdoc cref="Length.FromTwips(double)"/>
        public static Length Twips(this float value) => Length.FromTwips(value);

        /// <inheritdoc cref="Length.FromTwips(double?)"/>
        public static Length? Twips(this float? value) => Length.FromTwips(value);

        /// <inheritdoc cref="Length.FromTwips(double)"/>
        public static Length Twips(this decimal value) => Length.FromTwips(Convert.ToDouble(value));

        /// <inheritdoc cref="Length.FromTwips(double?)"/>
        public static Length? Twips(this decimal? value) => Length.FromTwips(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region UsSurveyFoot

        /// <inheritdoc cref="Length.FromUsSurveyFeet(double)"/>
        public static Length UsSurveyFeet(this int value) => Length.FromUsSurveyFeet(value);

        /// <inheritdoc cref="Length.FromUsSurveyFeet(double?)"/>
        public static Length? UsSurveyFeet(this int? value) => Length.FromUsSurveyFeet(value);

        /// <inheritdoc cref="Length.FromUsSurveyFeet(double)"/>
        public static Length UsSurveyFeet(this long value) => Length.FromUsSurveyFeet(value);

        /// <inheritdoc cref="Length.FromUsSurveyFeet(double?)"/>
        public static Length? UsSurveyFeet(this long? value) => Length.FromUsSurveyFeet(value);

        /// <inheritdoc cref="Length.FromUsSurveyFeet(double)"/>
        public static Length UsSurveyFeet(this double value) => Length.FromUsSurveyFeet(value);

        /// <inheritdoc cref="Length.FromUsSurveyFeet(double?)"/>
        public static Length? UsSurveyFeet(this double? value) => Length.FromUsSurveyFeet(value);

        /// <inheritdoc cref="Length.FromUsSurveyFeet(double)"/>
        public static Length UsSurveyFeet(this float value) => Length.FromUsSurveyFeet(value);

        /// <inheritdoc cref="Length.FromUsSurveyFeet(double?)"/>
        public static Length? UsSurveyFeet(this float? value) => Length.FromUsSurveyFeet(value);

        /// <inheritdoc cref="Length.FromUsSurveyFeet(double)"/>
        public static Length UsSurveyFeet(this decimal value) => Length.FromUsSurveyFeet(Convert.ToDouble(value));

        /// <inheritdoc cref="Length.FromUsSurveyFeet(double?)"/>
        public static Length? UsSurveyFeet(this decimal? value) => Length.FromUsSurveyFeet(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Yard

        /// <inheritdoc cref="Length.FromYards(double)"/>
        public static Length Yards(this int value) => Length.FromYards(value);

        /// <inheritdoc cref="Length.FromYards(double?)"/>
        public static Length? Yards(this int? value) => Length.FromYards(value);

        /// <inheritdoc cref="Length.FromYards(double)"/>
        public static Length Yards(this long value) => Length.FromYards(value);

        /// <inheritdoc cref="Length.FromYards(double?)"/>
        public static Length? Yards(this long? value) => Length.FromYards(value);

        /// <inheritdoc cref="Length.FromYards(double)"/>
        public static Length Yards(this double value) => Length.FromYards(value);

        /// <inheritdoc cref="Length.FromYards(double?)"/>
        public static Length? Yards(this double? value) => Length.FromYards(value);

        /// <inheritdoc cref="Length.FromYards(double)"/>
        public static Length Yards(this float value) => Length.FromYards(value);

        /// <inheritdoc cref="Length.FromYards(double?)"/>
        public static Length? Yards(this float? value) => Length.FromYards(value);

        /// <inheritdoc cref="Length.FromYards(double)"/>
        public static Length Yards(this decimal value) => Length.FromYards(Convert.ToDouble(value));

        /// <inheritdoc cref="Length.FromYards(double?)"/>
        public static Length? Yards(this decimal? value) => Length.FromYards(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
