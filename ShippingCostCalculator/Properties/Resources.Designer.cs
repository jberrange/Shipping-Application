﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shipping.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Shipping.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;PackageDefinitionsTable&gt;
        ///  &lt;PackageType&gt;
        ///    &lt;PackageName&gt;Small&lt;/PackageName&gt;
        ///    &lt;PackageLength&gt;210&lt;/PackageLength&gt;
        ///    &lt;PackageWidth&gt;280&lt;/PackageWidth&gt;
        ///    &lt;PackageHeight&gt;130&lt;/PackageHeight&gt;
        ///    &lt;PackageMass&gt;25&lt;/PackageMass&gt;
        ///    &lt;PackageCost&gt;5.00&lt;/PackageCost&gt;
        ///  &lt;/PackageType&gt;
        ///  &lt;PackageType&gt;
        ///    &lt;PackageName&gt;Medium&lt;/PackageName&gt;
        ///    &lt;PackageLength&gt;280&lt;/PackageLength&gt;
        ///    &lt;PackageWidth&gt;390&lt;/PackageWidth&gt;
        ///    &lt;PackageHeight&gt;180&lt;/PackageHeight&gt;
        ///    &lt;Pac [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string XMLPackageDefinitions {
            get {
                return ResourceManager.GetString("XMLPackageDefinitions", resourceCulture);
            }
        }
    }
}
