﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Felinesoft.UmbracoCodeFirst.Core.Modules.ContentTypeBase.T4
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using Felinesoft.UmbracoCodeFirst;
    using Felinesoft.UmbracoCodeFirst.Core.ClassFileGeneration;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "E:\tfs\DefaultCollection\Felinesoft.UmbracoCodeFirst\Dev Branches\dev-main\Felinesoft.UmbracoCodeFirst\Core\Modules\ContentTypeBase\T4\UmbracoCodeFirstContentType.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class UmbracoCodeFirstContentType : UmbracoCodeFirstContentTypeBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write(@"using Felinesoft.UmbracoCodeFirst;
using Felinesoft.UmbracoCodeFirst.ContentTypes;
using Felinesoft.UmbracoCodeFirst.DataTypes;
using Felinesoft.UmbracoCodeFirst.Attributes;
using Felinesoft.UmbracoCodeFirst.Extensions;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System;
using Felinesoft.UmbracoCodeFirst.DataTypes.BuiltIn;

namespace ");
            
            #line 19 "E:\tfs\DefaultCollection\Felinesoft.UmbracoCodeFirst\Dev Branches\dev-main\Felinesoft.UmbracoCodeFirst\Core\Modules\ContentTypeBase\T4\UmbracoCodeFirstContentType.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    [");
            
            #line 21 "E:\tfs\DefaultCollection\Felinesoft.UmbracoCodeFirst\Dev Branches\dev-main\Felinesoft.UmbracoCodeFirst\Core\Modules\ContentTypeBase\T4\UmbracoCodeFirstContentType.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.AttributeName));
            
            #line default
            #line hidden
            this.Write("(@\"");
            
            #line 21 "E:\tfs\DefaultCollection\Felinesoft.UmbracoCodeFirst\Dev Branches\dev-main\Felinesoft.UmbracoCodeFirst\Core\Modules\ContentTypeBase\T4\UmbracoCodeFirstContentType.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("\", @\"");
            
            #line 21 "E:\tfs\DefaultCollection\Felinesoft.UmbracoCodeFirst\Dev Branches\dev-main\Felinesoft.UmbracoCodeFirst\Core\Modules\ContentTypeBase\T4\UmbracoCodeFirstContentType.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Alias));
            
            #line default
            #line hidden
            this.Write("\", ");
            
            #line 21 "E:\tfs\DefaultCollection\Felinesoft.UmbracoCodeFirst\Dev Branches\dev-main\Felinesoft.UmbracoCodeFirst\Core\Modules\ContentTypeBase\T4\UmbracoCodeFirstContentType.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.AllowedChildren));
            
            #line default
            #line hidden
            this.Write(", @\"");
            
            #line 21 "E:\tfs\DefaultCollection\Felinesoft.UmbracoCodeFirst\Dev Branches\dev-main\Felinesoft.UmbracoCodeFirst\Core\Modules\ContentTypeBase\T4\UmbracoCodeFirstContentType.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Icon));
            
            #line default
            #line hidden
            this.Write("\", ");
            
            #line 21 "E:\tfs\DefaultCollection\Felinesoft.UmbracoCodeFirst\Dev Branches\dev-main\Felinesoft.UmbracoCodeFirst\Core\Modules\ContentTypeBase\T4\UmbracoCodeFirstContentType.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.AllowAtRoot));
            
            #line default
            #line hidden
            this.Write(", ");
            
            #line 21 "E:\tfs\DefaultCollection\Felinesoft.UmbracoCodeFirst\Dev Branches\dev-main\Felinesoft.UmbracoCodeFirst\Core\Modules\ContentTypeBase\T4\UmbracoCodeFirstContentType.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.EnableListView));
            
            #line default
            #line hidden
            this.Write(", @\"");
            
            #line 21 "E:\tfs\DefaultCollection\Felinesoft.UmbracoCodeFirst\Dev Branches\dev-main\Felinesoft.UmbracoCodeFirst\Core\Modules\ContentTypeBase\T4\UmbracoCodeFirstContentType.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Description));
            
            #line default
            #line hidden
            this.Write("\")]\r\n");
            
            #line 22 "E:\tfs\DefaultCollection\Felinesoft.UmbracoCodeFirst\Dev Branches\dev-main\Felinesoft.UmbracoCodeFirst\Core\Modules\ContentTypeBase\T4\UmbracoCodeFirstContentType.tt"
