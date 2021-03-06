﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.Experimental.Director.AnimatorControllerPlayable
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A8FF7A2C-E4EE-4232-AB17-3FCABEC16496
// Assembly location: C:\Users\Blake\sandbox\unity\test-project\Library\UnityAssemblies\UnityEngine.dll

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Director
{
  /// <summary>
  ///   <para>Playable that plays a RuntimeAnimatorController. Can be used as an input to an AnimationPlayable.</para>
  /// </summary>
  [UsedByNativeCode]
  public sealed class AnimatorControllerPlayable : AnimationPlayable, IAnimatorControllerPlayable
  {
    /// <summary>
    ///   <para>RuntimeAnimatorController played by this playable.</para>
    /// </summary>
    public RuntimeAnimatorController animatorController { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>See IAnimatorControllerPlayable.layerCount.</para>
    /// </summary>
    public int layerCount { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>See IAnimatorControllerPlayable.parameterCount.</para>
    /// </summary>
    public int parameterCount { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; }

    private AnimatorControllerParameter[] parameters { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; }

    public AnimatorControllerPlayable(RuntimeAnimatorController controller)
      : base(false)
    {
      this.m_Ptr = IntPtr.Zero;
      this.InstantiateEnginePlayable(controller);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void InstantiateEnginePlayable(RuntimeAnimatorController controller);

    public override int AddInput(AnimationPlayable source)
    {
      Debug.LogError((object) "AnimationClipPlayable doesn't support adding inputs");
      return -1;
    }

    public override bool SetInput(AnimationPlayable source, int index)
    {
      Debug.LogError((object) "AnimationClipPlayable doesn't support setting inputs");
      return false;
    }

    public override bool SetInputs(IEnumerable<AnimationPlayable> sources)
    {
      Debug.LogError((object) "AnimationClipPlayable doesn't support setting inputs");
      return false;
    }

    public override bool RemoveInput(int index)
    {
      Debug.LogError((object) "AnimationClipPlayable doesn't support removing inputs");
      return false;
    }

    public override bool RemoveInput(AnimationPlayable playable)
    {
      Debug.LogError((object) "AnimationClipPlayable doesn't support removing inputs");
      return false;
    }

    public override bool RemoveAllInputs()
    {
      Debug.LogError((object) "AnimationClipPlayable doesn't support removing inputs");
      return false;
    }

    /// <summary>
    ///   <para>See IAnimatorControllerPlayable.GetFloat.</para>
    /// </summary>
    /// <param name="name"></param>
    /// <param name="id"></param>
    public float GetFloat(string name)
    {
      return this.GetFloatString(name);
    }

    /// <summary>
    ///   <para>See IAnimatorControllerPlayable.GetFloat.</para>
    /// </summary>
    /// <param name="name"></param>
    /// <param name="id"></param>
    public float GetFloat(int id)
    {
      return this.GetFloatID(id);
    }

    /// <summary>
    ///   <para>See IAnimatorControllerPlayable.SetFloat.</para>
    /// </summary>
    /// <param name="name"></param>
    /// <param name="value"></param>
    /// <param name="id"></param>
    public void SetFloat(string name, float value)
    {
      this.SetFloatString(name, value);
    }

    /// <summary>
    ///   <para>See IAnimatorControllerPlayable.SetFloat.</para>
    /// </summary>
    /// <param name="name"></param>
    /// <param name="value"></param>
    /// <param name="id"></param>
    public void SetFloat(int id, float value)
    {
      this.SetFloatID(id, value);
    }

    /// <summary>
    ///   <para>See IAnimatorControllerPlayable.GetBool.</para>
    /// </summary>
    /// <param name="name"></param>
    /// <param name="id"></param>
    public bool GetBool(string name)
    {
      return this.GetBoolString(name);
    }

    /// <summary>
    ///   <para>See IAnimatorControllerPlayable.GetBool.</para>
    /// </summary>
    /// <param name="name"></param>
    /// <param name="id"></param>
    public bool GetBool(int id)
    {
      return this.GetBoolID(id);
    }

    /// <summary>
    ///   <para>See IAnimatorControllerPlayable.SetBool.</para>
    /// </summary>
    /// <param name="name"></param>
    /// <param name="value"></param>
    /// <param name="id"></param>
    public void SetBool(string name, bool value)
    {
      this.SetBoolString(name, value);
    }

    /// <summary>
    ///   <para>See IAnimatorControllerPlayable.SetBool.</para>
    /// </summary>
    /// <param name="name"></param>
    /// <param name="value"></param>
    /// <param name="id"></param>
    public void SetBool(int id, bool value)
    {
      this.SetBoolID(id, value);
    }

    /// <summary>
    ///   <para>See IAnimatorControllerPlayable.GetInteger.</para>
    /// </summary>
    /// <param name="name"></param>
    /// <param name="id"></param>
    public int GetInteger(string name)
    {
      return this.GetIntegerString(name);
    }

    /// <summary>
    ///   <para>See IAnimatorControllerPlayable.GetInteger.</para>
    /// </summary>
    /// <param name="name"></param>
    /// <param name="id"></param>
    public int GetInteger(int id)
    {
      return this.GetIntegerID(id);
    }

    /// <summary>
    ///   <para>See IAnimatorControllerPlayable.SetInteger.</para>
    /// </summary>
    /// <param name="name"></param>
    /// <param name="value"></param>
    /// <param name="id"></param>
    public void SetInteger(string name, int value)
    {
      this.SetIntegerString(name, value);
    }

    /// <summary>
    ///   <para>See IAnimatorControllerPlayable.SetInteger.</para>
    /// </summary>
    /// <param name="name"></param>
    /// <param name="value"></param>
    /// <param name="id"></param>
    public void SetInteger(int id, int value)
    {
      this.SetIntegerID(id, value);
    }

    /// <summary>
    ///   <para>See IAnimatorControllerPlayable.SetTrigger.</para>
    /// </summary>
    /// <param name="name"></param>
    /// <param name="id"></param>
    public void SetTrigger(string name)
    {
      this.SetTriggerString(name);
    }

    /// <summary>
    ///   <para>See IAnimatorControllerPlayable.SetTrigger.</para>
    /// </summary>
    /// <param name="name"></param>
    /// <param name="id"></param>
    public void SetTrigger(int id)
    {
      this.SetTriggerID(id);
    }

    /// <summary>
    ///   <para>See IAnimatorControllerPlayable.ResetTrigger.</para>
    /// </summary>
    /// <param name="name"></param>
    /// <param name="id"></param>
    public void ResetTrigger(string name)
    {
      this.ResetTriggerString(name);
    }

    /// <summary>
    ///   <para>See IAnimatorControllerPlayable.ResetTrigger.</para>
    /// </summary>
    /// <param name="name"></param>
    /// <param name="id"></param>
    public void ResetTrigger(int id)
    {
      this.ResetTriggerID(id);
    }

    /// <summary>
    ///   <para>See IAnimatorControllerPlayable.IsParameterControlledByCurve.</para>
    /// </summary>
    /// <param name="name"></param>
    /// <param name="id"></param>
    public bool IsParameterControlledByCurve(string name)
    {
      return this.IsParameterControlledByCurveString(name);
    }

    /// <summary>
    ///   <para>See IAnimatorControllerPlayable.IsParameterControlledByCurve.</para>
    /// </summary>
    /// <param name="name"></param>
    /// <param name="id"></param>
    public bool IsParameterControlledByCurve(int id)
    {
      return this.IsParameterControlledByCurveID(id);
    }

    /// <summary>
    ///   <para>See IAnimatorControllerPlayable.GetLayerName.</para>
    /// </summary>
    /// <param name="layerIndex"></param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public string GetLayerName(int layerIndex);

    /// <summary>
    ///   <para>See IAnimatorControllerPlayable.GetLayerIndex.</para>
    /// </summary>
    /// <param name="layerName"></param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public int GetLayerIndex(string layerName);

    /// <summary>
    ///   <para>See IAnimatorControllerPlayable.GetLayerWeight.</para>
    /// </summary>
    /// <param name="layerIndex"></param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public float GetLayerWeight(int layerIndex);

    /// <summary>
    ///   <para>See IAnimatorControllerPlayable.SetLayerWeight.</para>
    /// </summary>
    /// <param name="layerIndex"></param>
    /// <param name="weight"></param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public void SetLayerWeight(int layerIndex, float weight);

    /// <summary>
    ///   <para>See IAnimatorControllerPlayable.GetCurrentAnimatorStateInfo.</para>
    /// </summary>
    /// <param name="layerIndex"></param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex);

    /// <summary>
    ///   <para>See IAnimatorControllerPlayable.GetNextAnimatorStateInfo.</para>
    /// </summary>
    /// <param name="layerIndex"></param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex);

    /// <summary>
    ///   <para>See IAnimatorControllerPlayable.GetAnimatorTransitionInfo.</para>
    /// </summary>
    /// <param name="layerIndex"></param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex);

    /// <summary>
    ///   <para>See IAnimatorControllerPlayable.GetCurrentAnimatorClipInfo.</para>
    /// </summary>
    /// <param name="layerIndex"></param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex);

    /// <summary>
    ///   <para>See IAnimatorControllerPlayable.GetNextAnimatorClipInfo.</para>
    /// </summary>
    /// <param name="layerIndex"></param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal string ResolveHash(int hash);

    /// <summary>
    ///   <para>See IAnimatorControllerPlayable.IsInTransition.</para>
    /// </summary>
    /// <param name="layerIndex"></param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public bool IsInTransition(int layerIndex);

    /// <summary>
    ///   <para>See AnimatorController.GetParameter.</para>
    /// </summary>
    /// <param name="index"></param>
    public AnimatorControllerParameter GetParameter(int index)
    {
      AnimatorControllerParameter[] parameters = this.parameters;
      if (index < 0 && index >= this.parameters.Length)
        throw new IndexOutOfRangeException("index");
      return parameters[index];
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern int StringToHash(string name);

    [ExcludeFromDocs]
    public void CrossFadeInFixedTime(string stateName, float transitionDuration, int layer)
    {
      float fixedTime = 0.0f;
      this.CrossFadeInFixedTime(stateName, transitionDuration, layer, fixedTime);
    }

    [ExcludeFromDocs]
    public void CrossFadeInFixedTime(string stateName, float transitionDuration)
    {
      float fixedTime = 0.0f;
      int layer = -1;
      this.CrossFadeInFixedTime(stateName, transitionDuration, layer, fixedTime);
    }

    /// <summary>
    ///   <para>See IAnimatorControllerPlayable.CrossFadeInFixedTime.</para>
    /// </summary>
    /// <param name="stateName"></param>
    /// <param name="transitionDuration"></param>
    /// <param name="layer"></param>
    /// <param name="fixedTime"></param>
    /// <param name="stateNameHash"></param>
    public void CrossFadeInFixedTime(string stateName, float transitionDuration, [DefaultValue("-1")] int layer, [DefaultValue("0.0f")] float fixedTime)
    {
      this.CrossFadeInFixedTime(AnimatorControllerPlayable.StringToHash(stateName), transitionDuration, layer, fixedTime);
    }

    /// <summary>
    ///   <para>See IAnimatorControllerPlayable.CrossFadeInFixedTime.</para>
    /// </summary>
    /// <param name="stateName"></param>
    /// <param name="transitionDuration"></param>
    /// <param name="layer"></param>
    /// <param name="fixedTime"></param>
    /// <param name="stateNameHash"></param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public void CrossFadeInFixedTime(int stateNameHash, float transitionDuration, [DefaultValue("-1")] int layer, [DefaultValue("0.0f")] float fixedTime);

    [ExcludeFromDocs]
    public void CrossFadeInFixedTime(int stateNameHash, float transitionDuration, int layer)
    {
      float fixedTime = 0.0f;
      this.CrossFadeInFixedTime(stateNameHash, transitionDuration, layer, fixedTime);
    }

    [ExcludeFromDocs]
    public void CrossFadeInFixedTime(int stateNameHash, float transitionDuration)
    {
      float fixedTime = 0.0f;
      int layer = -1;
      this.CrossFadeInFixedTime(stateNameHash, transitionDuration, layer, fixedTime);
    }

    [ExcludeFromDocs]
    public void CrossFade(string stateName, float transitionDuration, int layer)
    {
      float normalizedTime = float.NegativeInfinity;
      this.CrossFade(stateName, transitionDuration, layer, normalizedTime);
    }

    [ExcludeFromDocs]
    public void CrossFade(string stateName, float transitionDuration)
    {
      float normalizedTime = float.NegativeInfinity;
      int layer = -1;
      this.CrossFade(stateName, transitionDuration, layer, normalizedTime);
    }

    /// <summary>
    ///   <para>See IAnimatorControllerPlayable.CrossFade.</para>
    /// </summary>
    /// <param name="stateName"></param>
    /// <param name="transitionDuration"></param>
    /// <param name="layer"></param>
    /// <param name="normalizedTime"></param>
    /// <param name="stateNameHash"></param>
    public void CrossFade(string stateName, float transitionDuration, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTime)
    {
      this.CrossFade(AnimatorControllerPlayable.StringToHash(stateName), transitionDuration, layer, normalizedTime);
    }

    /// <summary>
    ///   <para>See IAnimatorControllerPlayable.CrossFade.</para>
    /// </summary>
    /// <param name="stateName"></param>
    /// <param name="transitionDuration"></param>
    /// <param name="layer"></param>
    /// <param name="normalizedTime"></param>
    /// <param name="stateNameHash"></param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public void CrossFade(int stateNameHash, float transitionDuration, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTime);

    [ExcludeFromDocs]
    public void CrossFade(int stateNameHash, float transitionDuration, int layer)
    {
      float normalizedTime = float.NegativeInfinity;
      this.CrossFade(stateNameHash, transitionDuration, layer, normalizedTime);
    }

    [ExcludeFromDocs]
    public void CrossFade(int stateNameHash, float transitionDuration)
    {
      float normalizedTime = float.NegativeInfinity;
      int layer = -1;
      this.CrossFade(stateNameHash, transitionDuration, layer, normalizedTime);
    }

    [ExcludeFromDocs]
    public void PlayInFixedTime(string stateName, int layer)
    {
      float fixedTime = float.NegativeInfinity;
      this.PlayInFixedTime(stateName, layer, fixedTime);
    }

    [ExcludeFromDocs]
    public void PlayInFixedTime(string stateName)
    {
      float fixedTime = float.NegativeInfinity;
      int layer = -1;
      this.PlayInFixedTime(stateName, layer, fixedTime);
    }

    /// <summary>
    ///   <para>See IAnimatorControllerPlayable.PlayInFixedTime.</para>
    /// </summary>
    /// <param name="stateName"></param>
    /// <param name="layer"></param>
    /// <param name="fixedTime"></param>
    /// <param name="stateNameHash"></param>
    public void PlayInFixedTime(string stateName, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float fixedTime)
    {
      this.PlayInFixedTime(AnimatorControllerPlayable.StringToHash(stateName), layer, fixedTime);
    }

    /// <summary>
    ///   <para>See IAnimatorControllerPlayable.PlayInFixedTime.</para>
    /// </summary>
    /// <param name="stateName"></param>
    /// <param name="layer"></param>
    /// <param name="fixedTime"></param>
    /// <param name="stateNameHash"></param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public void PlayInFixedTime(int stateNameHash, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float fixedTime);

    [ExcludeFromDocs]
    public void PlayInFixedTime(int stateNameHash, int layer)
    {
      float fixedTime = float.NegativeInfinity;
      this.PlayInFixedTime(stateNameHash, layer, fixedTime);
    }

    [ExcludeFromDocs]
    public void PlayInFixedTime(int stateNameHash)
    {
      float fixedTime = float.NegativeInfinity;
      int layer = -1;
      this.PlayInFixedTime(stateNameHash, layer, fixedTime);
    }

    [ExcludeFromDocs]
    public void Play(string stateName, int layer)
    {
      float normalizedTime = float.NegativeInfinity;
      this.Play(stateName, layer, normalizedTime);
    }

    [ExcludeFromDocs]
    public void Play(string stateName)
    {
      float normalizedTime = float.NegativeInfinity;
      int layer = -1;
      this.Play(stateName, layer, normalizedTime);
    }

    /// <summary>
    ///   <para>See IAnimatorControllerPlayable.Play.</para>
    /// </summary>
    /// <param name="stateName"></param>
    /// <param name="layer"></param>
    /// <param name="normalizedTime"></param>
    /// <param name="stateNameHash"></param>
    public void Play(string stateName, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTime)
    {
      this.Play(AnimatorControllerPlayable.StringToHash(stateName), layer, normalizedTime);
    }

    /// <summary>
    ///   <para>See IAnimatorControllerPlayable.Play.</para>
    /// </summary>
    /// <param name="stateName"></param>
    /// <param name="layer"></param>
    /// <param name="normalizedTime"></param>
    /// <param name="stateNameHash"></param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public void Play(int stateNameHash, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTime);

    [ExcludeFromDocs]
    public void Play(int stateNameHash, int layer)
    {
      float normalizedTime = float.NegativeInfinity;
      this.Play(stateNameHash, layer, normalizedTime);
    }

    [ExcludeFromDocs]
    public void Play(int stateNameHash)
    {
      float normalizedTime = float.NegativeInfinity;
      int layer = -1;
      this.Play(stateNameHash, layer, normalizedTime);
    }

    /// <summary>
    ///   <para>See IAnimatorControllerPlayable.HasState.</para>
    /// </summary>
    /// <param name="layerIndex"></param>
    /// <param name="stateID"></param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public bool HasState(int layerIndex, int stateID);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void SetFloatString(string name, float value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void SetFloatID(int id, float value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private float GetFloatString(string name);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private float GetFloatID(int id);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void SetBoolString(string name, bool value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void SetBoolID(int id, bool value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private bool GetBoolString(string name);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private bool GetBoolID(int id);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void SetIntegerString(string name, int value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void SetIntegerID(int id, int value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private int GetIntegerString(string name);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private int GetIntegerID(int id);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void SetTriggerString(string name);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void SetTriggerID(int id);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void ResetTriggerString(string name);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void ResetTriggerID(int id);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private bool IsParameterControlledByCurveString(string name);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private bool IsParameterControlledByCurveID(int id);
  }
}
