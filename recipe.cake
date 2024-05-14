#load ./Cake.IntelliJ.Recipe.All.cake

Environment.SetVariableNames(
  githubTokenVariable: "GITHUB_PAT"
);

IntelliJBuildParameters.SetParameters(
  context: Context,
  buildSystem: BuildSystem,
  sourceDirectoryPath: "./src/plugin",
  title: "Cake.IntelliJ.Recipe TEST",
  repositoryName: "unknown",
  repositoryOwner: "nils-a",
  marketplaceId: "12345-some-plugin",
  shouldRunPluginVerifier: false,
  intelliJAnalyzerTasks: new[]{ "check", "verifyPlugin" },
  preferredBuildProviderType: BuildProviderType.GitHubActions,
  preferredBuildAgentOperatingSystem: PlatformFamily.Windows
);

IntelliJBuildParameters.PrintParameters(Context);

ToolSettings.SetToolPreprocessorDirectives(
  gitReleaseManagerGlobalTool: "#tool dotnet:?package=GitReleaseManager.Tool&version=0.17.0");

ToolSettings.SetToolSettings(context: Context);

IntelliJBuild.Run();
