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
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// Provides properties that describe the contents of a workspace folder.
    /// </summary>
    [DataContract]
    public partial class WorkspaceFolderContents :  IEquatable<WorkspaceFolderContents>, IValidatableObject
    {
        public WorkspaceFolderContents()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceFolderContents" /> class.
        /// </summary>
        /// <param name="EndPosition">The last position in the result set. .</param>
        /// <param name="Folder">The folder from which to return items. You can enter either the folder name or folder ID..</param>
        /// <param name="Items">Items.</param>
        /// <param name="ParentFolders">ParentFolders.</param>
        /// <param name="ResultSetSize">The number of results returned in this response. .</param>
        /// <param name="StartPosition">Starting position of the current result set..</param>
        /// <param name="TotalSetSize">The total number of items available in the result set. This will always be greater than or equal to the value of the property returning the results in the in the response..</param>
        /// <param name="WorkspaceId">The id of the workspace, always populated..</param>
        public WorkspaceFolderContents(string EndPosition = default(string), WorkspaceItem Folder = default(WorkspaceItem), List<WorkspaceItem> Items = default(List<WorkspaceItem>), List<WorkspaceItem> ParentFolders = default(List<WorkspaceItem>), string ResultSetSize = default(string), string StartPosition = default(string), string TotalSetSize = default(string), string WorkspaceId = default(string))
        {
            this.EndPosition = EndPosition;
            this.Folder = Folder;
            this.Items = Items;
            this.ParentFolders = ParentFolders;
            this.ResultSetSize = ResultSetSize;
            this.StartPosition = StartPosition;
            this.TotalSetSize = TotalSetSize;
            this.WorkspaceId = WorkspaceId;
        }
        
        /// <summary>
        /// The last position in the result set. 
        /// </summary>
        /// <value>The last position in the result set. </value>
        [DataMember(Name="endPosition", EmitDefaultValue=false)]
        public string EndPosition { get; set; }
        /// <summary>
        /// The folder from which to return items. You can enter either the folder name or folder ID.
        /// </summary>
        /// <value>The folder from which to return items. You can enter either the folder name or folder ID.</value>
        [DataMember(Name="folder", EmitDefaultValue=false)]
        public WorkspaceItem Folder { get; set; }
        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<WorkspaceItem> Items { get; set; }
        /// <summary>
        /// Gets or Sets ParentFolders
        /// </summary>
        [DataMember(Name="parentFolders", EmitDefaultValue=false)]
        public List<WorkspaceItem> ParentFolders { get; set; }
        /// <summary>
        /// The number of results returned in this response. 
        /// </summary>
        /// <value>The number of results returned in this response. </value>
        [DataMember(Name="resultSetSize", EmitDefaultValue=false)]
        public string ResultSetSize { get; set; }
        /// <summary>
        /// Starting position of the current result set.
        /// </summary>
        /// <value>Starting position of the current result set.</value>
        [DataMember(Name="startPosition", EmitDefaultValue=false)]
        public string StartPosition { get; set; }
        /// <summary>
        /// The total number of items available in the result set. This will always be greater than or equal to the value of the property returning the results in the in the response.
        /// </summary>
        /// <value>The total number of items available in the result set. This will always be greater than or equal to the value of the property returning the results in the in the response.</value>
        [DataMember(Name="totalSetSize", EmitDefaultValue=false)]
        public string TotalSetSize { get; set; }
        /// <summary>
        /// The id of the workspace, always populated.
        /// </summary>
        /// <value>The id of the workspace, always populated.</value>
        [DataMember(Name="workspaceId", EmitDefaultValue=false)]
        public string WorkspaceId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkspaceFolderContents {\n");
            sb.Append("  EndPosition: ").Append(EndPosition).Append("\n");
            sb.Append("  Folder: ").Append(Folder).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  ParentFolders: ").Append(ParentFolders).Append("\n");
            sb.Append("  ResultSetSize: ").Append(ResultSetSize).Append("\n");
            sb.Append("  StartPosition: ").Append(StartPosition).Append("\n");
            sb.Append("  TotalSetSize: ").Append(TotalSetSize).Append("\n");
            sb.Append("  WorkspaceId: ").Append(WorkspaceId).Append("\n");
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
            return this.Equals(obj as WorkspaceFolderContents);
        }

        /// <summary>
        /// Returns true if WorkspaceFolderContents instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkspaceFolderContents to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkspaceFolderContents other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EndPosition == other.EndPosition ||
                    this.EndPosition != null &&
                    this.EndPosition.Equals(other.EndPosition)
                ) && 
                (
                    this.Folder == other.Folder ||
                    this.Folder != null &&
                    this.Folder.Equals(other.Folder)
                ) && 
                (
                    this.Items == other.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(other.Items)
                ) && 
                (
                    this.ParentFolders == other.ParentFolders ||
                    this.ParentFolders != null &&
                    this.ParentFolders.SequenceEqual(other.ParentFolders)
                ) && 
                (
                    this.ResultSetSize == other.ResultSetSize ||
                    this.ResultSetSize != null &&
                    this.ResultSetSize.Equals(other.ResultSetSize)
                ) && 
                (
                    this.StartPosition == other.StartPosition ||
                    this.StartPosition != null &&
                    this.StartPosition.Equals(other.StartPosition)
                ) && 
                (
                    this.TotalSetSize == other.TotalSetSize ||
                    this.TotalSetSize != null &&
                    this.TotalSetSize.Equals(other.TotalSetSize)
                ) && 
                (
                    this.WorkspaceId == other.WorkspaceId ||
                    this.WorkspaceId != null &&
                    this.WorkspaceId.Equals(other.WorkspaceId)
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
                if (this.EndPosition != null)
                    hash = hash * 59 + this.EndPosition.GetHashCode();
                if (this.Folder != null)
                    hash = hash * 59 + this.Folder.GetHashCode();
                if (this.Items != null)
                    hash = hash * 59 + this.Items.GetHashCode();
                if (this.ParentFolders != null)
                    hash = hash * 59 + this.ParentFolders.GetHashCode();
                if (this.ResultSetSize != null)
                    hash = hash * 59 + this.ResultSetSize.GetHashCode();
                if (this.StartPosition != null)
                    hash = hash * 59 + this.StartPosition.GetHashCode();
                if (this.TotalSetSize != null)
                    hash = hash * 59 + this.TotalSetSize.GetHashCode();
                if (this.WorkspaceId != null)
                    hash = hash * 59 + this.WorkspaceId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
