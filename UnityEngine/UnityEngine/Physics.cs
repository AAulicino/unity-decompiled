﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.Physics
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A8FF7A2C-E4EE-4232-AB17-3FCABEC16496
// Assembly location: C:\Users\Blake\sandbox\unity\test-project\Library\UnityAssemblies\UnityEngine.dll

using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;

namespace UnityEngine
{
  /// <summary>
  ///   <para>Global physics properties and helper methods.</para>
  /// </summary>
  public class Physics
  {
    /// <summary>
    ///   <para>Layer mask constant to select ignore raycast layer.</para>
    /// </summary>
    public const int IgnoreRaycastLayer = 4;
    [Obsolete("Please use Physics.IgnoreRaycastLayer instead. (UnityUpgradable) -> IgnoreRaycastLayer", true)]
    public const int kIgnoreRaycastLayer = 4;
    /// <summary>
    ///   <para>Layer mask constant to select default raycast layers.</para>
    /// </summary>
    public const int DefaultRaycastLayers = -5;
    [Obsolete("Please use Physics.DefaultRaycastLayers instead. (UnityUpgradable) -> DefaultRaycastLayers", true)]
    public const int kDefaultRaycastLayers = -5;
    /// <summary>
    ///   <para>Layer mask constant to select all layers.</para>
    /// </summary>
    public const int AllLayers = -1;
    [Obsolete("Please use Physics.AllLayers instead. (UnityUpgradable) -> AllLayers", true)]
    public const int kAllLayers = -1;

    /// <summary>
    ///   <para>The gravity applied to all rigid bodies in the scene.</para>
    /// </summary>
    public static Vector3 gravity
    {
      get
      {
        Vector3 vector3;
        Physics.INTERNAL_get_gravity(out vector3);
        return vector3;
      }
      set
      {
        Physics.INTERNAL_set_gravity(ref value);
      }
    }

