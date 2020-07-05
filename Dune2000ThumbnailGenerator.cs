using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace MissionLauncher
{
    class Dune2000ThumbnailGenerator
    {
        const int ThinSpiceId = 1;
        const int ThikSpice2Id = 2;
        const int WormId = 20;
        const int SpawnId = 23;
        const int SpiceBloom1Id = 41;
        const int SpiceBloom2Id = 42;
        const int SpiceBloom3Id = 43;
        const int SpiceBloom4Id = 44;
        const int SpiceBloom5Id = 45;

        static Color SandColor = Color.FromArgb(235, 204, 146);
        static Color ClearGroundColor = Color.FromArgb(189, 115, 49);
        static Color SpiceColor = Color.FromArgb(247, 173, 82);
        static Color RockColor = Color.FromArgb(90, 41, 41);
        static Color BuildingColor = Color.Blue;
        static Color UnitColor = Color.Magenta;

        string fileName;

        public Dune2000ThumbnailGenerator(string fileName)
        {
            this.fileName = fileName;
        }

        public Bitmap GetBitmap()
        {
            Bitmap bitmap;

            using (var fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            using (var binaryReader = new BinaryReader(fileStream))
            {
                int mapWidth = binaryReader.ReadUInt16();
                int mapHeight = binaryReader.ReadUInt16();
                bitmap = new Bitmap(mapWidth, mapHeight);

                for (int y = 0; y < mapHeight; y++)
                {
                    for (int x = 0; x < mapWidth; x++)
                    {
                        int tile = binaryReader.ReadUInt16();
                        int overlay = binaryReader.ReadUInt16();

                        switch (overlay)
                        {
                            case WormId:
                                break;
                            case ThinSpiceId:
                            case ThikSpice2Id:
                            case SpiceBloom1Id:
                            case SpiceBloom2Id:
                            case SpiceBloom3Id:
                            case SpiceBloom4Id:
                            case SpiceBloom5Id:
                                bitmap.SetPixel(x, y, SpiceColor);
                                continue;
                            default:
                                break;
                        }

                        if ((overlay >= 4 && overlay <= 132) || (overlay >= 204 && overlay <= 332) || (overlay >= 404 && overlay <= 532) ||
                            (overlay >= 580 && overlay <= 597) || (overlay >= 620 && overlay <= 637) || (overlay >= 660 && overlay <= 676) ||
                            (overlay >= 700 && overlay <= 716)) bitmap.SetPixel(x, y, BuildingColor);
                        else if ((overlay >= 180 && overlay <= 194) || (overlay >= 360 && overlay <= 374) || (overlay >= 560 && overlay <= 574) ||
                            (overlay >= 598 && overlay <= 610) || (overlay >= 638 && overlay <= 652) || (overlay >= 677 && overlay <= 688) ||
                            (overlay >= 717 && overlay <= 728)) bitmap.SetPixel(x, y, UnitColor);
                        else if (tile >= 550 && tile < 600) bitmap.SetPixel(x, y, ClearGroundColor);
                        else if ((tile > 350 && tile < 550) || (tile > 104 && tile < 244) || tile > 600) bitmap.SetPixel(x, y, RockColor);
                        else bitmap.SetPixel(x, y, SandColor);
                    }
                }
            }

            int scaleFactor = 2;
            var result = new Bitmap(bitmap.Width * scaleFactor, bitmap.Height * scaleFactor);
            using (var graphics = Graphics.FromImage(result))
            {
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                graphics.DrawImage(bitmap, 0, 0, result.Width, result.Height);
            }
            bitmap.Dispose();

            return result;
        }


    }
}
