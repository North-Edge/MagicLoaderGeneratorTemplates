# MagicLoader generator .NET templates

## Description
These templates are meant to facilitate the creation of mods based o the [MagicLoaderGenerator](https://github.com/North-Edge/MagicLoaderGenerator) library.

## Installing or Updating the templates
`dotnet new install NorthEdge.MagicLoaderGenerator.Templates`

## Creating a solution
`dotnet new mlg-sln -n MyMod`

## Creating a console project only
`dotnet new mlg-mod -n MyMod`

## Uninstalling
`dotnet new uninstall NorthEdge.MagicLoaderGenerator.Templates`

# Changelog
## Version 1.1.0
- Initial stable release
## Version 1.1.1
- Remove the root namespace property in the project file
## Version 1.2.0
- Bump the version of the MagicLoaderGenerator package to 1.2.0
- Add a target to automatically install the generated templates
- Fix the content of the config for the Console template
- Add the `Input` folder to the project structure 
## Version 1.2.1
- Bump the version of the MagicLoaderGenerator package to 1.2.1
