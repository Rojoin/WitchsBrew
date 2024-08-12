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





public class AkDiffractionPathInfo : global::System.IDisposable {

  private global::System.IntPtr swigCPtr;

  protected bool swigCMemOwn;



  internal AkDiffractionPathInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {

    swigCMemOwn = cMemoryOwn;

    swigCPtr = cPtr;

  }



  internal static global::System.IntPtr getCPtr(AkDiffractionPathInfo obj) {

    return (obj == null) ? global::System.IntPtr.Zero : obj.swigCPtr;

  }



  internal virtual void setCPtr(global::System.IntPtr cPtr) {

    Dispose();

    swigCPtr = cPtr;

  }



  ~AkDiffractionPathInfo() {

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

          AkSoundEnginePINVOKE.CSharp_delete_AkDiffractionPathInfo(swigCPtr);

        }

        swigCPtr = global::System.IntPtr.Zero;

      }

      global::System.GC.SuppressFinalize(this);

    }

  }



  public UnityEngine.Vector3 emitterPos { set { AkSoundEnginePINVOKE.CSharp_AkDiffractionPathInfo_emitterPos_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkDiffractionPathInfo_emitterPos_get(swigCPtr); } 

  }



  public AkTransform virtualPos { set { AkSoundEnginePINVOKE.CSharp_AkDiffractionPathInfo_virtualPos_set(swigCPtr, AkTransform.getCPtr(value)); } 

    get {

      global::System.IntPtr cPtr = AkSoundEnginePINVOKE.CSharp_AkDiffractionPathInfo_virtualPos_get(swigCPtr);

      AkTransform ret = (cPtr == global::System.IntPtr.Zero) ? null : new AkTransform(cPtr, false);

      return ret;

    } 

  }



  public uint nodeCount { set { AkSoundEnginePINVOKE.CSharp_AkDiffractionPathInfo_nodeCount_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkDiffractionPathInfo_nodeCount_get(swigCPtr); } 

  }



  public float diffraction { set { AkSoundEnginePINVOKE.CSharp_AkDiffractionPathInfo_diffraction_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkDiffractionPathInfo_diffraction_get(swigCPtr); } 

  }



  public float transmissionLoss { set { AkSoundEnginePINVOKE.CSharp_AkDiffractionPathInfo_transmissionLoss_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkDiffractionPathInfo_transmissionLoss_get(swigCPtr); } 

  }



  public float totLength { set { AkSoundEnginePINVOKE.CSharp_AkDiffractionPathInfo_totLength_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkDiffractionPathInfo_totLength_get(swigCPtr); } 

  }



  public float obstructionValue { set { AkSoundEnginePINVOKE.CSharp_AkDiffractionPathInfo_obstructionValue_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkDiffractionPathInfo_obstructionValue_get(swigCPtr); } 

  }



  public static int GetSizeOf() { return AkSoundEnginePINVOKE.CSharp_AkDiffractionPathInfo_GetSizeOf(); }



  public UnityEngine.Vector3 GetNodes(uint idx) { return AkSoundEnginePINVOKE.CSharp_AkDiffractionPathInfo_GetNodes(swigCPtr, idx); }



  public float GetAngles(uint idx) { return AkSoundEnginePINVOKE.CSharp_AkDiffractionPathInfo_GetAngles(swigCPtr, idx); }



  public ulong GetPortals(uint idx) { return AkSoundEnginePINVOKE.CSharp_AkDiffractionPathInfo_GetPortals(swigCPtr, idx); }



  public ulong GetRooms(uint idx) { return AkSoundEnginePINVOKE.CSharp_AkDiffractionPathInfo_GetRooms(swigCPtr, idx); }



  public void Clone(AkDiffractionPathInfo other) { AkSoundEnginePINVOKE.CSharp_AkDiffractionPathInfo_Clone(swigCPtr, AkDiffractionPathInfo.getCPtr(other)); }



  public AkDiffractionPathInfo() : this(AkSoundEnginePINVOKE.CSharp_new_AkDiffractionPathInfo(), true) {

  }



  public const uint kMaxNodes = 8;

}

#endif // #if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_WIIU || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.
