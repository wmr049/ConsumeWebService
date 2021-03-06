﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.237
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.237.
// 
#pragma warning disable 1591

namespace BLL.WsPraetorium {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Xml.Serialization;
    using System.Configuration;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ServerBinding", Namespace="urn:LFGWSDL")]
    public partial class LFGWSDLService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback deleteUserOperationCompleted;
        
        private System.Threading.SendOrPostCallback desenrolUserCourseOperationCompleted;
        
        private System.Threading.SendOrPostCallback enrolUserCourseOperationCompleted;
        
        private System.Threading.SendOrPostCallback finalGradeOperationCompleted;
        
        private System.Threading.SendOrPostCallback insertCourseOperationCompleted;
        
        private System.Threading.SendOrPostCallback insertUserOperationCompleted;
        
        private System.Threading.SendOrPostCallback insertUserArrayOperationCompleted;
        
        private System.Threading.SendOrPostCallback restoreUserOperationCompleted;
        
        private System.Threading.SendOrPostCallback searchCourseOperationCompleted;
        
        private System.Threading.SendOrPostCallback searchEnrolmentOperationCompleted;
        
        private System.Threading.SendOrPostCallback searchRoleOperationCompleted;
        
        private System.Threading.SendOrPostCallback searchUserOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public LFGWSDLService() {
            this.Url = ConfigurationManager.AppSettings["WsPraetorium"];//global::BLL.Properties.Settings.Default.BLL_WsPraetorium_LFGWSDLService;
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
        public event deleteUserCompletedEventHandler deleteUserCompleted;
        
        /// <remarks/>
        public event desenrolUserCourseCompletedEventHandler desenrolUserCourseCompleted;
        
        /// <remarks/>
        public event enrolUserCourseCompletedEventHandler enrolUserCourseCompleted;
        
        /// <remarks/>
        public event finalGradeCompletedEventHandler finalGradeCompleted;
        
        /// <remarks/>
        public event insertCourseCompletedEventHandler insertCourseCompleted;
        
        /// <remarks/>
        public event insertUserCompletedEventHandler insertUserCompleted;
        
        /// <remarks/>
        public event insertUserArrayCompletedEventHandler insertUserArrayCompleted;
        
        /// <remarks/>
        public event restoreUserCompletedEventHandler restoreUserCompleted;
        
        /// <remarks/>
        public event searchCourseCompletedEventHandler searchCourseCompleted;
        
        /// <remarks/>
        public event searchEnrolmentCompletedEventHandler searchEnrolmentCompleted;
        
        /// <remarks/>
        public event searchRoleCompletedEventHandler searchRoleCompleted;
        
        /// <remarks/>
        public event searchUserCompletedEventHandler searchUserCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:ServerAction", RequestNamespace="urn:LFGWSDL", ResponseNamespace="urn:LFGWSDL")]
        [return: System.Xml.Serialization.SoapElementAttribute("deleteUserReturn")]
        public int deleteUser(object username) {
            object[] results = this.Invoke("deleteUser", new object[] {
                        username});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void deleteUserAsync(object username) {
            this.deleteUserAsync(username, null);
        }
        
        /// <remarks/>
        public void deleteUserAsync(object username, object userState) {
            if ((this.deleteUserOperationCompleted == null)) {
                this.deleteUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OndeleteUserOperationCompleted);
            }
            this.InvokeAsync("deleteUser", new object[] {
                        username}, this.deleteUserOperationCompleted, userState);
        }
        
        private void OndeleteUserOperationCompleted(object arg) {
            if ((this.deleteUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.deleteUserCompleted(this, new deleteUserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:ServerAction", RequestNamespace="urn:LFGWSDL", ResponseNamespace="urn:LFGWSDL")]
        [return: System.Xml.Serialization.SoapElementAttribute("desenrolUserCourseReturn")]
        public int desenrolUserCourse(object username1, object shortname) {
            object[] results = this.Invoke("desenrolUserCourse", new object[] {
                        username1,
                        shortname});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void desenrolUserCourseAsync(object username1, object shortname) {
            this.desenrolUserCourseAsync(username1, shortname, null);
        }
        
        /// <remarks/>
        public void desenrolUserCourseAsync(object username1, object shortname, object userState) {
            if ((this.desenrolUserCourseOperationCompleted == null)) {
                this.desenrolUserCourseOperationCompleted = new System.Threading.SendOrPostCallback(this.OndesenrolUserCourseOperationCompleted);
            }
            this.InvokeAsync("desenrolUserCourse", new object[] {
                        username1,
                        shortname}, this.desenrolUserCourseOperationCompleted, userState);
        }
        
        private void OndesenrolUserCourseOperationCompleted(object arg) {
            if ((this.desenrolUserCourseCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.desenrolUserCourseCompleted(this, new desenrolUserCourseCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:ServerAction", RequestNamespace="urn:LFGWSDL", ResponseNamespace="urn:LFGWSDL")]
        [return: System.Xml.Serialization.SoapElementAttribute("enrolUserCourseReturn")]
        public int enrolUserCourse(object username1, object shortname1, object role, object groupname) {
            object[] results = this.Invoke("enrolUserCourse", new object[] {
                        username1,
                        shortname1,
                        role,
                        groupname});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void enrolUserCourseAsync(object username1, object shortname1, object role, object groupname) {
            this.enrolUserCourseAsync(username1, shortname1, role, groupname, null);
        }
        
        /// <remarks/>
        public void enrolUserCourseAsync(object username1, object shortname1, object role, object groupname, object userState) {
            if ((this.enrolUserCourseOperationCompleted == null)) {
                this.enrolUserCourseOperationCompleted = new System.Threading.SendOrPostCallback(this.OnenrolUserCourseOperationCompleted);
            }
            this.InvokeAsync("enrolUserCourse", new object[] {
                        username1,
                        shortname1,
                        role,
                        groupname}, this.enrolUserCourseOperationCompleted, userState);
        }
        
        private void OnenrolUserCourseOperationCompleted(object arg) {
            if ((this.enrolUserCourseCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.enrolUserCourseCompleted(this, new enrolUserCourseCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:ServerAction", RequestNamespace="urn:LFGWSDL", ResponseNamespace="urn:LFGWSDL")]
        [return: System.Xml.Serialization.SoapElementAttribute("finalGradeReturn")]
        public int finalGrade(object user, object course) {
            object[] results = this.Invoke("finalGrade", new object[] {
                        user,
                        course});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void finalGradeAsync(object user, object course) {
            this.finalGradeAsync(user, course, null);
        }
        
        /// <remarks/>
        public void finalGradeAsync(object user, object course, object userState) {
            if ((this.finalGradeOperationCompleted == null)) {
                this.finalGradeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnfinalGradeOperationCompleted);
            }
            this.InvokeAsync("finalGrade", new object[] {
                        user,
                        course}, this.finalGradeOperationCompleted, userState);
        }
        
        private void OnfinalGradeOperationCompleted(object arg) {
            if ((this.finalGradeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.finalGradeCompleted(this, new finalGradeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:ServerAction", RequestNamespace="urn:LFGWSDL", ResponseNamespace="urn:LFGWSDL")]
        [return: System.Xml.Serialization.SoapElementAttribute("insertCourseReturn")]
        public int insertCourse(object @params) {
            object[] results = this.Invoke("insertCourse", new object[] {
                        @params});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void insertCourseAsync(object @params) {
            this.insertCourseAsync(@params, null);
        }
        
        /// <remarks/>
        public void insertCourseAsync(object @params, object userState) {
            if ((this.insertCourseOperationCompleted == null)) {
                this.insertCourseOperationCompleted = new System.Threading.SendOrPostCallback(this.OninsertCourseOperationCompleted);
            }
            this.InvokeAsync("insertCourse", new object[] {
                        @params}, this.insertCourseOperationCompleted, userState);
        }
        
        private void OninsertCourseOperationCompleted(object arg) {
            if ((this.insertCourseCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.insertCourseCompleted(this, new insertCourseCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:ServerAction", RequestNamespace="urn:LFGWSDL", ResponseNamespace="urn:LFGWSDL")]
        [return: System.Xml.Serialization.SoapElementAttribute("insertUserReturn")]
        public int insertUser(object username1, object password, object firstname, object lastname, object confirmed, object email, object idnumber, object lang) {
            object[] results = this.Invoke("insertUser", new object[] {
                        username1,
                        password,
                        firstname,
                        lastname,
                        confirmed,
                        email,
                        idnumber,
                        lang});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void insertUserAsync(object username1, object password, object firstname, object lastname, object confirmed, object email, object idnumber, object lang) {
            this.insertUserAsync(username1, password, firstname, lastname, confirmed, email, idnumber, lang, null);
        }
        
        /// <remarks/>
        public void insertUserAsync(object username1, object password, object firstname, object lastname, object confirmed, object email, object idnumber, object lang, object userState) {
            if ((this.insertUserOperationCompleted == null)) {
                this.insertUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OninsertUserOperationCompleted);
            }
            this.InvokeAsync("insertUser", new object[] {
                        username1,
                        password,
                        firstname,
                        lastname,
                        confirmed,
                        email,
                        idnumber,
                        lang}, this.insertUserOperationCompleted, userState);
        }
        
        private void OninsertUserOperationCompleted(object arg) {
            if ((this.insertUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.insertUserCompleted(this, new insertUserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:ServerAction", RequestNamespace="urn:LFGWSDL", ResponseNamespace="urn:LFGWSDL")]
        [return: System.Xml.Serialization.SoapElementAttribute("insertUserReturn")]
        public int insertUserArray(object params1) {
            object[] results = this.Invoke("insertUserArray", new object[] {
                        params1});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void insertUserArrayAsync(object params1) {
            this.insertUserArrayAsync(params1, null);
        }
        
        /// <remarks/>
        public void insertUserArrayAsync(object params1, object userState) {
            if ((this.insertUserArrayOperationCompleted == null)) {
                this.insertUserArrayOperationCompleted = new System.Threading.SendOrPostCallback(this.OninsertUserArrayOperationCompleted);
            }
            this.InvokeAsync("insertUserArray", new object[] {
                        params1}, this.insertUserArrayOperationCompleted, userState);
        }
        
        private void OninsertUserArrayOperationCompleted(object arg) {
            if ((this.insertUserArrayCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.insertUserArrayCompleted(this, new insertUserArrayCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:ServerAction", RequestNamespace="urn:LFGWSDL", ResponseNamespace="urn:LFGWSDL")]
        [return: System.Xml.Serialization.SoapElementAttribute("restoreUserReturn")]
        public int restoreUser(object username1) {
            object[] results = this.Invoke("restoreUser", new object[] {
                        username1});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void restoreUserAsync(object username1) {
            this.restoreUserAsync(username1, null);
        }
        
        /// <remarks/>
        public void restoreUserAsync(object username1, object userState) {
            if ((this.restoreUserOperationCompleted == null)) {
                this.restoreUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OnrestoreUserOperationCompleted);
            }
            this.InvokeAsync("restoreUser", new object[] {
                        username1}, this.restoreUserOperationCompleted, userState);
        }
        
        private void OnrestoreUserOperationCompleted(object arg) {
            if ((this.restoreUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.restoreUserCompleted(this, new restoreUserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:ServerAction", RequestNamespace="urn:LFGWSDL", ResponseNamespace="urn:LFGWSDL")]
        [return: System.Xml.Serialization.SoapElementAttribute("searchCourseReturn")]
        public object searchCourse(object shortname1, object @return) {
            object[] results = this.Invoke("searchCourse", new object[] {
                        shortname1,
                        @return});
            return ((object)(results[0]));
        }
        
        /// <remarks/>
        public void searchCourseAsync(object shortname1, object @return) {
            this.searchCourseAsync(shortname1, @return, null);
        }
        
        /// <remarks/>
        public void searchCourseAsync(object shortname1, object @return, object userState) {
            if ((this.searchCourseOperationCompleted == null)) {
                this.searchCourseOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsearchCourseOperationCompleted);
            }
            this.InvokeAsync("searchCourse", new object[] {
                        shortname1,
                        @return}, this.searchCourseOperationCompleted, userState);
        }
        
        private void OnsearchCourseOperationCompleted(object arg) {
            if ((this.searchCourseCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.searchCourseCompleted(this, new searchCourseCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:ServerAction", RequestNamespace="urn:LFGWSDL", ResponseNamespace="urn:LFGWSDL")]
        [return: System.Xml.Serialization.SoapElementAttribute("searchEnrolmentReturn")]
        public object searchEnrolment(object shortname1, object role1) {
            object[] results = this.Invoke("searchEnrolment", new object[] {
                        shortname1,
                        role1});
            return ((object)(results[0]));
        }
        
        /// <remarks/>
        public void searchEnrolmentAsync(object shortname1, object role1) {
            this.searchEnrolmentAsync(shortname1, role1, null);
        }
        
        /// <remarks/>
        public void searchEnrolmentAsync(object shortname1, object role1, object userState) {
            if ((this.searchEnrolmentOperationCompleted == null)) {
                this.searchEnrolmentOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsearchEnrolmentOperationCompleted);
            }
            this.InvokeAsync("searchEnrolment", new object[] {
                        shortname1,
                        role1}, this.searchEnrolmentOperationCompleted, userState);
        }
        
        private void OnsearchEnrolmentOperationCompleted(object arg) {
            if ((this.searchEnrolmentCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.searchEnrolmentCompleted(this, new searchEnrolmentCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:ServerAction", RequestNamespace="urn:LFGWSDL", ResponseNamespace="urn:LFGWSDL")]
        [return: System.Xml.Serialization.SoapElementAttribute("searchRoleReturn")]
        public object searchRole(object role1) {
            object[] results = this.Invoke("searchRole", new object[] {
                        role1});
            return ((object)(results[0]));
        }
        
        /// <remarks/>
        public void searchRoleAsync(object role1) {
            this.searchRoleAsync(role1, null);
        }
        
        /// <remarks/>
        public void searchRoleAsync(object role1, object userState) {
            if ((this.searchRoleOperationCompleted == null)) {
                this.searchRoleOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsearchRoleOperationCompleted);
            }
            this.InvokeAsync("searchRole", new object[] {
                        role1}, this.searchRoleOperationCompleted, userState);
        }
        
        private void OnsearchRoleOperationCompleted(object arg) {
            if ((this.searchRoleCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.searchRoleCompleted(this, new searchRoleCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:ServerAction", RequestNamespace="urn:LFGWSDL", ResponseNamespace="urn:LFGWSDL")]
        [return: System.Xml.Serialization.SoapElementAttribute("searchUserReturn")]
        public object searchUser(object username1) {
            object[] results = this.Invoke("searchUser", new object[] {
                        username1});
            return ((object)(results[0]));
        }
        
        /// <remarks/>
        public void searchUserAsync(object username1) {
            this.searchUserAsync(username1, null);
        }
        
        /// <remarks/>
        public void searchUserAsync(object username1, object userState) {
            if ((this.searchUserOperationCompleted == null)) {
                this.searchUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsearchUserOperationCompleted);
            }
            this.InvokeAsync("searchUser", new object[] {
                        username1}, this.searchUserOperationCompleted, userState);
        }
        
        private void OnsearchUserOperationCompleted(object arg) {
            if ((this.searchUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.searchUserCompleted(this, new searchUserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void deleteUserCompletedEventHandler(object sender, deleteUserCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class deleteUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal deleteUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void desenrolUserCourseCompletedEventHandler(object sender, desenrolUserCourseCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class desenrolUserCourseCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal desenrolUserCourseCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void enrolUserCourseCompletedEventHandler(object sender, enrolUserCourseCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class enrolUserCourseCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal enrolUserCourseCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void finalGradeCompletedEventHandler(object sender, finalGradeCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class finalGradeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal finalGradeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void insertCourseCompletedEventHandler(object sender, insertCourseCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class insertCourseCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal insertCourseCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void insertUserCompletedEventHandler(object sender, insertUserCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class insertUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal insertUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void insertUserArrayCompletedEventHandler(object sender, insertUserArrayCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class insertUserArrayCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal insertUserArrayCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void restoreUserCompletedEventHandler(object sender, restoreUserCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class restoreUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal restoreUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void searchCourseCompletedEventHandler(object sender, searchCourseCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class searchCourseCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal searchCourseCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public object Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((object)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void searchEnrolmentCompletedEventHandler(object sender, searchEnrolmentCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class searchEnrolmentCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal searchEnrolmentCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public object Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((object)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void searchRoleCompletedEventHandler(object sender, searchRoleCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class searchRoleCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal searchRoleCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public object Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((object)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void searchUserCompletedEventHandler(object sender, searchUserCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class searchUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal searchUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public object Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((object)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591