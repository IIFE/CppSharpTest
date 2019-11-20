#define _LIBCPP_DISABLE_VISIBILITY_ANNOTATIONS
#define _LIBCPP_HIDE_FROM_ABI

#include <Consumer.h>

Base& (Base::*CppSharpTestNative_dll_symbols1)(const Base&) = &Base::operator=;
extern "C" { void CppSharpTestNative_dll_symbols2(void* __instance, const Base& _0) { new (__instance) Base(_0); } }
extern "C" { void CppSharpTestNative_dll_symbols3(void* __instance, const Derived& _0) { new (__instance) Derived(_0); } }
Derived& (Derived::*CppSharpTestNative_dll_symbols4)(const Derived&) = &Derived::operator=;
Derived& (Derived::*CppSharpTestNative_dll_symbols5)(Derived&&) = &Derived::operator=;
