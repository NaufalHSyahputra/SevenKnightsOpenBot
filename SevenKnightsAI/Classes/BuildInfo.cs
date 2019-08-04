using System;
using System.IO;
using System.Reflection;

namespace SevenKnightsAI.Classes
{
    internal static class BuildInfo
    {
        public static DateTime GetLinkerTime(this Assembly assembly, TimeZoneInfo target = null)
        {
            string filePath = assembly.Location;
            const int c_PeHeaderOffset = 60;
            const int c_LinkerTimestampOffset = 8;

            byte[] buffer = new byte[2048];

            using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                stream.Read(buffer, 0, 2048);
            }

            int offset = BitConverter.ToInt32(buffer, c_PeHeaderOffset);
            int secondsSince1970 = BitConverter.ToInt32(buffer, offset + c_LinkerTimestampOffset);
            DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

            DateTime linkTimeUtc = epoch.AddSeconds(secondsSince1970);

            TimeZoneInfo tz = target ?? TimeZoneInfo.Local;
            DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(linkTimeUtc, tz);

            return localTime;
        }
    }
}