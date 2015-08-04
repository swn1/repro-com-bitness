using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace ClassLibrary1
{
    [ComVisible(true)]
    [Guid("A72378AC-C51B-4C14-9A3E-F9B7F1BC1AF4")]
    public interface IRepro
    {
        int foo();
    }

    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [Guid("A2E68F26-7F87-4B3A-9DFE-363F66483289")]
    public class Repro : IRepro
    {
        public Repro() { }
        public int foo() { return 1; }
    }
}
