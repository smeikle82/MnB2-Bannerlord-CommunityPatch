using System.Runtime.InteropServices;
using JetBrains.Annotations;

namespace Antijank.Interop {

  [PublicAPI]
  [ComImport]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("CD45F185-1B21-48E2-967B-EAD743A8914E")]
  public interface IZoneIdentifier {

    UrlZone GetId();

    void SetId(UrlZone id);

    void Remove();

  }

}