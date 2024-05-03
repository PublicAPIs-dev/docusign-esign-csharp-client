/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
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
    /// EnvelopeViewTaggerSettings
    /// </summary>
    [DataContract]
    public partial class EnvelopeViewTaggerSettings :  IEquatable<EnvelopeViewTaggerSettings>, IValidatableObject
    {
        public EnvelopeViewTaggerSettings()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvelopeViewTaggerSettings" /> class.
        /// </summary>
        /// <param name="PaletteDefault">PaletteDefault.</param>
        /// <param name="PaletteSections">PaletteSections.</param>
        /// <param name="PaletteSettings">PaletteSettings.</param>
        public EnvelopeViewTaggerSettings(string PaletteDefault = default(string), string PaletteSections = default(string), PaletteSettings PaletteSettings = default(PaletteSettings))
        {
            this.PaletteDefault = PaletteDefault;
            this.PaletteSections = PaletteSections;
            this.PaletteSettings = PaletteSettings;
        }
        
        /// <summary>
        /// Gets or Sets PaletteDefault
        /// </summary>
        [DataMember(Name="paletteDefault", EmitDefaultValue=false)]
        public string PaletteDefault { get; set; }
        /// <summary>
        /// Gets or Sets PaletteSections
        /// </summary>
        [DataMember(Name="paletteSections", EmitDefaultValue=false)]
        public string PaletteSections { get; set; }
        /// <summary>
        /// Gets or Sets PaletteSettings
        /// </summary>
        [DataMember(Name="paletteSettings", EmitDefaultValue=false)]
        public PaletteSettings PaletteSettings { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnvelopeViewTaggerSettings {\n");
            sb.Append("  PaletteDefault: ").Append(PaletteDefault).Append("\n");
            sb.Append("  PaletteSections: ").Append(PaletteSections).Append("\n");
            sb.Append("  PaletteSettings: ").Append(PaletteSettings).Append("\n");
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
            return this.Equals(obj as EnvelopeViewTaggerSettings);
        }

        /// <summary>
        /// Returns true if EnvelopeViewTaggerSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of EnvelopeViewTaggerSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnvelopeViewTaggerSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PaletteDefault == other.PaletteDefault ||
                    this.PaletteDefault != null &&
                    this.PaletteDefault.Equals(other.PaletteDefault)
                ) && 
                (
                    this.PaletteSections == other.PaletteSections ||
                    this.PaletteSections != null &&
                    this.PaletteSections.Equals(other.PaletteSections)
                ) && 
                (
                    this.PaletteSettings == other.PaletteSettings ||
                    this.PaletteSettings != null &&
                    this.PaletteSettings.Equals(other.PaletteSettings)
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
                if (this.PaletteDefault != null)
                    hash = hash * 59 + this.PaletteDefault.GetHashCode();
                if (this.PaletteSections != null)
                    hash = hash * 59 + this.PaletteSections.GetHashCode();
                if (this.PaletteSettings != null)
                    hash = hash * 59 + this.PaletteSettings.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
