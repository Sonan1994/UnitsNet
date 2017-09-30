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
namespace UnitsNet.Extensions.NumberToMassMomentOfInertia
{
    public static class NumberToMassMomentOfInertiaExtensions
    {
        #region GramSquareCentimeter

        /// <inheritdoc cref="MassMomentOfInertia.FromGramSquareCentimeters(double)"/>
        public static MassMomentOfInertia GramSquareCentimeters(this int value) => MassMomentOfInertia.FromGramSquareCentimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromGramSquareCentimeters(double?)"/>
        public static MassMomentOfInertia? GramSquareCentimeters(this int? value) => MassMomentOfInertia.FromGramSquareCentimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromGramSquareCentimeters(double)"/>
        public static MassMomentOfInertia GramSquareCentimeters(this long value) => MassMomentOfInertia.FromGramSquareCentimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromGramSquareCentimeters(double?)"/>
        public static MassMomentOfInertia? GramSquareCentimeters(this long? value) => MassMomentOfInertia.FromGramSquareCentimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromGramSquareCentimeters(double)"/>
        public static MassMomentOfInertia GramSquareCentimeters(this double value) => MassMomentOfInertia.FromGramSquareCentimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromGramSquareCentimeters(double?)"/>
        public static MassMomentOfInertia? GramSquareCentimeters(this double? value) => MassMomentOfInertia.FromGramSquareCentimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromGramSquareCentimeters(double)"/>
        public static MassMomentOfInertia GramSquareCentimeters(this float value) => MassMomentOfInertia.FromGramSquareCentimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromGramSquareCentimeters(double?)"/>
        public static MassMomentOfInertia? GramSquareCentimeters(this float? value) => MassMomentOfInertia.FromGramSquareCentimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromGramSquareCentimeters(double)"/>
        public static MassMomentOfInertia GramSquareCentimeters(this decimal value) => MassMomentOfInertia.FromGramSquareCentimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="MassMomentOfInertia.FromGramSquareCentimeters(double?)"/>
        public static MassMomentOfInertia? GramSquareCentimeters(this decimal? value) => MassMomentOfInertia.FromGramSquareCentimeters(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region GramSquareDecimeter

        /// <inheritdoc cref="MassMomentOfInertia.FromGramSquareDecimeters(double)"/>
        public static MassMomentOfInertia GramSquareDecimeters(this int value) => MassMomentOfInertia.FromGramSquareDecimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromGramSquareDecimeters(double?)"/>
        public static MassMomentOfInertia? GramSquareDecimeters(this int? value) => MassMomentOfInertia.FromGramSquareDecimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromGramSquareDecimeters(double)"/>
        public static MassMomentOfInertia GramSquareDecimeters(this long value) => MassMomentOfInertia.FromGramSquareDecimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromGramSquareDecimeters(double?)"/>
        public static MassMomentOfInertia? GramSquareDecimeters(this long? value) => MassMomentOfInertia.FromGramSquareDecimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromGramSquareDecimeters(double)"/>
        public static MassMomentOfInertia GramSquareDecimeters(this double value) => MassMomentOfInertia.FromGramSquareDecimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromGramSquareDecimeters(double?)"/>
        public static MassMomentOfInertia? GramSquareDecimeters(this double? value) => MassMomentOfInertia.FromGramSquareDecimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromGramSquareDecimeters(double)"/>
        public static MassMomentOfInertia GramSquareDecimeters(this float value) => MassMomentOfInertia.FromGramSquareDecimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromGramSquareDecimeters(double?)"/>
        public static MassMomentOfInertia? GramSquareDecimeters(this float? value) => MassMomentOfInertia.FromGramSquareDecimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromGramSquareDecimeters(double)"/>
        public static MassMomentOfInertia GramSquareDecimeters(this decimal value) => MassMomentOfInertia.FromGramSquareDecimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="MassMomentOfInertia.FromGramSquareDecimeters(double?)"/>
        public static MassMomentOfInertia? GramSquareDecimeters(this decimal? value) => MassMomentOfInertia.FromGramSquareDecimeters(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region GramSquareMeter

        /// <inheritdoc cref="MassMomentOfInertia.FromGramSquareMeters(double)"/>
        public static MassMomentOfInertia GramSquareMeters(this int value) => MassMomentOfInertia.FromGramSquareMeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromGramSquareMeters(double?)"/>
        public static MassMomentOfInertia? GramSquareMeters(this int? value) => MassMomentOfInertia.FromGramSquareMeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromGramSquareMeters(double)"/>
        public static MassMomentOfInertia GramSquareMeters(this long value) => MassMomentOfInertia.FromGramSquareMeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromGramSquareMeters(double?)"/>
        public static MassMomentOfInertia? GramSquareMeters(this long? value) => MassMomentOfInertia.FromGramSquareMeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromGramSquareMeters(double)"/>
        public static MassMomentOfInertia GramSquareMeters(this double value) => MassMomentOfInertia.FromGramSquareMeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromGramSquareMeters(double?)"/>
        public static MassMomentOfInertia? GramSquareMeters(this double? value) => MassMomentOfInertia.FromGramSquareMeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromGramSquareMeters(double)"/>
        public static MassMomentOfInertia GramSquareMeters(this float value) => MassMomentOfInertia.FromGramSquareMeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromGramSquareMeters(double?)"/>
        public static MassMomentOfInertia? GramSquareMeters(this float? value) => MassMomentOfInertia.FromGramSquareMeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromGramSquareMeters(double)"/>
        public static MassMomentOfInertia GramSquareMeters(this decimal value) => MassMomentOfInertia.FromGramSquareMeters(Convert.ToDouble(value));

        /// <inheritdoc cref="MassMomentOfInertia.FromGramSquareMeters(double?)"/>
        public static MassMomentOfInertia? GramSquareMeters(this decimal? value) => MassMomentOfInertia.FromGramSquareMeters(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region GramSquareMillimeter

        /// <inheritdoc cref="MassMomentOfInertia.FromGramSquareMillimeters(double)"/>
        public static MassMomentOfInertia GramSquareMillimeters(this int value) => MassMomentOfInertia.FromGramSquareMillimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromGramSquareMillimeters(double?)"/>
        public static MassMomentOfInertia? GramSquareMillimeters(this int? value) => MassMomentOfInertia.FromGramSquareMillimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromGramSquareMillimeters(double)"/>
        public static MassMomentOfInertia GramSquareMillimeters(this long value) => MassMomentOfInertia.FromGramSquareMillimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromGramSquareMillimeters(double?)"/>
        public static MassMomentOfInertia? GramSquareMillimeters(this long? value) => MassMomentOfInertia.FromGramSquareMillimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromGramSquareMillimeters(double)"/>
        public static MassMomentOfInertia GramSquareMillimeters(this double value) => MassMomentOfInertia.FromGramSquareMillimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromGramSquareMillimeters(double?)"/>
        public static MassMomentOfInertia? GramSquareMillimeters(this double? value) => MassMomentOfInertia.FromGramSquareMillimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromGramSquareMillimeters(double)"/>
        public static MassMomentOfInertia GramSquareMillimeters(this float value) => MassMomentOfInertia.FromGramSquareMillimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromGramSquareMillimeters(double?)"/>
        public static MassMomentOfInertia? GramSquareMillimeters(this float? value) => MassMomentOfInertia.FromGramSquareMillimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromGramSquareMillimeters(double)"/>
        public static MassMomentOfInertia GramSquareMillimeters(this decimal value) => MassMomentOfInertia.FromGramSquareMillimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="MassMomentOfInertia.FromGramSquareMillimeters(double?)"/>
        public static MassMomentOfInertia? GramSquareMillimeters(this decimal? value) => MassMomentOfInertia.FromGramSquareMillimeters(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilogramSquareCentimeter

        /// <inheritdoc cref="MassMomentOfInertia.FromKilogramSquareCentimeters(double)"/>
        public static MassMomentOfInertia KilogramSquareCentimeters(this int value) => MassMomentOfInertia.FromKilogramSquareCentimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromKilogramSquareCentimeters(double?)"/>
        public static MassMomentOfInertia? KilogramSquareCentimeters(this int? value) => MassMomentOfInertia.FromKilogramSquareCentimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromKilogramSquareCentimeters(double)"/>
        public static MassMomentOfInertia KilogramSquareCentimeters(this long value) => MassMomentOfInertia.FromKilogramSquareCentimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromKilogramSquareCentimeters(double?)"/>
        public static MassMomentOfInertia? KilogramSquareCentimeters(this long? value) => MassMomentOfInertia.FromKilogramSquareCentimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromKilogramSquareCentimeters(double)"/>
        public static MassMomentOfInertia KilogramSquareCentimeters(this double value) => MassMomentOfInertia.FromKilogramSquareCentimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromKilogramSquareCentimeters(double?)"/>
        public static MassMomentOfInertia? KilogramSquareCentimeters(this double? value) => MassMomentOfInertia.FromKilogramSquareCentimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromKilogramSquareCentimeters(double)"/>
        public static MassMomentOfInertia KilogramSquareCentimeters(this float value) => MassMomentOfInertia.FromKilogramSquareCentimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromKilogramSquareCentimeters(double?)"/>
        public static MassMomentOfInertia? KilogramSquareCentimeters(this float? value) => MassMomentOfInertia.FromKilogramSquareCentimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromKilogramSquareCentimeters(double)"/>
        public static MassMomentOfInertia KilogramSquareCentimeters(this decimal value) => MassMomentOfInertia.FromKilogramSquareCentimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="MassMomentOfInertia.FromKilogramSquareCentimeters(double?)"/>
        public static MassMomentOfInertia? KilogramSquareCentimeters(this decimal? value) => MassMomentOfInertia.FromKilogramSquareCentimeters(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilogramSquareDecimeter

        /// <inheritdoc cref="MassMomentOfInertia.FromKilogramSquareDecimeters(double)"/>
        public static MassMomentOfInertia KilogramSquareDecimeters(this int value) => MassMomentOfInertia.FromKilogramSquareDecimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromKilogramSquareDecimeters(double?)"/>
        public static MassMomentOfInertia? KilogramSquareDecimeters(this int? value) => MassMomentOfInertia.FromKilogramSquareDecimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromKilogramSquareDecimeters(double)"/>
        public static MassMomentOfInertia KilogramSquareDecimeters(this long value) => MassMomentOfInertia.FromKilogramSquareDecimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromKilogramSquareDecimeters(double?)"/>
        public static MassMomentOfInertia? KilogramSquareDecimeters(this long? value) => MassMomentOfInertia.FromKilogramSquareDecimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromKilogramSquareDecimeters(double)"/>
        public static MassMomentOfInertia KilogramSquareDecimeters(this double value) => MassMomentOfInertia.FromKilogramSquareDecimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromKilogramSquareDecimeters(double?)"/>
        public static MassMomentOfInertia? KilogramSquareDecimeters(this double? value) => MassMomentOfInertia.FromKilogramSquareDecimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromKilogramSquareDecimeters(double)"/>
        public static MassMomentOfInertia KilogramSquareDecimeters(this float value) => MassMomentOfInertia.FromKilogramSquareDecimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromKilogramSquareDecimeters(double?)"/>
        public static MassMomentOfInertia? KilogramSquareDecimeters(this float? value) => MassMomentOfInertia.FromKilogramSquareDecimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromKilogramSquareDecimeters(double)"/>
        public static MassMomentOfInertia KilogramSquareDecimeters(this decimal value) => MassMomentOfInertia.FromKilogramSquareDecimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="MassMomentOfInertia.FromKilogramSquareDecimeters(double?)"/>
        public static MassMomentOfInertia? KilogramSquareDecimeters(this decimal? value) => MassMomentOfInertia.FromKilogramSquareDecimeters(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilogramSquareMeter

        /// <inheritdoc cref="MassMomentOfInertia.FromKilogramSquareMeters(double)"/>
        public static MassMomentOfInertia KilogramSquareMeters(this int value) => MassMomentOfInertia.FromKilogramSquareMeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromKilogramSquareMeters(double?)"/>
        public static MassMomentOfInertia? KilogramSquareMeters(this int? value) => MassMomentOfInertia.FromKilogramSquareMeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromKilogramSquareMeters(double)"/>
        public static MassMomentOfInertia KilogramSquareMeters(this long value) => MassMomentOfInertia.FromKilogramSquareMeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromKilogramSquareMeters(double?)"/>
        public static MassMomentOfInertia? KilogramSquareMeters(this long? value) => MassMomentOfInertia.FromKilogramSquareMeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromKilogramSquareMeters(double)"/>
        public static MassMomentOfInertia KilogramSquareMeters(this double value) => MassMomentOfInertia.FromKilogramSquareMeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromKilogramSquareMeters(double?)"/>
        public static MassMomentOfInertia? KilogramSquareMeters(this double? value) => MassMomentOfInertia.FromKilogramSquareMeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromKilogramSquareMeters(double)"/>
        public static MassMomentOfInertia KilogramSquareMeters(this float value) => MassMomentOfInertia.FromKilogramSquareMeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromKilogramSquareMeters(double?)"/>
        public static MassMomentOfInertia? KilogramSquareMeters(this float? value) => MassMomentOfInertia.FromKilogramSquareMeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromKilogramSquareMeters(double)"/>
        public static MassMomentOfInertia KilogramSquareMeters(this decimal value) => MassMomentOfInertia.FromKilogramSquareMeters(Convert.ToDouble(value));

        /// <inheritdoc cref="MassMomentOfInertia.FromKilogramSquareMeters(double?)"/>
        public static MassMomentOfInertia? KilogramSquareMeters(this decimal? value) => MassMomentOfInertia.FromKilogramSquareMeters(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilogramSquareMillimeter

        /// <inheritdoc cref="MassMomentOfInertia.FromKilogramSquareMillimeters(double)"/>
        public static MassMomentOfInertia KilogramSquareMillimeters(this int value) => MassMomentOfInertia.FromKilogramSquareMillimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromKilogramSquareMillimeters(double?)"/>
        public static MassMomentOfInertia? KilogramSquareMillimeters(this int? value) => MassMomentOfInertia.FromKilogramSquareMillimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromKilogramSquareMillimeters(double)"/>
        public static MassMomentOfInertia KilogramSquareMillimeters(this long value) => MassMomentOfInertia.FromKilogramSquareMillimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromKilogramSquareMillimeters(double?)"/>
        public static MassMomentOfInertia? KilogramSquareMillimeters(this long? value) => MassMomentOfInertia.FromKilogramSquareMillimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromKilogramSquareMillimeters(double)"/>
        public static MassMomentOfInertia KilogramSquareMillimeters(this double value) => MassMomentOfInertia.FromKilogramSquareMillimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromKilogramSquareMillimeters(double?)"/>
        public static MassMomentOfInertia? KilogramSquareMillimeters(this double? value) => MassMomentOfInertia.FromKilogramSquareMillimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromKilogramSquareMillimeters(double)"/>
        public static MassMomentOfInertia KilogramSquareMillimeters(this float value) => MassMomentOfInertia.FromKilogramSquareMillimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromKilogramSquareMillimeters(double?)"/>
        public static MassMomentOfInertia? KilogramSquareMillimeters(this float? value) => MassMomentOfInertia.FromKilogramSquareMillimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromKilogramSquareMillimeters(double)"/>
        public static MassMomentOfInertia KilogramSquareMillimeters(this decimal value) => MassMomentOfInertia.FromKilogramSquareMillimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="MassMomentOfInertia.FromKilogramSquareMillimeters(double?)"/>
        public static MassMomentOfInertia? KilogramSquareMillimeters(this decimal? value) => MassMomentOfInertia.FromKilogramSquareMillimeters(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MilligramSquareCentimeter

        /// <inheritdoc cref="MassMomentOfInertia.FromMilligramSquareCentimeters(double)"/>
        public static MassMomentOfInertia MilligramSquareCentimeters(this int value) => MassMomentOfInertia.FromMilligramSquareCentimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromMilligramSquareCentimeters(double?)"/>
        public static MassMomentOfInertia? MilligramSquareCentimeters(this int? value) => MassMomentOfInertia.FromMilligramSquareCentimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromMilligramSquareCentimeters(double)"/>
        public static MassMomentOfInertia MilligramSquareCentimeters(this long value) => MassMomentOfInertia.FromMilligramSquareCentimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromMilligramSquareCentimeters(double?)"/>
        public static MassMomentOfInertia? MilligramSquareCentimeters(this long? value) => MassMomentOfInertia.FromMilligramSquareCentimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromMilligramSquareCentimeters(double)"/>
        public static MassMomentOfInertia MilligramSquareCentimeters(this double value) => MassMomentOfInertia.FromMilligramSquareCentimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromMilligramSquareCentimeters(double?)"/>
        public static MassMomentOfInertia? MilligramSquareCentimeters(this double? value) => MassMomentOfInertia.FromMilligramSquareCentimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromMilligramSquareCentimeters(double)"/>
        public static MassMomentOfInertia MilligramSquareCentimeters(this float value) => MassMomentOfInertia.FromMilligramSquareCentimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromMilligramSquareCentimeters(double?)"/>
        public static MassMomentOfInertia? MilligramSquareCentimeters(this float? value) => MassMomentOfInertia.FromMilligramSquareCentimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromMilligramSquareCentimeters(double)"/>
        public static MassMomentOfInertia MilligramSquareCentimeters(this decimal value) => MassMomentOfInertia.FromMilligramSquareCentimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="MassMomentOfInertia.FromMilligramSquareCentimeters(double?)"/>
        public static MassMomentOfInertia? MilligramSquareCentimeters(this decimal? value) => MassMomentOfInertia.FromMilligramSquareCentimeters(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MilligramSquareDecimeter

        /// <inheritdoc cref="MassMomentOfInertia.FromMilligramSquareDecimeters(double)"/>
        public static MassMomentOfInertia MilligramSquareDecimeters(this int value) => MassMomentOfInertia.FromMilligramSquareDecimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromMilligramSquareDecimeters(double?)"/>
        public static MassMomentOfInertia? MilligramSquareDecimeters(this int? value) => MassMomentOfInertia.FromMilligramSquareDecimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromMilligramSquareDecimeters(double)"/>
        public static MassMomentOfInertia MilligramSquareDecimeters(this long value) => MassMomentOfInertia.FromMilligramSquareDecimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromMilligramSquareDecimeters(double?)"/>
        public static MassMomentOfInertia? MilligramSquareDecimeters(this long? value) => MassMomentOfInertia.FromMilligramSquareDecimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromMilligramSquareDecimeters(double)"/>
        public static MassMomentOfInertia MilligramSquareDecimeters(this double value) => MassMomentOfInertia.FromMilligramSquareDecimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromMilligramSquareDecimeters(double?)"/>
        public static MassMomentOfInertia? MilligramSquareDecimeters(this double? value) => MassMomentOfInertia.FromMilligramSquareDecimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromMilligramSquareDecimeters(double)"/>
        public static MassMomentOfInertia MilligramSquareDecimeters(this float value) => MassMomentOfInertia.FromMilligramSquareDecimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromMilligramSquareDecimeters(double?)"/>
        public static MassMomentOfInertia? MilligramSquareDecimeters(this float? value) => MassMomentOfInertia.FromMilligramSquareDecimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromMilligramSquareDecimeters(double)"/>
        public static MassMomentOfInertia MilligramSquareDecimeters(this decimal value) => MassMomentOfInertia.FromMilligramSquareDecimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="MassMomentOfInertia.FromMilligramSquareDecimeters(double?)"/>
        public static MassMomentOfInertia? MilligramSquareDecimeters(this decimal? value) => MassMomentOfInertia.FromMilligramSquareDecimeters(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MilligramSquareMeter

        /// <inheritdoc cref="MassMomentOfInertia.FromMilligramSquareMeters(double)"/>
        public static MassMomentOfInertia MilligramSquareMeters(this int value) => MassMomentOfInertia.FromMilligramSquareMeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromMilligramSquareMeters(double?)"/>
        public static MassMomentOfInertia? MilligramSquareMeters(this int? value) => MassMomentOfInertia.FromMilligramSquareMeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromMilligramSquareMeters(double)"/>
        public static MassMomentOfInertia MilligramSquareMeters(this long value) => MassMomentOfInertia.FromMilligramSquareMeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromMilligramSquareMeters(double?)"/>
        public static MassMomentOfInertia? MilligramSquareMeters(this long? value) => MassMomentOfInertia.FromMilligramSquareMeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromMilligramSquareMeters(double)"/>
        public static MassMomentOfInertia MilligramSquareMeters(this double value) => MassMomentOfInertia.FromMilligramSquareMeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromMilligramSquareMeters(double?)"/>
        public static MassMomentOfInertia? MilligramSquareMeters(this double? value) => MassMomentOfInertia.FromMilligramSquareMeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromMilligramSquareMeters(double)"/>
        public static MassMomentOfInertia MilligramSquareMeters(this float value) => MassMomentOfInertia.FromMilligramSquareMeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromMilligramSquareMeters(double?)"/>
        public static MassMomentOfInertia? MilligramSquareMeters(this float? value) => MassMomentOfInertia.FromMilligramSquareMeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromMilligramSquareMeters(double)"/>
        public static MassMomentOfInertia MilligramSquareMeters(this decimal value) => MassMomentOfInertia.FromMilligramSquareMeters(Convert.ToDouble(value));

        /// <inheritdoc cref="MassMomentOfInertia.FromMilligramSquareMeters(double?)"/>
        public static MassMomentOfInertia? MilligramSquareMeters(this decimal? value) => MassMomentOfInertia.FromMilligramSquareMeters(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MilligramSquareMillimeter

        /// <inheritdoc cref="MassMomentOfInertia.FromMilligramSquareMillimeters(double)"/>
        public static MassMomentOfInertia MilligramSquareMillimeters(this int value) => MassMomentOfInertia.FromMilligramSquareMillimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromMilligramSquareMillimeters(double?)"/>
        public static MassMomentOfInertia? MilligramSquareMillimeters(this int? value) => MassMomentOfInertia.FromMilligramSquareMillimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromMilligramSquareMillimeters(double)"/>
        public static MassMomentOfInertia MilligramSquareMillimeters(this long value) => MassMomentOfInertia.FromMilligramSquareMillimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromMilligramSquareMillimeters(double?)"/>
        public static MassMomentOfInertia? MilligramSquareMillimeters(this long? value) => MassMomentOfInertia.FromMilligramSquareMillimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromMilligramSquareMillimeters(double)"/>
        public static MassMomentOfInertia MilligramSquareMillimeters(this double value) => MassMomentOfInertia.FromMilligramSquareMillimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromMilligramSquareMillimeters(double?)"/>
        public static MassMomentOfInertia? MilligramSquareMillimeters(this double? value) => MassMomentOfInertia.FromMilligramSquareMillimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromMilligramSquareMillimeters(double)"/>
        public static MassMomentOfInertia MilligramSquareMillimeters(this float value) => MassMomentOfInertia.FromMilligramSquareMillimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromMilligramSquareMillimeters(double?)"/>
        public static MassMomentOfInertia? MilligramSquareMillimeters(this float? value) => MassMomentOfInertia.FromMilligramSquareMillimeters(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromMilligramSquareMillimeters(double)"/>
        public static MassMomentOfInertia MilligramSquareMillimeters(this decimal value) => MassMomentOfInertia.FromMilligramSquareMillimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="MassMomentOfInertia.FromMilligramSquareMillimeters(double?)"/>
        public static MassMomentOfInertia? MilligramSquareMillimeters(this decimal? value) => MassMomentOfInertia.FromMilligramSquareMillimeters(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region PoundSquareFoot

        /// <inheritdoc cref="MassMomentOfInertia.FromPoundSquareFeet(double)"/>
        public static MassMomentOfInertia PoundSquareFeet(this int value) => MassMomentOfInertia.FromPoundSquareFeet(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromPoundSquareFeet(double?)"/>
        public static MassMomentOfInertia? PoundSquareFeet(this int? value) => MassMomentOfInertia.FromPoundSquareFeet(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromPoundSquareFeet(double)"/>
        public static MassMomentOfInertia PoundSquareFeet(this long value) => MassMomentOfInertia.FromPoundSquareFeet(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromPoundSquareFeet(double?)"/>
        public static MassMomentOfInertia? PoundSquareFeet(this long? value) => MassMomentOfInertia.FromPoundSquareFeet(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromPoundSquareFeet(double)"/>
        public static MassMomentOfInertia PoundSquareFeet(this double value) => MassMomentOfInertia.FromPoundSquareFeet(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromPoundSquareFeet(double?)"/>
        public static MassMomentOfInertia? PoundSquareFeet(this double? value) => MassMomentOfInertia.FromPoundSquareFeet(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromPoundSquareFeet(double)"/>
        public static MassMomentOfInertia PoundSquareFeet(this float value) => MassMomentOfInertia.FromPoundSquareFeet(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromPoundSquareFeet(double?)"/>
        public static MassMomentOfInertia? PoundSquareFeet(this float? value) => MassMomentOfInertia.FromPoundSquareFeet(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromPoundSquareFeet(double)"/>
        public static MassMomentOfInertia PoundSquareFeet(this decimal value) => MassMomentOfInertia.FromPoundSquareFeet(Convert.ToDouble(value));

        /// <inheritdoc cref="MassMomentOfInertia.FromPoundSquareFeet(double?)"/>
        public static MassMomentOfInertia? PoundSquareFeet(this decimal? value) => MassMomentOfInertia.FromPoundSquareFeet(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region PoundSquareInch

        /// <inheritdoc cref="MassMomentOfInertia.FromPoundSquareInches(double)"/>
        public static MassMomentOfInertia PoundSquareInches(this int value) => MassMomentOfInertia.FromPoundSquareInches(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromPoundSquareInches(double?)"/>
        public static MassMomentOfInertia? PoundSquareInches(this int? value) => MassMomentOfInertia.FromPoundSquareInches(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromPoundSquareInches(double)"/>
        public static MassMomentOfInertia PoundSquareInches(this long value) => MassMomentOfInertia.FromPoundSquareInches(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromPoundSquareInches(double?)"/>
        public static MassMomentOfInertia? PoundSquareInches(this long? value) => MassMomentOfInertia.FromPoundSquareInches(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromPoundSquareInches(double)"/>
        public static MassMomentOfInertia PoundSquareInches(this double value) => MassMomentOfInertia.FromPoundSquareInches(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromPoundSquareInches(double?)"/>
        public static MassMomentOfInertia? PoundSquareInches(this double? value) => MassMomentOfInertia.FromPoundSquareInches(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromPoundSquareInches(double)"/>
        public static MassMomentOfInertia PoundSquareInches(this float value) => MassMomentOfInertia.FromPoundSquareInches(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromPoundSquareInches(double?)"/>
        public static MassMomentOfInertia? PoundSquareInches(this float? value) => MassMomentOfInertia.FromPoundSquareInches(value);

        /// <inheritdoc cref="MassMomentOfInertia.FromPoundSquareInches(double)"/>
        public static MassMomentOfInertia PoundSquareInches(this decimal value) => MassMomentOfInertia.FromPoundSquareInches(Convert.ToDouble(value));

        /// <inheritdoc cref="MassMomentOfInertia.FromPoundSquareInches(double?)"/>
        public static MassMomentOfInertia? PoundSquareInches(this decimal? value) => MassMomentOfInertia.FromPoundSquareInches(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
