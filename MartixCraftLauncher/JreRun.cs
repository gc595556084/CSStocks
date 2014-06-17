using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MartixCraftLauncher
{
    public class JreRun
    {
        public bool IsRunning;
        public static string Mainjar;
        public static string VersionDic;
        public static string MainDic;
        public static string NetDic;
        public static string LibDic;
        public static string NativeDic;
        public static string AssetDic;
        public static void Run1(string username)
        {
            LibDic = System.IO.Directory.GetCurrentDirectory() + "\\.minecraft\\libraries\\";
            NetDic = System.IO.Directory.GetCurrentDirectory() + "\\.minecraft\\libraries\\net\\";
            MainDic = System.IO.Directory.GetCurrentDirectory() + "\\.minecraft\\";
            MainDic = System.IO.Directory.GetCurrentDirectory() + "\\.minecraft\\assets";
            NativeDic = System.IO.Directory.GetCurrentDirectory() + "\\.minecraft\\version\\MartixCraft\\MartixCraft-natives\\";
            VersionDic = System.IO.Directory.GetCurrentDirectory() + "\\.minecraft\\version\\Martixcraft\\";
            Mainjar = System.IO.Directory.GetCurrentDirectory() + "\\.minecraft\\version\\Martixcraft\\Martixcraft.jar";
            username = MainWindow.b;
            Process p = new Process();
            p.StartInfo.FileName = "javaw.exe";           //設定程序名  
            p.StartInfo.Arguments = Mainjar + " -Xincgc -Xmx" + MainWindow.a + " -Djava.library.path=" + NativeDic + " -Dfml.ignoreInvalidMinecraftCertificates=true -Dfml.ignorePatchDiscrepancies=true -Dsun.java2d.noddraw=true -Dsun.java2d.pmoffscreen=false -Dsun.java2d.d3d=false -Dsun.java2d.opengl=false -cp=" + NetDic + "minecraftforge\\minecraftforge\\9.11.1.965\\minecraftforge-9.11.1.965.jar;" + NetDic + "\\minecraft\\launchwrapper\\1.8\\launchwrapper-1.8.jar;" + LibDic + "org\\scala-lang\\scala-library\\2.10.2\\scala-library-2.10.2.jar;" + LibDic + "org\\scala-lang\\scala-compiler\\2.10.2\\scala-compiler-2.10.2.jar;" + LibDic + "lzma\\lzma\\0.0.1\\lzma-0.0.1.jar;" + LibDic + "net\\sf\\jopt-simple\\jopt-simple\\4.5\\jopt-simple-4.5.jar;" + LibDic + "com\\paulscode\\codecjorbis\\20101023\\codecjorbis-20101023.jar;" + LibDic + "com\\paulscode\\codecwav\\20101023\\codecwav-20101023.jar;" + LibDic + "com\\paulscode\\libraryjavasound\\20101123\\libraryjavasound-20101123.jar;" + LibDic + "com\\paulscode\\librarylwjglopenal\\20100824\\librarylwjglopenal-20100824.jar;" + LibDic + "com\\paulscode\\soundsystem\\20120107\\soundsystem-20120107.jar;" + LibDic + "argo\\argo\\2.25_fixed\\argo-2.25_fixed.jar;" + LibDic + "org\\bouncycastle\\bcprov-jdk15on\\1.47\\bcprov-jdk15on-1.47.jar;" + LibDic + "com\\google\\guava\\guava\\14.0\\guava-14.0.jar;" + LibDic + "org\\apache\\commons\\commons-lang3\\3.1\\commons-lang3-3.1.jar;" + LibDic + "commons-io\\commons-io\\2.4\\commons-io-2.4.jar;" + LibDic + "net\\java\\jinput\\jinput\\2.0.5\\jinput-2.0.5.jar;" + LibDic + "net\\java\\jutils\\jutils\\1.0.0\\jutils-1.0.0.jar;" + LibDic + "com\\google\\code\\gson\\gson\\2.2.2\\gson-2.2.2.jar;" + LibDic + "org\\lwjgl\\lwjgl\\lwjgl\\2.9.0\\lwjgl-2.9.0.jar;" + LibDic + "org\\lwjgl\\lwjgl\\lwjgl_util\\2.9.0\\lwjgl_util-2.9.0.jar;" + LibDic + "org\\lwjgl\\lwjgl\\lwjgl-platform\\2.9.0\\lwjgl-platform-2.9.0-natives-windows.jar;" + LibDic + "net\\java\\jinput\\jinput-platform\\2.0.5\\jinput-platform-2.0.5-natives-windows.jar;" + Mainjar + " -mainClass=net.minecraft.launchwrapper.Launch --username " + username + " --session no --version MartixCraft --gameDir " + MainDic + " --assetsDir " + AssetDic + " --tweakClass cpw.mods.fml.common.launcher.FMLTweaker -ver16 -name=MartixCraft -windowSize=854x480 -gameDir=" + Mainjar + " -notMove";
            p.StartInfo.UseShellExecute = false;        //關閉Shell的使用  
            p.Start();    //啟動
        }
    }
}
