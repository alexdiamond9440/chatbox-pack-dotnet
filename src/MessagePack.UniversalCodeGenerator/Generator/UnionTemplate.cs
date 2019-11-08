﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace MessagePack.CodeGenerator.Generator
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\UnionTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class UnionTemplate : UnionTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write(@"/* THIS (.cs) FILE IS GENERATED. DO NOT CHANGE IT.
 * CHANGE THE .tt FILE INSTEAD. */

#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168

#pragma warning disable SA1200 // Using directives should be placed correctly
#pragma warning disable SA1403 // File may only contain a single namespace
#pragma warning disable SA1649 // File name should match first type name

namespace ");
            
            #line 18 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\UnionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    using System;\r\n    using System.Buffers;\r\n    using System.Collections.G" +
                    "eneric;\r\n    using MessagePack;\r\n\r\n");
            
            #line 25 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\UnionTemplate.tt"
 foreach(var info in UnionSerializationInfos) { 
            
            #line default
            #line hidden
            this.Write("    public sealed class ");
            
            #line 26 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\UnionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(info.Name));
            
            #line default
            #line hidden
            this.Write("Formatter : global::MessagePack.Formatters.IMessagePackFormatter<");
            
            #line 26 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\UnionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(info.FullName));
            
            #line default
            #line hidden
            this.Write(">\r\n    {\r\n        private readonly Dictionary<RuntimeTypeHandle, KeyValuePair<int" +
                    ", int>> typeToKeyAndJumpMap;\r\n        private readonly Dictionary<int, int> keyT" +
                    "oJumpMap;\r\n\r\n        public ");
            
            #line 31 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\UnionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(info.Name));
            
            #line default
            #line hidden
            this.Write("Formatter()\r\n        {\r\n            this.typeToKeyAndJumpMap = new Dictionary<Run" +
                    "timeTypeHandle, KeyValuePair<int, int>>(");
            
            #line 33 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\UnionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(info.SubTypes.Length));
            
            #line default
            #line hidden
            this.Write(", global::MessagePack.Internal.RuntimeTypeHandleEqualityComparer.Default)\r\n      " +
                    "      {\r\n");
            
            #line 35 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\UnionTemplate.tt"
 for(var i = 0; i < info.SubTypes.Length; i++) { var item = info.SubTypes[i]; 
            
            #line default
            #line hidden
            this.Write("                { typeof(");
            
            #line 36 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\UnionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.Type));
            
            #line default
            #line hidden
            this.Write(").TypeHandle, new KeyValuePair<int, int>(");
            
            #line 36 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\UnionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.Key));
            
            #line default
            #line hidden
            this.Write(", ");
            
            #line 36 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\UnionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(i));
            
            #line default
            #line hidden
            this.Write(") },\r\n");
            
            #line 37 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\UnionTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("            };\r\n            this.keyToJumpMap = new Dictionary<int, int>(");
            
            #line 39 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\UnionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(info.SubTypes.Length));
            
            #line default
            #line hidden
            this.Write(")\r\n            {\r\n");
            
            #line 41 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\UnionTemplate.tt"
 for(var i = 0; i < info.SubTypes.Length; i++) { var item = info.SubTypes[i]; 
            
            #line default
            #line hidden
            this.Write("                { ");
            
            #line 42 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\UnionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.Key));
            
            #line default
            #line hidden
            this.Write(", ");
            
            #line 42 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\UnionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(i));
            
            #line default
            #line hidden
            this.Write(" },\r\n");
            
            #line 43 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\UnionTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("            };\r\n        }\r\n\r\n        public void Serialize(ref MessagePackWriter " +
                    "writer, ");
            
            #line 47 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\UnionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(info.FullName));
            
            #line default
            #line hidden
            this.Write(@" value, global::MessagePack.MessagePackSerializerOptions options)
        {
            KeyValuePair<int, int> keyValuePair;
            if (value != null && this.typeToKeyAndJumpMap.TryGetValue(value.GetType().TypeHandle, out keyValuePair))
            {
                writer.WriteArrayHeader(2);
                writer.WriteInt32(keyValuePair.Key);
                switch (keyValuePair.Value)
                {
");
            
            #line 56 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\UnionTemplate.tt"
 for(var i = 0; i < info.SubTypes.Length; i++) { var item = info.SubTypes[i]; 
            
            #line default
            #line hidden
            this.Write("                    case ");
            
            #line 57 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\UnionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(i));
            
            #line default
            #line hidden
            this.Write(":\r\n                        options.Resolver.GetFormatterWithVerify<");
            
            #line 58 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\UnionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.Type));
            
            #line default
            #line hidden
            this.Write(">().Serialize(ref writer, (");
            
            #line 58 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\UnionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.Type));
            
            #line default
            #line hidden
            this.Write(")value, options);\r\n                        break;\r\n");
            
            #line 60 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\UnionTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("                    default:\r\n                        break;\r\n                }\r\n" +
                    "\r\n                return;\r\n            }\r\n\r\n            writer.WriteNil();\r\n    " +
                    "    }\r\n\r\n        public ");
            
            #line 71 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\UnionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(info.FullName));
            
            #line default
            #line hidden
            this.Write(@" Deserialize(ref MessagePackReader reader, global::MessagePack.MessagePackSerializerOptions options)
        {
            if (reader.TryReadNil())
            {
                return null;
            }

            if (reader.ReadArrayHeader() != 2)
            {
                throw new InvalidOperationException(""Invalid Union data was detected. Type:");
            
            #line 80 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\UnionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(info.FullName));
            
            #line default
            #line hidden
            this.Write("\");\r\n            }\r\n\r\n            var key = reader.ReadInt32();\r\n\r\n            if" +
                    " (!this.keyToJumpMap.TryGetValue(key, out key))\r\n            {\r\n                " +
                    "key = -1;\r\n            }\r\n\r\n            ");
            
            #line 90 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\UnionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(info.FullName));
            
            #line default
            #line hidden
            this.Write(" result = null;\r\n            switch (key)\r\n            {\r\n");
            
            #line 93 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\UnionTemplate.tt"
 for(var i = 0; i < info.SubTypes.Length; i++) { var item = info.SubTypes[i]; 
            
            #line default
            #line hidden
            this.Write("                case ");
            
            #line 94 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\UnionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(i));
            
            #line default
            #line hidden
            this.Write(":\r\n                    result = (");
            
            #line 95 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\UnionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(info.FullName));
            
            #line default
            #line hidden
            this.Write(")options.Resolver.GetFormatterWithVerify<");
            
            #line 95 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\UnionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.Type));
            
            #line default
            #line hidden
            this.Write(">().Deserialize(ref reader, options);\r\n                    break;\r\n");
            
            #line 97 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\UnionTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("                default:\r\n                    reader.Skip();\r\n                   " +
                    " break;\r\n            }\r\n\r\n            return result;\r\n        }\r\n    }\r\n\r\n");
            
            #line 107 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\UnionTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write(@"
}

#pragma warning restore 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612

#pragma warning restore SA1200 // Using directives should be placed correctly
#pragma warning restore SA1403 // File may only contain a single namespace
#pragma warning restore SA1649 // File name should match first type name
");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public class UnionTemplateBase
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
