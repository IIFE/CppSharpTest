// ----------------------------------------------------------------------------
// <auto-generated>
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
// </auto-generated>
// ----------------------------------------------------------------------------
#include "Consumer.h"

using namespace System;
using namespace System::Runtime::InteropServices;

CppSharpTestNative.dll::Base::Base(::Base* native)
    : __ownsNativeInstance(false)
{
    NativePtr = native;
}

CppSharpTestNative.dll::Base^ CppSharpTestNative.dll::Base::__CreateInstance(::System::IntPtr native)
{
    return gcnew ::CppSharpTestNative.dll::Base((::Base*) native.ToPointer());
}

CppSharpTestNative.dll::Base::~Base()
{
    delete NativePtr;
}

CppSharpTestNative.dll::Base::Base()
{
    __ownsNativeInstance = true;
    NativePtr = new ::Base();
}

void CppSharpTestNative.dll::Base::DoSomething()
{
    ((::Base*)NativePtr)->DoSomething();
}

CppSharpTestNative.dll::Base::Base(CppSharpTestNative.dll::Base^ _0)
{
    __ownsNativeInstance = true;
    if (ReferenceEquals(_0, nullptr))
        throw gcnew ::System::ArgumentNullException("_0", "Cannot be null because it is a C++ reference (&).");
    auto &__arg0 = *(::Base*)_0->NativePtr;
    NativePtr = new ::Base(__arg0);
}

System::IntPtr CppSharpTestNative.dll::Base::__Instance::get()
{
    return System::IntPtr(NativePtr);
}

void CppSharpTestNative.dll::Base::__Instance::set(System::IntPtr object)
{
    NativePtr = (::Base*)object.ToPointer();
}

int CppSharpTestNative.dll::Base::MI::get()
{
    return ((::Base*)NativePtr)->m_i;
}

void CppSharpTestNative.dll::Base::MI::set(int value)
{
    ((::Base*)NativePtr)->m_i = value;
}

double CppSharpTestNative.dll::Base::MD::get()
{
    return ((::Base*)NativePtr)->m_d;
}

void CppSharpTestNative.dll::Base::MD::set(double value)
{
    ((::Base*)NativePtr)->m_d = value;
}

CppSharpTestNative.dll::Derived::Derived(::Derived* native)
    : CppSharpTestNative.dll::Base((::Base*)native)
{
}

CppSharpTestNative.dll::Derived^ CppSharpTestNative.dll::Derived::__CreateInstance(::System::IntPtr native)
{
    return gcnew ::CppSharpTestNative.dll::Derived((::Derived*) native.ToPointer());
}

CppSharpTestNative.dll::Derived::~Derived()
{
    if (NativePtr)
    {
        auto __nativePtr = NativePtr;
        NativePtr = 0;
        delete (::Derived*) __nativePtr;
    }
}

CppSharpTestNative.dll::Derived::Derived()
    : CppSharpTestNative.dll::Base((::Base*)nullptr)
{
    __ownsNativeInstance = true;
    NativePtr = new ::Derived();
}

CppSharpTestNative.dll::Derived::Derived(CppSharpTestNative.dll::Derived^ _0)
    : CppSharpTestNative.dll::Base((::Base*)nullptr)
{
    __ownsNativeInstance = true;
    if (ReferenceEquals(_0, nullptr))
        throw gcnew ::System::ArgumentNullException("_0", "Cannot be null because it is a C++ reference (&).");
    auto &__arg0 = *(::Derived*)_0->NativePtr;
    NativePtr = new ::Derived(__arg0);
}

System::String^ CppSharpTestNative.dll::Derived::MS::get()
{
    return clix::marshalString<clix::E_UTF8>(((::Derived*)NativePtr)->m_s);
}

void CppSharpTestNative.dll::Derived::MS::set(System::String^ value)
{
    ((::Derived*)NativePtr)->m_s = clix::marshalString<clix::E_UTF8>(value);
}

