//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FileProcessor.Core.Configuration
{
    
    
    /// <summary>
    /// Путь к папке
    /// </summary>
    [global::System.ComponentModel.DescriptionAttribute("Путь к папке")]
    public partial class FileProcessorSection : global::System.Configuration.ConfigurationSection
    {
        
        #region Singleton Instance
        /// <summary>
        /// The XML name of the FileProcessorSection Configuration Section.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.3.2")]
        internal const string FileProcessorSectionSectionName = "FileProcessor";
        
        /// <summary>
        /// The XML path of the FileProcessorSection Configuration Section.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.3.2")]
        internal const string FileProcessorSectionSectionPath = "FileProcessor";
        
        /// <summary>
        /// Gets the FileProcessorSection instance.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.3.2")]
        public static global::FileProcessor.Core.Configuration.FileProcessorSection Instance
        {
            get
            {
                return ((global::FileProcessor.Core.Configuration.FileProcessorSection)(global::System.Configuration.ConfigurationManager.GetSection(global::FileProcessor.Core.Configuration.FileProcessorSection.FileProcessorSectionSectionPath)));
            }
        }
        #endregion
        
        #region Xmlns Property
        /// <summary>
        /// The XML name of the <see cref="Xmlns"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.3.2")]
        internal const string XmlnsPropertyName = "xmlns";
        
        /// <summary>
        /// Gets the XML namespace of this Configuration Section.
        /// </summary>
        /// <remarks>
        /// This property makes sure that if the configuration file contains the XML namespace,
        /// the parser doesn't throw an exception because it encounters the unknown "xmlns" attribute.
        /// </remarks>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.3.2")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::FileProcessor.Core.Configuration.FileProcessorSection.XmlnsPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public string Xmlns
        {
            get
            {
                return ((string)(base[global::FileProcessor.Core.Configuration.FileProcessorSection.XmlnsPropertyName]));
            }
        }
        #endregion
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.3.2")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region ProcessModules Property
        /// <summary>
        /// The XML name of the <see cref="ProcessModules"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.3.2")]
        internal const string ProcessModulesPropertyName = "processModules";
        
        /// <summary>
        /// Gets or sets the ProcessModules.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.3.2")]
        [global::System.ComponentModel.DescriptionAttribute("The ProcessModules.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::FileProcessor.Core.Configuration.FileProcessorSection.ProcessModulesPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public virtual global::FileProcessor.Core.Configuration.ProcessModuleCollection ProcessModules
        {
            get
            {
                return ((global::FileProcessor.Core.Configuration.ProcessModuleCollection)(base[global::FileProcessor.Core.Configuration.FileProcessorSection.ProcessModulesPropertyName]));
            }
            set
            {
                base[global::FileProcessor.Core.Configuration.FileProcessorSection.ProcessModulesPropertyName] = value;
            }
        }
        #endregion
    }
}
namespace FileProcessor.Core.Configuration
{
    
    
    /// <summary>
    /// The ProcessModuleElement Configuration Element.
    /// </summary>
    public partial class ProcessModuleElement : global::System.Configuration.ConfigurationElement
    {
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.3.2")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region Id Property
        /// <summary>
        /// The XML name of the <see cref="Id"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.3.2")]
        internal const string IdPropertyName = "id";
        
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.3.2")]
        [global::System.ComponentModel.DescriptionAttribute("The Id.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::FileProcessor.Core.Configuration.ProcessModuleElement.IdPropertyName, IsRequired=true, IsKey=true, IsDefaultCollection=false)]
        public virtual string Id
        {
            get
            {
                return ((string)(base[global::FileProcessor.Core.Configuration.ProcessModuleElement.IdPropertyName]));
            }
            set
            {
                base[global::FileProcessor.Core.Configuration.ProcessModuleElement.IdPropertyName] = value;
            }
        }
        #endregion
        
        #region AssemblyPath Property
        /// <summary>
        /// The XML name of the <see cref="AssemblyPath"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.3.2")]
        internal const string AssemblyPathPropertyName = "assemblyPath";
        
        /// <summary>
        /// Gets or sets the AssemblyPath.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.3.2")]
        [global::System.ComponentModel.DescriptionAttribute("The AssemblyPath.")]
        [global::System.Configuration.StringValidatorAttribute(InvalidCharacters="?*;:!", MaxLength=2147483647, MinLength=1)]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::FileProcessor.Core.Configuration.ProcessModuleElement.AssemblyPathPropertyName, IsRequired=true, IsKey=false, IsDefaultCollection=false)]
        public virtual string AssemblyPath
        {
            get
            {
                return ((string)(base[global::FileProcessor.Core.Configuration.ProcessModuleElement.AssemblyPathPropertyName]));
            }
            set
            {
                base[global::FileProcessor.Core.Configuration.ProcessModuleElement.AssemblyPathPropertyName] = value;
            }
        }
        #endregion
        
        #region FileMask Property
        /// <summary>
        /// The XML name of the <see cref="FileMask"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.3.2")]
        internal const string FileMaskPropertyName = "fileMask";
        
        /// <summary>
        /// Gets or sets the FileMask.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.3.2")]
        [global::System.ComponentModel.DescriptionAttribute("The FileMask.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::FileProcessor.Core.Configuration.ProcessModuleElement.FileMaskPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public virtual string FileMask
        {
            get
            {
                return ((string)(base[global::FileProcessor.Core.Configuration.ProcessModuleElement.FileMaskPropertyName]));
            }
            set
            {
                base[global::FileProcessor.Core.Configuration.ProcessModuleElement.FileMaskPropertyName] = value;
            }
        }
        #endregion
        
        #region WatchDirectory Property
        /// <summary>
        /// The XML name of the <see cref="WatchDirectory"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.3.2")]
        internal const string WatchDirectoryPropertyName = "watchDirectory";
        
        /// <summary>
        /// Gets or sets the WatchDirectory.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.3.2")]
        [global::System.ComponentModel.DescriptionAttribute("The WatchDirectory.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::FileProcessor.Core.Configuration.ProcessModuleElement.WatchDirectoryPropertyName, IsRequired=true, IsKey=false, IsDefaultCollection=false)]
        public virtual global::FileProcessor.Core.Configuration.DirectoryElement WatchDirectory
        {
            get
            {
                return ((global::FileProcessor.Core.Configuration.DirectoryElement)(base[global::FileProcessor.Core.Configuration.ProcessModuleElement.WatchDirectoryPropertyName]));
            }
            set
            {
                base[global::FileProcessor.Core.Configuration.ProcessModuleElement.WatchDirectoryPropertyName] = value;
            }
        }
        #endregion
        
        #region ProcessingDirectory Property
        /// <summary>
        /// The XML name of the <see cref="ProcessingDirectory"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.3.2")]
        internal const string ProcessingDirectoryPropertyName = "processingDirectory";
        
        /// <summary>
        /// Gets or sets the ProcessingDirectory.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.3.2")]
        [global::System.ComponentModel.DescriptionAttribute("The ProcessingDirectory.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::FileProcessor.Core.Configuration.ProcessModuleElement.ProcessingDirectoryPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public virtual global::FileProcessor.Core.Configuration.DirectoryElement ProcessingDirectory
        {
            get
            {
                return ((global::FileProcessor.Core.Configuration.DirectoryElement)(base[global::FileProcessor.Core.Configuration.ProcessModuleElement.ProcessingDirectoryPropertyName]));
            }
            set
            {
                base[global::FileProcessor.Core.Configuration.ProcessModuleElement.ProcessingDirectoryPropertyName] = value;
            }
        }
        #endregion
        
        #region SuccessDirectory Property
        /// <summary>
        /// The XML name of the <see cref="SuccessDirectory"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.3.2")]
        internal const string SuccessDirectoryPropertyName = "successDirectory";
        
        /// <summary>
        /// Gets or sets the SuccessDirectory.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.3.2")]
        [global::System.ComponentModel.DescriptionAttribute("The SuccessDirectory.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::FileProcessor.Core.Configuration.ProcessModuleElement.SuccessDirectoryPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public virtual global::FileProcessor.Core.Configuration.DirectoryElement SuccessDirectory
        {
            get
            {
                return ((global::FileProcessor.Core.Configuration.DirectoryElement)(base[global::FileProcessor.Core.Configuration.ProcessModuleElement.SuccessDirectoryPropertyName]));
            }
            set
            {
                base[global::FileProcessor.Core.Configuration.ProcessModuleElement.SuccessDirectoryPropertyName] = value;
            }
        }
        #endregion
        
        #region FailureDirectory Property
        /// <summary>
        /// The XML name of the <see cref="FailureDirectory"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.3.2")]
        internal const string FailureDirectoryPropertyName = "failureDirectory";
        
        /// <summary>
        /// Gets or sets the FailureDirectory.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.3.2")]
        [global::System.ComponentModel.DescriptionAttribute("The FailureDirectory.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::FileProcessor.Core.Configuration.ProcessModuleElement.FailureDirectoryPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public virtual global::FileProcessor.Core.Configuration.DirectoryElement FailureDirectory
        {
            get
            {
                return ((global::FileProcessor.Core.Configuration.DirectoryElement)(base[global::FileProcessor.Core.Configuration.ProcessModuleElement.FailureDirectoryPropertyName]));
            }
            set
            {
                base[global::FileProcessor.Core.Configuration.ProcessModuleElement.FailureDirectoryPropertyName] = value;
            }
        }
        #endregion
    }
}
namespace FileProcessor.Core.Configuration
{
    
    
    /// <summary>
    /// The DirectoryElement Configuration Element.
    /// </summary>
    [global::System.ComponentModel.DisplayNameAttribute("Папка")]
    public partial class DirectoryElement : global::System.Configuration.ConfigurationElement
    {
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.3.2")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region Path Property
        /// <summary>
        /// The XML name of the <see cref="Path"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.3.2")]
        internal const string PathPropertyName = "path";
        
        /// <summary>
        /// Gets or sets path to directory
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.3.2")]
        [global::System.ComponentModel.DescriptionAttribute("Path to directory")]
        [global::System.Configuration.StringValidatorAttribute(InvalidCharacters="?*;:!", MaxLength=2147483647, MinLength=1)]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::FileProcessor.Core.Configuration.DirectoryElement.PathPropertyName, IsRequired=true, IsKey=false, IsDefaultCollection=false)]
        public virtual string Path
        {
            get
            {
                return ((string)(base[global::FileProcessor.Core.Configuration.DirectoryElement.PathPropertyName]));
            }
            set
            {
                base[global::FileProcessor.Core.Configuration.DirectoryElement.PathPropertyName] = value;
            }
        }
        #endregion
        
        #region IsRelative Property
        /// <summary>
        /// The XML name of the <see cref="IsRelative"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.3.2")]
        internal const string IsRelativePropertyName = "isRelative";
        
        /// <summary>
        /// Gets or sets the IsRelative.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.3.2")]
        [global::System.ComponentModel.DescriptionAttribute("The IsRelative.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::FileProcessor.Core.Configuration.DirectoryElement.IsRelativePropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public virtual bool IsRelative
        {
            get
            {
                return ((bool)(base[global::FileProcessor.Core.Configuration.DirectoryElement.IsRelativePropertyName]));
            }
            set
            {
                base[global::FileProcessor.Core.Configuration.DirectoryElement.IsRelativePropertyName] = value;
            }
        }
        #endregion
    }
}
namespace FileProcessor.Core.Configuration
{
    
    
    /// <summary>
    /// A collection of ProcessModuleElement instances.
    /// </summary>
    [global::System.Configuration.ConfigurationCollectionAttribute(typeof(global::FileProcessor.Core.Configuration.ProcessModuleElement), CollectionType=global::System.Configuration.ConfigurationElementCollectionType.BasicMapAlternate, AddItemName=global::FileProcessor.Core.Configuration.ProcessModuleCollection.ProcessModuleElementPropertyName)]
    public partial class ProcessModuleCollection : global::System.Configuration.ConfigurationElementCollection
    {
        
        #region Constants
        /// <summary>
        /// The XML name of the individual <see cref="global::FileProcessor.Core.Configuration.ProcessModuleElement"/> instances in this collection.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.3.2")]
        internal const string ProcessModuleElementPropertyName = "processModule";
        #endregion
        
        #region Overrides
        /// <summary>
        /// Gets the type of the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <returns>The <see cref="global::System.Configuration.ConfigurationElementCollectionType"/> of this collection.</returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.3.2")]
        public override global::System.Configuration.ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return global::System.Configuration.ConfigurationElementCollectionType.BasicMapAlternate;
            }
        }
        
        /// <summary>
        /// Gets the name used to identify this collection of elements
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.3.2")]
        protected override string ElementName
        {
            get
            {
                return global::FileProcessor.Core.Configuration.ProcessModuleCollection.ProcessModuleElementPropertyName;
            }
        }
        
        /// <summary>
        /// Indicates whether the specified <see cref="global::System.Configuration.ConfigurationElement"/> exists in the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="elementName">The name of the element to verify.</param>
        /// <returns>
        /// <see langword="true"/> if the element exists in the collection; otherwise, <see langword="false"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.3.2")]
        protected override bool IsElementName(string elementName)
        {
            return (elementName == global::FileProcessor.Core.Configuration.ProcessModuleCollection.ProcessModuleElementPropertyName);
        }
        
        /// <summary>
        /// Gets the element key for the specified configuration element.
        /// </summary>
        /// <param name="element">The <see cref="global::System.Configuration.ConfigurationElement"/> to return the key for.</param>
        /// <returns>
        /// An <see cref="object"/> that acts as the key for the specified <see cref="global::System.Configuration.ConfigurationElement"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.3.2")]
        protected override object GetElementKey(global::System.Configuration.ConfigurationElement element)
        {
            return ((global::FileProcessor.Core.Configuration.ProcessModuleElement)(element)).Id;
        }
        
        /// <summary>
        /// Creates a new <see cref="global::FileProcessor.Core.Configuration.ProcessModuleElement"/>.
        /// </summary>
        /// <returns>
        /// A new <see cref="global::FileProcessor.Core.Configuration.ProcessModuleElement"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.3.2")]
        protected override global::System.Configuration.ConfigurationElement CreateNewElement()
        {
            return new global::FileProcessor.Core.Configuration.ProcessModuleElement();
        }
        #endregion
        
        #region Indexer
        /// <summary>
        /// Gets the <see cref="global::FileProcessor.Core.Configuration.ProcessModuleElement"/> at the specified index.
        /// </summary>
        /// <param name="index">The index of the <see cref="global::FileProcessor.Core.Configuration.ProcessModuleElement"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.3.2")]
        public global::FileProcessor.Core.Configuration.ProcessModuleElement this[int index]
        {
            get
            {
                return ((global::FileProcessor.Core.Configuration.ProcessModuleElement)(base.BaseGet(index)));
            }
        }
        
        /// <summary>
        /// Gets the <see cref="global::FileProcessor.Core.Configuration.ProcessModuleElement"/> with the specified key.
        /// </summary>
        /// <param name="id">The key of the <see cref="global::FileProcessor.Core.Configuration.ProcessModuleElement"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.3.2")]
        public global::FileProcessor.Core.Configuration.ProcessModuleElement this[object id]
        {
            get
            {
                return ((global::FileProcessor.Core.Configuration.ProcessModuleElement)(base.BaseGet(id)));
            }
        }
        #endregion
        
        #region Add
        /// <summary>
        /// Adds the specified <see cref="global::FileProcessor.Core.Configuration.ProcessModuleElement"/> to the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="processModule">The <see cref="global::FileProcessor.Core.Configuration.ProcessModuleElement"/> to add.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.3.2")]
        public void Add(global::FileProcessor.Core.Configuration.ProcessModuleElement processModule)
        {
            base.BaseAdd(processModule);
        }
        #endregion
        
        #region Remove
        /// <summary>
        /// Removes the specified <see cref="global::FileProcessor.Core.Configuration.ProcessModuleElement"/> from the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="processModule">The <see cref="global::FileProcessor.Core.Configuration.ProcessModuleElement"/> to remove.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.3.2")]
        public void Remove(global::FileProcessor.Core.Configuration.ProcessModuleElement processModule)
        {
            base.BaseRemove(this.GetElementKey(processModule));
        }
        #endregion
        
        #region GetItem
        /// <summary>
        /// Gets the <see cref="global::FileProcessor.Core.Configuration.ProcessModuleElement"/> at the specified index.
        /// </summary>
        /// <param name="index">The index of the <see cref="global::FileProcessor.Core.Configuration.ProcessModuleElement"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.3.2")]
        public global::FileProcessor.Core.Configuration.ProcessModuleElement GetItemAt(int index)
        {
            return ((global::FileProcessor.Core.Configuration.ProcessModuleElement)(base.BaseGet(index)));
        }
        
        /// <summary>
        /// Gets the <see cref="global::FileProcessor.Core.Configuration.ProcessModuleElement"/> with the specified key.
        /// </summary>
        /// <param name="id">The key of the <see cref="global::FileProcessor.Core.Configuration.ProcessModuleElement"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.3.2")]
        public global::FileProcessor.Core.Configuration.ProcessModuleElement GetItemByKey(string id)
        {
            return ((global::FileProcessor.Core.Configuration.ProcessModuleElement)(base.BaseGet(((object)(id)))));
        }
        #endregion
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.3.2")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
    }
}
