#pragma once
#include <string>

#ifdef CPPSHARPTESTNATIVE_EXPORTS
    #define LIBRARY_API __declspec(dllexport)
#else
    #define LIBRARY_API __declspec(dllimport)
#endif

struct LIBRARY_API Consumer
{
public:
    Description descr;

    DWORD value;

    bool DoSomething();
};