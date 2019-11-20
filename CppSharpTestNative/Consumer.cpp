
#include "pch.h"

#include "Consumer.h"

Base::Base() : m_i(0), m_d(0)
{
}

Base::~Base()
{
}

void Base::DoSomething()
{
}

Derived::Derived() : Base(), m_s("Test")
{
}
