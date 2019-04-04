We could not find a data exchange file at the path System.Configuration.ConfigurationErrorsException: SpecFlow configuration error ---> System.Xml.XmlException: DonnÃ©es non valides au niveau racine. Ligne 1, position 1.

Please open an issue at https://github.com/techtalk/SpecFlow/issues/
Complete output: 
System.Configuration.ConfigurationErrorsException: SpecFlow configuration error ---> System.Xml.XmlException: DonnÃ©es non valides au niveau racine. Ligne 1, position 1.
   Ã  System.Xml.XmlTextReaderImpl.Throw(Exception e)
   Ã  System.Xml.XmlTextReaderImpl.ParseRootLevelWhitespace()
   Ã  System.Xml.XmlTextReaderImpl.ParseDocumentContent()
   Ã  System.Configuration.ConfigurationSection.DeserializeSection(XmlReader reader)
   Ã  TechTalk.SpecFlow.Configuration.ConfigurationSectionHandler.CreateFromXml(String xmlContent)
   Ã  TechTalk.SpecFlow.Generator.Configuration.GeneratorConfigurationProvider.GetPlugins(SpecFlowConfigurationHolder configurationHolder)
   --- Fin de la trace de la pile d'exception interne ---
   Ã  TechTalk.SpecFlow.Generator.Configuration.GeneratorConfigurationProvider.GetPlugins(SpecFlowConfigurationHolder configurationHolder)
   Ã  TechTalk.SpecFlow.Generator.GeneratorContainerBuilder.LoadPlugins(ObjectContainer container, IGeneratorConfigurationProvider configurationProvider, SpecFlowConfigurationHolder configurationHolder)
   Ã  TechTalk.SpecFlow.Generator.GeneratorContainerBuilder.CreateContainer(SpecFlowConfigurationHolder configurationHolder, ProjectSettings projectSettings)
   Ã  TechTalk.SpecFlow.Generator.TestGeneratorFactory.CreateGenerator(ProjectSettings projectSettings)
   Ã  TechTalk.SpecFlow.VisualStudio.CodeBehindGenerator.Actions.GenerateTestFileAction.GenerateTestFile(GenerateTestFileParameters opts)



Command: c:\users\phil_\appdata\local\microsoft\visualstudio\15.0_ad0698d4\extensions\f43sadvd.lax\TechTalk.SpecFlow.VisualStudio.CodeBehindGenerator.exe
Parameters: GenerateTestFile --featurefile C:\Users\phil_\AppData\Local\Temp\tmp7750.tmp --outputdirectory C:\Users\phil_\AppData\Local\Temp --projectsettingsfile C:\Users\phil_\AppData\Local\Temp\tmp774F.tmp
Working Directory: 
