/* 
 * Gestão de Propostas
 *
 * API de Gestão de Propostas.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Objeto de resposta para o número da proposta.
    /// </summary>
    [DataContract]
    public partial class InclusaoPrePropostaResponse :  IEquatable<InclusaoPrePropostaResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InclusaoPrePropostaResponse" /> class.
        /// </summary>
        /// <param name="Numero">Número da proposta..</param>
        public InclusaoPrePropostaResponse(string Numero = default(string))
        {
            this.Numero = Numero;
        }
        
        /// <summary>
        /// Número da proposta.
        /// </summary>
        /// <value>Número da proposta.</value>
        [DataMember(Name="numero", EmitDefaultValue=false)]
        public string Numero { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InclusaoPrePropostaResponse {\n");
            sb.Append("  Numero: ").Append(Numero).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as InclusaoPrePropostaResponse);
        }

        /// <summary>
        /// Returns true if InclusaoPrePropostaResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of InclusaoPrePropostaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InclusaoPrePropostaResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Numero == input.Numero ||
                    (this.Numero != null &&
                    this.Numero.Equals(input.Numero))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Numero != null)
                    hashCode = hashCode * 59 + this.Numero.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}