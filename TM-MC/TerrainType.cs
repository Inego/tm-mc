using System.Collections.Generic;


namespace TM_MC
{

    public class TerrainType
    {
        public string name;
        public int code;

        private static List<TerrainType> list = null;

        private TerrainType(string name, int code)
        {
            this.name = name;
            this.code = code;
        }

        static TerrainType()
        {

            list = new List<TerrainType>();

            list.Add(new TerrainType("None",      0));       
            list.Add(new TerrainType("Plains",    1));       
            list.Add(new TerrainType("Swamp",     2));        
            list.Add(new TerrainType("Lakes",     3));        
            list.Add(new TerrainType("Forest",    4));       
            list.Add(new TerrainType("Mountains", 5));    
            list.Add(new TerrainType("Wasteland", 6));    
            list.Add(new TerrainType("Desert",    7));       

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