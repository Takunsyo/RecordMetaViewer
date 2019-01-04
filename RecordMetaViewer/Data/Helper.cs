using System.IO;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System.Reflection;
using System.IO.Pipes;
using System.Diagnostics;
using System.Drawing;

namespace RecordMetaViewer.Data
{
    public static class Helper
    {
        /// <summary>
        /// Get audio componet type string.
        /// </summary>
        public static string GetAudioComponentTypeString(int type)
        {
            switch (type)
            {
                case 0b00001: return "1/0Mode(Single mono)";
                case 0b00010: return "1/0 + 1/0Mode(Dual mono)";
                case 0b00011: return "2/0Mode(Stereo)";
                case 0b00100: return "2/1Mode";
                case 0b00101: return "3/0Mode";
                case 0b00110: return "2/2Mode";
                case 0b00111: return "3/1Mode";
                case 0b01000: return "3/2Mode";
                case 0b01001: return "3/2 + LFEMode(3/2.1Mode)";
                case 0b01010: return "3/3.1Mode";
                case 0b01011: return "2/0/0-2/0/2-0.1Mode";
                case 0b01100: return "5/2.1Mode";
                case 0b01101: return "3/2/2.1Mode";
                case 0b01110: return "2/0/0-3/0/2-0.1Mode";
                case 0b01111: return "0/2/0-3/0/2-0.1Mode";
                case 0b10000: return "2/0/0-3/2/3-0.2Mode";
                case 0b10001: return "3/3/3-5/2/3-3/0/0.2Mode";
                case 0b00000:
                case int i when (i >= 0b10010) && (i <= 0b11111):
                    return "Reserved";
                default: return "Illegal Vaule";
            }
        }

        /// <summary>
        /// Get video componet type string.
        /// </summary>
        public static string GetVideoComponentTypeString(int type)
        {
            switch (type)
            {
                case 0x01: return "480i(525i), 4:3";
                case 0x02: return "480i(525i), 16:9 With Side Panel";
                case 0x03: return "480i(525i), 16:9 No Side Panel";
                case 0x04: return "480i(525i),  > 16:9";
                case 0x83: return "4320p, 16:9";
                case 0x91: return "2160p, 4:3";
                case 0x92: return "2160p, 16:9 With Side Panel";
                case 0x93: return "2160p, 16:9 No Side Panel";
                case 0x94: return "2160p,  > 16:9";
                case 0xA1: return "480p(525p), 4:3";
                case 0xA2: return "480p(525p), 16:9 With Side Panel";
                case 0xA3: return "480p(525p), 16:9 No Side Panel";
                case 0xA4: return "480p(525p),  > 16:9";
                case 0xB1: return "1080i(1125i), 4:3";
                case 0xB2: return "1080i(1125i), 16:9 With Side Panel";
                case 0xB3: return "1080i(1125i), 16:9 No Side Panel";
                case 0xB4: return "1080i(1125i),  > 16:9";
                case 0xC1: return "720p(750p), 4:3";
                case 0xC2: return "720p(750p), 16:9 With Side Panel";
                case 0xC3: return "720p(750p), 16:9 No Side Panel";
                case 0xC4: return "720p(750p),  > 16:9";
                case 0xD1: return "240p 4:3";
                case 0xD2: return "240p 16:9 With Side Panel";
                case 0xD3: return "240p 16:9 No Side Panel";
                case 0xD4: return "240p  > 16:9";
                case 0xE1: return "1080p(1125p), 4:3";
                case 0xE2: return"1080p(1125p), 16:9 With Side Panel";
                case 0xE3: return "1080p(1125p), 16:9 No Side Panel";
                case 0xE4: return "1080p(1125p),  > 16:9";
                case 0xF1: return "180p 4:3";
                case 0xF2: return "180p 16:9 With Side Panel";
                case 0xF3: return "180p 16:9 No Side Panel";
                case 0xF4: return "180p  > 16:9";
                default: return "Illegal Vaule";
            }
        }
        