foreach(TemplateDescription template in Model.Templates)
    {
            
            #line default
            #line hidden
            this.Write("    [Template(");
            
            #line 24 "E:\tfs\DefaultCollection\Felinesoft.UmbracoCodeFirst\Dev Branches\dev-main\Felinesoft.UmbracoCodeFirst\Core\Modules\ContentTypeBase\T4\UmbracoCodeFirstContentType.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(template.IsDefault));
            
            #line default
            #line hidden
            this.Write(", \"");
            
            #line 24 "E:\tfs\DefaultCollection\Felinesoft.UmbracoCodeFirst\Dev Branches\dev-main\Felinesoft.UmbracoCodeFirst\Core\Modules\ContentTypeBase\T4\UmbracoCodeFirstContentType.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(template.Name));
            
            #line default
            #line hidden
            this.Write("\", \"");
            
            #line 24 "E:\tfs\DefaultCollection\Felinesoft.UmbracoCodeFirst\Dev Branches\dev-main\Felinesoft.UmbracoCodeFirst\Core\Modules\ContentTypeBase\T4\UmbracoCodeFirstContentType.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(template.Alias));
            
            #line default
            #line hidden
            this.Write("\")]\r\n");
            
            #line 25 "E:\tfs\DefaultCollection\Felinesoft.UmbracoCodeFirst\Dev Branches\dev-main\Felinesoft.UmbracoCodeFirst\Core\Modules\ContentTypeBase\T4\UmbracoCodeFirstContentType.tt"
}
            
            #line default
            #line hidden
            this.Write("    public class ");
            
            #line 26 "E:\tfs\DefaultCollection\Felinesoft.UmbracoCodeFirst\Dev Branches\dev-main\Felinesoft.UmbracoCodeFirst\Core\Modules\ContentTypeBase\T4\UmbracoCodeFirstContentType.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.ClassName));
            
            #line default
            #line hidden
            this.Write(" : ");
            
            #line 26 "E:\tfs\DefaultCollection\Felinesoft.UmbracoCodeFirst\Dev Branches\dev-main\Felinesoft.UmbracoCodeFirst\Core\Modules\ContentTypeBase\T4\UmbracoCodeFirstContentType.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.ParentClassName));
            
            #line default
            #line hidden
            this.Write("\r\n    {\r\n");
            
            #line 28 "E:\tfs\DefaultCollection\Felinesoft.UmbracoCodeFirst\Dev Branches\dev-main\Felinesoft.UmbracoCodeFirst\Core\Modules\ContentTypeBase\T4\UmbracoCodeFirstContentType.tt"
