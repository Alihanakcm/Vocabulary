﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vocabulary.MainUI {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.0.0.0")]
    internal sealed partial class BackGroundSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static BackGroundSettings defaultInstance = ((BackGroundSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new BackGroundSettings())));
        
        public static BackGroundSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("255, 255, 192")]
        public global::System.Drawing.Color FormBackground {
            get {
                return ((global::System.Drawing.Color)(this["FormBackground"]));
            }
            set {
                this["FormBackground"] = value;
            }
        }
    }
}
