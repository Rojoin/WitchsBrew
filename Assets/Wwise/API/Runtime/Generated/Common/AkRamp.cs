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





public class AkRamp : global::System.IDisposable {

  private global::System.IntPtr swigCPtr;

  protected bool swigCMemOwn;



  internal AkRamp(global::System.IntPtr cPtr, bool cMemoryOwn) {

    swigCMemOwn = cMemoryOwn;

    swigCPtr = cPtr;

  }



  internal static global::System.IntPtr getCPtr(AkRamp obj) {

    return (obj == null) ? global::System.IntPtr.Zero : obj.swigCPtr;

  }



  internal virtual void setCPtr(global::System.IntPtr cPtr) {

    Dispose();

    swigCPtr = cPtr;

  }



  ~AkRamp() {

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

          AkSoundEnginePINVOKE.CSharp_delete_AkRamp(swigCPtr);

        }

        swigCPtr = global::System.IntPtr.Zero;

      }

      global::System.GC.SuppressFinalize(this);

    }

  }



  public AkRamp() : this(AkSoundEnginePINVOKE.CSharp_new_AkRamp__SWIG_0(), true) {

  }



  public AkRamp(float in_fPrev, float in_fNext) : this(AkSoundEnginePINVOKE.CSharp_new_AkRamp__SWIG_1(in_fPrev, in_fNext), true) {

  }



  public float fPrev { set { AkSoundEnginePINVOKE.CSharp_AkRamp_fPrev_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkRamp_fPrev_get(swigCPtr); } 

  }



  public float fNext { set { AkSoundEnginePINVOKE.CSharp_AkRamp_fNext_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkRamp_fNext_get(swigCPtr); } 

  }



}

#endif // #if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_WIIU || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.
