#define _LIBCPP_DISABLE_VISIBILITY_ANNOTATIONS
#define _LIBCPP_HIDE_FROM_ABI

#include <Consumer.h>

extern "C" { void CppSharpTestNative_dll_symbols1(void* __instance, const Consumer& _0) { new (__instance) Consumer(_0); } }
Consumer& (Consumer::*CppSharpTestNative_dll_symbols2)(const Consumer&) = &Consumer::operator=;
Consumer& (Consumer::*CppSharpTestNative_dll_symbols3)(Consumer&&) = &Consumer::operator=;
extern "C" { void CppSharpTestNative_dll_symbols4(Consumer* __instance) { __instance->~Consumer(); } }
