// Copyright Song Fu 2016.

using UnrealBuildTool;
using System.Collections.Generic;

public class TankMultiplayerGameEditorTarget : TargetRules
{
	public TankMultiplayerGameEditorTarget(TargetInfo Target)
	{
		Type = TargetType.Editor;
	}

	//
	// TargetRules interface.
	//

	public override void SetupBinaries(
		TargetInfo Target,
		ref List<UEBuildBinaryConfiguration> OutBuildBinaryConfigurations,
		ref List<string> OutExtraModuleNames
		)
	{
		OutExtraModuleNames.AddRange( new string[] { "TankMultiplayerGame" } );
	}
}
