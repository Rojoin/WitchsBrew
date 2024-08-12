#if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_WIIU || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.

//------------------------------------------------------------------------------

// <auto-generated />

//

// This file was automatically generated by SWIG (http://www.swig.org).

// Version 4.0.2

//

// Do not make changes to this file unless you know what you are doing--modify

// the SWIG interface file instead.

//------------------------------------------------------------------------------





public enum AkMonitorErrorCode {

  ErrorCode_NoError = 0,

  ErrorCode_FileNotFound,

  ErrorCode_CannotOpenFile,

  ErrorCode_CannotStartStreamNoMemory,

  ErrorCode_IODevice,

  ErrorCode_IncompatibleIOSettings,

  ErrorCode_PluginUnsupportedChannelConfiguration,

  ErrorCode_PluginMediaUnavailable,

  ErrorCode_PluginInitialisationFailed,

  ErrorCode_PluginProcessingFailed,

  ErrorCode_PluginExecutionInvalid,

  ErrorCode_PluginAllocationFailed,

  ErrorCode_VorbisSeekTableRecommended,

  ErrorCode_VorbisDecodeError,

  ErrorCode_AACDecodeError,

  ErrorCode_xWMACreateDecoderFailed,

  ErrorCode_ATRAC9DecodeFailed,

  ErrorCode_ATRAC9LoopSectionTooSmall,

  ErrorCode_InvalidAudioFileHeader,

  ErrorCode_AudioFileHeaderTooLarge,

  ErrorCode_FileTooSmall,

  ErrorCode_TransitionNotAccurateChannel,

  ErrorCode_TransitionNotAccuratePluginMismatch,

  ErrorCode_TransitionNotAccurateRejectedByPlugin,

  ErrorCode_TransitionNotAccurateStarvation,

  ErrorCode_TransitionNotAccurateCodecError,

  ErrorCode_NothingToPlay,

  ErrorCode_PlayFailed,

  ErrorCode_StingerCouldNotBeScheduled,

  ErrorCode_TooLongSegmentLookAhead,

  ErrorCode_CannotScheduleMusicSwitch,

  ErrorCode_TooManySimultaneousMusicSegments,

  ErrorCode_PlaylistStoppedForEditing,

  ErrorCode_MusicClipsRescheduledAfterTrackEdit,

  ErrorCode_CannotPlaySource_Create,

  ErrorCode_CannotPlaySource_VirtualOff,

  ErrorCode_CannotPlaySource_TimeSkip,

  ErrorCode_CannotPlaySource_InconsistentState,

  ErrorCode_MediaNotLoaded,

  ErrorCode_VoiceStarving,

  ErrorCode_StreamingSourceStarving,

  ErrorCode_XMADecoderSourceStarving,

  ErrorCode_XMADecodingError,

  ErrorCode_InvalidXMAData,

  ErrorCode_PluginNotRegistered,

  ErrorCode_CodecNotRegistered,

  ErrorCode_PluginVersionMismatch,

  ErrorCode_EventIDNotFound,

  ErrorCode_InvalidGroupID,

  ErrorCode_SelectedChildNotAvailable,

  ErrorCode_SelectedNodeNotAvailable,

  ErrorCode_SelectedMediaNotAvailable,

  ErrorCode_NoValidSwitch,

  ErrorCode_SelectedNodeNotAvailablePlay,

  ErrorCode_FeedbackVoiceStarving,

  ErrorCode_BankLoadFailed,

  ErrorCode_BankUnloadFailed,

  ErrorCode_ErrorWhileLoadingBank,

  ErrorCode_InsufficientSpaceToLoadBank,

  ErrorCode_LowerEngineCommandListFull,

  ErrorCode_SeekNoMarker,

  ErrorCode_CannotSeekContinuous,

  ErrorCode_SeekAfterEof,

  ErrorCode_UnknownGameObject,

  ErrorCode_UnknownEmitter,

  ErrorCode_UnknownListener,

  ErrorCode_GameObjectIsNotListener,

  ErrorCode_GameObjectIsNotEmitter,

  ErrorCode_UnknownGameObjectEvent,

  ErrorCode_GameObjectIsNotEmitterEvent,

  ErrorCode_ExternalSourceNotResolved,

  ErrorCode_FileFormatMismatch,

  ErrorCode_CommandQueueFull,

  ErrorCode_CommandTooLarge,

  ErrorCode_XMACreateDecoderLimitReached,

  ErrorCode_XMAStreamBufferTooSmall,

  ErrorCode_ModulatorScopeError_Inst,

  ErrorCode_ModulatorScopeError_Obj,

  ErrorCode_SeekAfterEndOfPlaylist,

  ErrorCode_OpusRequireSeekTable,

  ErrorCode_OpusDecodeError,

  ErrorCode_OpusCreateDecoderFailed,

  ErrorCode_SourcePluginNotFound,

  ErrorCode_VirtualVoiceLimit,

  ErrorCode_AudioDeviceShareSetNotFound,

  ErrorCode_NotEnoughMemoryToStart,

  ErrorCode_UnkownOpusError,

  ErrorCode_AudioDeviceInitFailure,

  ErrorCode_AudioDeviceRemoveFailure,

  ErrorCode_AudioDeviceNotFound,

  ErrorCode_AudioDeviceNotValid,

  ErrorCode_SpatialAudio_ListenerAutomationNotSupported,

  ErrorCode_MediaDuplicationLength,

  ErrorCode_HwVoicesSystemInitFailed,

  ErrorCode_HwVoicesDecodeBatchFailed,

  ErrorCode_HwVoiceLimitReached,

  ErrorCode_HwVoiceInitFailed,

  ErrorCode_OpusHWCommandFailed,

  ErrorCode_AddOutputListenerIdWithZeroListeners,

  ErrorCode_3DObjectLimitExceeded,

  ErrorCode_OpusHWDecodeUnavailable,

  ErrorCode_OpusHWFatalError,

  ErrorCode_OpusHWTimeout,

  ErrorCode_SystemAudioObjectsUnavailable,

  ErrorCode_AddOutputNoDistinctListener,

  ErrorCode_PluginCannotRunOnObjectConfig,

  ErrorCode_SpatialAudio_ReflectionBusError,

  ErrorCode_VorbisHWDecodeUnavailable,

  Num_ErrorCodes

}

#endif // #if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_WIIU || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.
