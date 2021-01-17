namespace Agent
{
    
    using System;
    using System.Management;

    public class SerialProvider
    { 
        private SelectQuery Query;
        private ManagementObjectSearcher Searcher;

        public SerialProvider()
        {
            this.Query = new SelectQuery("SELECT * FROM Win32_ComputerSystemProduct");
            this.Searcher = new ManagementObjectSearcher(Query);
        }

        public string GetSerial()
        {
            foreach (ManagementObject managementObject in Searcher.Get())
            {
                string identifiyingNumber = managementObject.ToString().Split(',')[0].Split('=')[1];
                return identifiyingNumber;
            }
            return string.Empty;
        }
    }
}