using MonoDevelop.Core.Assemblies;
using MonoDevelop.DotNetCore;
using MonoDevelop.Projects;

namespace DotNetCoreSupportAnyTargetFramework
{
	[ExportProjectModelExtension]
	class DotNetCoreSupportAnyTargetFrameworkProjectExtension : DotNetCoreProjectExtension
	{
		protected override bool OnGetSupportsFramework (TargetFramework framework)
		{
			return true;
		}
	}
}
