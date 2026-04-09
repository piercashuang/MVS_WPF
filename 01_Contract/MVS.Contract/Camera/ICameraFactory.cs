using System.Collections.Generic;

namespace MVS.Contract.Camera
{
    public interface ICameraFactory
    {
        string Name { get; }
        string Version { get; }

        // 【删除】List<CameraMetaInfo> ScanCameras(); 

        ICamera CreateCamera(CameraMetaInfo info);
    }
}