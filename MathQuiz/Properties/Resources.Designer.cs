﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MathQuiz.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MathQuiz.Properties.Resources", typeof(Resources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Congratulations!.
        /// </summary>
        public static string Congradutulations_Exclamation {
            get {
                return ResourceManager.GetString("Congradutulations_Exclamation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You got all the answers right!.
        /// </summary>
        public static string Correct_Answers {
            get {
                return ResourceManager.GetString("Correct_Answers", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry!.
        /// </summary>
        public static string Sorry_Exclamation {
            get {
                return ResourceManager.GetString("Sorry_Exclamation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Time&apos;s up!.
        /// </summary>
        public static string Time_Is_Up {
            get {
                return ResourceManager.GetString("Time_Is_Up", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} seconds.
        /// </summary>
        public static string Time_Left_Seconds {
            get {
                return ResourceManager.GetString("Time_Left_Seconds", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You didn&apos;t finish in time..
        /// </summary>
        public static string Time_Ran_Out_Message {
            get {
                return ResourceManager.GetString("Time_Ran_Out_Message", resourceCulture);
            }
        }
    }
}
