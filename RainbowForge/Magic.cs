﻿using System.Diagnostics.CodeAnalysis;

namespace RainbowForge
{
	[SuppressMessage("ReSharper", "InconsistentNaming", Justification = "Enum member values are the CRC32 of the exact member name")]
	public enum Magic : ulong
	{
		Metadata = 0,
		FileContainer = 0x1014FA99,
		CompiledMeshObject = 0xABEB2DFB,
		CompiledMesh = 0xFC9E1595,
		CompiledTextureMap = 0x13237FE9,
		CompiledLowResolutionTextureMap = 0xD7B5C478,
		CompiledMediumResolutionTextureMap = 0xF9C80707,
		CompiledHighResolutionTextureMap = 0x59CE4D13,
		CompiledUltraResolutionTextureMap = 0x9F492D22,
		CompiledFutureResolutionTextureMap = 0x3876CCDF,
		CompiledTextureMapData = 0xc30c4b3d,
		CompiledLowResolutionGuiTextureMap = 0x9468B9E2,
		CompiledMediumResolutionGuiTextureMap = 0x05A61FAD,
		CompiledSoundMedia = 0x427411A3, // Wwise sound
		BuildTable = 0x22ECBE63,
		BuildColumn = 0x36839608,
		RowSelection = 0x8e716439,
		RowSelector = 0xf5bd7b8a,
		LocalizedString = 0x5fc9ce4d,
		EntityBuilder = 0x971A842E,
		WeaponData = 0xADBAB640,
		GameBootstrap = 0xE5A83560,
		LocalizationPackage = 0x6E3C9C6F,
		CompressedLocalizationData = 0xd28389b5,
		PlatformManager = 0xAE88DE65,
		World = 0xFBB63E47,
		LoadUnit = 0x943945C4,
		WorldMetaData = 0x3E237DA3,
		GIStream = 0xD16E3EBE,
		CompiledMeshShapeDataObject = 0x9231EE0F,
		CompiledSoundBank = 0x82688E42,
		ShaderCodeModuleUserMaterial = 0x1C9A0555,
		Material = 0x85C817C3,
		TextureMapSpec = 0x989DC6B2,
		TextureMap = 0xA2B7E917,
		Mesh = 0x415D9568,
		Skeleton = 0x24AECB7C,
		CollisionMaterial = 0x74F7311D,
		Entity = 0x0984415E,
		SpotLight = 0x80320FB8,
		FacialPoseGroup = 0xE640B4DA,
		FX = 0x824A23BA,
		SplashFX = 0x755ACE14,
		BallJointCommonData = 0x460DD209,
		LiteRagdoll = 0x891043D5,
		BoxShape = 0x4EC68E98,
		BuildRow = 0x348B28D6, // BuildRow in a BuildTable
		FireFontDescriptor = 0x58E38D86,
		MeshShape = 0xB22B3E61,
		PostEffects = 0xC83B8907,
		AtomGraph = 0xC0C861CD,
		BarrelShape = 0x97CD8890,
		BodyPartMapping = 0xB3ADF542,
		CapsuleShape = 0xB8599052,
		ClutterGenerationSettings = 0xB144F3A0,
		ConvexVerticesShape = 0x53667A87,
		EntityGroup = 0x3F742D26,
		GameSetting = 0x52534498,
		ListShape = 0x86EBFD8D,
		LODSelector = 0x51DC6B80,
		MarketingCamera = 0x5B7FC715,
		OmniLight = 0x344780D6,
		PersistableOptionsProfile = 0x8F07EDFF,
		RagdollNew = 0xC8DBDE7F,
		SoundPropagationMap = 0x97FCF21E,
		SphereShape = 0xFA3F7A18,
		Gadget = 0xB1F352BC,
		Weapon = 0x6E9FA2D0,
		Charm = 0x40FCADEE,
		Projectile = 0x73A641BD,
		Animation = 0x0FA3067F,
		R6AIWorldComponent = 0x584879B2,
		R6AIRoomManager = 0xFF69F55,
		AIStrategyManager = 0xBFAFB75B,
		AIVariationManager = 0xD2EE613B,
		AIVariationTrigger = 0x32A14BDF,
		TagValueList = 0x7855A3D0,
		AIConditionWorldEntityState = 0x227643F3,
		AIVariationEventSeed = 0xC015C79B,
		AIVariationEvent = 0x10E3B295,
		SpawnRequestManager = 0xCC1BF59,
		R6AIRoom = 0xdb9c79f2,
		TheaterData = 0x84EC653F,
		KinoExternalStateData = 0xB19D4FCD,
		KinoReplaceSetData = 0x3F49D5C9,
		KinoGraphData = 0x3527D1AE,
		TheaterCinematic = 0x28435F00,
		KinoMarkupDictionaryData = 0xBBA2898E,
		KinoReplaceFamilyData = 0x28941138,
		KinoReplaceTreeData = 0x2C1329D2,
		DominoScriptDefinition = 0xE802B9DA,
		CreditsData = 0x88AEAEB2,
		KinoBootStrapData = 0x0549696C,
		Universe = 0x98435A63,
		KinoMarkupSystemData = 0xABD50170,
		KinoSyncSystemData = 0x72FCB11D,
		KinoTagSystemData = 0x92F31FA2,
		GraphicsConfig = 0xB1420AD1,
		FactionSettings = 0x5CB07EA0,
		DebugSettings = 0x9B7A3615,
		AnimationSettings = 0x174B8004,
		KinoRuntimeData = 0x149E0A31,
		KinoReplaceSystemData = 0x235C0560,
		MultiLodSetup = 0xAEC77F9A,
		BulletPenetrationSettings = 0xFB75DFB2,
		ShaderTemplate = 0x6F74DDB4,
		DamageData = 0x314AECEE,
		WeaponSoundData = 0xBF95D157,
		DestructionMaterial = 0x6A7D34A9,
		ArmorData = 0x7DC13543,
		ProjectileData = 0xA2D01604,
		GadgetData = 0xB6AA66C5,
		ReinforcementGadgetData = 0xB93410FB,
		BodyPartTemplate = 0x02251ED8,
		LocalizationComponent = 0x8DC233A0,
		R6GMGameMode = 0xC56C24BF, //gamemodes
		GMPhase = 0x195883E9, //gamemode parameters
		TagValue = 0x96EADACB, //more gamemode parameters
		Character = 0x118B3297, //operators
		CharacterSet = 0xB11FC381, //elite sets
		CharacterHeadgear = 0xF080B73C,
		CharacterUniform = 0x74DF1F46,
		WeaponSet = 0xAF5106DC,
		GadgetSkin = 0x1920FDB8,
		WeaponSkin = 0x02302D3D,
		WeaponAttachmentSkin = 0xF827AF5A,
		WeaponAttachmentSkinSet = 0x33E7DDEF,
		AutomaticFireFeedbackSystem = 0xC65B4C82,
		PadTriggerEffectData = 0x650BC5F7,
		MuzzleFXWeaponData = 0x12467BB8,
		DecalInfo = 0x92B7B9C4,
		SoundExplosionASRParams = 0x701AAFD9,
		SoundDistanceVolumeCurve = 0x965F7A70,
		ExplosionData = 0xF46703EF,
		SoundRigidBody = 0x019323BE,
		SimpleHoleCutterParams = 0x081DBB0A,
		DestructionRule = 0x42A270E2,
		SoundMaterialSettings = 0x4CAED6B4,
		SoundState = 0x3A5FF4AA,
		SoundID = 0x83EC6C6D,
		WorldLoader = 0x353B4604,
		WorldDivisionToTagLoadUnitLookup = 0xFD4E0B46,
		WorldLoadUnit_LoadByTag = 4222068481,
		WorldLoadUnit_WorldDivision = 0x87C38DE,
		WorldGraphicData = 0xF4833172,
		BoundingVolume = 0x4AEC3476,
		GIBoundingVolume = 0x18E26479,
		GISettings = 0x94CCDC09,
		TagClient = 0xEACD765A,
		IColor = 0xF8206AF7,
		WindDefinition = 0xFF92D6FE,
		FragmentClassifier = 0x62521AFA,
		SurfaceRule = 0x67B7180C,
		FragmentRule = 0x6F809E8D,
		DecoParams = 0x78153A75,
		DestructionDebrisBank = 0x7EFC7BBC,
		DebrisBankParams = 0xA64AA8EA,
		DestructionData = 0xA9892F4D,
		DestructionMeshGroup = 0xAF53B819,
		LocalReflectionCubemap = 0xB0DFE3A2,
		BehaviorRule = 0xC62947F6,
		R6DestructionSpec = 0xE6EA7903,
		ReinforcementSpecs = 0xF299B284,
		SimpleVoronoiCutterParams = 0xFA53A1B9,
		GMSettings = 0xC9208D05,
		CTU = 0x484BD7A0,
		MVPAnimation = 0x15ACF38F,
		DebrisRule = 0xDD3175E0,
		CharacterParameters = 0xA5863E1C,
		ProgressionClientUnlockablesReward = 0x525B5254,
		ProgressionBoosterUnlockableReward = 0xFA961D1B,
		ProgressionRenownReward = 0xBE5DE60D,
		ProgressionSecondaryStoreReward = 0x8CD460EF,
		ProgressionCreditReward = 0x7E071365,
		InventoryModificationReward = 0xDFA222C0,
		WeaponParameters = 0xF1A4FFE8,
		GadgetProp = 0xB437504C,
		SoundDamageParameters = 0x500E5AA7,
		MultiAudioEventData = 0x3A8EBDC4,
		CharacterGameSoundSettings = 0xD3264858,
		SingleShotFeedbackSystem = 0x08657FFC,
		KinoUpdateContextData = 0x6DD2D2B2,
		ScopeData = 0xF83984F4,
		SoundPositionSettings = 0x6EC51CE8,
		ProximityRuleSet = 0x331885FB,
		DestructionInterceptionBehavior = 0x8EC8EFA3,
		DamageVulnerabilityData = 0x37FDE164,
		DamageVulnerabilitySituation = 0x252D9654,
		InterceptionRules = 0x99BEC7AC,
		SoundExplosionData = 0xC8C42C4A,
		SoundDistanceDurationCurve = 0xDB673D78,
		DeployableDestructionProperties = 0x57E53D80,
		EffectData = 0xD5DD2E78,
		HitZoneSettings = 0x3FCCEF27,
		DotEffectElectrify = 0x19AD0F43,
		SoundCameraParameters = 0x492C212A,
		HitVolumeSetting = 0x37DC8B92,
		TransformRule = 0x12F0D0CD,
		SplineCutterParams = 0xC38BA632,
		ShieldClipData = 0x91A51884,
		TextureProjector = 0x30199DD2,
		RecoilWeaponDataModifiers = 0x0FD4BA52,
		RollingGrenadeData = 0x4DD323EF,
		MoveProjectileInterceptionBehavior = 0x44F584B2,
		SpawnedDeploymentDestructionSettings = 0xB8D39F2C,
		PiercingData = 0xF08FF8E1,
		AttachmentData = 0x9C746BA2,
		SharedResourcePoolData = 0xE785230F,
		ManagedSoundResourceBootstrapStorer = 0x114A1670,
		GameActivityManager = 0x362E52EF,
		GraphicDebugData = 0x5EF32472,
		FireLoadOnDemandManager = 0xC2BB2B7B,
		R6Configs = 0xE9B7B975,
		GameDataManager = 0x2F9A4C63,
		R6DataSwitches = 0xC9D94E7B,
		InputConfig = 0x677C81B5,
		GameSoundSettings = 0x431F8D59,
		EnvironmentSoundSettings = 0xBCC33D21,
		RenderingAndToolSoundSettings = 0xFFC937C2,
		SoundPhysicSettings = 0xEBEE4F97,
		WeaponSoundSettings = 0x61DBE0D4,
		GameModeMusicSettings = 0xE11D37B0,
		FireSoundSettings = 0xA7408587,
		GameFlowSoundSettings = 0xE2B1DA63,
		SoundPropagationSettings = 0x5A2916ED,
		ZoningGenerationSettings = 0x6A3CCB87,
		DamageSoundSettings = 0x8781BA45,
		SoundEventsSettings = 0x55FED664,
		UISoundSettings = 0x5361FE09,
		SpaceBuilderGenerationSettings = 0xF0B801F4,
		SoundReplaySettings = 0xC73269C3,
		GameEventSoundSettings = 0x633C50A5,
		GameActivityConfig = 0xD28AECC8,
		CTUHeroConfig = 0x53510945,
		PelletClusterManagerConfig = 0x757A9B6A,
		AccessibilityConfig = 0xC164129B,
		CharacterConfig = 0x2F181F2A,
		AddonManager = 0x065C43E7,
		R6FeatOfArmsManager = 0xA3ED4D0E,
		ArchetypeSpawnConfig = 0x0979E1FD,
		R6GameObjectBank = 0x73D5049A,
		MatchTypeIntroScreen = 0xE7EB3EA2,
		MapBanScreen = 0xEC84C5A8,
		MatchTeamsHeaderCasterScreen = 0x90C46F67,
		CloseButtonScreen = 0x7094C8C0,
		SocialMainScreen = 0xD62CBF1B,
		PlayModesMenuDevScreen = 0x20A7F8DB,
		GridToolScreen = 0x654B677E,
		MultiModalTabsNavigationScreen = 0x66170928,
		MultiModalBackgroundScreen = 0xEC5E34FC,
		MultiModalRankedOverviewScreen = 0x5B4434F9,
		MultiModalRankedProfileScreen = 0xA9F08594,
		MultiModalRulesScreen = 0x5E287E30,
		MultiModalRankedSkillsScreen = 0xB53E8731,
		MultiModalMapsScreen = 0x31EDEB8F,
		MultiModalGenericOverviewScreen = 0x58A5FA99,
		MultiModalGameplayScreen = 0xB384D6BA,
		HudCasterCenteredCardScreen = 0xA28319BE,
		HudCasterVersusFeedbackScreen = 0xD8D4A3B7,
		HudCompassScreen = 0xFB911AC9,
		HudDangerIndicatorScreen = 0x9FCCFC0F,
		HudDotReticleScreen = 0x44CC846A,
		HudEffectScreen = 0x87EA637F,
		HudFirstPersonOverlayScreen = 0xC56394EC,
		HudHeaderScreen = 0xD0BF3717,
		HudInteractionsScreen = 0xEAA269F9,
		HudMarkersScreen = 0x9B40DEE7,
		HudMatchReplayOverlayScreen = 0x6365DDB5,
		HudPingLocationScreen = 0x88619F2B,
		HudPlayerCardScreen = 0x807B632C,
		HudPvePlantBombInfosScreen = 0x5B99D7EE,
		HudPveRemainingEnemiesScreen = 0x172AEDC3,
		HudReinforcementPoolScreen = 0x0AB4E591,
		HudReticleScreen = 0xF9547F6E,
		HudScoreAccumulatorScreen = 0xF894F45C,
		HudScorePanelScreen = 0xDE19A21F,
		HudScoreboardScreen = 0x2AFED9F5,
		HudVersusFeedbackScreen = 0x319D3B23,
		HudVoteSystemsScreen = 0xAF7EAE1C,
		HudWeaponInfoScreen = 0xF0D30C80,
		GameInfosScreen = 0x9EEEEE64,
		UplayNotificationScreen = 0x10EC8370,
		UplayNextNotificationScreen = 0x92487281,
		ModalsOverlayScreen = 0x83EF4293,
		GuiComposition = 0x068BC084,
		GuiSequencer = 0x39B65F1C,
		DevScreen = 0x1BE6C8CE,
		SoundDistanceRTPCCurve = 0x9FCDC4C4,
		FlickerInstanceData = 0x968EB336,
		DestructionCollisionInfo = 0xE6F88917,
		RTCPMaskScenario = 0xCD3A69BB,
		AIStimuliData = 0x1EB4394F,
		DestructionInputs = 0x870333E7,
		DiscoveryPlaylistCasual = 0xB2A34FD6,
		PortalHUBCinematic = 0xC8A9EA4D,
		SeasonsUIConfig = 0xAB65D3FB,
		MultimodalsUIData = 0xC7623831,
		PECStatData = 0xAC448642,
		OasisLibrary = 0x9448465F,
		GameModeSet = 0x02DADF46,
		ScoringEvent = 0x3A2E6B70,
		Achievement = 0x10EFF026,
		OperatorUnlockableCollection = 0x0C608314,
		WeaponAttachmentUnlockableCollection = 0xDC2518CD,
		WeaponVisualUnlockableCollection = 0x7534775B,
		WeaponUniversalVisualUnlockableCollection = 0xF97A20D9,
		CharmUnlockableCollection = 0x1FB57CD5,
		GadgetVisualUnlockableCollection = 0xA59508E9,
		BoosterUnlockableCollection = 0x963C6585,
		LootCrateUnlockableCollection = 0xC6C17A7E,
		BundleUnlockableCollection = 0x6741C390,
		CollectionUnlockableCollection = 0x6996E7AE,
		HeadgearUnlockableCollection = 0xA1063448,
		LegendaryUnlockableCollection = 0x44932C9B,
		UniformUnlockableCollection = 0xBDE2D3B6,
		VictoryPoseUnlockableCollection = 0xC41C7553,
		VictoryPoseUniversalUnlockableCollection = 0xC7EA0284,
		VictoryDanceUnlockableCollection = 0x9F7CC8DE,
		VictoryDanceUniversalUnlockableCollection = 0xF0FC923B,
		YearOperatorsBundleCollection = 0xAEF1B01E,
		UnlockablesProductIdMappingCollection = 0xF868521C,
		UbiShopTagCollection = 0x0D267C80,
		CurrencyGameObject = 0xCC0308BC,
		PackGameObject = 0xB2314E6A,
		PackTrinket = 0x10B8F86E,
		BattlePassBackgroundScreen = 0xD4400C98,
		MaterialPostFX = 0x5E748F79,
		SkyLight = 0x77EEEBB4,
		AIReactionData = 0x580CB97B,
		BattlePassProgressionContent = 0x87DC6BA2,
		BattlePassChallengesContent = 0x38E25AF8,
		PlaylistCategory = 0x2372F68D,
		PortalPlaylistLockSettings = 0x2F8211BE,
		PlayModesUIConfig = 0xB25C10A6,
		PECLeaderboard = 0xE4DA998A,
		OperatorFilter = 0x4221C364,
		SpawnPointWeightingRuleSet = 0xF8C91259,
		SpawnRuleSet = 0x3F132C04,
		ScoringRule = 0x1DC87D8D,
		SpecificOperatorsPlayedObjective = 0xB1385123,
		OldSchoolObjective = 0x9493DAE5,
		FullRosterObjective = 0x8DA57685,
		EveryOperatorWinObjective = 0x38D9651C,
		CustomizeWeaponObjective = 0x96CACB2E,
		RankObjective = 0x239EC16A,
		WeaponAttachmentsEquipObjective = 0x7ED1E02F,
		BoosterUnlockable = 0x768983D5,
		LootCrateUnlockable = 0xB09DBCA5,
		BundleUnlockable = 0x98941647,
		HeadgearUnlockable = 0x906F8AFA,
		LegendaryUnlockable = 0xAD2D511F,
		UniformUnlockable = 0x39895C86,
		UIUnlockInfo_Simple = 0x8E566044,
		FirstPartyReward = 0xBFF0DE83,
		ProjectileParameters = 0x4A8D785E,
		GameObjectUnlockable = 0x8FFC66AF,
		GadgetParameters = 0x76461ED4,
		GDOSpawnSpec = 0x8D1D966B,
		ECEntityRestrictionPack = 0xD4FF0A39,
		BattlePassRuleSection = 0x4B2C6170,
		SituationPlaylist = 0xF69F0F3A,
		CharacterAnimationParameters = 0x1D09EB70,
		AtomReplaceIdentifierData = 0xD26A7C20,
		ArchetypeDescriptor = 0xF3E453E6,
		BattlePassLayout = 0xBAF2B765,
		BattlePassAfterActionReport = 0x8FC83A83,
		GenericCamera = 0x6CCAF448,
		SoundDistanceLPFNonNormalizedCurve = 0xBEA18D0F,
		GDOWorld = 0x35A43414,
		LoadoutDefinition = 0xC7D8141C,
		PushBackSpecialMove = 0xFD73E329,
		BattlePassOverviewContent = 0x9DB1FD8E,
		BattlePassRulesContent = 0x72492CC9,
		BattlePassEventTile = 0xD6511707,
		BattlePassUniverseContent = 0x7B956A71,
		ShaderCodeModulePostPro = 0xD832DDF2,
		SoundNormalizedGenericCurve = 0x6B065046,
		GDOWeaponRecoil = 0xBBD29395,
		MVPAnimationData = 0x601620B7,
		DownJumpData = 0x6C98B26A,
		GlassCutterParams = 0x009447A3,
		BreakAllCutterParams = 0x69294D15,
		WorldDivisionContainer = 0x329B6C35,
		CameraTargetSwitcherWorldComponent = 0x35CB395B,
		NavMeshScenarioManagerWorldComponent = 0x61E700A1,
		WorldWallGroups = 0x927ED8BA,
		AtomWorldComponent = 0x2013DBD0,
		DestructionWorldComponent = 0x7A57CFE8,
		DebrisParticlesManager = 0x78826E3F,
		GameSessionWorldComponent = 0x6EDA4278,
		FunctionalTestWorldComponent = 0x6BEC97E0,
		RecordingManager = 0xE8301D07,
		PECEventWorldManager = 0xAFBFA30A,
		ReplayWorldComponent = 0x81416D84,
		SpawnManager = 0x0961ACE0,
		ProfileWorldComponent = 0xCBD05F03,
		ExplosionTestTargetWorldComponent = 0x98AB6F5F,
		GameDestructionWorldComponent = 0x13ED963C,
		SharedResourcePoolManager = 0x83B706A1,
		WallGroup = 0xB578ED58,
		DebrisParticleSystemSetting = 0xC75792F9,
		SoundPropagationGeneratorDynamicOccluderSettings = 0x2EE13FC3,
		WorldDivision = 0xC112A19D,
		SoundCollisionMaterial = 0x97164A5A,
		AIVariationSelector = 0x950CCA15,
		RefillDeployedGadgetInteractionMessageCondition = 0xB8D30640,
		R6UnlockableManager = 0xD38F00F7,
		R6SpawnBuilderDefinition = 0x9B5A2DDD,
		R6LootCrateGameObject = 0xD869438B,
		InputConfigTemplateManager = 0x9CD86D47,
		SoundSystem = 0xD5B8BCCF,
		DebugMenuFavoritesManager = 0x5C6DB8EE,
		TagManager = 0x6AB6B15A,
		R6GameFlowConfig = 0x4663080B,
		PersistableOptionsProfileManager = 0x0A6F2434,
		ArchetypeSoundSettings = 0x9537DEF3,
		TagCollection = 0x5CC5B62D,
		AIConfig = 0x3362A659,
		AnimationConfig = 0xF2909128,
		CameraConfig = 0x3ECFFBE9,
		DestructionConfig = 0x50E8BCD5,
		InputActionConfig = 0x23356DD3,
		CommerceConfig = 0xE4C879CB,
		PhysicConfig = 0x79D5DC5D,
		PresentationConfig = 0xE23D8547,
		StrategyManagerConfig = 0x05BAC528,
		TheaterActorConfig = 0x6D5ABB38,
		PlayerCameraFXConfig = 0xECBCB42A,
		RTCPMaskConfig = 0x08788F46,
		InGameReplayConfig = 0xAD65B916,
		AIStimuliConfig = 0x960ADC3B,
		IdlePatchSettings = 0x47266B85,
		KickManagerConfig = 0x997493CF,
		SurrenderManagerConfig = 0x34834281,
		R6DestructionInputConfig = 0x42A73527,
		EncounterConfig = 0xEC1AE5CE,
		PersistenceConfig = 0x2A1CD834,
		WeaponConfig = 0x6C95ED4B,
		CountryTeamsConfig = 0x58B67BB9,
		AccuracyConfig = 0x9259E092,
		ControlConfig = 0x5199247E,
		GadgetConfig = 0xACB24881,
		InteractionConfig = 0x772F30F9,
		InterfaceConfig = 0x3201FD47,
		OnlineConfig = 0x7E90DAF3,
		VisualConfig = 0x16F32462,
		LocalizationAITypeConfig = 0x42711A6B,
		LocalizationConfig = 0x50E9F706,
		CoverConfig = 0x0660CF94,
		HealthConfig = 0x1AEC36E4,
		VoiceOverConfig = 0x3BC05E8A,
		ActionFilterConfig = 0x10B76DDB,
		GMConfig = 0x01428BCD,
		PilotGenConfig = 0xF5957839,
		R6ProgressionManager = 0x1D781BF9,
		MissionGeneratorManager = 0x3033C2F5,
		R6LocalizationManager = 0xF4A4EA3C,
		GameModeManager = 0x62940EDE,
		ScoringUniverseComponent = 0x88723072,
		R6AchievementManager = 0xA9DF6179,
		R6GamerProfileManager = 0x5FB5B6AC,
		AtomReplaceManager = 0xECEB61FF,
		GameDataFolder = 0x328A37EF,
		SoundDistanceSpreadCurve = 0x25E81D4E,
		DynamicSoundEmitterIdentifier = 0x421B4E2C,
		AngelCamTree = 0x919BC0C1,
		ConnectionType = 0xB03D110F,
		PhysicCollisionMaterial = 0x7A9E1890,
		ConstraintStrengthType = 0x2B1E772F,
		MaterialPostFXConfig = 0x4EC26571,
		FireData = 0xAF43CA83,
		R6PresentationColorsConfig = 0xFE41FE3A,
		R6LocalizationTagConfig = 0x36DD627F,
		AIReactionPack = 0x6221143B,
		AIStrategy = 0x68D14966,
		GameModePersistenceContainer = 0x769234F3,
		DestructionPersistenceContainer = 0xABF1126E,
		SpeedRangeSet = 0x867272AD,
		BloodSpatterInfo = 0x67D4BB33,
		VisualRenderingSettings = 0x1EA9980D,
		RumbleEventData = 0x4A2B1E69,
		HudPreset = 0x823B0214,
		UIInteractionConfig = 0x46863A3E,
		PlaylistConfig = 0x3766A74D,
		GMCharacterDescriptor = 0x25246116,
		ScoringEventBonus = 0x5CD67520,
		ScoringRuleCollection = 0x0E4D615D,
		R6GamerProfile = 0x6AFDC2A9,
		R6BoosterGameObject = 0xE429F928,
		FxCollisionMaterial = 0x69FDD4B0,
		DecalInfoCollisionMaterial = 0x8D255754,
		PECCombinedDivisionStat = 0xA56C8CC5,
		PECEventStat = 0x2DEA8F56,
		PECStatsboard = 0x095C9647,
		GMStepIngameCinematic = 0xD523C20F,
		R6GameObject = 0xD097D3CC,
		AIVisionZone = 0xFB1080A9,
		MatchCompletionScoringRule = 0xC56BD2E2,
		HostageDBNOScoringRule = 0x8EA0B8DA,
		MissionCompletionScoringRule = 0x8F5197B5,
		PECEventObjective = 0x43CDE9D1,
		ClearanceLevelObjective = 0xD11602E4,
		AccumulateRenownObjective = 0x1B3B2DDA,
		WeaponSkinningProgressObjective = 0x17F24DEF,
		WelcomeToUPlayObjective = 0xAD823C99,
		CandidateSelectionObjective = 0x0890F33D,
		OperatorUnlockable = 0x587515A2,
		CharmUnlockable = 0x5E78DF4D,
		GDOUIDescription = 0x51066FDD,
		GDOUICharacter = 0x56C88C7F,
		SoundExplosionTinnitusData = 0xC10BB5D1,
		GDOAddTag = 0x9B19F386,
		RecoilWeaponData = 0xAAC174F3,
		AmmoWeaponData = 0x7F33044E,
		PlaylistObjective = 0xC6D9C255,
		GDOGMSettings = 0x93F555A4,
		TurnOnSpotSpecialMove = 0xB3E69826,
		AnimatedStartSpecialMove = 0x20315192,
		AnimatedStopSpecialMove = 0xE0DC44A6,
		PlantTurnSpecialMove = 0xA1CA4B23,
		WorldLoaderScenario = 0x63DE24AF,
		GameModeWorldComponent = 0x5B66A12C,
		WorldDivisionGroup = 0xBD036711,
		SoundSpaceData = 0xFC6CDAC0,
		TextureCutterParams = 0x8AD757D8,
		SoundAmbience = 0x43D7EC0D,
		SoundSpacePBR_RTPCs = 0xF38AD0D3,
		MergedDestructionHierarchy = 0x0B31D77C,
		FXWeaponData = 0x28C63628,
		AnimationWeaponData = 0x0B688159,
		DamageWeaponData = 0x360AF241,
		AccuracyWeaponData = 0x7B1E209F,
		NoiseData = 0x175D7309,
		GenericClusteringData = 0x7D61B237,
		DynamicSubMesh = 0xA4729FC9,
		DotEffectBarbedWire = 0x1CFAAAAF,
		PhoenixSceneData = 0xEC3826FF,
		PhoenixFont = 0xA6EA7232,
		KinoReplaceIdentifier = 0xd9606976,
		OverrideDefinition = 0x49fcd7bf,
		GraphicObject = 0xec6ac357,
		SpaceManager = 0xa527a3cb,
		SpaceComponentNode = 0x230B5DAB,
		UVTransform = 0xc52e2125,
		DetailMapDescriptor = 0x7799a6d5,
		TextureSelector = 0x7d08460d,
		R6ActionFilter = 0xc6382399,
		MeshBone = 0x9ef0e7a1,
		ShaderCodeVariable = 0x1bcb6f77,
		PhysicsSDKDataPack = 0x390f5602,
		BoneInitialTransforms = 0x6350e5a6,
		SkeletonMirrorData = 0xe96b19a5,
		Bone = 0x95741049,
		ConstraintTarget = 0xdf638110,
		PositionConstraintBoneModifier = 0xd0c34a81,
		OrientationConstraintBoneModifier = 0x75116750,
		BallJointBoneModifier = 0x4bf66801,
		RollBoneModifier = 0x76d082f6,
		ConstraintBoneModifier = 0x84240425,
		CompressBoneModifier = 0x844987d6,
		HingeVectorBoneModifier = 0xc0dd28a9,
		StretchBoneModifier = 0xcf6d16fa,
		WrinkleBoneModifier = 0xd12b891d,
		PendulumBoneModifier = 0x544175b,
		ReflexBoneModifier = 0x57daa86,
		LookAtBoneModifier = 0x8d774b2,
		FollowBoneModifier = 0x13ae4b43,
		HingeBoneModifier = 0x324796c7,
		Reflex3SkeletonConstraints = 0x8e3fb47a,
		WeaponAttachmentSight = 0xF8E187EA,
		WeaponAttachmentBarrel = 0x0B7410FB,
		WeaponAttachmentUnderbarrel = 0x305DAAF0,
		WeaponAttachmentGrip = 0xCEA4CA0E,
		WeaponAttachmentMagazine = 0xCE4A0B93,
		HudMessageScreen = 0x83CF3,
		TestDistanceFieldScreen = 0x011E8646,
		OptionsButtonScreen = 0x21F2156,
		SavingIndicatorScreen = 0x2E39828,
		ShopMainDetailsScreen = 0x35DD7B7,
		OptionMenuScreen = 0x71162CD,
		HudTickerScreen = 0x8FB1A41,
		EpilepsyWarningScreen = 0xE30EA90,
		SubtitleScreen = 0x10CD2580,
		LobbyRankProgressionScreen = 0x1169ABCD,
		LobbySearchingScreen = 0x13C926E5,
		BackgroundScreen = 0x14C061C0,
		OptInFlowScreen = 0x163FB24F,
		MatchOutcomeScreen = 0x1749DC10,
		HudDeathExperienceScreen = 0x17D11ADA,
		FunnelNavigation = 0x180E0D55,
		ControlsOptionsScreen = 0x1910B39F,
		KoreanPCBangScreen = 0x194A1FE4,
		BattlePassProgressionScreen = 0x1AAFCE39,
		RankChangeShowcaseScreen = 0x1D6C2E49,
		AccessibilityOptionsScreen = 0x1D6D67C0,
		SystemScreen = 0x1E26C8F8,
		HudConnectivityScreen = 0x21943A63,
		HudKillerInfoScreen = 0x23BF9925,
		OperatorBanningStepsHeaderScreen = 0x23CD3131,
		LoadoutSelectionScreen = 0x24D19860,
		ShopMainScreen = 0x27966F42,
		RoundIntroScreen = 0x31B492A9,
		GDOUICharm = 0x334B31A2,
		HudStanceScreen = 0x337544B7,
		MatchRewardsScreen = 0x33A3568D,
		HudDBNOScreen = 0x345D8BAB,
		WatchMainScreen = 0x415C097D,
		MatchShowcaseScreen = 0x43CEDB18,
		TeamCompositionScreen = 0x489C5552,
		LoadingIndicatorScreen = 0x48B37D86,
		QuickBootScreen = 0x4A798445,
		OperatorSelectionScreen = 0x5C53C116,
		RevealScreen = 0x5EC04AA3,
		GDOUICurrency = 0x61517D87,
		MatchIntroScreen = 0x6B231FF1,
		EventPlaylist = 0x6C95705C,
		HudScreen = 0x71288716,
		ScoreboardScreen = 0x759B2F0C,
		PortalOverlayScreen = 0x47B5DECD,
		PortalBackgroundScreen = 0x6619D57A,
		PortalContentScreen = 0x76D5826F,
		GDOUICharacterUniform = 0x7DC0C72E,
		OpenPackScreen = 0x82CA892F,
		GDOUIBooster = 0x85BE0AE0,
		HudWarningsScreen = 0x936B86B6,
		PortalLobbyScreen = 0x9B4018D4,
		RuntimeGeometrySettings = 0x340378D4,
		RuntimeVFXSettings = 0x9B8921EF,
		RuntimeReflectionSettings = 0x9C3CF247,
		VideoOverlayScreen = 0x9DEB0049,
		StartScreen = 0xA1111DBC,
		VoiceChatScreen = 0xA9A2526B,
		RuntimeLightingSettings = 0xAE148772,
		PlatformDescriptor = 0xAF296DB7,
		GDOUICharacterHeadgear = 0xB3E0418E,
		HudReplayScreen = 0xC3692044,
		GDOUISkin = 0xC9C108A7,
		LobbyPVEScreen = 0xCBF34700,
		GamePlaylist = 0xD74F36D1,
		DeathCamScreen = 0xDD535A95,
		CreditsMenuScreen = 0xDD743C79,
		WatermarkScreen = 0xDE8C31D8,
		PortalScreen = 0xE2047AF0,
		PlanningOverlayScreen = 0xE46C4EFE,
		MatchActivity = 0xE5929EEB,
		ChallengeData = 0xEA9FA35E,
		PauseMenuScreen = 0xF2B7EF38,
		HeroBanningScreen = 0xF40A6466,
		RuntimeDOFSettings = 0xF504EECC,
		RoundOutcomeScreen = 0xF622AE46,
		PCChatScreen = 0xF776ED2A,
		TacticalMapScreen = 0xFDA4B79A,
		LobbyPVPScreen = 0xFE15F469,
		GDOGameMode = 0xFF138919,
		FrameLimitConfig = 0x3E997631,
		HomeLandingScreen = 0x2FA0C47A,
		CrossExpositionAccessPointScreen = 0xE4EA16FA,
		AfterActionOverlayScreen = 0xB3FC5A70,
		AfterActionOverlayTabNavigationScreen = 0xBFE86D68,
		CasterMatchIntroScreen = 0x6200CD51,
		CommonHudElementsScreen = 0x8882306C,
		EndOfRoundReplayScreen = 0x3BD86505,
		OperatorBanVotingOverlayScreen = 0xDB7A4E87,
		PartySessionScreen = 0xA20627F3,
		PortalMessagesOverlayScreen = 0x55C79DF9,
		PortalPanelOverlayScreen = 0x2F732FDB,
		MainMenuTabNavigationScreen = 0x2D956174,
		SixthPickScreen = 0xB033548F,
		TeamLoadoutInfoScreen = 0x7EFE24E6,
		ToastNotificationScreen = 0x4B00F860,
		MatchTeamsHeaderScreen = 0xCA7276F6,
		NavigationHeaderScreen = 0xEA7134AC,
		WalletScreen = 0x3AEE3518,
		AlbumLandingScreen = 0x38D82699,
		AlbumGridScreen = 0x30B11EF1,
		AlbumOperatorScreen = 0x34140EE2,
		AlbumOperatorLoadoutScreen = 0x52213660,
		AlbumOperatorHeadgearsScreen = 0xAA46E8C4,
		AlbumOperatorUniformsScreen = 0xC112470D,
		AlbumOperatorVictoryDanceScreen = 0xD421B531,
		AlbumOperatorTipsScreen = 0x7E76F54B,
		AlbumOperatorBioScreen = 0x463CB0AE,
		AlbumAppearanceScreen = 0xABF0C331,
		MatchFlowHeaderScreen = 0x9B3BB0F4,
		PlayModesLandingScreen = 0xD9261E2F,
		PlayModesTerroristHuntLandingScreen = 0xBAFB153E,
		PlayModesCustomGameLandingScreen = 0x840757DE,
		PlayModesLearningAreaLandingScreen = 0xB660EA83,
		PlayModesTutorialsLandingScreen = 0x99434A89,
		PlayModesCustomGameCreateScreen = 0xFCE622E2,
		PlayModesCustomGameJoinScreen = 0xD1339DA0,
		PlayModesSituationsScreen = 0xAA97BA5F,
		PlayModesSituationsDifficultyScreen = 0x522559E1,
		PlanningPhaseCasterScreen = 0x709BB47B,
		MatchLootCrateRewardsScreen = 0xC9BB7AEA,
		MatchBattlePassRewardsScreen = 0xB4B2B9C2,
		ShopEliteUniformsScreen = 0xA04ED9F8,
		ShopMainUniformsByCtuScreen = 0x5C68E246,
		ShopMainUniformsByOperatorScreen = 0x83E1A167,
		ShopMainHeadgearsByCtuScreen = 0x25B46ADB,
		ShopMainHeadgearsByOperatorScreen = 0xF8F4D2F9,
		ShopMainWeaponsScreen = 0x2C62E10B,
		ShopMainWeaponSkinsScreen = 0x6BE35F39,
		ShopMainAllItemsOwnedScreen = 0x805F5E74,
		SeasonalWeaponSkinsScreen = 0x86202661,
		ShopBundleCollectionScreen = 0x4E4C84DB,
		EsportsMainPageScreen = 0x97D8B660,
		EsportsTeamItemsScreen = 0x625EA9A5,
		EsportsItemDetailsScreen = 0x6DDC8C93,
		BattlePassChallengesScreen = 0xF4FF820A,
		BattlePassOverviewScreen = 0xADED9F2D,
		BattlePassRulesScreen = 0x802CF26E,
		BattlePassTabNavigationScreen = 0x8A4E6BA2,
		PackManagerMainScreen = 0x38866309,
		BattlecupLandingScreen = 0x4FF56BD1,
		MultiModalScreen = 0x92005DF2,
		ChinaWarningScreen = 0x44BC3648,
		LegalIntroScreen = 0x36BE7C80,
		HudCasterHeaderScreen = 0x5833D2FF,
		HudCasterPlayerListScreen = 0xA96BA120,
		HudDeathEventScreen = 0x8331998F,
		HudFriendlyFireFeedbackScreen = 0x33ECCB02,
		HudGrenadeIndicatorScreen = 0x24694DF2,
		HudMatchReplayPlaybackControlsScreen = 0x9035BB74,
		HudMatchReplayShortcutsScreen = 0xE4DA3D00,
		HudPveGameModeScreen = 0xD674C05A,
		HudReverseFriendlyFireReminderScreen = 0xF68E6B43,
		HudTipsScreen = 0xECD39854,
		HudTrainingObjectivesScreen = 0x4BDEDF64,
		HudIQDetectorScreen = 0xB63E701E,
		HomeNotificationsScreen = 0xCE3867A6,
		ModalFeedbackScreen = 0xFB364970,
		OptionsTabNavigationScreen = 0xA68EB4D7,
		GameplayOptionsScreen = 0xA37B1CB1,
		AudioOptionsScreen = 0x8E0CBB2E,
		VideoOptionsScreen = 0x863DB59A,
		GraphicsOptionsScreen = 0x372DB739,
		VideoMemoryScreen = 0xFF627CAB,
		OptionsOverlayScreen = 0x5476D639,
		ControllerLayoutScreen = 0x59DC33DA,
		SafeFrameScreen = 0x3B19FD0B,
		AlbumOperatorGridScreen = 0x5DF79B4C,
		BattlecupUIConfig = 0x0BA3D865,
		EmptyInterceptionBehavior = 0x1C9990D0,
		HudPlayerLifeScreen = 0x942EAEDC,
		R6ShopCatalogConfig = 0x7E6E6AF7,
		GDOUIGadget = 0xCEEAE89B,
		PlanningPhaseTeamsHeaderScreen = 0xCB12519E,
		ShopMainCharmsScreen = 0xDAD658B0,
		SoundWorldComponent = 0x7BCB6B7D,
		RuntimeTextureSettings = 0x03F388EA,
		RuntimeTextureFilteringSettings = 0x8766EFE0,
		RuntimeShadowSettings = 0x0102F6FE,
		RuntimeAOSettings = 0xB92FA8AC,
		RuntimeLensEffectsSettings = 0x394B591A,
		RuntimeSharpnessSettings = 0xD1082F1C,
		ManagedSoundBank = 0xFA32E3AF,
		BundleGameObject = 0x4EB4DD16,
		DestructionCollisionMaterial = 0x5f1c96c2,
		PhoenixFontData = 0x9BB2CDF2,
		BattlePassRule = 0x9A1C7FA6,
		BattlePassUniverseScreen = 0xEA266162,
		EventActivity = 0x1763682B,
		KinoReplaceSystemFamiliesData = 0xC52060FD,
		PackGDOUIDescription = 0x101AF874,
		LootCrateGDOUIDescription = 0xB648C1DF,
		BattlePassGDOUIDescription = 0x91860285,
		LaserReinforcementData = 0xD26D9DC9,
		PlatformRuntimeSettings = 0x307F9215,
		MultiBehaviorInterceptionRuleSet = 0x8BB308EA,
		SingleBehaviorInterceptionRuleSet = 0x253D8D16,
		MultiBuyUnlockable = 0x0745E69C,
		GDOOperatorGameplayMetaInfo = 0xA818CD8D,
		OperatorCardElement = 0xC3645505,
		UnlockableManagerRewardCollection = 0x6009EB19,
		EsportTeamObject = 0xA43332F8,
		GuiSoundManager = 0x91DFE9EC,
		GameGuiFactory = 0x11C5A979,
		PhoenixLocalizedFontData = 0x669403B9,
		PhoenixFontDescriptorData = 0xCBD4939A,
		GuiDevComposition = 0x44929C4E,
		ManagedSoundMedia = 0x9CB7D50B,
		BattlePoint = 0xFABAE07A,
		GDOUIACKNotification = 0xB66B7701,
		BattlePassGameObject = 0x0D8CA779,
		LivePreloadFont = 0x4802A946,
		CreditsLogo = 0xC1D3C7C2,
		DeployableData = 0x9A138EAC,
		ShieldController = 0x9CBA6E8C,
		NavBoostSystemController = 0x0B319CD4,
		AdditionalWeaponController = 0x2A8A9BB7,
		ActiveAbilityGameplaySystemController = 0x2EB71977,
		DeployableGadgetSystemController = 0x37E5F2B9,
		IQGadgetController = 0x38B8EBEF,
		NokkGameplaySystemController = 0x3F68F863,
		BlackBeardController = 0x41E5CCD3,
		DroneGadgetSystemController = 0x53379B58,
		DoctorCurseMeleeGameplaySystemController = 0x5CCBA83F,
		ExplosiveDroneSystemController = 0x6D467226,
		PrespawnedEntityRuleSet = 0x766A5572,
		StealthSystemController = 0x790BE350,
		TriggerAbilityGameplaySystemController = 0x7D872DDF,
		ReinforcementDeployableData = 0xA5E6AFD9,
		ProjectileGadgetSystemController = 0xC031DDA5,
		ActivationAbilityGameplaySystemController = 0xC1F46A69,
		GroundDeployableData = 0xCC94D8CF,
		GrenadeGadgetSystemController = 0xCE5656FC,
		ControllableDecoySystemController = 0xD70CBA76,
		WeaponAddonController = 0xDAB0FE03,
		ReinforcementGameplaySystemController = 0xE5767941,
		WardenGadgetSystemController = 0xED993706,
		MeleeGameplaySystemController = 0xFF35649C,
		SheetChargeDeployableData = 0x24B769FE,
		PhoenixImageData = 0x131C89F9,
		PhoenixWidgetData = 0x1B3B6644,
		PhoenixVideoData = 0xB16F9CAE,
		PhoenixEnumData = 0xB7ABC60E,
		PhoenixSoundData = 0xE12986CE,
		PhoenixWidgetTypeData = 0xA5A10525,
		PhoenixTextStyleData = 0x005557B9,
		PhoenixImageAtlasData = 0xDF8E96F1,
		PhoenixFontCharacterSetData = 0x0CFB284C,
		RuntimeRenderScalingFactorSettings = 0xBB5542A0,
		LaserReinforcementDeployableData = 0x5D86305B,
		R6GameplayInteractionsPreset = 0xDBAA67AC,
		R6SeasonalTrainingChallenges = 0xF5AC3340,
		RuntimeAntiAliasingSettings = 0xA89F658D,
		LaserReinforcementSystemController = 0x2DF799F3,
		PhoenixColorPaletteData = 0x037B5227,
		RuntimeAdaptiveRenderScalingTargetFPSSettings = 0x650f34cf,
	}

