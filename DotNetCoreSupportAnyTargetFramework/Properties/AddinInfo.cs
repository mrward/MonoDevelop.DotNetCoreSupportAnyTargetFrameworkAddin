using System;
using Mono.Addins;
using Mono.Addins.Description;

[assembly: Addin(
	"DotNetCoreSupportAnyTargetFramework",
	Namespace = "MattWard",
	Version = "1.0"
)]

[assembly: AddinName(".NET Core Extended Target Framework Support")]
[assembly: AddinCategory("IDE extensions")]
[assembly: AddinDescription("This addin makes it possible to use SDK-style csproj files targeting all frameworks that Visual Studio for Mac supports.")]
[assembly: AddinAuthor("Matt Ward")]