foreach(TabDescription tab in Model.Tabs)
        {
            
            #line default
            #line hidden
            this.Write("        public class ");
            
            #line 30 "E:\tfs\DefaultCollection\Felinesoft.UmbracoCodeFirst\Dev Branches\dev-main\Felinesoft.UmbracoCodeFirst\Core\Modules\ContentTypeBase\T4\UmbracoCodeFirstContentType.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(tab.TabClassName));
            
            #line default
            #line hidden
            this.Write(" : TabBase\r\n        {\r\n");
            
            #line 32 "E:\tfs\DefaultCollection\Felinesoft.UmbracoCodeFirst\Dev Branches\dev-main\Felinesoft.UmbracoCodeFirst\Core\Modules\ContentTypeBase\T4\UmbracoCodeFirstContentType.tt"
foreach(PropertyDescription prop in tab.Properties)
            {

            
            #line default
            #line hidden
            this.Write("            [ContentProperty(@\"");
            
            #line 35 "E:\tfs\DefaultCollection\Felinesoft.UmbracoCodeFirst\Dev Branches\dev-main\Felinesoft.UmbracoCodeFirst\Core\Modules\ContentTypeBase\T4\UmbracoCodeFirstContentType.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.Name));
            
            #line default
            #line hidden
            this.Write("\", @\"");
            
            #line 35 "E:\tfs\DefaultCollection\Felinesoft.UmbracoCodeFirst\Dev Branches\dev-main\Felinesoft.UmbracoCodeFirst\Core\Modules\ContentTypeBase\T4\UmbracoCodeFirstContentType.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.Alias));
            
            #line default
            #line hidden
            this.Write("\", ");
            
            #line 35 "E:\tfs\DefaultCollection\Felinesoft.UmbracoCodeFirst\Dev Branches\dev-main\Felinesoft.UmbracoCodeFirst\Core\Modules\ContentTypeBase\T4\UmbracoCodeFirstContentType.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.Mandatory));
            
            #line default
            #line hidden
            this.Write(", @\"");
            
            #line 35 "E:\tfs\DefaultCollection\Felinesoft.UmbracoCodeFirst\Dev Branches\dev-main\Felinesoft.UmbracoCodeFirst\Core\Modules\ContentTypeBase\T4\UmbracoCodeFirstContentType.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.Description));
            
            #line default
            #line hidden
            this.Write("\", ");
            
            #line 35 "E:\tfs\DefaultCollection\Felinesoft.UmbracoCodeFirst\Dev Branches\dev-main\Felinesoft.UmbracoCodeFirst\Core\Modules\ContentTypeBase\T4\UmbracoCodeFirstContentType.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.SortOrder));
            
            #line default
            #line hidden
            this.Write(", false");
            
            #line 35 "E:\tfs\DefaultCollection\Felinesoft.UmbracoCodeFirst\Dev Branches\dev-main\Felinesoft.UmbracoCodeFirst\Core\Modules\ContentTypeBase\T4\UmbracoCodeFirstContentType.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.RegexpParam));
            
            #line default
            #line hidden
            this.Write(")]\r\n            public virtual ");
            
            #line 36 "E:\tfs\DefaultCollection\Felinesoft.UmbracoCodeFirst\Dev Branches\dev-main\Felinesoft.UmbracoCodeFirst\Core\Modules\ContentTypeBase\T4\UmbracoCodeFirstContentType.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.DataTypeClassName));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 36 "E:\tfs\DefaultCollection\Felinesoft.UmbracoCodeFirst\Dev Branches\dev-main\Felinesoft.UmbracoCodeFirst\Core\Modules\ContentTypeBase\T4\UmbracoCodeFirstContentType.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.PropertyName));
            
            #line default
            #line hidden
            this.Write(" { get; set; }\r\n\r\n");
            
            #line 38 "E:\tfs\DefaultCollection\Felinesoft.UmbracoCodeFirst\Dev Branches\dev-main\Felinesoft.UmbracoCodeFirst\Core\Modules\ContentTypeBase\T4\UmbracoCodeFirstContentType.tt"
          }
    
            
            #line default
            #line hidden
            this.Write("        }\r\n");
            
            #line 41 "E:\tfs\DefaultCollection\Felinesoft.UmbracoCodeFirst\Dev Branches\dev-main\Felinesoft.UmbracoCodeFirst\Core\Modules\ContentTypeBase\T4\UmbracoCodeFirstContentType.tt"

	    }
	    foreach(TabDescription tab in Model.Tabs)
        {
            
            #line default
            #line hidden
            this.Write("\r\n        [ContentTab(@\"");
            
            #line 46 "E:\tfs\DefaultCollection\Felinesoft.UmbracoCodeFirst\Dev Branches\dev-main\Felinesoft.UmbracoCodeFirst\Core\Modules\ContentTypeBase\T4\UmbracoCodeFirstContentType.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(tab.TabName));
            
            #line default
            #line hidden
            this.Write("\", ");
            
            #line 46 "E:\tfs\DefaultCollection\Felinesoft.UmbracoCodeFirst\Dev Branches\dev-main\Felinesoft.UmbracoCodeFirst\Core\Modules\ContentTypeBase\T4\UmbracoCodeFirstContentType.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(tab.SortOrder));
            
            #line default
            #line hidden
            this.Write(")]\r\n        public virtual ");
            
            #line 47 "E:\tfs\DefaultCollection\Felinesoft.UmbracoCodeFirst\Dev Branches\dev-main\Felinesoft.UmbracoCodeFirst\Core\Modules\ContentTypeBase\T4\UmbracoCodeFirstContentType.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(tab.TabClassName));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 47 "E:\tfs\DefaultCollection\Felinesoft.UmbracoCodeFirst\Dev Branches\dev-main\Felinesoft.UmbracoCodeFirst\Core\Modules\ContentTypeBase\T4\UmbracoCodeFirstContentType.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(tab.TabPropertyName));
            
            #line default
            #line hidden
            this.Write(" { get; set; }\r\n");
            
            #line 48 "E:\tfs\DefaultCollection\Felinesoft.UmbracoCodeFirst\Dev Branches\dev-main\Felinesoft.UmbracoCodeFirst\Core\Modules\ContentTypeBase\T4\UmbracoCodeFirstContentType.tt"

        }
            
            #line default
            #line hidden
            
            #line 50 "E:\tfs\DefaultCollection\Felinesoft.UmbracoCodeFirst\Dev Branches\dev-main\Felinesoft.UmbracoCodeFirst\Core\Modules\ContentTypeBase\T4\UmbracoCodeFirstContentType.tt"
