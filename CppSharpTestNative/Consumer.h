#pragma once
#include <string>

#ifdef CPPSHARPTESTNATIVE_EXPORTS
    #define LIBRARY_API __declspec(dllexport)
#else
    #define LIBRARY_API __declspec(dllimport)
#endif

class LIBRARY_API Base
{
public:
    Base();
    virtual ~Base();

    virtual void DoSomething();

    int m_i;
    double m_d;
};

class LIBRARY_API Derived : public Base
{
public:       
    Derived();    

    std::string m_s;
};