    /// <summary>
    ///   <para>The minimum contact penetration value in order to apply a penalty force (default 0.05). Must be positive.</para>
    /// </summary>
    [Obsolete("use Physics.defaultContactOffset or Collider.contactOffset instead.", true)]
    public static extern float minPenetrationForPenalty { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>The default contact offset of the newly created colliders.</para>
    /// </summary>
    public static extern float defaultContactOffset { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Two colliding objects with a relative velocity below this will not bounce (default 2). Must be positive.</para>
    /// </summary>
    public static extern float bounceThreshold { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    [Obsolete("Please use bounceThreshold instead.")]
    public static float bounceTreshold
    {
      get
      {
        return Physics.bounceThreshold;
      }
      set
      {
        Physics.bounceThreshold = value;
      }
    }

    /// <summary>
    ///   <para>The default linear velocity, below which objects start going to sleep (default 0.15). Must be positive.</para>
    /// </summary>
    [Obsolete("The sleepVelocity is no longer supported. Use sleepThreshold. Note that sleepThreshold is energy but not velocity.")]
    public static extern float sleepVelocity { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>The default angular velocity, below which objects start sleeping (default 0.14). Must be positive.</para>
    /// </summary>
    [Obsolete("The sleepAngularVelocity is no longer supported. Use sleepThreshold. Note that sleepThreshold is energy but not velocity.")]
    public static extern float sleepAngularVelocity { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>The default maximum angular velocity permitted for any rigid bodies (default 7). Must be positive.</para>
    /// </summary>
    [Obsolete("use Rigidbody.maxAngularVelocity instead.", true)]
    public static extern float maxAngularVelocity { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>The default solver iteration count permitted for any rigid bodies (default 7). Must be positive.</para>
    /// </summary>
    public static extern int solverIterationCount { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>The mass-normalized energy threshold, below which objects start going to sleep.</para>
    /// </summary>
    public static extern float sleepThreshold { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Specifies whether queries (raycasts, spherecasts, overlap tests, etc.) hit Triggers by default.</para>
    /// </summary>
    public static extern bool queriesHitTriggers { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    [Obsolete("penetrationPenaltyForce has no effect.")]
    public static extern float penetrationPenaltyForce { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_get_gravity(out Vector3 value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_set_gravity(ref Vector3 value);

    /// <summary>
    ///   <para>Casts a ray against all colliders in the scene.</para>
    /// </summary>
    /// <param name="origin">The starting point of the ray in world coordinates.</param>
    /// <param name="direction">The direction of the ray.</param>
    /// <param name="maxDistance">The max distance the rayhit is allowed to be from the start of the ray.</param>
    /// <param name="layerMask">A that is used to selectively ignore colliders when casting a ray.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    /// <returns>
    ///   <para>True when the ray intersects any collider, otherwise false.</para>
    /// </returns>
    [ExcludeFromDocs]
    public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      return Physics.Raycast(origin, direction, maxDistance, layerMask, queryTriggerInteraction);
    }

    /// <summary>
    ///   <para>Casts a ray against all colliders in the scene.</para>
    /// </summary>
    /// <param name="origin">The starting point of the ray in world coordinates.</param>
    /// <param name="direction">The direction of the ray.</param>
    /// <param name="maxDistance">The max distance the rayhit is allowed to be from the start of the ray.</param>
    /// <param name="layerMask">A that is used to selectively ignore colliders when casting a ray.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    /// <returns>
    ///   <para>True when the ray intersects any collider, otherwise false.</para>
    /// </returns>
    [ExcludeFromDocs]
    public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layerMask = -5;
      return Physics.Raycast(origin, direction, maxDistance, layerMask, queryTriggerInteraction);
    }

    /// <summary>
    ///   <para>Casts a ray against all colliders in the scene.</para>
    /// </summary>
    /// <param name="origin">The starting point of the ray in world coordinates.</param>
    /// <param name="direction">The direction of the ray.</param>
    /// <param name="maxDistance">The max distance the rayhit is allowed to be from the start of the ray.</param>
    /// <param name="layerMask">A that is used to selectively ignore colliders when casting a ray.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    /// <returns>
    ///   <para>True when the ray intersects any collider, otherwise false.</para>
    /// </returns>
    [ExcludeFromDocs]
    public static bool Raycast(Vector3 origin, Vector3 direction)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layerMask = -5;
      float maxDistance = float.PositiveInfinity;
      return Physics.Raycast(origin, direction, maxDistance, layerMask, queryTriggerInteraction);
    }

    /// <summary>
    ///   <para>Casts a ray against all colliders in the scene.</para>
    /// </summary>
    /// <param name="origin">The starting point of the ray in world coordinates.</param>
    /// <param name="direction">The direction of the ray.</param>
    /// <param name="maxDistance">The max distance the rayhit is allowed to be from the start of the ray.</param>
    /// <param name="layerMask">A that is used to selectively ignore colliders when casting a ray.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    /// <returns>
    ///   <para>True when the ray intersects any collider, otherwise false.</para>
    /// </returns>
    public static bool Raycast(Vector3 origin, Vector3 direction, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
    {
      return Physics.Internal_RaycastTest(origin, direction, maxDistance, layerMask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      return Physics.Raycast(origin, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layerMask = -5;
      return Physics.Raycast(origin, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layerMask = -5;
      float maxDistance = float.PositiveInfinity;
      return Physics.Raycast(origin, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
    }

    public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
    {
      return Physics.Internal_Raycast(origin, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
    }

    /// <summary>
    ///   <para>Same as above using ray.origin and ray.direction instead of origin and direction.</para>
    /// </summary>
    /// <param name="ray">The starting point and direction of the ray.</param>
    /// <param name="maxDistance">The max distance the rayhit is allowed to be from the start of the ray.</param>
    /// <param name="layerMask">A that is used to selectively ignore colliders when casting a ray.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    /// <returns>
    ///   <para>True when the ray intersects any collider, otherwise false.</para>
    /// </returns>
    [ExcludeFromDocs]
    public static bool Raycast(Ray ray, float maxDistance, int layerMask)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      return Physics.Raycast(ray, maxDistance, layerMask, queryTriggerInteraction);
    }

    /// <summary>
    ///   <para>Same as above using ray.origin and ray.direction instead of origin and direction.</para>
    /// </summary>
    /// <param name="ray">The starting point and direction of the ray.</param>
    /// <param name="maxDistance">The max distance the rayhit is allowed to be from the start of the ray.</param>
    /// <param name="layerMask">A that is used to selectively ignore colliders when casting a ray.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    /// <returns>
    ///   <para>True when the ray intersects any collider, otherwise false.</para>
    /// </returns>
    [ExcludeFromDocs]
    public static bool Raycast(Ray ray, float maxDistance)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layerMask = -5;
      return Physics.Raycast(ray, maxDistance, layerMask, queryTriggerInteraction);
    }

    /// <summary>
    ///   <para>Same as above using ray.origin and ray.direction instead of origin and direction.</para>
    /// </summary>
    /// <param name="ray">The starting point and direction of the ray.</param>
    /// <param name="maxDistance">The max distance the rayhit is allowed to be from the start of the ray.</param>
    /// <param name="layerMask">A that is used to selectively ignore colliders when casting a ray.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    /// <returns>
    ///   <para>True when the ray intersects any collider, otherwise false.</para>
    /// </returns>
    [ExcludeFromDocs]
    public static bool Raycast(Ray ray)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layerMask = -5;
      float maxDistance = float.PositiveInfinity;
      return Physics.Raycast(ray, maxDistance, layerMask, queryTriggerInteraction);
    }

    /// <summary>
    ///   <para>Same as above using ray.origin and ray.direction instead of origin and direction.</para>
    /// </summary>
    /// <param name="ray">The starting point and direction of the ray.</param>
    /// <param name="maxDistance">The max distance the rayhit is allowed to be from the start of the ray.</param>
    /// <param name="layerMask">A that is used to selectively ignore colliders when casting a ray.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    /// <returns>
    ///   <para>True when the ray intersects any collider, otherwise false.</para>
    /// </returns>
    public static bool Raycast(Ray ray, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
    {
      return Physics.Raycast(ray.origin, ray.direction, maxDistance, layerMask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      return Physics.Raycast(ray, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layerMask = -5;
      return Physics.Raycast(ray, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static bool Raycast(Ray ray, out RaycastHit hitInfo)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layerMask = -5;
      float maxDistance = float.PositiveInfinity;
      return Physics.Raycast(ray, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
    }

    public static bool Raycast(Ray ray, out RaycastHit hitInfo, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
    {
      return Physics.Raycast(ray.origin, ray.direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
    }

    /// <summary>
    ///   <para>Casts a ray through the scene and returns all hits. Note that order is not guaranteed.</para>
    /// </summary>
    /// <param name="ray">The starting point and direction of the ray.</param>
    /// <param name="maxDistance">The max distance the rayhit is allowed to be from the start of the ray.</param>
    /// <param name="layerMask">A that is used to selectively ignore colliders when casting a ray.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    [ExcludeFromDocs]
    public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      return Physics.RaycastAll(ray, maxDistance, layerMask, queryTriggerInteraction);
    }

    /// <summary>
    ///   <para>Casts a ray through the scene and returns all hits. Note that order is not guaranteed.</para>
    /// </summary>
    /// <param name="ray">The starting point and direction of the ray.</param>
    /// <param name="maxDistance">The max distance the rayhit is allowed to be from the start of the ray.</param>
    /// <param name="layerMask">A that is used to selectively ignore colliders when casting a ray.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    [ExcludeFromDocs]
    public static RaycastHit[] RaycastAll(Ray ray, float maxDistance)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layerMask = -5;
      return Physics.RaycastAll(ray, maxDistance, layerMask, queryTriggerInteraction);
    }

    /// <summary>
    ///   <para>Casts a ray through the scene and returns all hits. Note that order is not guaranteed.</para>
    /// </summary>
    /// <param name="ray">The starting point and direction of the ray.</param>
    /// <param name="maxDistance">The max distance the rayhit is allowed to be from the start of the ray.</param>
    /// <param name="layerMask">A that is used to selectively ignore colliders when casting a ray.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    [ExcludeFromDocs]
    public static RaycastHit[] RaycastAll(Ray ray)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layerMask = -5;
      float maxDistance = float.PositiveInfinity;
      return Physics.RaycastAll(ray, maxDistance, layerMask, queryTriggerInteraction);
    }

    /// <summary>
    ///   <para>Casts a ray through the scene and returns all hits. Note that order is not guaranteed.</para>
    /// </summary>
    /// <param name="ray">The starting point and direction of the ray.</param>
    /// <param name="maxDistance">The max distance the rayhit is allowed to be from the start of the ray.</param>
    /// <param name="layerMask">A that is used to selectively ignore colliders when casting a ray.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    public static RaycastHit[] RaycastAll(Ray ray, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
    {
      return Physics.RaycastAll(ray.origin, ray.direction, maxDistance, layerMask, queryTriggerInteraction);
    }

    /// <summary>
    ///   <para>See Also: Raycast.</para>
    /// </summary>
    /// <param name="origin">The starting point of the ray in world coordinates.</param>
    /// <param name="direction">The direction of the ray.</param>
    /// <param name="maxDistance">The max distance the rayhit is allowed to be from the start of the ray.</param>
    /// <param name="layermask">A that is used to selectively ignore colliders when casting a ray.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layermask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
    {
      return Physics.INTERNAL_CALL_RaycastAll(ref origin, ref direction, maxDistance, layermask, queryTriggerInteraction);
    }

    /// <summary>
    ///   <para>See Also: Raycast.</para>
    /// </summary>
    /// <param name="origin">The starting point of the ray in world coordinates.</param>
    /// <param name="direction">The direction of the ray.</param>
    /// <param name="maxDistance">The max distance the rayhit is allowed to be from the start of the ray.</param>
    /// <param name="layermask">A that is used to selectively ignore colliders when casting a ray.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    [ExcludeFromDocs]
    public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layermask)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      return Physics.INTERNAL_CALL_RaycastAll(ref origin, ref direction, maxDistance, layermask, queryTriggerInteraction);
    }

    /// <summary>
    ///   <para>See Also: Raycast.</para>
    /// </summary>
    /// <param name="origin">The starting point of the ray in world coordinates.</param>
    /// <param name="direction">The direction of the ray.</param>
    /// <param name="maxDistance">The max distance the rayhit is allowed to be from the start of the ray.</param>
    /// <param name="layermask">A that is used to selectively ignore colliders when casting a ray.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    [ExcludeFromDocs]
    public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layermask = -5;
      return Physics.INTERNAL_CALL_RaycastAll(ref origin, ref direction, maxDistance, layermask, queryTriggerInteraction);
    }

    /// <summary>
    ///   <para>See Also: Raycast.</para>
    /// </summary>
    /// <param name="origin">The starting point of the ray in world coordinates.</param>
    /// <param name="direction">The direction of the ray.</param>
    /// <param name="maxDistance">The max distance the rayhit is allowed to be from the start of the ray.</param>
    /// <param name="layermask">A that is used to selectively ignore colliders when casting a ray.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    [ExcludeFromDocs]
    public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layermask = -5;
      float maxDistance = float.PositiveInfinity;
      return Physics.INTERNAL_CALL_RaycastAll(ref origin, ref direction, maxDistance, layermask, queryTriggerInteraction);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern RaycastHit[] INTERNAL_CALL_RaycastAll(ref Vector3 origin, ref Vector3 direction, float maxDistance, int layermask, QueryTriggerInteraction queryTriggerInteraction);

    [ExcludeFromDocs]
    public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      return Physics.RaycastNonAlloc(ray, results, maxDistance, layerMask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layerMask = -5;
      return Physics.RaycastNonAlloc(ray, results, maxDistance, layerMask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static int RaycastNonAlloc(Ray ray, RaycastHit[] results)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layerMask = -5;
      float maxDistance = float.PositiveInfinity;
      return Physics.RaycastNonAlloc(ray, results, maxDistance, layerMask, queryTriggerInteraction);
    }

    /// <summary>
    ///   <para>Cast a ray through the scene and store the hits into the buffer.</para>
    /// </summary>
    /// <param name="ray">The starting point and direction of the ray.</param>
    /// <param name="results">The buffer to store the hits into.</param>
    /// <param name="maxDistance">The max distance the rayhit is allowed to be from the start of the ray.</param>
    /// <param name="layerMask">A that is used to selectively ignore colliders when casting a ray.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    /// <returns>
    ///   <para>The amount of hits stored into the results buffer.</para>
    /// </returns>
    public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
    {
      return Physics.RaycastNonAlloc(ray.origin, ray.direction, results, maxDistance, layerMask, queryTriggerInteraction);
    }

    /// <summary>
    ///   <para>Cast a ray through the scene and store the hits into the buffer.</para>
    /// </summary>
    /// <param name="origin">The starting point and direction of the ray.</param>
    /// <param name="results">The buffer to store the hits into.</param>
    /// <param name="direction">The direction of the ray.</param>
    /// <param name="maxDistance">The max distance the rayhit is allowed to be from the start of the ray.</param>
    /// <param name="layermask">A that is used to selectively ignore colliders when casting a ray.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    /// <returns>
    ///   <para>The amount of hits stored into the results buffer.</para>
    /// </returns>
    public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layermask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
    {
      return Physics.INTERNAL_CALL_RaycastNonAlloc(ref origin, ref direction, results, maxDistance, layermask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layermask)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      return Physics.INTERNAL_CALL_RaycastNonAlloc(ref origin, ref direction, results, maxDistance, layermask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layermask = -5;
      return Physics.INTERNAL_CALL_RaycastNonAlloc(ref origin, ref direction, results, maxDistance, layermask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layermask = -5;
      float maxDistance = float.PositiveInfinity;
      return Physics.INTERNAL_CALL_RaycastNonAlloc(ref origin, ref direction, results, maxDistance, layermask, queryTriggerInteraction);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern int INTERNAL_CALL_RaycastNonAlloc(ref Vector3 origin, ref Vector3 direction, RaycastHit[] results, float maxDistance, int layermask, QueryTriggerInteraction queryTriggerInteraction);

    /// <summary>
    ///   <para>Returns true if there is any collider intersecting the line between start and end.</para>
    /// </summary>
    /// <param name="start">Start point.</param>
    /// <param name="end">End point.</param>
    /// <param name="layerMask">A that is used to selectively ignore colliders when casting a ray.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    [ExcludeFromDocs]
    public static bool Linecast(Vector3 start, Vector3 end, int layerMask)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      return Physics.Linecast(start, end, layerMask, queryTriggerInteraction);
    }

    /// <summary>
    ///   <para>Returns true if there is any collider intersecting the line between start and end.</para>
    /// </summary>
    /// <param name="start">Start point.</param>
    /// <param name="end">End point.</param>
    /// <param name="layerMask">A that is used to selectively ignore colliders when casting a ray.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    [ExcludeFromDocs]
    public static bool Linecast(Vector3 start, Vector3 end)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layerMask = -5;
      return Physics.Linecast(start, end, layerMask, queryTriggerInteraction);
    }

    /// <summary>
    ///   <para>Returns true if there is any collider intersecting the line between start and end.</para>
    /// </summary>
    /// <param name="start">Start point.</param>
    /// <param name="end">End point.</param>
    /// <param name="layerMask">A that is used to selectively ignore colliders when casting a ray.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    public static bool Linecast(Vector3 start, Vector3 end, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
    {
      Vector3 direction = end - start;
      return Physics.Raycast(start, direction, direction.magnitude, layerMask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, int layerMask)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      return Physics.Linecast(start, end, out hitInfo, layerMask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layerMask = -5;
      return Physics.Linecast(start, end, out hitInfo, layerMask, queryTriggerInteraction);
    }

    public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
    {
      Vector3 direction = end - start;
      return Physics.Raycast(start, direction, out hitInfo, direction.magnitude, layerMask, queryTriggerInteraction);
    }

    /// <summary>
    ///   <para>Returns an array with all colliders touching or inside the sphere.</para>
    /// </summary>
    /// <param name="position">Center of the sphere.</param>
    /// <param name="radius">Radius of the sphere.</param>
    /// <param name="layerMask">A that is used to selectively ignore colliders when casting a ray.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    public static Collider[] OverlapSphere(Vector3 position, float radius, [DefaultValue("AllLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
    {
      return Physics.INTERNAL_CALL_OverlapSphere(ref position, radius, layerMask, queryTriggerInteraction);
    }

    /// <summary>
    ///   <para>Returns an array with all colliders touching or inside the sphere.</para>
    /// </summary>
    /// <param name="position">Center of the sphere.</param>
    /// <param name="radius">Radius of the sphere.</param>
    /// <param name="layerMask">A that is used to selectively ignore colliders when casting a ray.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    [ExcludeFromDocs]
    public static Collider[] OverlapSphere(Vector3 position, float radius, int layerMask)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      return Physics.INTERNAL_CALL_OverlapSphere(ref position, radius, layerMask, queryTriggerInteraction);
    }

    /// <summary>
    ///   <para>Returns an array with all colliders touching or inside the sphere.</para>
    /// </summary>
    /// <param name="position">Center of the sphere.</param>
    /// <param name="radius">Radius of the sphere.</param>
    /// <param name="layerMask">A that is used to selectively ignore colliders when casting a ray.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    [ExcludeFromDocs]
    public static Collider[] OverlapSphere(Vector3 position, float radius)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layerMask = -1;
      return Physics.INTERNAL_CALL_OverlapSphere(ref position, radius, layerMask, queryTriggerInteraction);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern Collider[] INTERNAL_CALL_OverlapSphere(ref Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

    /// <summary>
    ///   <para>Computes and stores colliders touching or inside the sphere into the provided buffer.</para>
    /// </summary>
    /// <param name="position">Center of the sphere.</param>
    /// <param name="radius">Radius of the sphere.</param>
    /// <param name="results">The buffer to store the results into.</param>
    /// <param name="layerMask">A that is used to selectively ignore colliders when casting a ray.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    /// <returns>
    ///   <para>The amount of colliders stored into the results buffer.</para>
    /// </returns>
    public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, [DefaultValue("AllLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
    {
      return Physics.INTERNAL_CALL_OverlapSphereNonAlloc(ref position, radius, results, layerMask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, int layerMask)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      return Physics.INTERNAL_CALL_OverlapSphereNonAlloc(ref position, radius, results, layerMask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layerMask = -1;
      return Physics.INTERNAL_CALL_OverlapSphereNonAlloc(ref position, radius, results, layerMask, queryTriggerInteraction);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern int INTERNAL_CALL_OverlapSphereNonAlloc(ref Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

    /// <summary>
    ///   <para>Casts a capsule against all colliders in the scene and returns detailed information on what was hit.</para>
    /// </summary>
    /// <param name="point1">The center of the sphere at the start of the capsule.</param>
    /// <param name="point2">The center of the sphere at the end of the capsule.</param>
    /// <param name="radius">The radius of the capsule.</param>
    /// <param name="direction">The direction into which to sweep the capsule.</param>
    /// <param name="maxDistance">The max length of the sweep.</param>
    /// <param name="layerMask">A that is used to selectively ignore colliders when casting a capsule.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    /// <returns>
    ///   <para>True when the capsule sweep intersects any collider, otherwise false.</para>
    /// </returns>
    [ExcludeFromDocs]
    public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, int layerMask)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      return Physics.CapsuleCast(point1, point2, radius, direction, maxDistance, layerMask, queryTriggerInteraction);
    }

    /// <summary>
    ///   <para>Casts a capsule against all colliders in the scene and returns detailed information on what was hit.</para>
    /// </summary>
    /// <param name="point1">The center of the sphere at the start of the capsule.</param>
    /// <param name="point2">The center of the sphere at the end of the capsule.</param>
    /// <param name="radius">The radius of the capsule.</param>
    /// <param name="direction">The direction into which to sweep the capsule.</param>
    /// <param name="maxDistance">The max length of the sweep.</param>
    /// <param name="layerMask">A that is used to selectively ignore colliders when casting a capsule.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    /// <returns>
    ///   <para>True when the capsule sweep intersects any collider, otherwise false.</para>
    /// </returns>
    [ExcludeFromDocs]
    public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layerMask = -5;
      return Physics.CapsuleCast(point1, point2, radius, direction, maxDistance, layerMask, queryTriggerInteraction);
    }

    /// <summary>
    ///   <para>Casts a capsule against all colliders in the scene and returns detailed information on what was hit.</para>
    /// </summary>
    /// <param name="point1">The center of the sphere at the start of the capsule.</param>
    /// <param name="point2">The center of the sphere at the end of the capsule.</param>
    /// <param name="radius">The radius of the capsule.</param>
    /// <param name="direction">The direction into which to sweep the capsule.</param>
    /// <param name="maxDistance">The max length of the sweep.</param>
    /// <param name="layerMask">A that is used to selectively ignore colliders when casting a capsule.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    /// <returns>
    ///   <para>True when the capsule sweep intersects any collider, otherwise false.</para>
    /// </returns>
    [ExcludeFromDocs]
    public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layerMask = -5;
      float maxDistance = float.PositiveInfinity;
      return Physics.CapsuleCast(point1, point2, radius, direction, maxDistance, layerMask, queryTriggerInteraction);
    }

    /// <summary>
    ///   <para>Casts a capsule against all colliders in the scene and returns detailed information on what was hit.</para>
    /// </summary>
    /// <param name="point1">The center of the sphere at the start of the capsule.</param>
    /// <param name="point2">The center of the sphere at the end of the capsule.</param>
    /// <param name="radius">The radius of the capsule.</param>
    /// <param name="direction">The direction into which to sweep the capsule.</param>
    /// <param name="maxDistance">The max length of the sweep.</param>
    /// <param name="layerMask">A that is used to selectively ignore colliders when casting a capsule.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    /// <returns>
    ///   <para>True when the capsule sweep intersects any collider, otherwise false.</para>
    /// </returns>
    public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
    {
      RaycastHit hitInfo;
      return Physics.Internal_CapsuleCast(point1, point2, radius, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      return Physics.CapsuleCast(point1, point2, radius, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layerMask = -5;
      return Physics.CapsuleCast(point1, point2, radius, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layerMask = -5;
      float maxDistance = float.PositiveInfinity;
      return Physics.CapsuleCast(point1, point2, radius, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
    }

    public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
    {
      return Physics.Internal_CapsuleCast(point1, point2, radius, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      return Physics.SphereCast(origin, radius, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layerMask = -5;
      return Physics.SphereCast(origin, radius, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layerMask = -5;
      float maxDistance = float.PositiveInfinity;
      return Physics.SphereCast(origin, radius, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
    }

    public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
    {
      return Physics.Internal_CapsuleCast(origin, origin, radius, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
    }

    /// <summary>
    ///   <para>Casts a sphere along a ray and returns detailed information on what was hit.</para>
    /// </summary>
    /// <param name="ray">The starting point and direction of the ray into which the sphere sweep is cast.</param>
    /// <param name="radius">The radius of the sphere.</param>
    /// <param name="maxDistance">The max length of the cast.</param>
    /// <param name="layerMask">A that is used to selectively ignore colliders when casting a capsule.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    /// <returns>
    ///   <para>True when the sphere sweep intersects any collider, otherwise false.</para>
    /// </returns>
    [ExcludeFromDocs]
    public static bool SphereCast(Ray ray, float radius, float maxDistance, int layerMask)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      return Physics.SphereCast(ray, radius, maxDistance, layerMask, queryTriggerInteraction);
    }

    /// <summary>
    ///   <para>Casts a sphere along a ray and returns detailed information on what was hit.</para>
    /// </summary>
    /// <param name="ray">The starting point and direction of the ray into which the sphere sweep is cast.</param>
    /// <param name="radius">The radius of the sphere.</param>
    /// <param name="maxDistance">The max length of the cast.</param>
    /// <param name="layerMask">A that is used to selectively ignore colliders when casting a capsule.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    /// <returns>
    ///   <para>True when the sphere sweep intersects any collider, otherwise false.</para>
    /// </returns>
    [ExcludeFromDocs]
    public static bool SphereCast(Ray ray, float radius, float maxDistance)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layerMask = -5;
      return Physics.SphereCast(ray, radius, maxDistance, layerMask, queryTriggerInteraction);
    }

    /// <summary>
    ///   <para>Casts a sphere along a ray and returns detailed information on what was hit.</para>
    /// </summary>
    /// <param name="ray">The starting point and direction of the ray into which the sphere sweep is cast.</param>
    /// <param name="radius">The radius of the sphere.</param>
    /// <param name="maxDistance">The max length of the cast.</param>
    /// <param name="layerMask">A that is used to selectively ignore colliders when casting a capsule.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    /// <returns>
    ///   <para>True when the sphere sweep intersects any collider, otherwise false.</para>
    /// </returns>
    [ExcludeFromDocs]
    public static bool SphereCast(Ray ray, float radius)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layerMask = -5;
      float maxDistance = float.PositiveInfinity;
      return Physics.SphereCast(ray, radius, maxDistance, layerMask, queryTriggerInteraction);
    }

    /// <summary>
    ///   <para>Casts a sphere along a ray and returns detailed information on what was hit.</para>
    /// </summary>
    /// <param name="ray">The starting point and direction of the ray into which the sphere sweep is cast.</param>
    /// <param name="radius">The radius of the sphere.</param>
    /// <param name="maxDistance">The max length of the cast.</param>
    /// <param name="layerMask">A that is used to selectively ignore colliders when casting a capsule.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    /// <returns>
    ///   <para>True when the sphere sweep intersects any collider, otherwise false.</para>
    /// </returns>
    public static bool SphereCast(Ray ray, float radius, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
    {
      RaycastHit hitInfo;
      return Physics.Internal_CapsuleCast(ray.origin, ray.origin, radius, ray.direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance, int layerMask)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      return Physics.SphereCast(ray, radius, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layerMask = -5;
      return Physics.SphereCast(ray, radius, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layerMask = -5;
      float maxDistance = float.PositiveInfinity;
      return Physics.SphereCast(ray, radius, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
    }

    public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
    {
      return Physics.Internal_CapsuleCast(ray.origin, ray.origin, radius, ray.direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
    }

    /// <summary>
    ///   <para>Like Physics.CapsuleCast, but this function will return all hits the capsule sweep intersects.</para>
    /// </summary>
    /// <param name="point1">The center of the sphere at the start of the capsule.</param>
    /// <param name="point2">The center of the sphere at the end of the capsule.</param>
    /// <param name="radius">The radius of the capsule.</param>
    /// <param name="direction">The direction into which to sweep the capsule.</param>
    /// <param name="maxDistance">The max length of the sweep.</param>
    /// <param name="layermask">A that is used to selectively ignore colliders when casting a capsule.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    /// <returns>
    ///   <para>An array of all colliders hit in the sweep.</para>
    /// </returns>
    public static RaycastHit[] CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layermask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
    {
      return Physics.INTERNAL_CALL_CapsuleCastAll(ref point1, ref point2, radius, ref direction, maxDistance, layermask, queryTriggerInteraction);
    }

    /// <summary>
    ///   <para>Like Physics.CapsuleCast, but this function will return all hits the capsule sweep intersects.</para>
    /// </summary>
    /// <param name="point1">The center of the sphere at the start of the capsule.</param>
    /// <param name="point2">The center of the sphere at the end of the capsule.</param>
    /// <param name="radius">The radius of the capsule.</param>
    /// <param name="direction">The direction into which to sweep the capsule.</param>
    /// <param name="maxDistance">The max length of the sweep.</param>
    /// <param name="layermask">A that is used to selectively ignore colliders when casting a capsule.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    /// <returns>
    ///   <para>An array of all colliders hit in the sweep.</para>
    /// </returns>
    [ExcludeFromDocs]
    public static RaycastHit[] CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, int layermask)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      return Physics.INTERNAL_CALL_CapsuleCastAll(ref point1, ref point2, radius, ref direction, maxDistance, layermask, queryTriggerInteraction);
    }

    /// <summary>
    ///   <para>Like Physics.CapsuleCast, but this function will return all hits the capsule sweep intersects.</para>
    /// </summary>
    /// <param name="point1">The center of the sphere at the start of the capsule.</param>
    /// <param name="point2">The center of the sphere at the end of the capsule.</param>
    /// <param name="radius">The radius of the capsule.</param>
    /// <param name="direction">The direction into which to sweep the capsule.</param>
    /// <param name="maxDistance">The max length of the sweep.</param>
    /// <param name="layermask">A that is used to selectively ignore colliders when casting a capsule.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    /// <returns>
    ///   <para>An array of all colliders hit in the sweep.</para>
    /// </returns>
    [ExcludeFromDocs]
    public static RaycastHit[] CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layermask = -5;
      return Physics.INTERNAL_CALL_CapsuleCastAll(ref point1, ref point2, radius, ref direction, maxDistance, layermask, queryTriggerInteraction);
    }

    /// <summary>
    ///   <para>Like Physics.CapsuleCast, but this function will return all hits the capsule sweep intersects.</para>
    /// </summary>
    /// <param name="point1">The center of the sphere at the start of the capsule.</param>
    /// <param name="point2">The center of the sphere at the end of the capsule.</param>
    /// <param name="radius">The radius of the capsule.</param>
    /// <param name="direction">The direction into which to sweep the capsule.</param>
    /// <param name="maxDistance">The max length of the sweep.</param>
    /// <param name="layermask">A that is used to selectively ignore colliders when casting a capsule.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    /// <returns>
    ///   <para>An array of all colliders hit in the sweep.</para>
    /// </returns>
    [ExcludeFromDocs]
    public static RaycastHit[] CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layermask = -5;
      float maxDistance = float.PositiveInfinity;
      return Physics.INTERNAL_CALL_CapsuleCastAll(ref point1, ref point2, radius, ref direction, maxDistance, layermask, queryTriggerInteraction);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern RaycastHit[] INTERNAL_CALL_CapsuleCastAll(ref Vector3 point1, ref Vector3 point2, float radius, ref Vector3 direction, float maxDistance, int layermask, QueryTriggerInteraction queryTriggerInteraction);

    /// <summary>
    ///   <para>Casts a capsule against all colliders in the scene and returns detailed information on what was hit into the buffer.</para>
    /// </summary>
    /// <param name="point1">The center of the sphere at the start of the capsule.</param>
    /// <param name="point2">The center of the sphere at the end of the capsule.</param>
    /// <param name="radius">The radius of the capsule.</param>
    /// <param name="direction">The direction into which to sweep the capsule.</param>
    /// <param name="results">The buffer to store the hits into.</param>
    /// <param name="maxDistance">The max length of the sweep.</param>
    /// <param name="layermask">A that is used to selectively ignore colliders when casting a capsule.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    /// <returns>
    ///   <para>The amount of hits stored into the buffer.</para>
    /// </returns>
    public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layermask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
    {
      return Physics.INTERNAL_CALL_CapsuleCastNonAlloc(ref point1, ref point2, radius, ref direction, results, maxDistance, layermask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results, float maxDistance, int layermask)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      return Physics.INTERNAL_CALL_CapsuleCastNonAlloc(ref point1, ref point2, radius, ref direction, results, maxDistance, layermask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results, float maxDistance)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layermask = -5;
      return Physics.INTERNAL_CALL_CapsuleCastNonAlloc(ref point1, ref point2, radius, ref direction, results, maxDistance, layermask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layermask = -5;
      float maxDistance = float.PositiveInfinity;
      return Physics.INTERNAL_CALL_CapsuleCastNonAlloc(ref point1, ref point2, radius, ref direction, results, maxDistance, layermask, queryTriggerInteraction);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern int INTERNAL_CALL_CapsuleCastNonAlloc(ref Vector3 point1, ref Vector3 point2, float radius, ref Vector3 direction, RaycastHit[] results, float maxDistance, int layermask, QueryTriggerInteraction queryTriggerInteraction);

    /// <summary>
    ///   <para>Like Physics.SphereCast, but this function will return all hits the sphere sweep intersects.</para>
    /// </summary>
    /// <param name="origin">The center of the sphere at the start of the sweep.</param>
    /// <param name="radius">The radius of the sphere.</param>
    /// <param name="direction">The direction in which to sweep the sphere.</param>
    /// <param name="maxDistance">The max length of the sweep.</param>
    /// <param name="layerMask">A that is used to selectively ignore colliders when casting a sphere.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    /// <returns>
    ///   <para>An array of all colliders hit in the sweep.</para>
    /// </returns>
    [ExcludeFromDocs]
    public static RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction, float maxDistance, int layerMask)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      return Physics.SphereCastAll(origin, radius, direction, maxDistance, layerMask, queryTriggerInteraction);
    }

    /// <summary>
    ///   <para>Like Physics.SphereCast, but this function will return all hits the sphere sweep intersects.</para>
    /// </summary>
    /// <param name="origin">The center of the sphere at the start of the sweep.</param>
    /// <param name="radius">The radius of the sphere.</param>
    /// <param name="direction">The direction in which to sweep the sphere.</param>
    /// <param name="maxDistance">The max length of the sweep.</param>
    /// <param name="layerMask">A that is used to selectively ignore colliders when casting a sphere.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    /// <returns>
    ///   <para>An array of all colliders hit in the sweep.</para>
    /// </returns>
    [ExcludeFromDocs]
    public static RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction, float maxDistance)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layerMask = -5;
      return Physics.SphereCastAll(origin, radius, direction, maxDistance, layerMask, queryTriggerInteraction);
    }

    /// <summary>
    ///   <para>Like Physics.SphereCast, but this function will return all hits the sphere sweep intersects.</para>
    /// </summary>
    /// <param name="origin">The center of the sphere at the start of the sweep.</param>
    /// <param name="radius">The radius of the sphere.</param>
    /// <param name="direction">The direction in which to sweep the sphere.</param>
    /// <param name="maxDistance">The max length of the sweep.</param>
    /// <param name="layerMask">A that is used to selectively ignore colliders when casting a sphere.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    /// <returns>
    ///   <para>An array of all colliders hit in the sweep.</para>
    /// </returns>
    [ExcludeFromDocs]
    public static RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layerMask = -5;
      float maxDistance = float.PositiveInfinity;
      return Physics.SphereCastAll(origin, radius, direction, maxDistance, layerMask, queryTriggerInteraction);
    }

    /// <summary>
    ///   <para>Like Physics.SphereCast, but this function will return all hits the sphere sweep intersects.</para>
    /// </summary>
    /// <param name="origin">The center of the sphere at the start of the sweep.</param>
    /// <param name="radius">The radius of the sphere.</param>
    /// <param name="direction">The direction in which to sweep the sphere.</param>
    /// <param name="maxDistance">The max length of the sweep.</param>
    /// <param name="layerMask">A that is used to selectively ignore colliders when casting a sphere.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    /// <returns>
    ///   <para>An array of all colliders hit in the sweep.</para>
    /// </returns>
    public static RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
    {
      return Physics.CapsuleCastAll(origin, origin, radius, direction, maxDistance, layerMask, queryTriggerInteraction);
    }

    /// <summary>
    ///   <para>Like Physics.SphereCast, but this function will return all hits the sphere sweep intersects.</para>
    /// </summary>
    /// <param name="ray">The starting point and direction of the ray into which the sphere sweep is cast.</param>
    /// <param name="radius">The radius of the sphere.</param>
    /// <param name="maxDistance">The max length of the sweep.</param>
    /// <param name="layerMask">A that is used to selectively ignore colliders when casting a sphere.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    [ExcludeFromDocs]
    public static RaycastHit[] SphereCastAll(Ray ray, float radius, float maxDistance, int layerMask)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      return Physics.SphereCastAll(ray, radius, maxDistance, layerMask, queryTriggerInteraction);
    }

    /// <summary>
    ///   <para>Like Physics.SphereCast, but this function will return all hits the sphere sweep intersects.</para>
    /// </summary>
    /// <param name="ray">The starting point and direction of the ray into which the sphere sweep is cast.</param>
    /// <param name="radius">The radius of the sphere.</param>
    /// <param name="maxDistance">The max length of the sweep.</param>
    /// <param name="layerMask">A that is used to selectively ignore colliders when casting a sphere.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    [ExcludeFromDocs]
    public static RaycastHit[] SphereCastAll(Ray ray, float radius, float maxDistance)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layerMask = -5;
      return Physics.SphereCastAll(ray, radius, maxDistance, layerMask, queryTriggerInteraction);
    }

    /// <summary>
    ///   <para>Like Physics.SphereCast, but this function will return all hits the sphere sweep intersects.</para>
    /// </summary>
    /// <param name="ray">The starting point and direction of the ray into which the sphere sweep is cast.</param>
    /// <param name="radius">The radius of the sphere.</param>
    /// <param name="maxDistance">The max length of the sweep.</param>
    /// <param name="layerMask">A that is used to selectively ignore colliders when casting a sphere.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    [ExcludeFromDocs]
    public static RaycastHit[] SphereCastAll(Ray ray, float radius)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layerMask = -5;
      float maxDistance = float.PositiveInfinity;
      return Physics.SphereCastAll(ray, radius, maxDistance, layerMask, queryTriggerInteraction);
    }

    /// <summary>
    ///   <para>Like Physics.SphereCast, but this function will return all hits the sphere sweep intersects.</para>
    /// </summary>
    /// <param name="ray">The starting point and direction of the ray into which the sphere sweep is cast.</param>
    /// <param name="radius">The radius of the sphere.</param>
    /// <param name="maxDistance">The max length of the sweep.</param>
    /// <param name="layerMask">A that is used to selectively ignore colliders when casting a sphere.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    public static RaycastHit[] SphereCastAll(Ray ray, float radius, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
    {
      return Physics.CapsuleCastAll(ray.origin, ray.origin, radius, ray.direction, maxDistance, layerMask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      return Physics.SphereCastNonAlloc(origin, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layerMask = -5;
      return Physics.SphereCastNonAlloc(origin, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layerMask = -5;
      float maxDistance = float.PositiveInfinity;
      return Physics.SphereCastNonAlloc(origin, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction);
    }

    /// <summary>
    ///   <para>Cast sphere along the direction and store the results into buffer.</para>
    /// </summary>
    /// <param name="origin">The center of the sphere at the start of the sweep.</param>
    /// <param name="radius">The radius of the sphere.</param>
    /// <param name="direction">The direction in which to sweep the sphere.</param>
    /// <param name="results">The buffer to save the hits into.</param>
    /// <param name="maxDistance">The max length of the sweep.</param>
    /// <param name="layerMask">A that is used to selectively ignore colliders when casting a sphere.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    /// <returns>
    ///   <para>The amount of hits stored into the results buffer.</para>
    /// </returns>
    public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
    {
      return Physics.CapsuleCastNonAlloc(origin, origin, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static int SphereCastNonAlloc(Ray ray, float radius, RaycastHit[] results, float maxDistance, int layerMask)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      return Physics.SphereCastNonAlloc(ray, radius, results, maxDistance, layerMask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static int SphereCastNonAlloc(Ray ray, float radius, RaycastHit[] results, float maxDistance)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layerMask = -5;
      return Physics.SphereCastNonAlloc(ray, radius, results, maxDistance, layerMask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static int SphereCastNonAlloc(Ray ray, float radius, RaycastHit[] results)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layerMask = -5;
      float maxDistance = float.PositiveInfinity;
      return Physics.SphereCastNonAlloc(ray, radius, results, maxDistance, layerMask, queryTriggerInteraction);
    }

    /// <summary>
    ///   <para>Cast sphere along the direction and store the results into buffer.</para>
    /// </summary>
    /// <param name="ray">The starting point and direction of the ray into which the sphere sweep is cast.</param>
    /// <param name="radius">The radius of the sphere.</param>
    /// <param name="results">The buffer to save the results to.</param>
    /// <param name="maxDistance">The max length of the sweep.</param>
    /// <param name="layerMask">A that is used to selectively ignore colliders when casting a sphere.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    /// <returns>
    ///   <para>The amount of hits stored into the results buffer.</para>
    /// </returns>
    public static int SphereCastNonAlloc(Ray ray, float radius, RaycastHit[] results, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
    {
      return Physics.CapsuleCastNonAlloc(ray.origin, ray.origin, radius, ray.direction, results, maxDistance, layerMask, queryTriggerInteraction);
    }

    /// <summary>
    ///   <para>Returns true if there are any colliders overlapping the sphere defined by position and radius in world coordinates.</para>
    /// </summary>
    /// <param name="position">Center of the sphere.</param>
    /// <param name="radius">Radius of the sphere.</param>
    /// <param name="layerMask">A that is used to selectively ignore colliders when casting a capsule.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    public static bool CheckSphere(Vector3 position, float radius, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
    {
      return Physics.INTERNAL_CALL_CheckSphere(ref position, radius, layerMask, queryTriggerInteraction);
    }

    /// <summary>
    ///   <para>Returns true if there are any colliders overlapping the sphere defined by position and radius in world coordinates.</para>
    /// </summary>
    /// <param name="position">Center of the sphere.</param>
    /// <param name="radius">Radius of the sphere.</param>
    /// <param name="layerMask">A that is used to selectively ignore colliders when casting a capsule.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    [ExcludeFromDocs]
    public static bool CheckSphere(Vector3 position, float radius, int layerMask)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      return Physics.INTERNAL_CALL_CheckSphere(ref position, radius, layerMask, queryTriggerInteraction);
    }

    /// <summary>
    ///   <para>Returns true if there are any colliders overlapping the sphere defined by position and radius in world coordinates.</para>
    /// </summary>
    /// <param name="position">Center of the sphere.</param>
    /// <param name="radius">Radius of the sphere.</param>
    /// <param name="layerMask">A that is used to selectively ignore colliders when casting a capsule.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    [ExcludeFromDocs]
    public static bool CheckSphere(Vector3 position, float radius)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layerMask = -5;
      return Physics.INTERNAL_CALL_CheckSphere(ref position, radius, layerMask, queryTriggerInteraction);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern bool INTERNAL_CALL_CheckSphere(ref Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

    /// <summary>
    ///   <para>Checks if any colliders overlap a capsule-shaped volume in world space.</para>
    /// </summary>
    /// <param name="start">The center of the sphere at the start of the capsule.</param>
    /// <param name="end">The center of the sphere at the end of the capsule.</param>
    /// <param name="radius">The radius of the capsule.</param>
    /// <param name="layermask">A that is used to selectively ignore colliders when casting a capsule.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, [DefaultValue("DefaultRaycastLayers")] int layermask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
    {
      return Physics.INTERNAL_CALL_CheckCapsule(ref start, ref end, radius, layermask, queryTriggerInteraction);
    }

    /// <summary>
    ///   <para>Checks if any colliders overlap a capsule-shaped volume in world space.</para>
    /// </summary>
    /// <param name="start">The center of the sphere at the start of the capsule.</param>
    /// <param name="end">The center of the sphere at the end of the capsule.</param>
    /// <param name="radius">The radius of the capsule.</param>
    /// <param name="layermask">A that is used to selectively ignore colliders when casting a capsule.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    [ExcludeFromDocs]
    public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layermask)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      return Physics.INTERNAL_CALL_CheckCapsule(ref start, ref end, radius, layermask, queryTriggerInteraction);
    }

    /// <summary>
    ///   <para>Checks if any colliders overlap a capsule-shaped volume in world space.</para>
    /// </summary>
    /// <param name="start">The center of the sphere at the start of the capsule.</param>
    /// <param name="end">The center of the sphere at the end of the capsule.</param>
    /// <param name="radius">The radius of the capsule.</param>
    /// <param name="layermask">A that is used to selectively ignore colliders when casting a capsule.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    [ExcludeFromDocs]
    public static bool CheckCapsule(Vector3 start, Vector3 end, float radius)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layermask = -5;
      return Physics.INTERNAL_CALL_CheckCapsule(ref start, ref end, radius, layermask, queryTriggerInteraction);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern bool INTERNAL_CALL_CheckCapsule(ref Vector3 start, ref Vector3 end, float radius, int layermask, QueryTriggerInteraction queryTriggerInteraction);

    /// <summary>
    ///   <para>Check whether the given box overlaps with other colliders or not.</para>
    /// </summary>
    /// <param name="center">Center of the box.</param>
    /// <param name="halfExtents">Half the size of the box in each dimension.</param>
    /// <param name="orientation">Rotation of the box.</param>
    /// <param name="layermask">A that is used to selectively ignore colliders when casting a ray.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    /// <returns>
    ///   <para>True, if the box overlaps with any colliders.</para>
    /// </returns>
    public static bool CheckBox(Vector3 center, Vector3 halfExtents, [DefaultValue("Quaternion.identity")] Quaternion orientation, [DefaultValue("DefaultRaycastLayers")] int layermask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
    {
      return Physics.INTERNAL_CALL_CheckBox(ref center, ref halfExtents, ref orientation, layermask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static bool CheckBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layermask)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      return Physics.INTERNAL_CALL_CheckBox(ref center, ref halfExtents, ref orientation, layermask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static bool CheckBox(Vector3 center, Vector3 halfExtents, Quaternion orientation)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layermask = -5;
      return Physics.INTERNAL_CALL_CheckBox(ref center, ref halfExtents, ref orientation, layermask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static bool CheckBox(Vector3 center, Vector3 halfExtents)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layermask = -5;
      Quaternion identity = Quaternion.identity;
      return Physics.INTERNAL_CALL_CheckBox(ref center, ref halfExtents, ref identity, layermask, queryTriggerInteraction);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern bool INTERNAL_CALL_CheckBox(ref Vector3 center, ref Vector3 halfExtents, ref Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction);

    /// <summary>
    ///   <para>Find all colliders touching or inside of the given box.</para>
    /// </summary>
    /// <param name="center">Center of the box.</param>
    /// <param name="halfExtents">Half of the size of the box in each dimension.</param>
    /// <param name="orientation">Rotation of the box.</param>
    /// <param name="layerMask">A that is used to selectively ignore colliders when casting a ray.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    /// <returns>
    ///   <para>Colliders that overlap with the given box.</para>
    /// </returns>
    public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, [DefaultValue("Quaternion.identity")] Quaternion orientation, [DefaultValue("AllLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
    {
      return Physics.INTERNAL_CALL_OverlapBox(ref center, ref halfExtents, ref orientation, layerMask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      return Physics.INTERNAL_CALL_OverlapBox(ref center, ref halfExtents, ref orientation, layerMask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layerMask = -1;
      return Physics.INTERNAL_CALL_OverlapBox(ref center, ref halfExtents, ref orientation, layerMask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layerMask = -1;
      Quaternion identity = Quaternion.identity;
      return Physics.INTERNAL_CALL_OverlapBox(ref center, ref halfExtents, ref identity, layerMask, queryTriggerInteraction);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern Collider[] INTERNAL_CALL_OverlapBox(ref Vector3 center, ref Vector3 halfExtents, ref Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

    /// <summary>
    ///   <para>Find all colliders touching or inside of the given box, and store them into the buffer.</para>
    /// </summary>
    /// <param name="center">Center of the box.</param>
    /// <param name="halfExtents">Half of the size of the box in each dimension.</param>
    /// <param name="results">The buffer to store the results in.</param>
    /// <param name="orientation">Rotation of the box.</param>
    /// <param name="layerMask">A that is used to selectively ignore colliders when casting a ray.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    /// <returns>
    ///   <para>The amount of colliders stored in results.</para>
    /// </returns>
    public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results, [DefaultValue("Quaternion.identity")] Quaternion orientation, [DefaultValue("AllLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
    {
      return Physics.INTERNAL_CALL_OverlapBoxNonAlloc(ref center, ref halfExtents, results, ref orientation, layerMask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation, int layerMask)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      return Physics.INTERNAL_CALL_OverlapBoxNonAlloc(ref center, ref halfExtents, results, ref orientation, layerMask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layerMask = -1;
      return Physics.INTERNAL_CALL_OverlapBoxNonAlloc(ref center, ref halfExtents, results, ref orientation, layerMask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layerMask = -1;
      Quaternion identity = Quaternion.identity;
      return Physics.INTERNAL_CALL_OverlapBoxNonAlloc(ref center, ref halfExtents, results, ref identity, layerMask, queryTriggerInteraction);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern int INTERNAL_CALL_OverlapBoxNonAlloc(ref Vector3 center, ref Vector3 halfExtents, Collider[] results, ref Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

    /// <summary>
    ///   <para>Like Physics.BoxCast, but returns all hits.</para>
    /// </summary>
    /// <param name="center">Center of the box.</param>
    /// <param name="halfExtents">Half the size of the box in each dimension.</param>
    /// <param name="direction">The direction in which to cast the box.</param>
    /// <param name="orientation">Rotation of the box.</param>
    /// <param name="maxDistance">The max length of the cast.</param>
    /// <param name="layermask">A that is used to selectively ignore colliders when casting a capsule.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    /// <returns>
    ///   <para>All colliders that were hit.</para>
    /// </returns>
    public static RaycastHit[] BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, [DefaultValue("Quaternion.identity")] Quaternion orientation, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layermask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
    {
      return Physics.INTERNAL_CALL_BoxCastAll(ref center, ref halfExtents, ref direction, ref orientation, maxDistance, layermask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static RaycastHit[] BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layermask)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      return Physics.INTERNAL_CALL_BoxCastAll(ref center, ref halfExtents, ref direction, ref orientation, maxDistance, layermask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static RaycastHit[] BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layermask = -5;
      return Physics.INTERNAL_CALL_BoxCastAll(ref center, ref halfExtents, ref direction, ref orientation, maxDistance, layermask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static RaycastHit[] BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layermask = -5;
      float maxDistance = float.PositiveInfinity;
      return Physics.INTERNAL_CALL_BoxCastAll(ref center, ref halfExtents, ref direction, ref orientation, maxDistance, layermask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static RaycastHit[] BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layermask = -5;
      float maxDistance = float.PositiveInfinity;
      Quaternion identity = Quaternion.identity;
      return Physics.INTERNAL_CALL_BoxCastAll(ref center, ref halfExtents, ref direction, ref identity, maxDistance, layermask, queryTriggerInteraction);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern RaycastHit[] INTERNAL_CALL_BoxCastAll(ref Vector3 center, ref Vector3 halfExtents, ref Vector3 direction, ref Quaternion orientation, float maxDistance, int layermask, QueryTriggerInteraction queryTriggerInteraction);

    /// <summary>
    ///   <para>Cast the box along the direction, and store hits in the provided buffer.</para>
    /// </summary>
    /// <param name="center">Center of the box.</param>
    /// <param name="halfExtents">Half the size of the box in each dimension.</param>
    /// <param name="direction">The direction in which to cast the box.</param>
    /// <param name="results">The buffer to store the results in.</param>
    /// <param name="orientation">Rotation of the box.</param>
    /// <param name="maxDistance">The max length of the cast.</param>
    /// <param name="layermask">A that is used to selectively ignore colliders when casting a capsule.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    /// <returns>
    ///   <para>The amount of hits stored to the results buffer.</para>
    /// </returns>
    public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results, [DefaultValue("Quaternion.identity")] Quaternion orientation, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layermask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
    {
      return Physics.INTERNAL_CALL_BoxCastNonAlloc(ref center, ref halfExtents, ref direction, results, ref orientation, maxDistance, layermask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results, Quaternion orientation, float maxDistance, int layermask)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      return Physics.INTERNAL_CALL_BoxCastNonAlloc(ref center, ref halfExtents, ref direction, results, ref orientation, maxDistance, layermask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results, Quaternion orientation, float maxDistance)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layermask = -5;
      return Physics.INTERNAL_CALL_BoxCastNonAlloc(ref center, ref halfExtents, ref direction, results, ref orientation, maxDistance, layermask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results, Quaternion orientation)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layermask = -5;
      float maxDistance = float.PositiveInfinity;
      return Physics.INTERNAL_CALL_BoxCastNonAlloc(ref center, ref halfExtents, ref direction, results, ref orientation, maxDistance, layermask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layermask = -5;
      float maxDistance = float.PositiveInfinity;
      Quaternion identity = Quaternion.identity;
      return Physics.INTERNAL_CALL_BoxCastNonAlloc(ref center, ref halfExtents, ref direction, results, ref identity, maxDistance, layermask, queryTriggerInteraction);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern int INTERNAL_CALL_BoxCastNonAlloc(ref Vector3 center, ref Vector3 halfExtents, ref Vector3 direction, RaycastHit[] results, ref Quaternion orientation, float maxDistance, int layermask, QueryTriggerInteraction queryTriggerInteraction);

    private static bool Internal_BoxCast(Vector3 center, Vector3 halfExtents, Quaternion orientation, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layermask, QueryTriggerInteraction queryTriggerInteraction)
    {
      return Physics.INTERNAL_CALL_Internal_BoxCast(ref center, ref halfExtents, ref orientation, ref direction, out hitInfo, maxDistance, layermask, queryTriggerInteraction);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern bool INTERNAL_CALL_Internal_BoxCast(ref Vector3 center, ref Vector3 halfExtents, ref Quaternion orientation, ref Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layermask, QueryTriggerInteraction queryTriggerInteraction);

    [ExcludeFromDocs]
    public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      return Physics.BoxCast(center, halfExtents, direction, orientation, maxDistance, layerMask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layerMask = -5;
      return Physics.BoxCast(center, halfExtents, direction, orientation, maxDistance, layerMask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layerMask = -5;
      float maxDistance = float.PositiveInfinity;
      return Physics.BoxCast(center, halfExtents, direction, orientation, maxDistance, layerMask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layerMask = -5;
      float maxDistance = float.PositiveInfinity;
      Quaternion identity = Quaternion.identity;
      return Physics.BoxCast(center, halfExtents, direction, identity, maxDistance, layerMask, queryTriggerInteraction);
    }

    /// <summary>
    ///   <para>Casts the box along a ray and returns detailed information on what was hit.</para>
    /// </summary>
    /// <param name="center">Center of the box.</param>
    /// <param name="halfExtents">Half the size of the box in each dimension.</param>
    /// <param name="direction">The direction in which to cast the box.</param>
    /// <param name="orientation">Rotation of the box.</param>
    /// <param name="maxDistance">The max length of the cast.</param>
    /// <param name="layerMask">A that is used to selectively ignore colliders when casting a capsule.</param>
    /// <param name="queryTriggerInteraction">Specifies whether this query should hit Triggers.</param>
    /// <returns>
    ///   <para>True, if any intersections were found.</para>
    /// </returns>
    public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, [DefaultValue("Quaternion.identity")] Quaternion orientation, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
    {
      RaycastHit hitInfo;
      return Physics.Internal_BoxCast(center, halfExtents, orientation, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance, int layerMask)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      return Physics.BoxCast(center, halfExtents, direction, out hitInfo, orientation, maxDistance, layerMask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layerMask = -5;
      return Physics.BoxCast(center, halfExtents, direction, out hitInfo, orientation, maxDistance, layerMask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layerMask = -5;
      float maxDistance = float.PositiveInfinity;
      return Physics.BoxCast(center, halfExtents, direction, out hitInfo, orientation, maxDistance, layerMask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      int layerMask = -5;
      float maxDistance = float.PositiveInfinity;
      Quaternion identity = Quaternion.identity;
      return Physics.BoxCast(center, halfExtents, direction, out hitInfo, identity, maxDistance, layerMask, queryTriggerInteraction);
    }

    public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, [DefaultValue("Quaternion.identity")] Quaternion orientation, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
    {
      return Physics.Internal_BoxCast(center, halfExtents, orientation, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
    }

    /// <summary>
    ///   <para>Makes the collision detection system ignore all collisions between collider1 and collider2.</para>
    /// </summary>
    /// <param name="collider1"></param>
    /// <param name="collider2"></param>
    /// <param name="ignore"></param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void IgnoreCollision(Collider collider1, Collider collider2, [DefaultValue("true")] bool ignore);

    /// <summary>
    ///   <para>Makes the collision detection system ignore all collisions between collider1 and collider2.</para>
    /// </summary>
    /// <param name="collider1"></param>
    /// <param name="collider2"></param>
    /// <param name="ignore"></param>
    [ExcludeFromDocs]
    public static void IgnoreCollision(Collider collider1, Collider collider2)
    {
      bool ignore = true;
      Physics.IgnoreCollision(collider1, collider2, ignore);
    }

    /// <summary>
    ///         <para>Makes the collision detection system ignore all collisions between any collider in layer1 and any collider in layer2.
    /// 
    /// Note that IgnoreLayerCollision will reset the trigger state of affected colliders, so you might receive OnTriggerExit and OnTriggerEnter messages in response to calling this.</para>
    ///       </summary>
    /// <param name="layer1"></param>
    /// <param name="layer2"></param>
    /// <param name="ignore"></param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void IgnoreLayerCollision(int layer1, int layer2, [DefaultValue("true")] bool ignore);

    /// <summary>
    ///         <para>Makes the collision detection system ignore all collisions between any collider in layer1 and any collider in layer2.
    /// 
    /// Note that IgnoreLayerCollision will reset the trigger state of affected colliders, so you might receive OnTriggerExit and OnTriggerEnter messages in response to calling this.</para>
    ///       </summary>
    /// <param name="layer1"></param>
    /// <param name="layer2"></param>
    /// <param name="ignore"></param>
    [ExcludeFromDocs]
    public static void IgnoreLayerCollision(int layer1, int layer2)
    {
      bool ignore = true;
      Physics.IgnoreLayerCollision(layer1, layer2, ignore);
    }

    /// <summary>
    ///   <para>Are collisions between layer1 and layer2 being ignored?</para>
    /// </summary>
    /// <param name="layer1"></param>
    /// <param name="layer2"></param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern bool GetIgnoreLayerCollision(int layer1, int layer2);

    private static bool Internal_Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layermask, QueryTriggerInteraction queryTriggerInteraction)
    {
      return Physics.INTERNAL_CALL_Internal_Raycast(ref origin, ref direction, out hitInfo, maxDistance, layermask, queryTriggerInteraction);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern bool INTERNAL_CALL_Internal_Raycast(ref Vector3 origin, ref Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layermask, QueryTriggerInteraction queryTriggerInteraction);

    private static bool Internal_CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layermask, QueryTriggerInteraction queryTriggerInteraction)
    {
      return Physics.INTERNAL_CALL_Internal_CapsuleCast(ref point1, ref point2, radius, ref direction, out hitInfo, maxDistance, layermask, queryTriggerInteraction);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern bool INTERNAL_CALL_Internal_CapsuleCast(ref Vector3 point1, ref Vector3 point2, float radius, ref Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layermask, QueryTriggerInteraction queryTriggerInteraction);

    private static bool Internal_RaycastTest(Vector3 origin, Vector3 direction, float maxDistance, int layermask, QueryTriggerInteraction queryTriggerInteraction)
    {
      return Physics.INTERNAL_CALL_Internal_RaycastTest(ref origin, ref direction, maxDistance, layermask, queryTriggerInteraction);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern bool INTERNAL_CALL_Internal_RaycastTest(ref Vector3 origin, ref Vector3 direction, float maxDistance, int layermask, QueryTriggerInteraction queryTriggerInteraction);
  }
}