foreach(PropertyDescription prop in Model.Properties)
        {
        
            
            #line default
            #line hidden
            this.Write("\r\n        [ContentProperty(@\"");
            
            #line 54 "E:\tfs\DefaultCollection\Felinesoft.UmbracoCodeFirst\Dev Branches\dev-main\Felinesoft.UmbracoCodeFirst\Core\Modules\ContentTypeBase\T4\UmbracoCodeFirstContentType.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.Name));
            
            #line default
            #line hidden
            this.Write("\", \"");
            
            #line 54 "E:\tfs\DefaultCollection\Felinesoft.UmbracoCodeFirst\Dev Branches\dev-main\Felinesoft.UmbracoCodeFirst\Core\Modules\ContentTypeBase\T4\UmbracoCodeFirstContentType.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.Alias));
            
            #line default
            #line hidden
            this.Write("\", ");
            
            #line 54 "E:\tfs\DefaultCollection\Felinesoft.UmbracoCodeFirst\Dev Branches\dev-main\Felinesoft.UmbracoCodeFirst\Core\Modules\ContentTypeBase\T4\UmbracoCodeFirstContentType.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.Mandatory));
            
            #line default
            #line hidden
            this.Write(", @\"");
            
            #line 54 "E:\tfs\DefaultCollection\Felinesoft.UmbracoCodeFirst\Dev Branches\dev-main\Felinesoft.UmbracoCodeFirst\Core\Modules\ContentTypeBase\T4\UmbracoCodeFirstContentType.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.Description));
            
            #line default
            #line hidden
            this.Write("\", ");
            
            #line 54 "E:\tfs\DefaultCollection\Felinesoft.UmbracoCodeFirst\Dev Branches\dev-main\Felinesoft.UmbracoCodeFirst\Core\Modules\ContentTypeBase\T4\UmbracoCodeFirstContentType.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.SortOrder));
            
            #line default
            #line hidden
            this.Write(", false");
            
            #line 54 "E:\tfs\DefaultCollection\Felinesoft.UmbracoCodeFirst\Dev Branches\dev-main\Felinesoft.UmbracoCodeFirst\Core\Modules\ContentTypeBase\T4\UmbracoCodeFirstContentType.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.RegexpParam));
            
            #line default
            #line hidden
            this.Write(")]\r\n        public virtual ");
            
            #line 55 "E:\tfs\DefaultCollection\Felinesoft.UmbracoCodeFirst\Dev Branches\dev-main\Felinesoft.UmbracoCodeFirst\Core\Modules\ContentTypeBase\T4\UmbracoCodeFirstContentType.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.DataTypeClassName));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 55 "E:\tfs\DefaultCollection\Felinesoft.UmbracoCodeFirst\Dev Branches\dev-main\Felinesoft.UmbracoCodeFirst\Core\Modules\ContentTypeBase\T4\UmbracoCodeFirstContentType.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.PropertyName));
            
            #line default
            #line hidden
            this.Write(" { get; set; }\r\n");
            
            #line 56 "E:\tfs\DefaultCollection\Felinesoft.UmbracoCodeFirst\Dev Branches\dev-main\Felinesoft.UmbracoCodeFirst\Core\Modules\ContentTypeBase\T4\UmbracoCodeFirstContentType.tt"
      }
        
            
            #line default
            #line hidden
            
            #line 58 "E:\tfs\DefaultCollection\Felinesoft.UmbracoCodeFirst\Dev Branches\dev-main\Felinesoft.UmbracoCodeFirst\Core\Modules\ContentTypeBase\T4\UmbracoCodeFirstContentType.tt"
foreach(CompositionDescription comp in Model.Compositions)
        {
        
            
            #line default
            #line hidden
            this.Write("\r\n        [ContentComposition]\r\n        public virtual ");
            
            #line 63 "E:\tfs\DefaultCollection\Felinesoft.UmbracoCodeFirst\Dev Branches\dev-main\Felinesoft.UmbracoCodeFirst\Core\Modules\ContentTypeBase\T4\UmbracoCodeFirstContentType.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(comp.TypeName));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 63 "E:\tfs\DefaultCollection\Felinesoft.UmbracoCodeFirst\Dev Branches\dev-main\Felinesoft.UmbracoCodeFirst\Core\Modules\ContentTypeBase\T4\UmbracoCodeFirstContentType.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(comp.PropertyName));
            
            #line default
            #line hidden
            this.Write(" { get; set; }\r\n");
            
            #line 64 "E:\tfs\DefaultCollection\Felinesoft.UmbracoCodeFirst\Dev Branches\dev-main\Felinesoft.UmbracoCodeFirst\Core\Modules\ContentTypeBase\T4\UmbracoCodeFirstContentType.tt"
      }
        
            
            #line default
            #line hidden
            this.Write("    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public class UmbracoCodeFirstContentTypeBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
