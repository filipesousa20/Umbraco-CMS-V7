﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace Umbraco.Web.org.umbraco.update {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="CheckForUpgradeSoap", Namespace="http://update.umbraco.org/")]
    public partial class CheckForUpgrade : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback InstallOperationCompleted;
        
        private System.Threading.SendOrPostCallback CheckUpgradeOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public CheckForUpgrade() {
            this.Url = global::Umbraco.Web.Properties.Settings.Default.umbraco_org_umbraco_update_CheckForUpgrade;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event InstallCompletedEventHandler InstallCompleted;
        
        /// <remarks/>
        public event CheckUpgradeCompletedEventHandler CheckUpgradeCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://update.umbraco.org/Install", RequestNamespace="http://update.umbraco.org/", ResponseNamespace="http://update.umbraco.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Install(System.Guid installId, bool isUpgrade, bool installCompleted, System.DateTime timestamp, int versionMajor, int versionMinor, int versionPatch, string versionComment, string error, string userAgent, string dbProvider) {
            this.Invoke("Install", new object[] {
                        installId,
                        isUpgrade,
                        installCompleted,
                        timestamp,
                        versionMajor,
                        versionMinor,
                        versionPatch,
                        versionComment,
                        error,
                        userAgent,
                        dbProvider});
        }
        
        /// <remarks/>
        public void InstallAsync(System.Guid installId, bool isUpgrade, bool installCompleted, System.DateTime timestamp, int versionMajor, int versionMinor, int versionPatch, string versionComment, string error, string userAgent, string dbProvider) {
            this.InstallAsync(installId, isUpgrade, installCompleted, timestamp, versionMajor, versionMinor, versionPatch, versionComment, error, userAgent, dbProvider, null);
        }
        
        /// <remarks/>
        public void InstallAsync(System.Guid installId, bool isUpgrade, bool installCompleted, System.DateTime timestamp, int versionMajor, int versionMinor, int versionPatch, string versionComment, string error, string userAgent, string dbProvider, object userState) {
            if ((this.InstallOperationCompleted == null)) {
                this.InstallOperationCompleted = new System.Threading.SendOrPostCallback(this.OnInstallOperationCompleted);
            }
            this.InvokeAsync("Install", new object[] {
                        installId,
                        isUpgrade,
                        installCompleted,
                        timestamp,
                        versionMajor,
                        versionMinor,
                        versionPatch,
                        versionComment,
                        error,
                        userAgent,
                        dbProvider}, this.InstallOperationCompleted, userState);
        }
        
        private void OnInstallOperationCompleted(object arg) {
            if ((this.InstallCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.InstallCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://update.umbraco.org/CheckUpgrade", RequestNamespace="http://update.umbraco.org/", ResponseNamespace="http://update.umbraco.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public UpgradeResult CheckUpgrade(int versionMajor, int versionMinor, int versionPatch, string versionComment) {
            object[] results = this.Invoke("CheckUpgrade", new object[] {
                        versionMajor,
                        versionMinor,
                        versionPatch,
                        versionComment});
            return ((UpgradeResult)(results[0]));
        }
        
        /// <remarks/>
        public void CheckUpgradeAsync(int versionMajor, int versionMinor, int versionPatch, string versionComment) {
            this.CheckUpgradeAsync(versionMajor, versionMinor, versionPatch, versionComment, null);
        }
        
        /// <remarks/>
        public void CheckUpgradeAsync(int versionMajor, int versionMinor, int versionPatch, string versionComment, object userState) {
            if ((this.CheckUpgradeOperationCompleted == null)) {
                this.CheckUpgradeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCheckUpgradeOperationCompleted);
            }
            this.InvokeAsync("CheckUpgrade", new object[] {
                        versionMajor,
                        versionMinor,
                        versionPatch,
                        versionComment}, this.CheckUpgradeOperationCompleted, userState);
        }
        
        private void OnCheckUpgradeOperationCompleted(object arg) {
            if ((this.CheckUpgradeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CheckUpgradeCompleted(this, new CheckUpgradeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://update.umbraco.org/")]
    public partial class UpgradeResult {
        
        private string commentField;
        
        private UpgradeType upgradeTypeField;
        
        private string upgradeUrlField;
        
        /// <remarks/>
        public string Comment {
            get {
                return this.commentField;
            }
            set {
                this.commentField = value;
            }
        }
        
        /// <remarks/>
        public UpgradeType UpgradeType {
            get {
                return this.upgradeTypeField;
            }
            set {
                this.upgradeTypeField = value;
            }
        }
        
        /// <remarks/>
        public string UpgradeUrl {
            get {
                return this.upgradeUrlField;
            }
            set {
                this.upgradeUrlField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://update.umbraco.org/")]
    public enum UpgradeType {
        
        /// <remarks/>
        None,
        
        /// <remarks/>
        Patch,
        
        /// <remarks/>
        Minor,
        
        /// <remarks/>
        Major,
        
        /// <remarks/>
        Critical,
        
        /// <remarks/>
        Error,
        
        /// <remarks/>
        OutOfSync,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void InstallCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void CheckUpgradeCompletedEventHandler(object sender, CheckUpgradeCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CheckUpgradeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CheckUpgradeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public UpgradeResult Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((UpgradeResult)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591