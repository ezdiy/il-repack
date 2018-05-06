using System;
namespace System.Diagnostics.Contracts
{
    public class Contract
    {
        //Note: can't use __arglist in template function
        static public void Requires<T>(bool b, string s = "") { Requires(b, s); }
        static public void Assert(bool b, string s = "") { Requires(b, s); }
        static public void Requires(bool b, string s = "")
        {
            if (!b) throw new Exception("Contract.Requires " + s);
        }

    }
}