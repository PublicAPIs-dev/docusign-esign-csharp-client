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
    /// Description of a page of a document.
    /// </summary>
    [DataContract]
    public partial class Page :  IEquatable<Page>, IValidatableObject
    {
        public Page()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Page" /> class.
        /// </summary>
        /// <param name="Dpi">The number of dots per inch used for the page image..</param>
        /// <param name="ErrorDetails">Array or errors..</param>
        /// <param name="Height">Height of the tab in pixels..</param>
        /// <param name="ImageBytes">ImageBytes.</param>
        /// <param name="MimeType">MimeType.</param>
        /// <param name="PageId">PageId.</param>
        /// <param name="Sequence">Sequence.</param>
        /// <param name="Width">Width of the tab in pixels..</param>
        public Page(string Dpi = default(string), ErrorDetails ErrorDetails = default(ErrorDetails), string Height = default(string), string ImageBytes = default(string), string MimeType = default(string), string PageId = default(string), string Sequence = default(string), string Width = default(string))
        {
            this.Dpi = Dpi;
            this.ErrorDetails = ErrorDetails;
            this.Height = Height;
            this.ImageBytes = ImageBytes;
            this.MimeType = MimeType;
            this.PageId = PageId;
            this.Sequence = Sequence;
            this.Width = Width;
        }
        
        /// <summary>
        /// The number of dots per inch used for the page image.
        /// </summary>
        /// <value>The number of dots per inch used for the page image.</value>
        [DataMember(Name="dpi", EmitDefaultValue=false)]
        public string Dpi { get; set; }
        /// <summary>
        /// Array or errors.
        /// </summary>
        /// <value>Array or errors.</value>
        [DataMember(Name="errorDetails", EmitDefaultValue=false)]
        public ErrorDetails ErrorDetails { get; set; }
        /// <summary>
        /// Height of the tab in pixels.
        /// </summary>
        /// <value>Height of the tab in pixels.</value>
        [DataMember(Name="height", EmitDefaultValue=false)]
        public string Height { get; set; }
        /// <summary>
        /// Gets or Sets ImageBytes
        /// </summary>
        [DataMember(Name="imageBytes", EmitDefaultValue=false)]
        public string ImageBytes { get; set; }
        /// <summary>
        /// Gets or Sets MimeType
        /// </summary>
        [DataMember(Name="mimeType", EmitDefaultValue=false)]
        public string MimeType { get; set; }
        /// <summary>
        /// Gets or Sets PageId
        /// </summary>
        [DataMember(Name="pageId", EmitDefaultValue=false)]
        public string PageId { get; set; }
        /// <summary>
        /// Gets or Sets Sequence
        /// </summary>
        [DataMember(Name="sequence", EmitDefaultValue=false)]
        public string Sequence { get; set; }
        /// <summary>
        /// Width of the tab in pixels.
        /// </summary>
        /// <value>Width of the tab in pixels.</value>
        [DataMember(Name="width", EmitDefaultValue=false)]
        public string Width { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Page {\n");
            sb.Append("  Dpi: ").Append(Dpi).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  ImageBytes: ").Append(ImageBytes).Append("\n");
            sb.Append("  MimeType: ").Append(MimeType).Append("\n");
            sb.Append("  PageId: ").Append(PageId).Append("\n");
            sb.Append("  Sequence: ").Append(Sequence).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
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
            return this.Equals(obj as Page);
        }

        /// <summary>
        /// Returns true if Page instances are equal
        /// </summary>
        /// <param name="other">Instance of Page to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Page other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Dpi == other.Dpi ||
                    this.Dpi != null &&
                    this.Dpi.Equals(other.Dpi)
                ) && 
                (
                    this.ErrorDetails == other.ErrorDetails ||
                    this.ErrorDetails != null &&
                    this.ErrorDetails.Equals(other.ErrorDetails)
                ) && 
                (
                    this.Height == other.Height ||
                    this.Height != null &&
                    this.Height.Equals(other.Height)
                ) && 
                (
                    this.ImageBytes == other.ImageBytes ||
                    this.ImageBytes != null &&
                    this.ImageBytes.Equals(other.ImageBytes)
                ) && 
                (
                    this.MimeType == other.MimeType ||
                    this.MimeType != null &&
                    this.MimeType.Equals(other.MimeType)
                ) && 
                (
                    this.PageId == other.PageId ||
                    this.PageId != null &&
                    this.PageId.Equals(other.PageId)
                ) && 
                (
                    this.Sequence == other.Sequence ||
                    this.Sequence != null &&
                    this.Sequence.Equals(other.Sequence)
                ) && 
                (
                    this.Width == other.Width ||
                    this.Width != null &&
                    this.Width.Equals(other.Width)
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
                if (this.Dpi != null)
                    hash = hash * 59 + this.Dpi.GetHashCode();
                if (this.ErrorDetails != null)
                    hash = hash * 59 + this.ErrorDetails.GetHashCode();
                if (this.Height != null)
                    hash = hash * 59 + this.Height.GetHashCode();
                if (this.ImageBytes != null)
                    hash = hash * 59 + this.ImageBytes.GetHashCode();
                if (this.MimeType != null)
                    hash = hash * 59 + this.MimeType.GetHashCode();
                if (this.PageId != null)
                    hash = hash * 59 + this.PageId.GetHashCode();
                if (this.Sequence != null)
                    hash = hash * 59 + this.Sequence.GetHashCode();
                if (this.Width != null)
                    hash = hash * 59 + this.Width.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
