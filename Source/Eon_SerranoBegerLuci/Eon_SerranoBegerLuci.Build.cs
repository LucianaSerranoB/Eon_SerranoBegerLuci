// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Eon_SerranoBegerLuci : ModuleRules
{
	public Eon_SerranoBegerLuci(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"Eon_SerranoBegerLuci",
			"Eon_SerranoBegerLuci/Variant_Platforming",
			"Eon_SerranoBegerLuci/Variant_Platforming/Animation",
			"Eon_SerranoBegerLuci/Variant_Combat",
			"Eon_SerranoBegerLuci/Variant_Combat/AI",
			"Eon_SerranoBegerLuci/Variant_Combat/Animation",
			"Eon_SerranoBegerLuci/Variant_Combat/Gameplay",
			"Eon_SerranoBegerLuci/Variant_Combat/Interfaces",
			"Eon_SerranoBegerLuci/Variant_Combat/UI",
			"Eon_SerranoBegerLuci/Variant_SideScrolling",
			"Eon_SerranoBegerLuci/Variant_SideScrolling/AI",
			"Eon_SerranoBegerLuci/Variant_SideScrolling/Gameplay",
			"Eon_SerranoBegerLuci/Variant_SideScrolling/Interfaces",
			"Eon_SerranoBegerLuci/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
