using Agilent.AgilentRfSigGen.Interop;
using Ivi.RFSigGen.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N5181ASignalGeneatorApi
{
    public class N5181ASignalGeneator
    {

        AgilentRfSigGen driver = null;


        public struct DriverIdentity
        {
            public string Identifier;
            public string Revision;
            public string Vendor;
            public string Description;
            public string InstrumentModel;
            public string InstrumentFirmwareRevision;
            public string SerialNumber;
            public bool Simulate;
        }
        public bool Initialize(string visaName, out DriverIdentity di, out string outMessage)
        {
            di = new DriverIdentity();
            outMessage = string.Empty;
            try
            {
                // Create driver instance
                driver = new AgilentRfSigGen();

                // Class compliant interface (implemented by Agilent's interface)

                IIviRFSigGen drvr = (IIviRFSigGen)driver;



                // Edit resource and options as needed.  Resource is ignored if option Simulate=true
                string resourceDesc = visaName;
                //resourceDesc = "TCPIP0::<ip or hostname>::INSTR";


                //string initOptions = "QueryInstrStatus=true, Simulate=true, DriverSetup= Model=, Trace=false, TraceName=c:\\temp\\traceOut";
                string initOptions = "QueryInstrStatus=true, Simulate=false, DriverSetup= Model=, Trace=false, TraceName=c:\\temp\\traceOut";

                bool idquery = true;
                bool reset = true;

                // Initialize the driver.  See driver help topic "Initializing the IVI-COM Driver" for additional information
                driver.Initialize(resourceDesc, idquery, reset, initOptions);

                // Print a few IIviDriverIdentity properties
                di.Identifier = driver.Identity.Identifier;
                di.Revision = driver.Identity.Revision;
                di.Vendor = driver.Identity.Vendor;
                di.Description = driver.Identity.Description;
                di.InstrumentModel = driver.Identity.InstrumentModel;
                di.InstrumentFirmwareRevision = driver.Identity.InstrumentFirmwareRevision;
                di.SerialNumber = driver.System.SerialNumber;
                di.Simulate = driver.DriverOperation.Simulate;

                return true;
            }
            catch (Exception err)
            {
                outMessage = err.Message;
                return false;
            }
        }
        public void Reset()
        {
            driver.Utility.Reset();
        }
        public double Frequency
        {
            set
            {
                driver.RF.Frequency = value;
            }
            get
            {
                return driver.RF.Frequency;
            }
        }
        public double Power
        {
            set
            {
                driver.RF.Level = value;
            }
            get
            {
                return driver.RF.Level;
            }
        }
        public bool OutputEnable
        {
            set
            {
                driver.RF.OutputEnabled = value;
            }
            get
            {
                return driver.RF.OutputEnabled;
            }
        }

        public void Close()
        {
            if (driver != null && driver.Initialized)
            {
                driver.Close();
                driver = null;
            }
        }
    }
}
