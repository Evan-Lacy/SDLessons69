using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Room
    {

        private float _minLength = 1.0f;
        private float _minWidth = 1.0f;
        private float _minHeigth = 1.0f;
        private float _maxLength = 999.0f;
        private float _maxWidth = 999.0f;
        private float _maxHeigth = 999.0f;

        private float _length;
        private float _width;
        private float _height;

        public float Length { 
            get { return _length; } 
            set 
            {
                if(value > _minLength && value < _maxLength)
                {
                    _length = value;
                } else
                {
                    throw new ArgumentException("Length is outstide valid range");
                }
                
            } 
        }

        public float Width {
            get { return _width; }
            set 
            {
                if(value > _minWidth && value < _maxWidth)
                {
                    _width = value;
                }
                else
                {
                    throw new ArgumentException("Width is outstide valid range");
                }

            }
        }

        public float Height {
            get { return _height; }
            set
            {
                if (value > _minHeigth && value < _maxHeigth)
                {
                    _height = value;
                }
                else
                {
                    throw new ArgumentException("Height is outstide valid range");
                }

            }
        }

        //Access Modifer, return type, signature
        //1     2       3
        public float GetSurfaceArea()
        {
            //4 - body
            return 2 * Length + Height + 2 * Length * Width + 2 * Width * Height;
        }
    }
}
