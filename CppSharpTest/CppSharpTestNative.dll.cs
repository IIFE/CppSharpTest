// ----------------------------------------------------------------------------
// <auto-generated>
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
// </auto-generated>
// ----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace CppSharpTestNative.dll
{
    public unsafe partial class Base : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 24)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::System.IntPtr vfptr_Base;

            [FieldOffset(8)]
            internal int m_i;

            [FieldOffset(16)]
            internal double m_d;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("CppSharpTestNative.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="??0Base@@QEAA@XZ")]
            internal static extern global::System.IntPtr ctor(global::System.IntPtr __instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("CppSharpTestNative.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="??0Base@@QEAA@AEBV0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CppSharpTestNative.dll.Base> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CppSharpTestNative.dll.Base>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CppSharpTestNative.dll.Base __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CppSharpTestNative.dll.Base(native.ToPointer(), skipVTables);
        }

        internal static global::CppSharpTestNative.dll.Base __CreateInstance(global::CppSharpTestNative.dll.Base.__Internal native, bool skipVTables = false)
        {
            return new global::CppSharpTestNative.dll.Base(native, skipVTables);
        }

        private static void* __CopyValue(global::CppSharpTestNative.dll.Base.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CppSharpTestNative.dll.Base.__Internal));
            global::CppSharpTestNative.dll.Base.__Internal.cctor(ret, new global::System.IntPtr(&native));
            return ret.ToPointer();
        }

        private Base(global::CppSharpTestNative.dll.Base.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Base(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
            if (skipVTables)
                __OriginalVTables = new void*[] { *(void**) (__Instance + 0) };
            else
                SetupVTables(true);
        }

        public Base()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CppSharpTestNative.dll.Base.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            __Internal.ctor((__Instance + __PointerAdjustment));
            SetupVTables(GetType().FullName == "CppSharpTestNative.dll.Base");
        }

        public Base(global::CppSharpTestNative.dll.Base _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CppSharpTestNative.dll.Base.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            if (ReferenceEquals(_0, null))
                throw new global::System.ArgumentNullException("_0", "Cannot be null because it is a C++ reference (&).");
            var __arg0 = _0.__Instance;
            __Internal.cctor((__Instance + __PointerAdjustment), __arg0);
            SetupVTables(GetType().FullName == "CppSharpTestNative.dll.Base");
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CppSharpTestNative.dll.Base __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            ((global::CppSharpTestNative.dll.Base.__Internal*) __Instance)->vfptr_Base = new global::System.IntPtr(__OriginalVTables[0]);
            if (disposing)
            {
                var __slot = *(void**) ((IntPtr) __OriginalVTables[0] + 1 * 8);
                var ___dtorDelegate = (global::CppSharpTestNative.dll.Delegates.Action_IntPtr_int) Marshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::CppSharpTestNative.dll.Delegates.Action_IntPtr_int));
                ___dtorDelegate((__Instance + __PointerAdjustment), 0);
            }
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public virtual void DoSomething()
        {
            var __slot = *(void**) ((IntPtr) __OriginalVTables[0] + 2 * 8);
            var ___DoSomethingDelegate = (global::CppSharpTestNative.dll.Delegates.Action_IntPtr) Marshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::CppSharpTestNative.dll.Delegates.Action_IntPtr));
            ___DoSomethingDelegate((__Instance + __PointerAdjustment));
        }

        public int MI
        {
            get
            {
                return ((global::CppSharpTestNative.dll.Base.__Internal*) __Instance)->m_i;
            }

            set
            {
                ((global::CppSharpTestNative.dll.Base.__Internal*)__Instance)->m_i = value;
            }
        }

        public double MD
        {
            get
            {
                return ((global::CppSharpTestNative.dll.Base.__Internal*) __Instance)->m_d;
            }

            set
            {
                ((global::CppSharpTestNative.dll.Base.__Internal*)__Instance)->m_d = value;
            }
        }

        #region Virtual table interop

        // virtual ~Base()
        private static global::CppSharpTestNative.dll.Delegates.Action_IntPtr_int _dtorDelegateInstance;

        private static void _dtorDelegateHook(global::System.IntPtr __instance, int delete)
        {
            if (!NativeToManagedMap.ContainsKey(__instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::CppSharpTestNative.dll.Base) NativeToManagedMap[__instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            __target.Dispose(true);
        }

        // void DoSomething()
        private static global::CppSharpTestNative.dll.Delegates.Action_IntPtr _DoSomethingDelegateInstance;

        private static void _DoSomethingDelegateHook(global::System.IntPtr __instance)
        {
            if (!NativeToManagedMap.ContainsKey(__instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::CppSharpTestNative.dll.Base) NativeToManagedMap[__instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            __target.DoSomething();
        }

        private static void*[] __ManagedVTables;
        private static void*[] __ManagedVTablesDtorOnly;
        private static void*[] _Thunks;

        private void SetupVTables(bool destructorOnly = false)
        {
            if (__OriginalVTables != null)
                return;
            __OriginalVTables = new void*[] { *(void**) (__Instance + 0) };

            if (_Thunks == null)
            {
                _Thunks = new void*[2];
                _dtorDelegateInstance += _dtorDelegateHook;
                _Thunks[0] = Marshal.GetFunctionPointerForDelegate(_dtorDelegateInstance).ToPointer();
                _DoSomethingDelegateInstance += _DoSomethingDelegateHook;
                _Thunks[1] = Marshal.GetFunctionPointerForDelegate(_DoSomethingDelegateInstance).ToPointer();
            }

            if (destructorOnly)
            {
                if (__ManagedVTablesDtorOnly == null)
                {
                    __ManagedVTablesDtorOnly = new void*[1];
                    var vfptr0 = Marshal.AllocHGlobal(3 * 8);
                    __ManagedVTablesDtorOnly[0] = vfptr0.ToPointer();
                    *(void**) (vfptr0 + 0) = *(void**) (new IntPtr(*(void**) __Instance) + 0 + 0);
                    *(void**) (vfptr0 + 8) = _Thunks[0];
                    *(void**) (vfptr0 + 16) = *(void**) (new IntPtr(*(void**) __Instance) + 0 + 16);
                }

                *(void**) (__Instance + 0) = __ManagedVTablesDtorOnly[0];
            }
            else
            {
                if (__ManagedVTables == null)
                {
                    __ManagedVTables = new void*[1];
                    var vfptr0 = Marshal.AllocHGlobal(3 * 8);
                    __ManagedVTables[0] = vfptr0.ToPointer();
                    *(void**) (vfptr0 + 0) = *(void**) (new IntPtr(*(void**) __Instance) + 0 + 0);
                    *(void**) (vfptr0 + 8) = _Thunks[0];
                    *(void**) (vfptr0 + 16) = _Thunks[1];
                }

                *(void**) (__Instance + 0) = __ManagedVTables[0];
            }
        }

        #endregion
    }

    public unsafe partial class Derived : global::CppSharpTestNative.dll.Base, IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 56)]
        public new partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::System.IntPtr vfptr_Base;

            [FieldOffset(8)]
            internal int m_i;

            [FieldOffset(16)]
            internal double m_d;

            [FieldOffset(24)]
            internal global::Std.BasicString.__Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C m_s;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("CppSharpTestNative.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="??0Derived@@QEAA@V?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@@Z")]
            internal static extern global::System.IntPtr ctor(global::System.IntPtr __instance, global::System.IntPtr s);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("CppSharpTestNative.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="??0Derived@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor_1(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        internal static new global::CppSharpTestNative.dll.Derived __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CppSharpTestNative.dll.Derived(native.ToPointer(), skipVTables);
        }

        internal static global::CppSharpTestNative.dll.Derived __CreateInstance(global::CppSharpTestNative.dll.Derived.__Internal native, bool skipVTables = false)
        {
            return new global::CppSharpTestNative.dll.Derived(native, skipVTables);
        }

        private static void* __CopyValue(global::CppSharpTestNative.dll.Derived.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CppSharpTestNative.dll.Derived.__Internal));
            global::CppSharpTestNative.dll.Derived.__Internal.cctor_1(ret, new global::System.IntPtr(&native));
            return ret.ToPointer();
        }

        private Derived(global::CppSharpTestNative.dll.Derived.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Derived(void* native, bool skipVTables = false)
            : base((void*) null)
        {
            __PointerAdjustment = 0;
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
            if (skipVTables)
                __OriginalVTables = new void*[] { *(void**) (__Instance + 0) };
            else
                SetupVTables(true);
        }

        public Derived(string s)
            : this((void*) null)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CppSharpTestNative.dll.Derived.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            var __basicString0 = new global::Std.BasicString<sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>>();
            global::Std.BasicStringExtensions.Assign(__basicString0, s);
            var __arg0 = __basicString0.__Instance;
            __Internal.ctor((__Instance + __PointerAdjustment), __arg0);
            __basicString0.Dispose();
            SetupVTables(GetType().FullName == "CppSharpTestNative.dll.Derived");
        }

        public Derived(global::CppSharpTestNative.dll.Derived _0)
            : this((void*) null)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CppSharpTestNative.dll.Derived.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            if (ReferenceEquals(_0, null))
                throw new global::System.ArgumentNullException("_0", "Cannot be null because it is a C++ reference (&).");
            var __arg0 = _0.__Instance;
            __Internal.cctor_1((__Instance + __PointerAdjustment), __arg0);
            SetupVTables(GetType().FullName == "CppSharpTestNative.dll.Derived");
        }

        public static implicit operator global::CppSharpTestNative.dll.Derived(string s)
        {
            return new global::CppSharpTestNative.dll.Derived(s);
        }

        public string MS
        {
            get
            {
                var __basicStringRet0 = global::Std.BasicString<sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>>.__CreateInstance(new global::System.IntPtr(&((global::CppSharpTestNative.dll.Derived.__Internal*) __Instance)->m_s));
                var __stringRet0 = global::Std.BasicStringExtensions.CStr(__basicStringRet0);
                __basicStringRet0.Dispose(false);
                return __stringRet0;
            }

            set
            {
                global::Std.BasicStringExtensions.__Internal.Assign(new global::System.IntPtr(&((global::CppSharpTestNative.dll.Derived.__Internal*)__Instance)->m_s), value);
            }
        }

        #region Virtual table interop

        // Derived
        private static global::CppSharpTestNative.dll.Delegates.Action_IntPtr_int _dtorDelegateInstance;

        private static void _dtorDelegateHook(global::System.IntPtr __instance, int delete)
        {
            if (!NativeToManagedMap.ContainsKey(__instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::CppSharpTestNative.dll.Derived) NativeToManagedMap[__instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            __target.Dispose(true);
        }

        // void DoSomething()
        private static global::CppSharpTestNative.dll.Delegates.Action_IntPtr _DoSomethingDelegateInstance;

        private static void _DoSomethingDelegateHook(global::System.IntPtr __instance)
        {
            if (!NativeToManagedMap.ContainsKey(__instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::CppSharpTestNative.dll.Derived) NativeToManagedMap[__instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            __target.DoSomething();
        }

        private static void*[] __ManagedVTables;
        private static void*[] __ManagedVTablesDtorOnly;
        private static void*[] _Thunks;

        private void SetupVTables(bool destructorOnly = false)
        {
            if (__OriginalVTables != null)
                return;
            __OriginalVTables = new void*[] { *(void**) (__Instance + 0) };

            if (_Thunks == null)
            {
                _Thunks = new void*[2];
                _dtorDelegateInstance += _dtorDelegateHook;
                _Thunks[0] = Marshal.GetFunctionPointerForDelegate(_dtorDelegateInstance).ToPointer();
                _DoSomethingDelegateInstance += _DoSomethingDelegateHook;
                _Thunks[1] = Marshal.GetFunctionPointerForDelegate(_DoSomethingDelegateInstance).ToPointer();
            }

            if (destructorOnly)
            {
                if (__ManagedVTablesDtorOnly == null)
                {
                    __ManagedVTablesDtorOnly = new void*[1];
                    var vfptr0 = Marshal.AllocHGlobal(3 * 8);
                    __ManagedVTablesDtorOnly[0] = vfptr0.ToPointer();
                    *(void**) (vfptr0 + 0) = *(void**) (new IntPtr(*(void**) __Instance) + 0 + 0);
                    *(void**) (vfptr0 + 8) = _Thunks[0];
                    *(void**) (vfptr0 + 16) = *(void**) (new IntPtr(*(void**) __Instance) + 0 + 16);
                }

                *(void**) (__Instance + 0) = __ManagedVTablesDtorOnly[0];
            }
            else
            {
                if (__ManagedVTables == null)
                {
                    __ManagedVTables = new void*[1];
                    var vfptr0 = Marshal.AllocHGlobal(3 * 8);
                    __ManagedVTables[0] = vfptr0.ToPointer();
                    *(void**) (vfptr0 + 0) = *(void**) (new IntPtr(*(void**) __Instance) + 0 + 0);
                    *(void**) (vfptr0 + 8) = _Thunks[0];
                    *(void**) (vfptr0 + 16) = _Thunks[1];
                }

                *(void**) (__Instance + 0) = __ManagedVTables[0];
            }
        }

        #endregion
    }

    namespace Delegates
    {
        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
        internal unsafe delegate void Action_IntPtr_int(global::System.IntPtr __instance, int arg1);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
        internal unsafe delegate void Action_IntPtr(global::System.IntPtr __instance);
    }
}
