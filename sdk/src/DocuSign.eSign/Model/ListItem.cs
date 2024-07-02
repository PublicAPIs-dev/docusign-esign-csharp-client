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
    /// One of the selectable items in the &#x60;listItems&#x60; property of a [&#x60;list&#x60;](/docs/esign-rest-api/reference/envelopes/enveloperecipienttabs/create/) tab.
    /// </summary>
    [DataContract]
    public partial class ListItem :  IEquatable<ListItem>, IValidatableObject
    {
        public ListItem()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListItem" /> class.
        /// </summary>
        /// <param name="Selected">When set to **true**, indicates that this item is the default selection shown to a signer.   Only one selection can be set as the default..</param>
        /// <param name="SelectedMetadata">Metadata that indicates whether the &#x60;selected&#x60; property is editable..</param>
        /// <param name="Text">Specifies the text that is shown in the dropdown list. .</param>
        /// <param name="TextMetadata">TextMetadata.</param>
        /// <param name="Value">Specifies the value that is used when the list item is selected..</param>
        /// <param name="ValueMetadata">Metadata that indicates whether the &#x60;value&#x60; property is editable..</param>
        public ListItem(string Selected = default(string), PropertyMetadata SelectedMetadata = default(PropertyMetadata), string Text = default(string), PropertyMetadata TextMetadata = default(PropertyMetadata), string Value = default(string), PropertyMetadata ValueMetadata = default(PropertyMetadata))
        {
            this.Selected = Selected;
            this.SelectedMetadata = SelectedMetadata;
            this.Text = Text;
            this.TextMetadata = TextMetadata;
            this.Value = Value;
            this.ValueMetadata = ValueMetadata;
        }
        
        /// <summary>
        /// When set to **true**, indicates that this item is the default selection shown to a signer.   Only one selection can be set as the default.
        /// </summary>
        /// <value>When set to **true**, indicates that this item is the default selection shown to a signer.   Only one selection can be set as the default.</value>
        [DataMember(Name="selected", EmitDefaultValue=false)]
        public string Selected { get; set; }
        /// <summary>
        /// Metadata that indicates whether the &#x60;selected&#x60; property is editable.
        /// </summary>
        /// <value>Metadata that indicates whether the &#x60;selected&#x60; property is editable.</value>
        [DataMember(Name="selectedMetadata", EmitDefaultValue=false)]
        public PropertyMetadata SelectedMetadata { get; set; }
        /// <summary>
        /// Specifies the text that is shown in the dropdown list. 
        /// </summary>
        /// <value>Specifies the text that is shown in the dropdown list. </value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }
        /// <summary>
        /// Gets or Sets TextMetadata
        /// </summary>
        [DataMember(Name="textMetadata", EmitDefaultValue=false)]
        public PropertyMetadata TextMetadata { get; set; }
        /// <summary>
        /// Specifies the value that is used when the list item is selected.
        /// </summary>
        /// <value>Specifies the value that is used when the list item is selected.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
        /// <summary>
        /// Metadata that indicates whether the &#x60;value&#x60; property is editable.
        /// </summary>
        /// <value>Metadata that indicates whether the &#x60;value&#x60; property is editable.</value>
        [DataMember(Name="valueMetadata", EmitDefaultValue=false)]
        public PropertyMetadata ValueMetadata { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListItem {\n");
            sb.Append("  Selected: ").Append(Selected).Append("\n");
            sb.Append("  SelectedMetadata: ").Append(SelectedMetadata).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  TextMetadata: ").Append(TextMetadata).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  ValueMetadata: ").Append(ValueMetadata).Append("\n");
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
            return this.Equals(obj as ListItem);
        }

        /// <summary>
        /// Returns true if ListItem instances are equal
        /// </summary>
        /// <param name="other">Instance of ListItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Selected == other.Selected ||
                    this.Selected != null &&
                    this.Selected.Equals(other.Selected)
                ) && 
                (
                    this.SelectedMetadata == other.SelectedMetadata ||
                    this.SelectedMetadata != null &&
                    this.SelectedMetadata.Equals(other.SelectedMetadata)
                ) && 
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
                ) && 
                (
                    this.TextMetadata == other.TextMetadata ||
                    this.TextMetadata != null &&
                    this.TextMetadata.Equals(other.TextMetadata)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) && 
                (
                    this.ValueMetadata == other.ValueMetadata ||
                    this.ValueMetadata != null &&
                    this.ValueMetadata.Equals(other.ValueMetadata)
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
                if (this.Selected != null)
                    hash = hash * 59 + this.Selected.GetHashCode();
                if (this.SelectedMetadata != null)
                    hash = hash * 59 + this.SelectedMetadata.GetHashCode();
                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();
                if (this.TextMetadata != null)
                    hash = hash * 59 + this.TextMetadata.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                if (this.ValueMetadata != null)
                    hash = hash * 59 + this.ValueMetadata.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
