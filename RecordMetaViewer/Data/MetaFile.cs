using System;
using System.Drawing;
using System.IO;

namespace RecordMetaViewer.Data
{
    public class MetaFile
    {
        public Program Meta
        {
            get
            {
                return Program.Deserialize(this.mMeta);
            }
            private set
            {
                this.mMeta = value.Serialize();
            }
        }

        private byte[] mMeta { get; set; }

        internal byte[] mLogo { get;}

        public Image Logo
        {
            get
            {
                using (MemoryStream st = new MemoryStream())
                {
                    if (mLogo == null || mLogo.Length <= 0) return null;
                    st.Write(mLogo, 0, mLogo.Length);
                    return Image.FromStream(st);
                }
            }
        }

        internal byte[] mThumb { get; private set; }

        public void SetThumbImage(byte[] image) => mThumb = image;

        public Image ThumbImage
        {
            get
            {
                using (MemoryStream st = new MemoryStream())
                {
                    if (mThumb == null || mThumb.Length <= 0) return null;
                    st.Write(mThumb, 0, mThumb.Length);
                    return Image.FromStream(st);
                }
            }
            set
            {
                using(MemoryStream st = new MemoryStream())
                {
                    if (value == null) mThumb = null;
                    value.Save(st, System.Drawing.Imaging.ImageFormat.Png);
                    mThumb = st.ToArray();
                }
            }
        }

        private static readonly byte[] m_head = new byte[] { 0x54, 0x56, 0x41, 0x46 }; //TVAF in ASCII

        private byte[] Header
        {
            get
            {
                int req = (this.mMeta.Length << 12) + (this.mLogo == null ? 0 : this.mLogo.Length);
                var tmp = BitConverter.GetBytes(req);
                //Here have 1 byte for futher dev.
                return m_head.AppendArray(tmp);
            }
        }

        internal byte[] Body
        {
            get
            {
                var tmp = this.mMeta.AppendArray(mLogo);
                return tmp.AppendArray(mThumb);
            }
        }

        public MetaFile(byte[] jMeta, byte[] cLogo, byte[] thumb)
        {
            this.mMeta = jMeta;
            this.mLogo = cLogo;
            this.mThumb = thumb;
        }
        
        internal byte[] GetBytes()
        {
            return this.Header.AppendArray(Body);
        }

        internal protected static MetaFile ReadByte(byte[] data)
        {
            for (int i = 0; i <= 3; i++)
            {
                if (!(data[i].Equals(m_head[i])))
                {
                    return null;
                }
            }
            int offset = 8;
            var tmp = BitConverter.ToInt32(data, 4);
            tmp = tmp & 0xFFFFFF;
            int MetaLength = tmp >> 12;
            int LogoLength = tmp & 0xFFF;
            byte[] Meta = new byte[MetaLength];
            byte[] Logo = new byte[LogoLength];
            Array.Copy(data, offset, Meta, 0, MetaLength);
            offset += MetaLength;
            Array.Copy(data, offset, Logo, 0, LogoLength);
            offset += LogoLength;
            int ThumbLength = data.Length - offset;
            byte[] Thumb = new byte[ThumbLength];
            Array.Copy(data, offset, Thumb, 0, ThumbLength);
            var rep = new MetaFile(Meta, Logo, Thumb);
            return rep;
        }

        /// <summary>
        /// Write ".meta" file.
        /// </summary>
        /// <param name="path">full file path</param>
        /// <returns></returns>
        public bool WtiteFile(string path)
        {
            path = Path.GetExtension(path).ToLower() == (".meta") ? path : Path.Combine(Path.GetDirectoryName(path), Path.GetFileNameWithoutExtension(path) + ".meta");
            try
            {
                if (File.Exists(path))
                {
                    File.Move(path, path + ".old");
                }
            }
            catch
            {
                return false;
            }
            try
            {
                using (FileStream sw = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    var tmp = this.GetBytes();
                    sw.Write(tmp, 0, tmp.Length);
                }
                File.SetAttributes(path, File.GetAttributes(path) | FileAttributes.Hidden);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// Read ".meta" file to <see cref="EPGMetaFile"/> object.
        /// </summary>
        /// <param name="path">full file path.</param>
        /// <returns></returns>
        public static MetaFile ReadFile(string path)
        {
            if (File.Exists(path))
            {
                using (FileStream ssr = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    for (int i = 0; i <= 3; i++)
                    {
                        if (!(ssr.ReadByte()==(int)(m_head[i])))
                        {
                            return null;
                        }
                    }
                    byte[] head = new byte[4];
                    ssr.Read(head, 0, 4);
                    var tmp = BitConverter.ToInt32(head, 0);
                    tmp = tmp & 0xFFFFFF;
                    int MetaLength = tmp >> 12;
                    int LogoLength = tmp & 0xFFF;
                    byte[] Meta = new byte[MetaLength];
                    byte[] Logo = new byte[LogoLength];
                    int offset = 8;
                    ssr.Read(Meta, 0, MetaLength);
                    ssr.Read(Logo, 0, LogoLength);
                    int ThumbLength = (int)ssr.Length - offset;
                    byte[] Thumb = new byte[ThumbLength];
                    ssr.Read(Thumb, 0, ThumbLength);
                    var rep = new MetaFile(Meta, Logo, Thumb);
                    return rep;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
