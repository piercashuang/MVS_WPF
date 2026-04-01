using System;
using System.Collections.Generic;
using System.Linq;

namespace MVS.Contract.Camera
{
    public class CameraStatus
    {
        // 1. 定义属性：ID、名称、描述、以及用于 UI 显示的颜色 (十六进制)
        public int Id { get; }
        public string Name { get; }
        public string Description { get; }
        public string HexColor { get; }

        // 2. 私有构造函数
        private CameraStatus(int id, string name, string description, string hexColor)
        {
            Id = id;
            Name = name;
            Description = description;
            HexColor = hexColor;
        }

        // 3. 静态实例：定义所有可能的相机状态
        public static readonly CameraStatus Offline = new CameraStatus(0, "Offline", "离线", "#FF808080"); // 灰色
        public static readonly CameraStatus Idle = new CameraStatus(1, "Idle", "空闲", "#FF00FF00");    // 绿色
        public static readonly CameraStatus Running = new CameraStatus(2, "Running", "正在采集", "#FF007ACC"); // 蓝色
        public static readonly CameraStatus Error = new CameraStatus(3, "Error", "故障", "#FFFF0000");   // 红色

        // 4. 逻辑判断辅助属性
        public bool IsAvailable => this == Idle || this == Running;

        // 5. 集合操作
        public static IEnumerable<CameraStatus> GetAll() =>
            new[] { Offline, Idle, Running, Error };

        public static CameraStatus FromId(int id) =>
            GetAll().FirstOrDefault(x => x.Id == id) ?? Offline;

        public override string ToString() => Description;
    }
}