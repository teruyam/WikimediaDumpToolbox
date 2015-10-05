﻿namespace WikimediaDumpToolbox.Models {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mediawiki.org/xml/export-0.8/")]
    [System.Xml.Serialization.XmlRootAttribute("mediawiki", Namespace="http://www.mediawiki.org/xml/export-0.8/", IsNullable=false)]
    public partial class MediaWikiType {
        
        private SiteInfoType siteinfoField;
        
        private PageType[] pageField;
        
        private LogItemType[] logitemField;
        
        private string versionField;
        
        private string langField;
        
        /// <remarks/>
        public SiteInfoType siteinfo {
            get {
                return this.siteinfoField;
            }
            set {
                this.siteinfoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("page")]
        public PageType[] page {
            get {
                return this.pageField;
            }
            set {
                this.pageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("logitem")]
        public LogItemType[] logitem {
            get {
                return this.logitemField;
            }
            set {
                this.logitemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.w3.org/XML/1998/namespace")]
        public string lang {
            get {
                return this.langField;
            }
            set {
                this.langField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mediawiki.org/xml/export-0.8/")]
    public partial class SiteInfoType {
        
        private string sitenameField;
        
        private string baseField;
        
        private string generatorField;
        
        private CaseType caseField;
        
        private bool caseFieldSpecified;
        
        private NamespaceType[] namespacesField;
        
        /// <remarks/>
        public string sitename {
            get {
                return this.sitenameField;
            }
            set {
                this.sitenameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string @base {
            get {
                return this.baseField;
            }
            set {
                this.baseField = value;
            }
        }
        
        /// <remarks/>
        public string generator {
            get {
                return this.generatorField;
            }
            set {
                this.generatorField = value;
            }
        }
        
        /// <remarks/>
        public CaseType @case {
            get {
                return this.caseField;
            }
            set {
                this.caseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool caseSpecified {
            get {
                return this.caseFieldSpecified;
            }
            set {
                this.caseFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("namespace", IsNullable=false)]
        public NamespaceType[] namespaces {
            get {
                return this.namespacesField;
            }
            set {
                this.namespacesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mediawiki.org/xml/export-0.8/")]
    public enum CaseType {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("first-letter")]
        firstletter,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("case-sensitive")]
        casesensitive,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("case-insensitive")]
        caseinsensitive,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mediawiki.org/xml/export-0.8/")]
    public partial class NamespaceType {
        
        private string keyField;
        
        private CaseType caseField;
        
        private bool caseFieldSpecified;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CaseType @case {
            get {
                return this.caseField;
            }
            set {
                this.caseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool caseSpecified {
            get {
                return this.caseFieldSpecified;
            }
            set {
                this.caseFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mediawiki.org/xml/export-0.8/")]
    public partial class TextType {
        
        private string spaceField;
        
        private DeletedFlagType deletedField;
        
        private bool deletedFieldSpecified;
        
        private string idField;
        
        private string bytesField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.w3.org/XML/1998/namespace")]
        public string space {
            get {
                return this.spaceField;
            }
            set {
                this.spaceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DeletedFlagType deleted {
            get {
                return this.deletedField;
            }
            set {
                this.deletedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool deletedSpecified {
            get {
                return this.deletedFieldSpecified;
            }
            set {
                this.deletedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="NMTOKEN")]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string bytes {
            get {
                return this.bytesField;
            }
            set {
                this.bytesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mediawiki.org/xml/export-0.8/")]
    public enum DeletedFlagType {
        
        /// <remarks/>
        deleted,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mediawiki.org/xml/export-0.8/")]
    public partial class DiscussionThreadingInfo {
        
        private string threadSubjectField;
        
        private string threadParentField;
        
        private string threadAncestorField;
        
        private string threadPageField;
        
        private string threadIDField;
        
        private string threadAuthorField;
        
        private string threadEditStatusField;
        
        private string threadTypeField;
        
        /// <remarks/>
        public string ThreadSubject {
            get {
                return this.threadSubjectField;
            }
            set {
                this.threadSubjectField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string ThreadParent {
            get {
                return this.threadParentField;
            }
            set {
                this.threadParentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string ThreadAncestor {
            get {
                return this.threadAncestorField;
            }
            set {
                this.threadAncestorField = value;
            }
        }
        
        /// <remarks/>
        public string ThreadPage {
            get {
                return this.threadPageField;
            }
            set {
                this.threadPageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string ThreadID {
            get {
                return this.threadIDField;
            }
            set {
                this.threadIDField = value;
            }
        }
        
        /// <remarks/>
        public string ThreadAuthor {
            get {
                return this.threadAuthorField;
            }
            set {
                this.threadAuthorField = value;
            }
        }
        
        /// <remarks/>
        public string ThreadEditStatus {
            get {
                return this.threadEditStatusField;
            }
            set {
                this.threadEditStatusField = value;
            }
        }
        
        /// <remarks/>
        public string ThreadType {
            get {
                return this.threadTypeField;
            }
            set {
                this.threadTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mediawiki.org/xml/export-0.8/")]
    public partial class UploadType {
        
        private System.DateTime timestampField;
        
        private ContributorType contributorField;
        
        private string commentField;
        
        private string filenameField;
        
        private string srcField;
        
        private string sizeField;
        
        /// <remarks/>
        public System.DateTime timestamp {
            get {
                return this.timestampField;
            }
            set {
                this.timestampField = value;
            }
        }
        
        /// <remarks/>
        public ContributorType contributor {
            get {
                return this.contributorField;
            }
            set {
                this.contributorField = value;
            }
        }
        
        /// <remarks/>
        public string comment {
            get {
                return this.commentField;
            }
            set {
                this.commentField = value;
            }
        }
        
        /// <remarks/>
        public string filename {
            get {
                return this.filenameField;
            }
            set {
                this.filenameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string src {
            get {
                return this.srcField;
            }
            set {
                this.srcField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string size {
            get {
                return this.sizeField;
            }
            set {
                this.sizeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mediawiki.org/xml/export-0.8/")]
    public partial class ContributorType {
        
        private string usernameField;
        
        private string idField;
        
        private string ipField;
        
        private DeletedFlagType deletedField;
        
        private bool deletedFieldSpecified;
        
        /// <remarks/>
        public string username {
            get {
                return this.usernameField;
            }
            set {
                this.usernameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string ip {
            get {
                return this.ipField;
            }
            set {
                this.ipField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DeletedFlagType deleted {
            get {
                return this.deletedField;
            }
            set {
                this.deletedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool deletedSpecified {
            get {
                return this.deletedFieldSpecified;
            }
            set {
                this.deletedFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mediawiki.org/xml/export-0.8/")]
    public partial class LogParamsType {
        
        private string spaceField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.w3.org/XML/1998/namespace")]
        public string space {
            get {
                return this.spaceField;
            }
            set {
                this.spaceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mediawiki.org/xml/export-0.8/")]
    public partial class LogTextType {
        
        private DeletedFlagType deletedField;
        
        private bool deletedFieldSpecified;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DeletedFlagType deleted {
            get {
                return this.deletedField;
            }
            set {
                this.deletedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool deletedSpecified {
            get {
                return this.deletedFieldSpecified;
            }
            set {
                this.deletedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mediawiki.org/xml/export-0.8/")]
    public partial class CommentType {
        
        private DeletedFlagType deletedField;
        
        private bool deletedFieldSpecified;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DeletedFlagType deleted {
            get {
                return this.deletedField;
            }
            set {
                this.deletedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool deletedSpecified {
            get {
                return this.deletedFieldSpecified;
            }
            set {
                this.deletedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mediawiki.org/xml/export-0.8/")]
    public partial class LogItemType {
        
        private string idField;
        
        private System.DateTime timestampField;
        
        private ContributorType contributorField;
        
        private CommentType commentField;
        
        private string typeField;
        
        private string actionField;
        
        private LogTextType textField;
        
        private string logtitleField;
        
        private LogParamsType paramsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime timestamp {
            get {
                return this.timestampField;
            }
            set {
                this.timestampField = value;
            }
        }
        
        /// <remarks/>
        public ContributorType contributor {
            get {
                return this.contributorField;
            }
            set {
                this.contributorField = value;
            }
        }
        
        /// <remarks/>
        public CommentType comment {
            get {
                return this.commentField;
            }
            set {
                this.commentField = value;
            }
        }
        
        /// <remarks/>
        public string type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        public string action {
            get {
                return this.actionField;
            }
            set {
                this.actionField = value;
            }
        }
        
        /// <remarks/>
        public LogTextType text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
        
        /// <remarks/>
        public string logtitle {
            get {
                return this.logtitleField;
            }
            set {
                this.logtitleField = value;
            }
        }
        
        /// <remarks/>
        public LogParamsType @params {
            get {
                return this.paramsField;
            }
            set {
                this.paramsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mediawiki.org/xml/export-0.8/")]
    public partial class RevisionType {
        
        private string idField;
        
        private string parentidField;
        
        private System.DateTime timestampField;
        
        private ContributorType contributorField;
        
        private object minorField;
        
        private CommentType commentField;
        
        private TextType textField;
        
        private string sha1Field;
        
        private string modelField;
        
        private string formatField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string parentid {
            get {
                return this.parentidField;
            }
            set {
                this.parentidField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime timestamp {
            get {
                return this.timestampField;
            }
            set {
                this.timestampField = value;
            }
        }
        
        /// <remarks/>
        public ContributorType contributor {
            get {
                return this.contributorField;
            }
            set {
                this.contributorField = value;
            }
        }
        
        /// <remarks/>
        public object minor {
            get {
                return this.minorField;
            }
            set {
                this.minorField = value;
            }
        }
        
        /// <remarks/>
        public CommentType comment {
            get {
                return this.commentField;
            }
            set {
                this.commentField = value;
            }
        }
        
        /// <remarks/>
        public TextType text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
        
        /// <remarks/>
        public string sha1 {
            get {
                return this.sha1Field;
            }
            set {
                this.sha1Field = value;
            }
        }
        
        /// <remarks/>
        public string model {
            get {
                return this.modelField;
            }
            set {
                this.modelField = value;
            }
        }
        
        /// <remarks/>
        public string format {
            get {
                return this.formatField;
            }
            set {
                this.formatField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mediawiki.org/xml/export-0.8/")]
    public partial class RedirectType {
        
        private string titleField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mediawiki.org/xml/export-0.8/")]
    public partial class PageType {
        
        private string titleField;
        
        private string nsField;
        
        private string idField;
        
        private RedirectType redirectField;
        
        private string restrictionsField;
        
        private object[] itemsField;
        
        private DiscussionThreadingInfo discussionthreadinginfoField;
        
        /// <remarks/>
        public string title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string ns {
            get {
                return this.nsField;
            }
            set {
                this.nsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public RedirectType redirect {
            get {
                return this.redirectField;
            }
            set {
                this.redirectField = value;
            }
        }
        
        /// <remarks/>
        public string restrictions {
            get {
                return this.restrictionsField;
            }
            set {
                this.restrictionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("revision", typeof(RevisionType))]
        [System.Xml.Serialization.XmlElementAttribute("upload", typeof(UploadType))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        public DiscussionThreadingInfo discussionthreadinginfo {
            get {
                return this.discussionthreadinginfoField;
            }
            set {
                this.discussionthreadinginfoField = value;
            }
        }
    }
}
