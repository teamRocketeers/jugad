﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;
public sealed class Wallpaper
{
    const int SPI_SETDESKWALLPAPER = 20;
    const int SPIF_UPDATEINIFILE = 0x01;
    const int SPIF_SENDWININICHANGE = 0x02;

    private static string WallpaperStyle = "";
    private static string WallpaperFileName = "";
    private static string TileWallpaper = "";
    public static string BackGround = "";
    public static bool Switched = false;

    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

    public enum Style : int
    {
        Tiled,
        Centered,
        Stretched
    }

    public static void SaveWallpaper()
    {
        RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);
        WallpaperStyle = key.GetValue(@"WallpaperStyle", "").ToString();
        WallpaperFileName = key.GetValue(@"Wallpaper", "").ToString();
        TileWallpaper = key.GetValue(@"TileWallpaper", "").ToString();
        key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Colors", true);
        BackGround = key.GetValue(@"BackGround", "").ToString();
    }

    public static void SetWallpaper()
    {
        if (WallpaperStyle.Length == 0) return; 
        Switched = true;
        RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);
        key.SetValue("Wallpaper", "");
        key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Colors", true);
        key.SetValue("BackGround", "0 0 0");
        SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, "", SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
    }

    public static void RestoreWallpaper()
    {
        if (WallpaperStyle.Length == 0 || !Switched) return;
        RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);
        key.SetValue("WallpaperStyle", WallpaperStyle);
        key.SetValue("Wallpaper", WallpaperFileName);
        key.SetValue("TileWallpaper", TileWallpaper);
        key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Colors", true);
        key.SetValue("BackGround", BackGround);
        SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, WallpaperFileName, SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
        Switched = true;
    }
}