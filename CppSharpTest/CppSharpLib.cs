using CppSharp;
using CppSharp.AST;
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
            options.GeneratorKind = CppSharp.Generators.GeneratorKind.CLI;
            var module = options.AddModule("Generated");
            module.IncludeDirs.Add(@"..\..\..\CppSharpTestNative");            
            module.Headers.Add("Consumer.h");            
            options.OutputDir = ".. /../../CppSharpTestCLI/Generated";
            options.Verbose = true;            
            
            driver.ParserOptions.MicrosoftMode = true;
            driver.ParserOptions.SetupMSVC(VisualStudioVersion.Latest);            
            driver.ParserOptions.ToolSetToUse = 14200;
            driver.ParserOptions.Verbose = true;            
            driver.ParserOptions.EnableRTTI = true;
            driver.ParserOptions.LanguageVersion = CppSharp.Parser.LanguageVersion.CPP14;
        }

        public void SetupPasses(Driver driver)
        {
            
        }
    }
}
