#region Using directives

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.ConstrainedExecution;

#endregion

//
// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
//
[assembly: AssemblyTitle(@"")]
[assembly: AssemblyDescription(@"")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(@"UPM_IPS")]
[assembly: AssemblyProduct(@"PracticaIPS")]
[assembly: AssemblyCopyright("")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: System.Resources.NeutralResourcesLanguage("en")]

//
// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Revision and Build Numbers 
// by using the '*' as shown below:

[assembly: AssemblyVersion(@"1.0.0.0")]
[assembly: ComVisible(false)]
[assembly: CLSCompliant(true)]
[assembly: ReliabilityContract(Consistency.MayCorruptProcess, Cer.None)]

//
// Make the Dsl project internally visible to the DslPackage assembly
//
[assembly: InternalsVisibleTo(@"Company.PracticaIPS.DslPackage, PublicKey=002400000480000094000000060200000024000052534131000400000100010005C2A61D5147F44ED01FF7D6CC4CB7949B180298B8A4927D9D0F1F4B50BB8C214BD3E36948E37F7BC71E1B49E4FDC8A3DF2E390D03F4DC57CC8E7075C3DE383404A3A21C9A03D119E782C79F2ACCC5944DC4D82C6CCBFF238958A94BB3A9970DF49B54EBCD60BF2A15C9042A66F6C88F7873427B0903707EE1A5F4E46F2F4EE5")]