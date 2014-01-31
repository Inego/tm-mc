using System.Collections.Generic;
using System.Drawing;


namespace TM_MC
{

    public class TerrainType
    {
        public string name;
        public int code;
        public Color color;
        public Color color2;
        public Pen pen;
        public Brush brush;
        public Brush brush2;

        private static List<TerrainType> list = null;

        private TerrainType(string name, int code, string color, string color2)
        {
            this.name = name;
            this.code = code;
            this.color = ColorTranslator.FromHtml(color);
            this.pen = new Pen(this.color);
            this.brush = new SolidBrush(this.color);
        }

        static TerrainType()
        {

            list = new List<TerrainType>();

            list.Add(new TerrainType("None", 0, "#ffffff", "#ffffff"));
            list.Add(new TerrainType("Plains", 1, "#b08040", "#a06040"));
            list.Add(new TerrainType("Swamp", 2, "#404040", "#000000"));
            list.Add(new TerrainType("Lakes", 3, "#60c0f0", "#2080f0"));
            list.Add(new TerrainType("Forest", 4, "#80f080", "#40a040"));
            list.Add(new TerrainType("Mountains", 5, "#c0c0c0", "#808080"));
            list.Add(new TerrainType("Wasteland", 6, "#f08080", "#e04040"));
            list.Add(new TerrainType("Desert", 7, "#f0f080", "#e0e040"));

        }

        public static TerrainType byCode(int i)
        {
            return list[i];
        }

        public static TerrainType byChar(char c)
        {
            return list[TerrainCode(c)];
        }


        static int TerrainCode(char c)
        {
            switch (c)
            {
                case 'P':
                    return 1;
                case 'S':
                    return 2;
                case 'L':
                    return 3;
                case 'F':
                    return 4;
                case 'M':
                    return 5;
                case 'W':
                    return 6;
                case 'D':
                    return 7;
            }

            return 0;

        }


    }



}