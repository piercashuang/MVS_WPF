namespace MVS.Ui.Models {
    public class MvsGlobal {
        private static MvsGlobal _instance;
        public static MvsGlobal Instance => _instance ??= new MvsGlobal();
        public string CurrentVersion { get; set; } = "V1.0.0";
    }
}
