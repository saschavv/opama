﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Opama.EMailTemplates {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class DuplicateRegistrationEMail {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal DuplicateRegistrationEMail() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Opama.EMailTemplates.DuplicateRegistrationEMail", typeof(DuplicateRegistrationEMail).Assembly);
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
        ///   Looks up a localized string similar to Hi &lt;%NAME%&gt;,&lt;br /&gt;&lt;br /&gt;You&apos;ve signed up for safe password storage. Awesome!&lt;br /&gt;&lt;br /&gt;The thing is, there already is an account for &lt;%EMAIL%&gt; in the database. Maybe you forgot you already signed up. Those things happen, so no sweat. Just sign in with your old password to access your account.&lt;br /&gt;&lt;br /&gt;Maybe, you&apos;ve forgotten your password. Now, that IS an issue, as all data is encrypted using your password and there&apos;s no unencrypted record of it. There&apos;s no way to decrypt your data without your password. [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string HTMLBody {
            get {
                return ResourceManager.GetString("HTMLBody", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to About your recent signup to Opama powered secure password storage..
        /// </summary>
        internal static string Subject {
            get {
                return ResourceManager.GetString("Subject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hi &lt;%NAME%&gt;,
        ///
        ///You&apos;ve signed up for safe password storage. Awesome!
        ///
        ///The thing is, there already is an account for &lt;%EMAIL%&gt; in the database. Maybe you forgot you already signed up. Those things happen, so no sweat. Just sign in with your old password to access your account.
        ///
        ///Maybe, you&apos;ve forgotten your password. Now, that IS an issue, as all data is encrypted using your password and there&apos;s no unencrypted record of it. There&apos;s no way to decrypt your data without your password.
        ///So, what&apos;s next, you ask. Wel [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string TextBody {
            get {
                return ResourceManager.GetString("TextBody", resourceCulture);
            }
        }
    }
}
