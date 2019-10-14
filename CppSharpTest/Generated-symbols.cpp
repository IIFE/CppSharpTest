#define _LIBCPP_DISABLE_VISIBILITY_ANNOTATIONS
#define _LIBCPP_HIDE_FROM_ABI

#include <Consumer.h>

extern "C" { void Generated_symbols1(void* __instance) { new (__instance) Consumer(); } }
extern "C" { void Generated_symbols2(void* __instance, const Consumer& _0) { new (__instance) Consumer(_0); } }
Consumer& (Consumer::*Generated_symbols3)(const Consumer&) = &Consumer::operator=;
Consumer& (Consumer::*Generated_symbols4)(Consumer&&) = &Consumer::operator=;
extern "C" { void Generated_symbols5(Consumer* __instance) { __instance->~Consumer(); } }
extern "C" { void Generated_symbols6(void* __instance, const CSGString& _0) { new (__instance) CSGString(_0); } }
CSGString& (CSGString::*Generated_symbols7)(const CSGString&) = &CSGString::operator=;
CSGString& (CSGString::*Generated_symbols8)(CSGString&&) = &CSGString::operator=;
extern "C" { void Generated_symbols9(CSGString* __instance) { __instance->~CSGString(); } }
