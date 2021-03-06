﻿using CatFactory.CodeFactory;
using CatFactory.CodeFactory.Scaffolding;

namespace CatFactory.Tests.Models
{
    public class DapperProject : Project<DapperProjectSettings>
    {
        public void Scaffolding(ICodeBuilder codeBuilder)
        {
            OnScaffoldingDefinition(new ScaffoldingDefinitionEventArgs(Logger, codeBuilder));
        }

        public void Scaffolded(ICodeBuilder codeBuilder)
        {
            OnScaffoldedDefinition(new ScaffoldedDefinitionEventArgs(Logger, codeBuilder));
        }

        public AuthorInfo AuthorInfo { get; set; }
    }
}
