/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.39
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace org.doubango.tinyWRAP {

using System;
using System.Runtime.InteropServices;

public class MediaSessionMgr : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal MediaSessionMgr(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(MediaSessionMgr obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~MediaSessionMgr() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
        swigCMemOwn = false;
        tinyWRAPPINVOKE.delete_MediaSessionMgr(swigCPtr);
      }
      swigCPtr = new HandleRef(null, IntPtr.Zero);
      GC.SuppressFinalize(this);
    }
  }

  public bool sessionSetInt32(twrap_media_type_t media, string key, int value) {
    bool ret = tinyWRAPPINVOKE.MediaSessionMgr_sessionSetInt32(swigCPtr, (int)media, key, value);
    return ret;
  }

  public bool consumerSetInt32(twrap_media_type_t media, string key, int value) {
    bool ret = tinyWRAPPINVOKE.MediaSessionMgr_consumerSetInt32(swigCPtr, (int)media, key, value);
    return ret;
  }

  public bool consumerSetInt64(twrap_media_type_t media, string key, long value) {
    bool ret = tinyWRAPPINVOKE.MediaSessionMgr_consumerSetInt64(swigCPtr, (int)media, key, value);
    return ret;
  }

  public bool producerSetInt32(twrap_media_type_t media, string key, int value) {
    bool ret = tinyWRAPPINVOKE.MediaSessionMgr_producerSetInt32(swigCPtr, (int)media, key, value);
    return ret;
  }

  public bool producerSetInt64(twrap_media_type_t media, string key, long value) {
    bool ret = tinyWRAPPINVOKE.MediaSessionMgr_producerSetInt64(swigCPtr, (int)media, key, value);
    return ret;
  }

  public ProxyPlugin findProxyPluginConsumer(twrap_media_type_t media) {
    IntPtr cPtr = tinyWRAPPINVOKE.MediaSessionMgr_findProxyPluginConsumer(swigCPtr, (int)media);
    ProxyPlugin ret = (cPtr == IntPtr.Zero) ? null : new ProxyPlugin(cPtr, false);
    return ret;
  }

  public ProxyPlugin findProxyPluginProducer(twrap_media_type_t media) {
    IntPtr cPtr = tinyWRAPPINVOKE.MediaSessionMgr_findProxyPluginProducer(swigCPtr, (int)media);
    ProxyPlugin ret = (cPtr == IntPtr.Zero) ? null : new ProxyPlugin(cPtr, false);
    return ret;
  }

  public static bool defaultsSetBandwidthLevel(tmedia_bandwidth_level_t bl) {
    bool ret = tinyWRAPPINVOKE.MediaSessionMgr_defaultsSetBandwidthLevel((int)bl);
    return ret;
  }

  public static tmedia_bandwidth_level_t defaultsGetBandwidthLevel() {
    tmedia_bandwidth_level_t ret = (tmedia_bandwidth_level_t)tinyWRAPPINVOKE.MediaSessionMgr_defaultsGetBandwidthLevel();
    return ret;
  }

  public static bool defaultsSetEchoTail(uint echo_tail) {
    bool ret = tinyWRAPPINVOKE.MediaSessionMgr_defaultsSetEchoTail(echo_tail);
    return ret;
  }

  public static uint defaultsGetEchoTail() {
    uint ret = tinyWRAPPINVOKE.MediaSessionMgr_defaultsGetEchoTail();
    return ret;
  }

  public static bool defaultsSetEchoSuppEnabled(bool echo_supp_enabled) {
    bool ret = tinyWRAPPINVOKE.MediaSessionMgr_defaultsSetEchoSuppEnabled(echo_supp_enabled);
    return ret;
  }

  public static bool defaultsGetEchoSuppEnabled() {
    bool ret = tinyWRAPPINVOKE.MediaSessionMgr_defaultsGetEchoSuppEnabled();
    return ret;
  }

  public static bool defaultsSetAgcEnabled(bool agc_enabled) {
    bool ret = tinyWRAPPINVOKE.MediaSessionMgr_defaultsSetAgcEnabled(agc_enabled);
    return ret;
  }

  public static bool defaultsGetAgcEnabled() {
    bool ret = tinyWRAPPINVOKE.MediaSessionMgr_defaultsGetAgcEnabled();
    return ret;
  }

  public static bool defaultsSetAgcLevel(float agc_level) {
    bool ret = tinyWRAPPINVOKE.MediaSessionMgr_defaultsSetAgcLevel(agc_level);
    return ret;
  }

  public static float defaultsGetAgcLevel() {
    float ret = tinyWRAPPINVOKE.MediaSessionMgr_defaultsGetAgcLevel();
    return ret;
  }

  public static bool defaultsSetVadEnabled(bool vad_enabled) {
    bool ret = tinyWRAPPINVOKE.MediaSessionMgr_defaultsSetVadEnabled(vad_enabled);
    return ret;
  }

  public static bool defaultsGetGetVadEnabled() {
    bool ret = tinyWRAPPINVOKE.MediaSessionMgr_defaultsGetGetVadEnabled();
    return ret;
  }

  public static bool defaultsSetNoiseSuppEnabled(bool noise_supp_enabled) {
    bool ret = tinyWRAPPINVOKE.MediaSessionMgr_defaultsSetNoiseSuppEnabled(noise_supp_enabled);
    return ret;
  }

  public static bool defaultsGetNoiseSuppEnabled() {
    bool ret = tinyWRAPPINVOKE.MediaSessionMgr_defaultsGetNoiseSuppEnabled();
    return ret;
  }

  public static bool defaultsSetNoiseSuppLevel(int noise_supp_level) {
    bool ret = tinyWRAPPINVOKE.MediaSessionMgr_defaultsSetNoiseSuppLevel(noise_supp_level);
    return ret;
  }

  public static int defaultsGetNoiseSuppLevel() {
    int ret = tinyWRAPPINVOKE.MediaSessionMgr_defaultsGetNoiseSuppLevel();
    return ret;
  }

  public static bool defaultsSet100relEnabled(bool _100rel_enabled) {
    bool ret = tinyWRAPPINVOKE.MediaSessionMgr_defaultsSet100relEnabled(_100rel_enabled);
    return ret;
  }

  public static bool defaultsGet100relEnabled() {
    bool ret = tinyWRAPPINVOKE.MediaSessionMgr_defaultsGet100relEnabled();
    return ret;
  }

  public static bool defaultsSetScreenSize(int sx, int sy) {
    bool ret = tinyWRAPPINVOKE.MediaSessionMgr_defaultsSetScreenSize(sx, sy);
    return ret;
  }

}

}
