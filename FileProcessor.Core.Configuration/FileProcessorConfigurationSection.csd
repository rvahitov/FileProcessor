<?xml version="1.0" encoding="utf-8"?>
<configurationSectionModel xmlns:dm0="http://schemas.microsoft.com/VisualStudio/2008/DslTools/Core" dslVersion="1.0.0.0" Id="90d7a8fb-0bf5-455e-86e9-2e6b638d4e7d" namespace="FileProcessor.Core.Configuration" xmlSchemaNamespace="urn:FileProcessor.Core.Configuration" xmlns="http://schemas.microsoft.com/dsltools/ConfigurationSectionDesigner">
  <typeDefinitions>
    <externalType name="String" namespace="System" />
    <externalType name="Boolean" namespace="System" />
    <externalType name="Int32" namespace="System" />
    <externalType name="Int64" namespace="System" />
    <externalType name="Single" namespace="System" />
    <externalType name="Double" namespace="System" />
    <externalType name="DateTime" namespace="System" />
    <externalType name="TimeSpan" namespace="System" />
  </typeDefinitions>
  <configurationElements>
    <configurationSection name="FileProcessorSection" documentation="Путь к папке" codeGenOptions="Singleton, XmlnsProperty" xmlSectionName="FileProcessor">
      <elementProperties>
        <elementProperty name="ProcessModules" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="processModules" isReadOnly="false">
          <type>
            <configurationElementCollectionMoniker name="/90d7a8fb-0bf5-455e-86e9-2e6b638d4e7d/ProcessModuleCollection" />
          </type>
        </elementProperty>
      </elementProperties>
    </configurationSection>
    <configurationElement name="ProcessModuleElement">
      <attributeProperties>
        <attributeProperty name="Id" isRequired="true" isKey="true" isDefaultCollection="false" xmlName="id" isReadOnly="false">
          <type>
            <externalTypeMoniker name="/90d7a8fb-0bf5-455e-86e9-2e6b638d4e7d/String" />
          </type>
        </attributeProperty>
        <attributeProperty name="AssemblyPath" isRequired="true" isKey="false" isDefaultCollection="false" xmlName="assemblyPath" isReadOnly="false">
          <validator>
            <stringValidatorMoniker name="/90d7a8fb-0bf5-455e-86e9-2e6b638d4e7d/PathValidator" />
          </validator>
          <type>
            <externalTypeMoniker name="/90d7a8fb-0bf5-455e-86e9-2e6b638d4e7d/String" />
          </type>
        </attributeProperty>
        <attributeProperty name="FileMask" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="fileMask" isReadOnly="false">
          <type>
            <externalTypeMoniker name="/90d7a8fb-0bf5-455e-86e9-2e6b638d4e7d/String" />
          </type>
        </attributeProperty>
      </attributeProperties>
      <elementProperties>
        <elementProperty name="WatchDirectory" isRequired="true" isKey="false" isDefaultCollection="false" xmlName="watchDirectory" isReadOnly="false">
          <type>
            <configurationElementMoniker name="/90d7a8fb-0bf5-455e-86e9-2e6b638d4e7d/DirectoryElement" />
          </type>
        </elementProperty>
        <elementProperty name="ProcessingDirectory" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="processingDirectory" isReadOnly="false">
          <type>
            <configurationElementMoniker name="/90d7a8fb-0bf5-455e-86e9-2e6b638d4e7d/DirectoryElement" />
          </type>
        </elementProperty>
        <elementProperty name="SuccessDirectory" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="successDirectory" isReadOnly="false">
          <type>
            <configurationElementMoniker name="/90d7a8fb-0bf5-455e-86e9-2e6b638d4e7d/DirectoryElement" />
          </type>
        </elementProperty>
        <elementProperty name="FailureDirectory" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="failureDirectory" isReadOnly="false">
          <type>
            <configurationElementMoniker name="/90d7a8fb-0bf5-455e-86e9-2e6b638d4e7d/DirectoryElement" />
          </type>
        </elementProperty>
      </elementProperties>
    </configurationElement>
    <configurationElement name="DirectoryElement" displayName="Папка">
      <attributeProperties>
        <attributeProperty name="Path" isRequired="true" isKey="false" isDefaultCollection="false" xmlName="path" isReadOnly="false" documentation="Path to directory">
          <validator>
            <stringValidatorMoniker name="/90d7a8fb-0bf5-455e-86e9-2e6b638d4e7d/PathValidator" />
          </validator>
          <type>
            <externalTypeMoniker name="/90d7a8fb-0bf5-455e-86e9-2e6b638d4e7d/String" />
          </type>
        </attributeProperty>
        <attributeProperty name="IsRelative" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="isRelative" isReadOnly="false">
          <type>
            <externalTypeMoniker name="/90d7a8fb-0bf5-455e-86e9-2e6b638d4e7d/Boolean" />
          </type>
        </attributeProperty>
      </attributeProperties>
    </configurationElement>
    <configurationElementCollection name="ProcessModuleCollection" xmlItemName="processModule" codeGenOptions="Indexer, AddMethod, RemoveMethod, GetItemMethods">
      <itemType>
        <configurationElementMoniker name="/90d7a8fb-0bf5-455e-86e9-2e6b638d4e7d/ProcessModuleElement" />
      </itemType>
    </configurationElementCollection>
  </configurationElements>
  <propertyValidators>
    <validators>
      <stringValidator name="PathValidator" invalidCharacters="?*;:!" minLength="1" />
    </validators>
  </propertyValidators>
</configurationSectionModel>