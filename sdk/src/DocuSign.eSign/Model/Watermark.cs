/* 
 * Docusign eSignature REST API
 *
 * The Docusign eSignature REST API provides you with a powerful, convenient, and simple Web services API for interacting with Docusign.
 *
 * OpenAPI spec version: v2.1
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// Watermark
    /// </summary>
    [DataContract]
    public partial class Watermark :  IEquatable<Watermark>, IValidatableObject
    {
        public Watermark()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Watermark" /> class.
        /// </summary>
        /// <param name="DisplayAngle">DisplayAngle.</param>
        /// <param name="Enabled">Enabled.</param>
        /// <param name="Font">The font to be used for the tab value. Supported Fonts: Arial, Arial, ArialNarrow, Calibri, CourierNew, Garamond, Georgia, Helvetica,   LucidaConsole, Tahoma, TimesNewRoman, Trebuchet, Verdana, MSGothic, MSMincho, Default..</param>
        /// <param name="FontColor">The font color used for the information in the tab.  Possible values are: Black, BrightBlue, BrightRed, DarkGreen, DarkRed, Gold, Green, NavyBlue, Purple, or White..</param>
        /// <param name="FontSize">The font size used for the information in the tab.  Possible values are: Size7, Size8, Size9, Size10, Size11, Size12, Size14, Size16, Size18, Size20, Size22, Size24, Size26, Size28, Size36, Size48, or Size72..</param>
        /// <param name="Id">Id.</param>
        /// <param name="ImageBase64">ImageBase64.</param>
        /// <param name="Transparency">Transparency.</param>
        /// <param name="WatermarkText">WatermarkText.</param>
        public Watermark(string DisplayAngle = default(string), string Enabled = default(string), string Font = default(string), string FontColor = default(string), string FontSize = default(string), string Id = default(string), string ImageBase64 = default(string), string Transparency = default(string), string WatermarkText = default(string))
        {
            this.DisplayAngle = DisplayAngle;
            this.Enabled = Enabled;
            this.Font = Font;
            this.FontColor = FontColor;
            this.FontSize = FontSize;
            this.Id = Id;
            this.ImageBase64 = ImageBase64;
            this.Transparency = Transparency;
            this.WatermarkText = WatermarkText;
        }
        
        /// <summary>
        /// Gets or Sets DisplayAngle
        /// </summary>
        [DataMember(Name="displayAngle", EmitDefaultValue=false)]
        public string DisplayAngle { get; set; }
        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public string Enabled { get; set; }
        /// <summary>
        /// The font to be used for the tab value. Supported Fonts: Arial, Arial, ArialNarrow, Calibri, CourierNew, Garamond, Georgia, Helvetica,   LucidaConsole, Tahoma, TimesNewRoman, Trebuchet, Verdana, MSGothic, MSMincho, Default.
        /// </summary>
        /// <value>The font to be used for the tab value. Supported Fonts: Arial, Arial, ArialNarrow, Calibri, CourierNew, Garamond, Georgia, Helvetica,   LucidaConsole, Tahoma, TimesNewRoman, Trebuchet, Verdana, MSGothic, MSMincho, Default.</value>
        [DataMember(Name="font", EmitDefaultValue=false)]
        public string Font { get; set; }
        /// <summary>
        /// The font color used for the information in the tab.  Possible values are: Black, BrightBlue, BrightRed, DarkGreen, DarkRed, Gold, Green, NavyBlue, Purple, or White.
        /// </summary>
        /// <value>The font color used for the information in the tab.  Possible values are: Black, BrightBlue, BrightRed, DarkGreen, DarkRed, Gold, Green, NavyBlue, Purple, or White.</value>
        [DataMember(Name="fontColor", EmitDefaultValue=false)]
        public string FontColor { get; set; }
        /// <summary>
        /// The font size used for the information in the tab.  Possible values are: Size7, Size8, Size9, Size10, Size11, Size12, Size14, Size16, Size18, Size20, Size22, Size24, Size26, Size28, Size36, Size48, or Size72.
        /// </summary>
        /// <value>The font size used for the information in the tab.  Possible values are: Size7, Size8, Size9, Size10, Size11, Size12, Size14, Size16, Size18, Size20, Size22, Size24, Size26, Size28, Size36, Size48, or Size72.</value>
        [DataMember(Name="fontSize", EmitDefaultValue=false)]
        public string FontSize { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets ImageBase64
        /// </summary>
        [DataMember(Name="imageBase64", EmitDefaultValue=false)]
        public string ImageBase64 { get; set; }
        /// <summary>
        /// Gets or Sets Transparency
        /// </summary>
        [DataMember(Name="transparency", EmitDefaultValue=false)]
        public string Transparency { get; set; }
        /// <summary>
        /// Gets or Sets WatermarkText
        /// </summary>
        [DataMember(Name="watermarkText", EmitDefaultValue=false)]
        public string WatermarkText { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Watermark {\n");
            sb.Append("  DisplayAngle: ").Append(DisplayAngle).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Font: ").Append(Font).Append("\n");
            sb.Append("  FontColor: ").Append(FontColor).Append("\n");
            sb.Append("  FontSize: ").Append(FontSize).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ImageBase64: ").Append(ImageBase64).Append("\n");
            sb.Append("  Transparency: ").Append(Transparency).Append("\n");
            sb.Append("  WatermarkText: ").Append(WatermarkText).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Watermark);
        }

        /// <summary>
        /// Returns true if Watermark instances are equal
        /// </summary>
        /// <param name="other">Instance of Watermark to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Watermark other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DisplayAngle == other.DisplayAngle ||
                    this.DisplayAngle != null &&
                    this.DisplayAngle.Equals(other.DisplayAngle)
                ) && 
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) && 
                (
                    this.Font == other.Font ||
                    this.Font != null &&
                    this.Font.Equals(other.Font)
                ) && 
                (
                    this.FontColor == other.FontColor ||
                    this.FontColor != null &&
                    this.FontColor.Equals(other.FontColor)
                ) && 
                (
                    this.FontSize == other.FontSize ||
                    this.FontSize != null &&
                    this.FontSize.Equals(other.FontSize)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.ImageBase64 == other.ImageBase64 ||
                    this.ImageBase64 != null &&
                    this.ImageBase64.Equals(other.ImageBase64)
                ) && 
                (
                    this.Transparency == other.Transparency ||
                    this.Transparency != null &&
                    this.Transparency.Equals(other.Transparency)
                ) && 
                (
                    this.WatermarkText == other.WatermarkText ||
                    this.WatermarkText != null &&
                    this.WatermarkText.Equals(other.WatermarkText)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.DisplayAngle != null)
                    hash = hash * 59 + this.DisplayAngle.GetHashCode();
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                if (this.Font != null)
                    hash = hash * 59 + this.Font.GetHashCode();
                if (this.FontColor != null)
                    hash = hash * 59 + this.FontColor.GetHashCode();
                if (this.FontSize != null)
                    hash = hash * 59 + this.FontSize.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.ImageBase64 != null)
                    hash = hash * 59 + this.ImageBase64.GetHashCode();
                if (this.Transparency != null)
                    hash = hash * 59 + this.Transparency.GetHashCode();
                if (this.WatermarkText != null)
                    hash = hash * 59 + this.WatermarkText.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
