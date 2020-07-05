using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FunkyFr3sh.Dune2000
{
    public class UibFile
    {
        public string FilePath;
        public List<string> Items = new List<string>();

        public UibFile(string filePath)
        {
            FilePath = filePath;
            readUib();
        }

        private void readUib()
        {
            if (!File.Exists(FilePath)) return;
            using (var fileStream = new FileStream(FilePath, FileMode.Open, FileAccess.Read))
            {
                fileStream.Position = 3;
                int _Byte;
                while ((_Byte = fileStream.ReadByte()) != -1)
                {
                    if (fileStream.Position == fileStream.Length) break;
                    string value = "";
                    byte[] buffer = new byte[2];
                    fileStream.Read(buffer, 0, buffer.Length);
                    UInt16 stringLength = BitConverter.ToUInt16(buffer, 0);
                    stringLength -= 1;
                    if (stringLength > 0)
                    {
                        byte[] byteValue = new byte[stringLength];
                        fileStream.Read(byteValue, 0, byteValue.Length);
                        value = Encoding.Default.GetString(byteValue);
                    }
                    Items.Add(value);
                }
            }
        }

        public void AddBlanks(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Items.Add("");
                Items.Add("");
            }
        }

        public void SetValue(string key, string value)
        {
            for (int i = 0; i < Items.Count; i += 2)
            {
                if (Items[i].ToLower() == key.ToLower())
                {
                    Items[i] = key;
                    Items[i + 1] = value;
                    return;
                }
            }
            Items.Add(key);
            Items.Add(value);
        }

        public string GetValue(string key, string defaultValue)
        {
            for (int i = 0; i < Items.Count; i += 2)
            {
                if (Items[i].ToLower() == key.ToLower()) return Items[i + 1];
            }
            return defaultValue;
        }

        public void WriteUib()
        {
            using (var fileStream = new FileStream(FilePath, FileMode.Create, FileAccess.Write))
            {
                byte[] bytes = BitConverter.GetBytes((UInt16)(Items.Count / 2));
                fileStream.Write(bytes, 0, bytes.Length);
                fileStream.WriteByte(0x00);
                for (int i = 0; i < Items.Count; i++)
                {
                    fileStream.WriteByte(0x00);
                    bytes = BitConverter.GetBytes((UInt16)(Items[i].Length + 1));
                    fileStream.Write(bytes, 0, bytes.Length);
                    bytes = Encoding.Default.GetBytes(Items[i]);
                    fileStream.Write(bytes, 0, bytes.Length);
                }
                fileStream.WriteByte(0x00);
            }
        }

    }
}