        /// <summary>
        /// Get audio sampling rate string from sampling rate numbers.
        /// </summary>
        public static string GetAudioSamplingRateString(int value)
        {
            switch (value)
            {
                case 16000:return "16kHz";
                case 22050:return "22.05kHz";
                case 24000:return "24kHz";
                case 32000:return "32kHz";
                case 44100:return "44.1kHz";
                case 48000:return "48kHz";
                default:return value.ToString();
            }
        }

        /// <summary>
        /// Append an array after another array.
        /// </summary>
        /// <typeparam name="T">Array collection <see cref="Type"/>.</typeparam>
        /// <param name="source">Base array, index from 0.</param>
        /// <param name="array">Second array, index after base array's last item.</param>
        /// <returns>A full array.</returns>
        public static T[] AppendArray<T>(this T[] source, T[] array)
        {
            if (source is null & array is null) return null;
            if (source is null) return array;
            if (array is null) return source;
            int ltmp = source.Length;
            var tmp = source;
            Array.Resize(ref tmp, ltmp + array.Length);
            Array.Copy(array, 0, tmp, ltmp, array.Length);
            return tmp;
        }

        /// <summary>
        /// Get a UNIX Timestamp from a specific DateTime object.
        /// <para>*TimeStamp is counted in milliseconds.</para>
        /// </summary>
        public static long GetUNIXTimeStamp(DateTime time) =>
            (long)(time.ToUniversalTime().Subtract(new DateTime(1970, 1, 1))).TotalMilliseconds;
        
        /// <summary>
        /// Get current time UNIX Timestamp.
        /// <para>*TimeStamp is counted in milliseconds.</para>
        /// </summary>
        public static long GetUNIXTimeStamp() =>
            GetUNIXTimeStamp(DateTime.Now);

        /// <summary>
        /// Get a <see cref="DateTime"/> object from a UNIX TimeStamp.
        /// </summary>
        /// <param name="UNIXTimeStamp">The TimeStamp are Mirakurun server is using counted in milliseconds.</param>
        /// <returns></returns>
        public static DateTime GetDateTime(long UNIXTimeStamp)=>
            new DateTime(1970, 1, 1).AddMilliseconds(UNIXTimeStamp);
        
        /// <summary>
        /// Initialize <see cref="Channel"/>s data from channel perfix data.
        /// </summary>
        public static IEnumerable<Channel> GetChannels()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ChannelPrefix.json");
            if (File.Exists(path))
            {
                var prefexStr = "";
                using (var reader = File.OpenText(path))
                {
                    prefexStr = reader.ReadToEnd();
                }
                if (!string.IsNullOrWhiteSpace(prefexStr))
                {
                    try
                    {
                        return JsonConvert.DeserializeObject<IEnumerable<Channel>>(prefexStr);
                    }
                    catch
                    {
                    }
                }
            }
            var Str = Properties.Resources.ChannelPrefix;
            return JsonConvert.DeserializeObject<IEnumerable<Channel>>(Str);
        }

        /// <summary>
        /// A <see cref="Channel"/> object list. need to be initialized by <see cref="GetChannels"/> method.
        /// </summary>
        public static IEnumerable<Channel> Channels { get; set; }

        /// <summary>
        /// Get a <see cref="Channel"/> object from <see cref="Channels"/>.
        /// </summary>
        /// <param name="id">Channel id.</param>
        /// <returns>A <see cref="Channel"/> object.</returns>
        public static string GetChannelName(long id)=> 
            Channels.First(x => x.id == id)?.name;

