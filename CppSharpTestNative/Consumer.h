#pragma once
#include <Windows.h>

#ifdef CPPSHARPTESTNATIVE_EXPORTS
    #define LIBRARY_API __declspec(dllexport)
#else
    #define LIBRARY_API __declspec(dllimport)
#endif

struct LIBRARY_API Consumer
{
public:    
    Consumer(LPCSTR lpsz);

    LPCSTR m_lpsz;
};