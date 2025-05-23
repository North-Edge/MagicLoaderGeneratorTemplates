using MagicLoaderGenerator.Localization.Providers;
using MagicLoaderGenerator.Filesystem.Generators;
using Microsoft.Extensions.Configuration;
using MagicLoaderGenerator.Filesystem;
using MagicLoaderGenerator;

var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                                        .AddJsonFile("config.json", optional: false);
var appConfig = new AppConfig(builder.Build());
var mod = new MagicLoaderMod(new JsonLocalizationProvider(appConfig), appConfig);

var outputDir = mod.Generate(new ZipOutputGenerator(appConfig));

System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo {
    UseShellExecute = true,
    FileName = outputDir,
    Verb = "open"
});
