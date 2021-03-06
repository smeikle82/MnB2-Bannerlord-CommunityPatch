using System.ComponentModel;
using System.Runtime.InteropServices;


namespace Antijank.Debugging {

  [ComImport]
  [ComConversionLoss]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("41BD395D-DE99-48F1-BF7A-CC0F44A6D281")]
  
  public interface ICorDebugDebugEvent {

    [return: Description("pDebugEventKind")]
    CorDebugDebugEventKind GetEventKind();

    [return: MarshalAs(UnmanagedType.Interface)] [return: Description("ppThread")]
    ICorDebugThread GetThread();

  }

}