using System;
using MVS.Contract.Camera;

namespace MVS.Camera.Hik
{
    public class HikCameraFactory : ICameraFactory
    {
        public string Name => "Hikvision Camera Factory";
        public string Version => "1.0.0";

        // 已经不需要在这里写扫描逻辑了

        public ICamera CreateCamera(CameraMetaInfo info)
        {
            // 直接根据传入的元信息，实例化控制类
            // return new HikCamera(info.SerialNumber);
            throw new NotImplementedException("这里写具体的 new HikCamera 逻辑");
        }
    }
}