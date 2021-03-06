﻿using TechTalk.SpecFlow.Generator.Interfaces;
using TechTalk.SpecFlow.Generator.Plugins;
using TechTalk.SpecFlow.Generator.UnitTestProvider;
using TechTalk.SpecFlow.Infrastructure;
using TechTalk.SpecFlow.Utils;
using Unickq.SpecFlow.Selenium;

[assembly: GeneratorPlugin(typeof(GeneratorPlugin))]

namespace Unickq.SpecFlow.Selenium
{
    public class GeneratorPlugin : IGeneratorPlugin
    {
        public void Initialize(GeneratorPluginEvents generatorPluginEvents, GeneratorPluginParameters generatorPluginParameters)
        {
            generatorPluginEvents.RegisterDependencies += GeneratorPluginEvents_RegisterDependencies;
        }

        private static void GeneratorPluginEvents_RegisterDependencies(object sender, RegisterDependenciesEventArgs e)
        {           
            var container = e.ObjectContainer;
            var projectSettings = container.Resolve<ProjectSettings>();
            var codeDomHelper = container.Resolve<CodeDomHelper>(projectSettings.ProjectPlatformSettings.Language);
            var generatorProvider = new TestGeneratorProvider(codeDomHelper);
            container.RegisterInstanceAs<IUnitTestGeneratorProvider>(generatorProvider, Extensions.Name);
        }
    }
}
