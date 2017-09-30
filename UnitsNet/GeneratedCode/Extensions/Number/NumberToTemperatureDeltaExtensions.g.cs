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
namespace UnitsNet.Extensions.NumberToTemperatureDelta
{
    public static class NumberToTemperatureDeltaExtensions
    {
        #region DegreeCelsiusDelta

        /// <inheritdoc cref="TemperatureDelta.FromDegreesCelsiusDelta(double)"/>
        public static TemperatureDelta DegreesCelsiusDelta(this int value) => TemperatureDelta.FromDegreesCelsiusDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesCelsiusDelta(double?)"/>
        public static TemperatureDelta? DegreesCelsiusDelta(this int? value) => TemperatureDelta.FromDegreesCelsiusDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesCelsiusDelta(double)"/>
        public static TemperatureDelta DegreesCelsiusDelta(this long value) => TemperatureDelta.FromDegreesCelsiusDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesCelsiusDelta(double?)"/>
        public static TemperatureDelta? DegreesCelsiusDelta(this long? value) => TemperatureDelta.FromDegreesCelsiusDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesCelsiusDelta(double)"/>
        public static TemperatureDelta DegreesCelsiusDelta(this double value) => TemperatureDelta.FromDegreesCelsiusDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesCelsiusDelta(double?)"/>
        public static TemperatureDelta? DegreesCelsiusDelta(this double? value) => TemperatureDelta.FromDegreesCelsiusDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesCelsiusDelta(double)"/>
        public static TemperatureDelta DegreesCelsiusDelta(this float value) => TemperatureDelta.FromDegreesCelsiusDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesCelsiusDelta(double?)"/>
        public static TemperatureDelta? DegreesCelsiusDelta(this float? value) => TemperatureDelta.FromDegreesCelsiusDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesCelsiusDelta(double)"/>
        public static TemperatureDelta DegreesCelsiusDelta(this decimal value) => TemperatureDelta.FromDegreesCelsiusDelta(Convert.ToDouble(value));

