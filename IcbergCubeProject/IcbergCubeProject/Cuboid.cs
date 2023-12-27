using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IcbergCubeProject
{
    public class Cuboid
    {
        public bool[] Care { get; set; }
        public DimAggregate[] Aggregates { get; set; }

        private int _index = -1;
        public int Index
        {
            get
            {
                if (_index < 0)
                {
                    _index = 0;
                    for (int i = 0; i < Care.Length; i++)
                    {
                        _index += (Care[i] ? 1 : 0) * (Convert.ToInt32(Math.Pow(2, i)));
                    }
                }

                return _index;
            }
        }
    }

    public class DimAggregate
    {
        public bool[] Presentation { get; set; }
        public int Aggregate { get; set; }

        private int _index = -1;
        public int Index
        {
            get
            {
                if (_index < 0)
                {
                    _index = 0;
                    for (int i = 0; i < Presentation.Length; i++)
                    {
                        _index += (Presentation[i] ? 1 : 0) * (Convert.ToInt32(Math.Pow(2, i)));
                    }
                }

                return _index;
            }
        }
    }
}
