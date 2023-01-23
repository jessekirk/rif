using System;
using System.Management.Automation;

namespace Rif
{
    [Cmdlet(VerbsCommon.Get, "RifDtsUtc")]
    public class Dts : Cmdlet
    {
        protected override void ProcessRecord()
        {
            WriteObject(DateTime.UtcNow.ToString("yyyyMMddTHHmmssfffZ"));
        }
    }
}