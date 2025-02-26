﻿using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("VNC.Core")]
[assembly: AssemblyDescription("Base class for a variety of needs")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("VNC")]
[assembly: AssemblyProduct("VNC.Core")]
[assembly: AssemblyCopyright("Copyright © 2018-2023")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

//In order to begin building localizable applications, set
//<UICulture>CultureYouAreCodingWith</UICulture> in your .csproj file
//inside a <PropertyGroup>.  For example, if you are using US english
//in your source files, set the <UICulture> to en-US.  Then uncomment
//the NeutralResourceLanguage attribute below.  Update the "en-US" in
//the line below to match the UICulture setting in the project file.

//[assembly: NeutralResourcesLanguage("en-US", UltimateResourceFallbackLocation.Satellite)]


[assembly:ThemeInfo(
    ResourceDictionaryLocation.None, //where theme specific resource dictionaries are located
                             //(used if a resource is not found in the page,
                             // or application resource dictionaries)
    ResourceDictionaryLocation.SourceAssembly //where the generic resource dictionary is located
                                      //(used if a resource is not found in the page,
                                      // app, or any theme specific resource dictionaries)
)]


// Version information for an assembly consists of three attributes:
//
//  AssemblyVersion                 - Not shown in Explorer
//  AssemblyFileVersion             - File Version in Explorer
//  AssemblyInformationalVersion    - Product Version in Explorer
//
// AssemblyVersion is required.
// If AssemblyFileVersion is not provided it is loaded from AssemblyVersion.
// If AssemblyInformationalVersion is not provided it is loaded from AssemblyFileVersion if provided
// otherwise from AssemblyVersion.  It can be an arbitrary string.
//
// Each attribute takes a version number consisting of four parts:
//
//      Major Version
//      Minor Version 
//      Build Number    - Days since 1/1/2000
//      Revision        - Seconds since midnight/2
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
// [assembly: AssemblyVersion("1.0.0.*")]
//
// AssemblyVersion History
//
//  Version     Date        By
//  1.0.0.0                 Christopher Rhodes
//      Initial Version
[assembly: AssemblyVersion("2.1.0.0")]

// AssemblyFileVersion History
//
//  Version     Date        By
//  1.0.0.0     01/09/2014   Christopher Rhodes
//      Initial Version
[assembly: AssemblyFileVersion("2.1.0.0")]

// AssemblyInformationalVersion History
//
//  Version   Date        By
//  1.0.0.0   mm/dd/yyyy    Developer
//      Initial Version
[assembly: AssemblyInformationalVersion("2.1.0.2023.06.22A")]
//[assembly: AssemblyInformationalVersion("2.0.0")]