        /// <inheritdoc cref="TemperatureDelta.FromDegreesCelsiusDelta(double?)"/>
        public static TemperatureDelta? DegreesCelsiusDelta(this decimal? value) => TemperatureDelta.FromDegreesCelsiusDelta(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region DegreeDelisleDelta

        /// <inheritdoc cref="TemperatureDelta.FromDegreesDelisleDelta(double)"/>
        public static TemperatureDelta DegreesDelisleDelta(this int value) => TemperatureDelta.FromDegreesDelisleDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesDelisleDelta(double?)"/>
        public static TemperatureDelta? DegreesDelisleDelta(this int? value) => TemperatureDelta.FromDegreesDelisleDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesDelisleDelta(double)"/>
        public static TemperatureDelta DegreesDelisleDelta(this long value) => TemperatureDelta.FromDegreesDelisleDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesDelisleDelta(double?)"/>
        public static TemperatureDelta? DegreesDelisleDelta(this long? value) => TemperatureDelta.FromDegreesDelisleDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesDelisleDelta(double)"/>
        public static TemperatureDelta DegreesDelisleDelta(this double value) => TemperatureDelta.FromDegreesDelisleDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesDelisleDelta(double?)"/>
        public static TemperatureDelta? DegreesDelisleDelta(this double? value) => TemperatureDelta.FromDegreesDelisleDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesDelisleDelta(double)"/>
        public static TemperatureDelta DegreesDelisleDelta(this float value) => TemperatureDelta.FromDegreesDelisleDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesDelisleDelta(double?)"/>
        public static TemperatureDelta? DegreesDelisleDelta(this float? value) => TemperatureDelta.FromDegreesDelisleDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesDelisleDelta(double)"/>
        public static TemperatureDelta DegreesDelisleDelta(this decimal value) => TemperatureDelta.FromDegreesDelisleDelta(Convert.ToDouble(value));

        /// <inheritdoc cref="TemperatureDelta.FromDegreesDelisleDelta(double?)"/>
        public static TemperatureDelta? DegreesDelisleDelta(this decimal? value) => TemperatureDelta.FromDegreesDelisleDelta(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region DegreeFahrenheitDelta

        /// <inheritdoc cref="TemperatureDelta.FromDegreesFahrenheitDelta(double)"/>
        public static TemperatureDelta DegreesFahrenheitDelta(this int value) => TemperatureDelta.FromDegreesFahrenheitDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesFahrenheitDelta(double?)"/>
        public static TemperatureDelta? DegreesFahrenheitDelta(this int? value) => TemperatureDelta.FromDegreesFahrenheitDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesFahrenheitDelta(double)"/>
        public static TemperatureDelta DegreesFahrenheitDelta(this long value) => TemperatureDelta.FromDegreesFahrenheitDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesFahrenheitDelta(double?)"/>
        public static TemperatureDelta? DegreesFahrenheitDelta(this long? value) => TemperatureDelta.FromDegreesFahrenheitDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesFahrenheitDelta(double)"/>
        public static TemperatureDelta DegreesFahrenheitDelta(this double value) => TemperatureDelta.FromDegreesFahrenheitDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesFahrenheitDelta(double?)"/>
        public static TemperatureDelta? DegreesFahrenheitDelta(this double? value) => TemperatureDelta.FromDegreesFahrenheitDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesFahrenheitDelta(double)"/>
        public static TemperatureDelta DegreesFahrenheitDelta(this float value) => TemperatureDelta.FromDegreesFahrenheitDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesFahrenheitDelta(double?)"/>
        public static TemperatureDelta? DegreesFahrenheitDelta(this float? value) => TemperatureDelta.FromDegreesFahrenheitDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesFahrenheitDelta(double)"/>
        public static TemperatureDelta DegreesFahrenheitDelta(this decimal value) => TemperatureDelta.FromDegreesFahrenheitDelta(Convert.ToDouble(value));

        /// <inheritdoc cref="TemperatureDelta.FromDegreesFahrenheitDelta(double?)"/>
        public static TemperatureDelta? DegreesFahrenheitDelta(this decimal? value) => TemperatureDelta.FromDegreesFahrenheitDelta(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region DegreeNewtonDelta

        /// <inheritdoc cref="TemperatureDelta.FromDegreesNewtonDelta(double)"/>
        public static TemperatureDelta DegreesNewtonDelta(this int value) => TemperatureDelta.FromDegreesNewtonDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesNewtonDelta(double?)"/>
        public static TemperatureDelta? DegreesNewtonDelta(this int? value) => TemperatureDelta.FromDegreesNewtonDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesNewtonDelta(double)"/>
        public static TemperatureDelta DegreesNewtonDelta(this long value) => TemperatureDelta.FromDegreesNewtonDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesNewtonDelta(double?)"/>
        public static TemperatureDelta? DegreesNewtonDelta(this long? value) => TemperatureDelta.FromDegreesNewtonDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesNewtonDelta(double)"/>
        public static TemperatureDelta DegreesNewtonDelta(this double value) => TemperatureDelta.FromDegreesNewtonDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesNewtonDelta(double?)"/>
        public static TemperatureDelta? DegreesNewtonDelta(this double? value) => TemperatureDelta.FromDegreesNewtonDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesNewtonDelta(double)"/>
        public static TemperatureDelta DegreesNewtonDelta(this float value) => TemperatureDelta.FromDegreesNewtonDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesNewtonDelta(double?)"/>
        public static TemperatureDelta? DegreesNewtonDelta(this float? value) => TemperatureDelta.FromDegreesNewtonDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesNewtonDelta(double)"/>
        public static TemperatureDelta DegreesNewtonDelta(this decimal value) => TemperatureDelta.FromDegreesNewtonDelta(Convert.ToDouble(value));

        /// <inheritdoc cref="TemperatureDelta.FromDegreesNewtonDelta(double?)"/>
        public static TemperatureDelta? DegreesNewtonDelta(this decimal? value) => TemperatureDelta.FromDegreesNewtonDelta(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region DegreeRankineDelta

        /// <inheritdoc cref="TemperatureDelta.FromDegreesRankineDelta(double)"/>
        public static TemperatureDelta DegreesRankineDelta(this int value) => TemperatureDelta.FromDegreesRankineDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesRankineDelta(double?)"/>
        public static TemperatureDelta? DegreesRankineDelta(this int? value) => TemperatureDelta.FromDegreesRankineDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesRankineDelta(double)"/>
        public static TemperatureDelta DegreesRankineDelta(this long value) => TemperatureDelta.FromDegreesRankineDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesRankineDelta(double?)"/>
        public static TemperatureDelta? DegreesRankineDelta(this long? value) => TemperatureDelta.FromDegreesRankineDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesRankineDelta(double)"/>
        public static TemperatureDelta DegreesRankineDelta(this double value) => TemperatureDelta.FromDegreesRankineDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesRankineDelta(double?)"/>
        public static TemperatureDelta? DegreesRankineDelta(this double? value) => TemperatureDelta.FromDegreesRankineDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesRankineDelta(double)"/>
        public static TemperatureDelta DegreesRankineDelta(this float value) => TemperatureDelta.FromDegreesRankineDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesRankineDelta(double?)"/>
        public static TemperatureDelta? DegreesRankineDelta(this float? value) => TemperatureDelta.FromDegreesRankineDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesRankineDelta(double)"/>
        public static TemperatureDelta DegreesRankineDelta(this decimal value) => TemperatureDelta.FromDegreesRankineDelta(Convert.ToDouble(value));

        /// <inheritdoc cref="TemperatureDelta.FromDegreesRankineDelta(double?)"/>
        public static TemperatureDelta? DegreesRankineDelta(this decimal? value) => TemperatureDelta.FromDegreesRankineDelta(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region DegreeReaumurDelta

        /// <inheritdoc cref="TemperatureDelta.FromDegreesReaumurDelta(double)"/>
        public static TemperatureDelta DegreesReaumurDelta(this int value) => TemperatureDelta.FromDegreesReaumurDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesReaumurDelta(double?)"/>
        public static TemperatureDelta? DegreesReaumurDelta(this int? value) => TemperatureDelta.FromDegreesReaumurDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesReaumurDelta(double)"/>
        public static TemperatureDelta DegreesReaumurDelta(this long value) => TemperatureDelta.FromDegreesReaumurDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesReaumurDelta(double?)"/>
        public static TemperatureDelta? DegreesReaumurDelta(this long? value) => TemperatureDelta.FromDegreesReaumurDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesReaumurDelta(double)"/>
        public static TemperatureDelta DegreesReaumurDelta(this double value) => TemperatureDelta.FromDegreesReaumurDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesReaumurDelta(double?)"/>
        public static TemperatureDelta? DegreesReaumurDelta(this double? value) => TemperatureDelta.FromDegreesReaumurDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesReaumurDelta(double)"/>
        public static TemperatureDelta DegreesReaumurDelta(this float value) => TemperatureDelta.FromDegreesReaumurDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesReaumurDelta(double?)"/>
        public static TemperatureDelta? DegreesReaumurDelta(this float? value) => TemperatureDelta.FromDegreesReaumurDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesReaumurDelta(double)"/>
        public static TemperatureDelta DegreesReaumurDelta(this decimal value) => TemperatureDelta.FromDegreesReaumurDelta(Convert.ToDouble(value));

        /// <inheritdoc cref="TemperatureDelta.FromDegreesReaumurDelta(double?)"/>
        public static TemperatureDelta? DegreesReaumurDelta(this decimal? value) => TemperatureDelta.FromDegreesReaumurDelta(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region DegreeRoemerDelta

        /// <inheritdoc cref="TemperatureDelta.FromDegreesRoemerDelta(double)"/>
        public static TemperatureDelta DegreesRoemerDelta(this int value) => TemperatureDelta.FromDegreesRoemerDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesRoemerDelta(double?)"/>
        public static TemperatureDelta? DegreesRoemerDelta(this int? value) => TemperatureDelta.FromDegreesRoemerDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesRoemerDelta(double)"/>
        public static TemperatureDelta DegreesRoemerDelta(this long value) => TemperatureDelta.FromDegreesRoemerDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesRoemerDelta(double?)"/>
        public static TemperatureDelta? DegreesRoemerDelta(this long? value) => TemperatureDelta.FromDegreesRoemerDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesRoemerDelta(double)"/>
        public static TemperatureDelta DegreesRoemerDelta(this double value) => TemperatureDelta.FromDegreesRoemerDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesRoemerDelta(double?)"/>
        public static TemperatureDelta? DegreesRoemerDelta(this double? value) => TemperatureDelta.FromDegreesRoemerDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesRoemerDelta(double)"/>
        public static TemperatureDelta DegreesRoemerDelta(this float value) => TemperatureDelta.FromDegreesRoemerDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesRoemerDelta(double?)"/>
        public static TemperatureDelta? DegreesRoemerDelta(this float? value) => TemperatureDelta.FromDegreesRoemerDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromDegreesRoemerDelta(double)"/>
        public static TemperatureDelta DegreesRoemerDelta(this decimal value) => TemperatureDelta.FromDegreesRoemerDelta(Convert.ToDouble(value));

        /// <inheritdoc cref="TemperatureDelta.FromDegreesRoemerDelta(double?)"/>
        public static TemperatureDelta? DegreesRoemerDelta(this decimal? value) => TemperatureDelta.FromDegreesRoemerDelta(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KelvinDelta

        /// <inheritdoc cref="TemperatureDelta.FromKelvinsDelta(double)"/>
        public static TemperatureDelta KelvinsDelta(this int value) => TemperatureDelta.FromKelvinsDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromKelvinsDelta(double?)"/>
        public static TemperatureDelta? KelvinsDelta(this int? value) => TemperatureDelta.FromKelvinsDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromKelvinsDelta(double)"/>
        public static TemperatureDelta KelvinsDelta(this long value) => TemperatureDelta.FromKelvinsDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromKelvinsDelta(double?)"/>
        public static TemperatureDelta? KelvinsDelta(this long? value) => TemperatureDelta.FromKelvinsDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromKelvinsDelta(double)"/>
        public static TemperatureDelta KelvinsDelta(this double value) => TemperatureDelta.FromKelvinsDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromKelvinsDelta(double?)"/>
        public static TemperatureDelta? KelvinsDelta(this double? value) => TemperatureDelta.FromKelvinsDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromKelvinsDelta(double)"/>
        public static TemperatureDelta KelvinsDelta(this float value) => TemperatureDelta.FromKelvinsDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromKelvinsDelta(double?)"/>
        public static TemperatureDelta? KelvinsDelta(this float? value) => TemperatureDelta.FromKelvinsDelta(value);

        /// <inheritdoc cref="TemperatureDelta.FromKelvinsDelta(double)"/>
        public static TemperatureDelta KelvinsDelta(this decimal value) => TemperatureDelta.FromKelvinsDelta(Convert.ToDouble(value));

        /// <inheritdoc cref="TemperatureDelta.FromKelvinsDelta(double?)"/>
        public static TemperatureDelta? KelvinsDelta(this decimal? value) => TemperatureDelta.FromKelvinsDelta(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
