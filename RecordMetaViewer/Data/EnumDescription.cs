using System;
using System.Globalization;

namespace RecordMetaViewer.Data
{
    /// <summary>
    /// A <see cref="System.ComponentModel.DescriptionAttribute"/> like Attribute can provide an assosiated Enum <see cref="Type"/> object.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field,AllowMultiple =true)]
    public class EnumDescriptionAttribute : Attribute
    {
        /// <summary>
        /// Assosiated enum type.
        /// </summary>
        public Type ConnectedEnumType { get; set; } = null;

        /// <summary>
        /// Description of this object.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Setter's culture if available.
        /// </summary>
        public CultureInfo Culture { get; set; } = CultureInfo.CurrentUICulture;

        /// <summary>
        /// Initialize <see cref="EnumDescriptionAttribute"/> with description, an assosiated enum <see cref="Type"/>,
        /// and setter's <see cref="CultureInfo"/>.
        /// </summary>
        public EnumDescriptionAttribute(string description,Type connectedEnum ,CultureInfo culture)
        {
            if (!connectedEnum.IsEnum) throw new InvalidOperationException("Paramater 'connectedEnum' must be an Enum type.");
            this.Description = description;
            this.ConnectedEnumType = connectedEnum;
            this.Culture = culture;
        }

        /// <summary>
        /// Initialize <see cref="EnumDescriptionAttribute"/> with description,
        /// and setter's <see cref="CultureInfo"/>.
        /// </summary>
        public EnumDescriptionAttribute(string description, CultureInfo culture)
        {
            this.Description = description;
            this.Culture = culture;
        }
        
        /// <summary>
        /// Initialize <see cref="EnumDescriptionAttribute"/> with description, an assosiated enum <see cref="Type"/>.
        /// </summary>
        public EnumDescriptionAttribute(string description, Type connectedEnum)
        {
            if (!connectedEnum.IsEnum) throw new InvalidOperationException("Paramater 'connectedEnum' must be an Enum type.");
            this.Description = description;
            this.ConnectedEnumType = connectedEnum;
        }

        /// <summary>
        /// Initialize <see cref="EnumDescriptionAttribute"/> with description.
        /// </summary>
        public EnumDescriptionAttribute(string description)
        {
            this.Description = description;
        }

        /// <summary>
        /// Initialize <see cref="EnumDescriptionAttribute"/> with default setting.
        /// </summary>
        public EnumDescriptionAttribute()
        {
            this.Description = "Undefined";
        }
    }
}