        /// <summary>
        /// Get description string defined by <see cref="DescriptionAttribute"/> 
        /// attribute from an <see cref="Enum"/> object.
        /// </summary>
        /// <param name="value">An <see cref="Enum"/> value.</param>
        /// <returns>The string in <see cref="EnumDescriptionAttribute.Description"/> if 
        /// an <see cref="EnumDescriptionAttribute"/> is present.</returns>
        public static string GetDescription(this Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            EnumDescriptionAttribute[] attributes =(EnumDescriptionAttribute[])fi?.
                GetCustomAttributes(typeof(EnumDescriptionAttribute),false);

            if (attributes != null &&attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }

        /// <summary>
        /// Get an <see cref="EnumDescriptionAttribute"/> object from an <see cref="Enum"/> object. 
        /// </summary>
        /// <param name="value">An <see cref="Enum"/> value.</param>
        /// <returns>An <see cref="EnumDescriptionAttribute"/> object associated to input value.</returns>
        public static EnumDescriptionAttribute GetAttribute(this Enum value)=>
            ((EnumDescriptionAttribute[])value.GetType().GetField(value.ToString())?.
            GetCustomAttributes(typeof(EnumDescriptionAttribute), false))?.First();
        

        /// <summary>
        /// Get description string defined by <see cref="EnumDescriptionAttribute"/> 
        /// attribute from an <see cref="Enum"/> in <see cref="int"/> form.
        /// </summary>
        /// <typeparam name="E">Type must be an <see cref="Enum"/> type.</typeparam>
        /// <param name="val">A <see cref="Enum"/> value in <see cref="int"/> form.</param>
        /// <returns>The string in <see cref="EnumDescriptionAttribute.Description"/> if 
        /// an <see cref="EnumDescriptionAttribute"/> is present.</returns>
        public static string GetDescription<E>(this int val) where E : Enum => 
            (((E)(object)val)as Enum).GetDescription();

        /// <summary>
        /// Get description string defined by <see cref="EnumDescriptionAttribute"/>
        /// attribute from an <see cref="Enum"/> in <see cref="int"/> form.
        /// </summary>
        /// <param name="val">An <see cref="Enum"/> value in <see cref="int"/> form.</param>
        /// <param name="root">Associated root <see cref="Enum"/> object. </param>
        /// <returns>The string in <see cref="EnumDescriptionAttribute.Description"/> if 
        /// an <see cref="EnumDescriptionAttribute"/> is present.</returns>
        public static string GetDescription(this int val,Enum root)
        {
            var rootDescription = root.GetAttribute();

            var value = Enum.ToObject(rootDescription.ConnectedEnumType, val);

            FieldInfo fi = rootDescription.ConnectedEnumType.GetField(value.ToString());

            EnumDescriptionAttribute[] attributes = (EnumDescriptionAttribute[])fi?.
                GetCustomAttributes(typeof(EnumDescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }

        /// <summary>
        /// Foreach extension method for <see cref="IEnumerable{T}"/> object using iterator.
        /// <para>*Faster then foreach statement in certen instance.</para>
        /// </summary>
        /// <typeparam name="T">Input collection <see cref="Type>"/></typeparam>
        /// <typeparam name="TResult">Return collection <see cref="Type"/></typeparam>
        /// <param name="input">Input collection.</param>
        /// <param name="func">Delegation for the foreach statement.</param>
        /// <returns>A collection processed by <see cref="Func{T, TResult}"/> paramater in a foreach style.</returns>
        public static IEnumerable<TResult> ForEach<T, TResult>(this IEnumerable<T> input, Func<T, TResult> func)
        {
            if (input is null || func is null) yield break;
            foreach (T item in input) yield return func(item);
        }

        /// <summary>
        /// Foreach extension method for <see cref="IEnumerable{T}"/> object using iterator.
        /// <para>*Faster then foreach statement in certen instance.</para>
        /// </summary>
        /// <typeparam name="T">Collection <see cref="Type"/>.</typeparam>
        /// <param name="input">Input collection.</param>
        /// <param name="action">Delegation for the foreach statement.</param>
        /// <returns>A collection process by <see cref="Action{T}"/> paramater in a foreach style.</returns>
        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> input, Action<T> action)
        {
            if (input is null || action is null) yield break;
            foreach (T item in input)
            {
                action(item);
                yield return item;
            }
        }

        public static readonly string FFMpegPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ffmpeg.exe");

        public static Image GetThumbnail(string path)
        {
            string ffcmd = $@"-i ""{path}"" -ss 00:03:00 -s 480x270 -t 1 -f mjpeg pipe:1";

            var ffProcess = new Process()
            {
                StartInfo = new ProcessStartInfo()
                {
                    FileName = FFMpegPath,
                    Arguments = ffcmd,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    UseShellExecute = false,
                    RedirectStandardOutput = true
                }
            };
            ffProcess.Start();
            var result = Image.FromStream(ffProcess.StandardOutput.BaseStream);
            ffProcess.WaitForExit();
            return result;
        }
    }
}

