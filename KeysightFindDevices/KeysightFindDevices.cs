using Ivi.Visa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeysightFindDevicesApi
{
    public class KeysightFindDevices
    {

        public struct KeysightDevice
        {
            public string VisaAddress;
            public string Alias;
        }
        public enum INTERFACE_TYPE
        {
            PXI,
            USB,
            GPIB,
            TCPIP_LAN,
            TCPIP_SOCKET,
            VXI_11,
            HiSLIP,
            ASRL
        }
        public static bool FindDevices(INTERFACE_TYPE interfaceType, out List<KeysightDevice> deviceList, out string outMessage)
        {
            deviceList = new List<KeysightDevice>();
            outMessage = string.Empty;
            IEnumerable<string> devices;
            try
            {
                // Finding all devices and interfaces is straightforward
                devices = GlobalResourceManager.Find();

                //foreach (string device in devices)
                //{
                  //  Console.WriteLine("\tAddress: {0}, Alias: {1}", device, GlobalResourceManager.Parse(device).AliasIfExists);
                //}
            }
            catch (VisaException ex)
            {
                outMessage = "Didn't find any devices!" + ex.Message;
                return false;
            }

            bool b = false;

            // All instruments (no INTFC, BACKPLANE or MEMACC)
            //Find("?*INSTR");
            if (interfaceType == INTERFACE_TYPE.PXI)
            {
                // PXI modules
                b = Find("PXI?*INSTR", ref deviceList);
            }
            if (interfaceType == INTERFACE_TYPE.USB)
            {
                // USB devices
                b = Find("USB?*INSTR", ref deviceList);
            }
            if (interfaceType == INTERFACE_TYPE.GPIB)
            {
                // GPIB instruments
                b = Find("GPIB?*", ref deviceList);
                // GPIB interfaces
                b = Find("GPIB?*INTFC", ref deviceList);
                // GPIB instruments on the GPIB0 interface
                b = Find("GPIB0?*INSTR", ref deviceList);
            }
            if (interfaceType == INTERFACE_TYPE.TCPIP_LAN)
            {
                // LAN instruments
                b = Find("TCPIP?*", ref deviceList);
            }
            if (interfaceType == INTERFACE_TYPE.TCPIP_SOCKET)
            {
                // SOCKET (::SOCKET) instruments
                b = Find("TCPIP?*SOCKET", ref deviceList);
            }

            if (interfaceType == INTERFACE_TYPE.VXI_11)
            {
                // VXI-11 (inst) instruments
                b = Find("TCPIP?*inst?*INSTR", ref deviceList);
            }

            if (interfaceType == INTERFACE_TYPE.HiSLIP)
            {
                // HiSLIP (hislip) instruments
                b = Find("TCPIP?*hislip?*INSTR", ref deviceList);
            }
            if (interfaceType == INTERFACE_TYPE.ASRL)
            {
                // RS-232 instruments
                b = Find("ASRL?*INSTR", ref deviceList);
            }
            return b;
        }
        static bool Find(string searchString, ref List<KeysightDevice> deviceList)
        {
            IEnumerable<string> devices;
            try
            {
                devices = GlobalResourceManager.Find(searchString);

                foreach (string device in devices)
                {
                    //Console.WriteLine("\tAddress: {0}, Alias: {1}", device, GlobalResourceManager.Parse(device).AliasIfExists);
                    KeysightDevice d = new KeysightDevice
                    {
                        VisaAddress = device,
                        Alias = GlobalResourceManager.Parse(device).AliasIfExists
                    };
                    deviceList.Add(d);
                }
                return true;
            }
            catch (VisaException ex)
            {
                return false;
            }
        }

    }
}
