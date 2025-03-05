using lab;
class Program
{
    static void Main()
    {
        //AccountControl DRM = new AccountControl();
        //DRM.CreateUsername();
        //DRM.CreatePassword();
        //DRM.DRM();
        string strCmdText;
        strCmdText = "shutdown /s /t 0";
        System.Diagnostics.Process.Start("CMD.exe", strCmdText);
    }
}