	public enum ContainerMagic : uint
	{
		Descriptor = 1,
		Hash = 6,

		// This entire assumption is incorrect and why
		// RF is being replaced by RS
		File = 0x57FBAA34,
		File2 = 0x57FBAA36
	}

	public enum AssetType
	{
		Unknown,
		Mesh,
		Texture,
		Sound,
		FlatArchive
	}

	[SuppressMessage("ReSharper", "InconsistentNaming", Justification = "Enum member names are how they appear in game files")]
	public enum StaticUid : ulong
	{
		DataControlGlobalMetaKey = 0x010,
		GameBootstrap = 0x800,
		UIFactory = 0x80A,
		GameSettings = 0x816,
		GameSoundSettings = 0x833,
		Universe = 0x83B,
		InputConfigurationTemplateManager = 0x89B,
		ManagedSoundResourceBootstrapStorer = 0x89D,
		SoundSystem = 0x89E,
		FireLoadOnDemandManager = 0x8A1,
		TagManager = 0x8A4,
		Validation = 0x8AE,
		GameActivityManager = 0x8B1,
		R6Configs = 0x962,
		GameDataManager = 0x964,
		KinoBootStrapData = 0x966,
		R6DataSwitches = 0x967,
		GraphicDebugData = 0x968,
		PlatformManager = 0x969,
		GameFlowConfig = 0xBDA,
		DefaultMaterial = 0xBDB,
		FastLoadTableOfContents = 0xBE0,
		DefaultVisualRenderingSetting = 0xBFF,
		VisualRenderingSettingConvertFromFP = 0xC00,
		VisualRenderingSettingConvertFromTP = 0xC01,
		DefaultNormalTexture = 0xC1C,
		DefaultNormalCompiledTextureMap = 0xC1D,
		DefaultSpecularTexture = 0xC26,
		DefaultSpecularCompiledTextureMap = 0xC27,
		DefaultDiffuseTexture = 0xC30,
		DefaultDiffuseCompiledTextureMap = 0xC31,
		DefaultDither8x8Texture = 0xC3A,
		DefaultDither8x8CompiledTextureMap = 0xC3B,
		DefaultDither5x5Texture = 0xC44,
		DefaultDither5x5CompiledTextureMap = 0xC45,
		DefaultClothMaskTexture = 0xC4E,
		DefaultClothMaskCompiledTextureMap = 0xC4F,
		BlackTexture = 0xC58,
		BlackCompiledTextureMap = 0xC59,
		WhiteTexture = 0xC62,
		WhiteCompiledTextureMap = 0xC63,
		DefaultCubeTexture = 0xC6C,
		DefaultCubeCompiledTextureMap = 0xC6D,
		MipMapRevealTexture = 0xC76,
		MipMapRevealCompiledTextureMap = 0xC77,
		DefragDebugTexture = 0xC80,
		DefragDebugCompiledTextureMap = 0xC81,
		BadAccessDiffuseTexture = 0xC8A,
		BadAccessDiffuseCompiledTextureMap = 0xC8B,
		BadAccessNormalTexture = 0xC94,
		BadAccessNormalCompiledTextureMap = 0xC95,
		BadAccessSpecTexture = 0xC9E,
		BadAccessSpecCompiledTextureMap = 0xC9F,
		BadAccessMiscTexture = 0xCA8,
		BadAccessMiscCompiledTextureMap = 0xCA9,
		EnvMapVisLUTTexture = 0xCB2,
		EnvMapVisLUTCompiledTextureMap = 0xCB3,
		DefaultGIVolumeTexture = 0xCBC,
		DefaultGIVolumeCompiledTextureMap = 0xCBD,
		NeutralShadowTexture = 0xCC6,
		NeutralShadowCompiledTextureMap = 0xCC7,
		DisolveNoiseTexture = 0xCD0,
		DisolveNoiseCompiledTextureMap = 0xCD1,
		DefaultTextureWhiteI16 = 0xCDA,
		DefaultTextureWhiteI16Map = 0xCDB,
		BlackTransparentTexture = 0xCE4,
		BlackTransparentCompiledTextureMap = 0xCE5,
		UnitSphere = 0xE10,
		UnitSphereCompiledMesh = 0xE11,
		UnitHalfSphere = 0xE12,
		UnitHalfSphereCompiledMesh = 0xE13,
		UnitCylinder = 0xE16,
		UnitCylinderCompiledMesh = 0xE17,
		UnitCircle = 0xE1A,
		UnitCircleCompiledMesh = 0xE1B,
		UnitCone = 0xE1C,
		UnitConeCompiledMesh = 0xE1D,
		SpotlightCube = 0xE1E,
		SpotlightCubeCompiledMesh = 0xE1F,
		UnitOcclusionSphere = 0xE20,
		UnitOcclusionSphereCompiledMesh = 0xE21,
		UnitOcclusionHalfSphere = 0xE22,
		UnitOcclusionHalfSphereCompiledMesh = 0xE23,
		UnitOcclusionCylinder = 0xE24,
		UnitOcclusionCylinderCompiledMesh = 0xE25,
		DeferredLightOmniMesh = 0xE26,
		DeferredLightOmniMeshCompiledMesh = 0xE27,
		DeferredLightProbeMesh = 0xE28,
		DeferredLightProbeMeshCompiledMesh = 0xE29,
		DeferredLightBoxMesh = 0xE2A,
		DeferredLightBoxMeshCompiledMesh = 0xE2B,
		DeferredLightSpotMesh = 0xE2C,
		DeferredLightSpotMeshCompiledMesh = 0xE2D
	}
}