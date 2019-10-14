using CppSharp;
using CppSharp.AST;
using CppSharp.Generators;
using CppSharp.Generators.CSharp;
using CppSharp.Passes;
using CppSharp.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CppSharpTest
{
    public class CppSharpLib : ILibrary
    {
        public void Postprocess(Driver driver, ASTContext ctx)
        {
            
        }

        public void Preprocess(Driver driver, ASTContext ctx)
        {
        }

        public void Setup(Driver driver)
        {            
            var options = driver.Options;
            options.GeneratorKind = CppSharp.Generators.GeneratorKind.CSharp;
            var module = options.AddModule("CppSharpTestNative.dll");
            module.IncludeDirs.Add(@"..\..\..\CppSharpTestNative");            
            module.Headers.Add("Consumer.h");            
            options.OutputDir = @"..\..\..\CppSharpTest";                                
            
            driver.ParserOptions.MicrosoftMode = true;
            driver.ParserOptions.SetupMSVC(VisualStudioVersion.Latest);            
            driver.ParserOptions.ToolSetToUse = 14200;                   
            driver.ParserOptions.EnableRTTI = true;                                 
        }

        public void SetupPasses(Driver driver)
        {
        }
    }
}
