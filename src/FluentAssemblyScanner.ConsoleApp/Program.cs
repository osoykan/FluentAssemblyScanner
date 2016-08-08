﻿using System;
using System.Collections.Generic;

using FluentAssemblyScanner.ConsoleApp.Animals;

namespace FluentAssemblyScanner.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IEnumerable<Type> types = FluentAssemblyScanner.FromAssemblyInDirectory(AssemblyFilterFactory.All())
                                                           .IncludeNonPublicTypes()
                                                           .ExcludeAssemblyContaining<IAnimal>()
                                                           .BasedOn<IAnimal>()
                                                           .Filter()
                                                           .NonStatic()
                                                           .MethodHasAttribute<VoiceAttribute>()
                                                           .Scan();
        }
    }
}