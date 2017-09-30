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
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.Units;

// Windows Runtime Component does not support CultureInfo type, so use culture name string instead for public methods: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if WINDOWS_UWP
using Culture = System.String;
#else
using Culture = System.IFormatProvider;
#endif

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     Angular acceleration is the rate of change of rotational speed.
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
#if WINDOWS_UWP
    public sealed partial class RotationalAcceleration
#else
    public partial struct RotationalAcceleration : IComparable, IComparable<RotationalAcceleration>
#endif
    {
        /// <summary>
        ///     Base unit of RotationalAcceleration.
        /// </summary>
        private readonly double _radiansPerSecondSquared;

		// Windows Runtime Component requires a default constructor
#if WINDOWS_UWP
        public RotationalAcceleration() : this(0)
        {
        }
#endif

        public RotationalAcceleration(double radianspersecondsquared)
        {
            _radiansPerSecondSquared = Convert.ToDouble(radianspersecondsquared);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        private
#else
        public
#endif
        RotationalAcceleration(long radianspersecondsquared)
        {
            _radiansPerSecondSquared = Convert.ToDouble(radianspersecondsquared);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        // Windows Runtime Component does not support decimal type
#if WINDOWS_UWP
        private
#else
        public
#endif
        RotationalAcceleration(decimal radianspersecondsquared)
        {
            _radiansPerSecondSquared = Convert.ToDouble(radianspersecondsquared);
        }

        #region Properties

		/// <summary>
		///     The <see cref="QuantityType" /> of this quantity.
		/// </summary>
        public static QuantityType QuantityType => QuantityType.RotationalAcceleration;

		/// <summary>
		///     The base unit representation of this quantity for the numeric value stored internally. All conversions go via this value.
		/// </summary>
        public static RotationalAccelerationUnit BaseUnit
        {
            get { return RotationalAccelerationUnit.RadianPerSecondSquared; }
        }

        /// <summary>
        ///     All units of measurement for the RotationalAcceleration quantity.
        /// </summary>
        public static RotationalAccelerationUnit[] Units { get; } = Enum.GetValues(typeof(RotationalAccelerationUnit)).Cast<RotationalAccelerationUnit>().ToArray();

        /// <summary>
        ///     Get RotationalAcceleration in DegreesPerSecondSquared.
        /// </summary>
        public double DegreesPerSecondSquared
        {
            get { return (180/Math.PI)*_radiansPerSecondSquared; }
        }

        /// <summary>
        ///     Get RotationalAcceleration in RadiansPerSecondSquared.
        /// </summary>
        public double RadiansPerSecondSquared
        {
            get { return _radiansPerSecondSquared; }
        }

        #endregion

        #region Static

        public static RotationalAcceleration Zero
        {
            get { return new RotationalAcceleration(); }
        }

        /// <summary>
        ///     Get RotationalAcceleration from DegreesPerSecondSquared.
        /// </summary>
        public static RotationalAcceleration FromDegreesPerSecondSquared(double degreespersecondsquared)
        {
            return new RotationalAcceleration((Math.PI/180)*degreespersecondsquared);
        }

        /// <summary>
        ///     Get RotationalAcceleration from RadiansPerSecondSquared.
        /// </summary>
        public static RotationalAcceleration FromRadiansPerSecondSquared(double radianspersecondsquared)
        {
            return new RotationalAcceleration(radianspersecondsquared);
        }

        // Windows Runtime Component does not support nullable types (double?): https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        /// <summary>
        ///     Get nullable RotationalAcceleration from nullable DegreesPerSecondSquared.
        /// </summary>
        public static RotationalAcceleration? FromDegreesPerSecondSquared(double? degreespersecondsquared)
        {
            if (degreespersecondsquared.HasValue)
            {
                return FromDegreesPerSecondSquared(degreespersecondsquared.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable RotationalAcceleration from nullable RadiansPerSecondSquared.
        /// </summary>
        public static RotationalAcceleration? FromRadiansPerSecondSquared(double? radianspersecondsquared)
        {
            if (radianspersecondsquared.HasValue)
            {
                return FromRadiansPerSecondSquared(radianspersecondsquared.Value);
            }
            else
            {
                return null;
            }
        }

#endif

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="RotationalAccelerationUnit" /> to <see cref="RotationalAcceleration" />.
        /// </summary>
        /// <param name="val">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>RotationalAcceleration unit value.</returns>
        public static RotationalAcceleration From(double val, RotationalAccelerationUnit fromUnit)
        {
            switch (fromUnit)
            {
                case RotationalAccelerationUnit.DegreePerSecondSquared:
                    return FromDegreesPerSecondSquared(val);
                case RotationalAccelerationUnit.RadianPerSecondSquared:
                    return FromRadiansPerSecondSquared(val);

                default:
                    throw new NotImplementedException("fromUnit: " + fromUnit);
            }
        }

        // Windows Runtime Component does not support nullable types (double?): https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="RotationalAccelerationUnit" /> to <see cref="RotationalAcceleration" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>RotationalAcceleration unit value.</returns>
        public static RotationalAcceleration? From(double? value, RotationalAccelerationUnit fromUnit)
        {
            if (!value.HasValue)
            {
                return null;
            }
            switch (fromUnit)
            {
                case RotationalAccelerationUnit.DegreePerSecondSquared:
                    return FromDegreesPerSecondSquared(value.Value);
                case RotationalAccelerationUnit.RadianPerSecondSquared:
                    return FromRadiansPerSecondSquared(value.Value);

                default:
                    throw new NotImplementedException("fromUnit: " + fromUnit);
            }
        }
#endif

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(RotationalAccelerationUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <param name="culture">Culture to use for localization. Defaults to Thread.CurrentUICulture.</param>
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(RotationalAccelerationUnit unit, [CanBeNull] Culture culture)
        {
            return UnitSystem.GetCached(culture).GetDefaultAbbreviation(unit);
        }

        #endregion

        #region Arithmetic Operators

        // Windows Runtime Component does not allow operator overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        public static RotationalAcceleration operator -(RotationalAcceleration right)
        {
            return new RotationalAcceleration(-right._radiansPerSecondSquared);
        }

        public static RotationalAcceleration operator +(RotationalAcceleration left, RotationalAcceleration right)
        {
            return new RotationalAcceleration(left._radiansPerSecondSquared + right._radiansPerSecondSquared);
        }

        public static RotationalAcceleration operator -(RotationalAcceleration left, RotationalAcceleration right)
        {
            return new RotationalAcceleration(left._radiansPerSecondSquared - right._radiansPerSecondSquared);
        }

        public static RotationalAcceleration operator *(double left, RotationalAcceleration right)
        {
            return new RotationalAcceleration(left*right._radiansPerSecondSquared);
        }

        public static RotationalAcceleration operator *(RotationalAcceleration left, double right)
        {
            return new RotationalAcceleration(left._radiansPerSecondSquared*(double)right);
        }

        public static RotationalAcceleration operator /(RotationalAcceleration left, double right)
        {
            return new RotationalAcceleration(left._radiansPerSecondSquared/(double)right);
        }

        public static double operator /(RotationalAcceleration left, RotationalAcceleration right)
        {
            return Convert.ToDouble(left._radiansPerSecondSquared/right._radiansPerSecondSquared);
        }
#endif

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");
            if (!(obj is RotationalAcceleration)) throw new ArgumentException("Expected type RotationalAcceleration.", "obj");
            return CompareTo((RotationalAcceleration) obj);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        internal
#else
        public
#endif
        int CompareTo(RotationalAcceleration other)
        {
            return _radiansPerSecondSquared.CompareTo(other._radiansPerSecondSquared);
        }

        // Windows Runtime Component does not allow operator overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        public static bool operator <=(RotationalAcceleration left, RotationalAcceleration right)
        {
            return left._radiansPerSecondSquared <= right._radiansPerSecondSquared;
        }

        public static bool operator >=(RotationalAcceleration left, RotationalAcceleration right)
        {
            return left._radiansPerSecondSquared >= right._radiansPerSecondSquared;
        }

        public static bool operator <(RotationalAcceleration left, RotationalAcceleration right)
        {
            return left._radiansPerSecondSquared < right._radiansPerSecondSquared;
        }

        public static bool operator >(RotationalAcceleration left, RotationalAcceleration right)
        {
            return left._radiansPerSecondSquared > right._radiansPerSecondSquared;
        }

        public static bool operator ==(RotationalAcceleration left, RotationalAcceleration right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left._radiansPerSecondSquared == right._radiansPerSecondSquared;
        }

        public static bool operator !=(RotationalAcceleration left, RotationalAcceleration right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left._radiansPerSecondSquared != right._radiansPerSecondSquared;
        }
#endif

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return _radiansPerSecondSquared.Equals(((RotationalAcceleration) obj)._radiansPerSecondSquared);
        }

        public override int GetHashCode()
        {
            return _radiansPerSecondSquared.GetHashCode();
        }

        #endregion

        #region Conversion

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value in new unit if successful, exception otherwise.</returns>
        /// <exception cref="NotImplementedException">If conversion was not successful.</exception>
        public double As(RotationalAccelerationUnit unit)
        {
            switch (unit)
            {
                case RotationalAccelerationUnit.DegreePerSecondSquared:
                    return DegreesPerSecondSquared;
                case RotationalAccelerationUnit.RadianPerSecondSquared:
                    return RadiansPerSecondSquared;

                default:
                    throw new NotImplementedException("unit: " + unit);
            }
        }

        #endregion

        #region Parsing

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static RotationalAcceleration Parse(string str)
        {
            return Parse(str, null);
        }

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="culture">Format to use when parsing number and unit. If it is null, it defaults to <see cref="NumberFormatInfo.CurrentInfo"/> for parsing the number and <see cref="CultureInfo.CurrentUICulture"/> for parsing the unit abbreviation by culture/language.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static RotationalAcceleration Parse(string str, [CanBeNull] Culture culture)
        {
            if (str == null) throw new ArgumentNullException("str");

        // Windows Runtime Component does not support CultureInfo type, so use culture name string for public methods instead: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if WINDOWS_UWP
            IFormatProvider formatProvider = culture == null ? null : new CultureInfo(culture);
#else
            IFormatProvider formatProvider = culture;
#endif
            return QuantityParser.Parse<RotationalAcceleration, RotationalAccelerationUnit>(str, formatProvider,
                delegate(string value, string unit, IFormatProvider formatProvider2)
                {
                    double parsedValue = double.Parse(value, formatProvider2);
                    RotationalAccelerationUnit parsedUnit = ParseUnit(unit, formatProvider2);
                    return From(parsedValue, parsedUnit);
                }, (x, y) => FromRadiansPerSecondSquared(x.RadiansPerSecondSquared + y.RadiansPerSecondSquared));
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, out RotationalAcceleration result)
        {
            return TryParse(str, null, out result);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="culture">Format to use when parsing number and unit. If it is null, it defaults to <see cref="NumberFormatInfo.CurrentInfo"/> for parsing the number and <see cref="CultureInfo.CurrentUICulture"/> for parsing the unit abbreviation by culture/language.</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, [CanBeNull] Culture culture, out RotationalAcceleration result)
        {
            try
            {
                result = Parse(str, culture);
                return true;
            }
            catch
            {
                result = default(RotationalAcceleration);
                return false;
            }
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static RotationalAccelerationUnit ParseUnit(string str)
        {
            return ParseUnit(str, (IFormatProvider)null);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static RotationalAccelerationUnit ParseUnit(string str, [CanBeNull] string cultureName)
        {
            return ParseUnit(str, cultureName == null ? null : new CultureInfo(cultureName));
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        internal
#else
        public
#endif
        static RotationalAccelerationUnit ParseUnit(string str, IFormatProvider formatProvider = null)
        {
            if (str == null) throw new ArgumentNullException("str");

            var unitSystem = UnitSystem.GetCached(formatProvider);
            var unit = unitSystem.Parse<RotationalAccelerationUnit>(str.Trim());

            if (unit == RotationalAccelerationUnit.Undefined)
            {
                var newEx = new UnitsNetException("Error parsing string. The unit is not a recognized RotationalAccelerationUnit.");
                newEx.Data["input"] = str;
                newEx.Data["formatprovider"] = formatProvider?.ToString() ?? "(null)";
                throw newEx;
            }

            return unit;
        }

        #endregion

        /// <summary>
        ///     Set the default unit used by ToString(). Default is RadianPerSecondSquared
        /// </summary>
        public static RotationalAccelerationUnit ToStringDefaultUnit { get; set; } = RotationalAccelerationUnit.RadianPerSecondSquared;

        /// <summary>
        ///     Get default string representation of value and unit.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return ToString(ToStringDefaultUnit);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using current UI culture and two significant digits after radix.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <returns>String representation.</returns>
        public string ToString(RotationalAccelerationUnit unit)
        {
            return ToString(unit, null, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using two significant digits after radix.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="culture">Culture to use for localization and number formatting.</param>
        /// <returns>String representation.</returns>
        public string ToString(RotationalAccelerationUnit unit, [CanBeNull] Culture culture)
        {
            return ToString(unit, culture, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="culture">Culture to use for localization and number formatting.</param>
        /// <param name="significantDigitsAfterRadix">The number of significant digits after the radix point.</param>
        /// <returns>String representation.</returns>
        [UsedImplicitly]
        public string ToString(RotationalAccelerationUnit unit, [CanBeNull] Culture culture, int significantDigitsAfterRadix)
        {
            double value = As(unit);
            string format = UnitFormatter.GetFormat(value, significantDigitsAfterRadix);
            return ToString(unit, culture, format);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="culture">Culture to use for localization and number formatting.</param>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="format">String format to use. Default:  "{0:0.##} {1} for value and unit abbreviation respectively."</param>
        /// <param name="args">Arguments for string format. Value and unit are implictly included as arguments 0 and 1.</param>
        /// <returns>String representation.</returns>
        [UsedImplicitly]
        public string ToString(RotationalAccelerationUnit unit, [CanBeNull] Culture culture, [NotNull] string format,
            [NotNull] params object[] args)
        {
            if (format == null) throw new ArgumentNullException(nameof(format));
            if (args == null) throw new ArgumentNullException(nameof(args));

        // Windows Runtime Component does not support CultureInfo type, so use culture name string for public methods instead: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if WINDOWS_UWP
            IFormatProvider formatProvider = culture == null ? null : new CultureInfo(culture);
#else
            IFormatProvider formatProvider = culture;
#endif
            double value = As(unit);
            object[] formatArgs = UnitFormatter.GetFormatArgs(unit, value, formatProvider, args);
            return string.Format(formatProvider, format, formatArgs);
        }

        /// <summary>
        /// Represents the largest possible value of RotationalAcceleration
        /// </summary>
        public static RotationalAcceleration MaxValue
        {
            get
            {
                return new RotationalAcceleration(double.MaxValue);
            }
        }

        /// <summary>
        /// Represents the smallest possible value of RotationalAcceleration
        /// </summary>
        public static RotationalAcceleration MinValue
        {
            get
            {
                return new RotationalAcceleration(double.MinValue);
            }
        }
    }
}
