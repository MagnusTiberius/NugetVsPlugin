// Guids.cs
// MUST match guids.h
using System;

namespace EidPassportInc.VSPackage1
{
    static class GuidList
    {
        public const string guidVSPackage1PkgString = "3a4dba69-0930-48d8-8ff3-1feb81d9f973";
        public const string guidVSPackage1CmdSetString = "ce9d86b8-f85e-426f-b4e6-3a6086e83c1f";
        public const string guidToolWindowPersistanceString = "a8cc3a3e-b59b-4ed3-aaf1-52158f3f69f5";

        public static readonly Guid guidVSPackage1CmdSet = new Guid(guidVSPackage1CmdSetString);
    };
}