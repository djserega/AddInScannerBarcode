using System.Runtime.InteropServices;

namespace AddIn
{
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IScannerBarcode
    {
        bool Connected { get; }
        string Error { get; }
        int Port { get; set; }
        int BaudRate { get; set; }
        int DataBits { get; set; }

        bool Connect();
        void Disconnect();
    }
}