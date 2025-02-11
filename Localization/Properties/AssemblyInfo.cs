using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Windows.Markup;

[assembly: XmlnsDefinition("http://rasyidf.github.io/Localisation", "Rasyidf.Localization")]

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Rasyidf.Localization")]
[assembly: AssemblyDescription("Fast WPF Localization Framework")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Rasyidf")]
[assembly: AssemblyProduct("Rasyidf.Localization")]
[assembly: AssemblyCopyright("Copyright © 2019 Rasyidf")]
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

[assembly: NeutralResourcesLanguage("en-US", UltimateResourceFallbackLocation.MainAssembly)]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
// [assembly: AssemblyVersion("0.2.0.0")]
[assembly: AssemblyVersion("0.4.0.0")]
[assembly: AssemblyFileVersion("0.4.0.0")]