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





public class AkPlaylistItem : global::System.IDisposable {

  private global::System.IntPtr swigCPtr;

  protected bool swigCMemOwn;



  internal AkPlaylistItem(global::System.IntPtr cPtr, bool cMemoryOwn) {

    swigCMemOwn = cMemoryOwn;

    swigCPtr = cPtr;

  }



  internal static global::System.IntPtr getCPtr(AkPlaylistItem obj) {

    return (obj == null) ? global::System.IntPtr.Zero : obj.swigCPtr;

  }



  internal virtual void setCPtr(global::System.IntPtr cPtr) {

    Dispose();

    swigCPtr = cPtr;

  }



  ~AkPlaylistItem() {

    Dispose(false);

  }



  public void Dispose() {

    Dispose(true);

    global::System.GC.SuppressFinalize(this);

  }



  protected virtual void Dispose(bool disposing) {

    lock(this) {

      if (swigCPtr != global::System.IntPtr.Zero) {

        if (swigCMemOwn) {

          swigCMemOwn = false;

          AkSoundEnginePINVOKE.CSharp_delete_AkPlaylistItem(swigCPtr);

        }

        swigCPtr = global::System.IntPtr.Zero;

      }

      global::System.GC.SuppressFinalize(this);

    }

  }



  public AkPlaylistItem() : this(AkSoundEnginePINVOKE.CSharp_new_AkPlaylistItem__SWIG_0(), true) {

  }



  public AkPlaylistItem(AkPlaylistItem in_rCopy) : this(AkSoundEnginePINVOKE.CSharp_new_AkPlaylistItem__SWIG_1(AkPlaylistItem.getCPtr(in_rCopy)), true) {

  }



  public AkPlaylistItem Assign(AkPlaylistItem in_rCopy) {

    AkPlaylistItem ret = new AkPlaylistItem(AkSoundEnginePINVOKE.CSharp_AkPlaylistItem_Assign(swigCPtr, AkPlaylistItem.getCPtr(in_rCopy)), false);

    return ret;

  }



  public bool IsEqualTo(AkPlaylistItem in_rCopy) { return AkSoundEnginePINVOKE.CSharp_AkPlaylistItem_IsEqualTo(swigCPtr, AkPlaylistItem.getCPtr(in_rCopy)); }



  public AKRESULT SetExternalSources(uint in_nExternalSrc, AkExternalSourceInfoArray in_pExternalSrc) { return (AKRESULT)AkSoundEnginePINVOKE.CSharp_AkPlaylistItem_SetExternalSources(swigCPtr, in_nExternalSrc, in_pExternalSrc.GetBuffer()); }



  public uint audioNodeID { set { AkSoundEnginePINVOKE.CSharp_AkPlaylistItem_audioNodeID_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkPlaylistItem_audioNodeID_get(swigCPtr); } 

  }



  public int msDelay { set { AkSoundEnginePINVOKE.CSharp_AkPlaylistItem_msDelay_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkPlaylistItem_msDelay_get(swigCPtr); } 

  }



  public global::System.IntPtr pCustomInfo { set { AkSoundEnginePINVOKE.CSharp_AkPlaylistItem_pCustomInfo_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkPlaylistItem_pCustomInfo_get(swigCPtr); }

  }



}

#endif // #if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_WIIU || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.
