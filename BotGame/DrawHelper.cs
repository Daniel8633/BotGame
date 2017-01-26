using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BotGame
{
    static class DrawHelper
    {
        public static Texture2D createRectangle(int width, int height, bool fill = true)
        {
            Texture2D t = new Texture2D(Application.Instance.GraphicsDevice, height, width);

            Color[] data = new Color[width * height];

            if (fill)
            {
                for (int i = 0; i < data.Length; i++)
                    data[i] = Color.White;
            }
            else
            {
                
                for (int x = 0; x < width; x++)
                {
                    for (int y = 0; y < height; y++)
                    {
                        Color c = Color.Transparent;

                        if (x == 0)
                            c = Color.White;
                        if (x == height - 1)
                            c = Color.White;
                        if (y == 0)
                            c = Color.White;
                        if (y == width - 1)
                            c = Color.White;

                        data[x + y * width] = c;
                    }
                }
            }

            t.SetData(data);

            return t;
        }

    }
}
