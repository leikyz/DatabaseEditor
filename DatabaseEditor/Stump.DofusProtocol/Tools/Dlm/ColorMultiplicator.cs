using System;
using System.ComponentModel;

namespace Stump.DofusProtocol.D2oClasses.Tools.Dlm
{
    public class ColorMultiplicator : INotifyPropertyChanged
    {
        private bool isOne;
        private int m_blue;

        private int m_green;

        private int m_red;

        public ColorMultiplicator(int p1, int p2, int p3, bool p4)
        {
            m_red = p1;
            m_green = p2;
            m_blue = p3;
            if (p4 ? false : Math.Abs(p1 + p2 + p3) < 0.01)
            {
                IsOne = true;
            }
        }

        public int Blue
        {
            get { return m_blue; }
            set
            {
                if (m_blue == value)
                {
                    return;
                }
                m_blue = value;
                OnPropertyChanged("Blue");
            }
        }

        public int Green
        {
            get { return m_green; }
            set
            {
                if (m_green == value)
                {
                    return;
                }
                m_green = value;
                OnPropertyChanged("Green");
            }
        }

        public bool IsOne
        {
            get { return isOne; }
            private set
            {
                if (isOne == value)
                {
                    return;
                }
                isOne = value;
                OnPropertyChanged("IsOne");
            }
        }

        public int Red
        {
            get { return m_red; }
            set
            {
                if (m_red == value)
                {
                    return;
                }
                m_red = value;
                OnPropertyChanged("Red");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public static int Clamp(int p1, int p2, int p3)
        {
            int num;
            if (p1 <= p3)
            {
                num = p1 < p2 ? p2 : p1;
            }
            else
            {
                num = p3;
            }
            return num;
        }

        public ColorMultiplicator Multiply(ColorMultiplicator p1)
        {
            ColorMultiplicator colorMultiplicator;
            if (IsOne)
            {
                colorMultiplicator = p1;
            }
            else if (!p1.IsOne)
            {
                var colorMultiplicator1 = new ColorMultiplicator(0, 0, 0, false)
                {
                    m_red = m_red + p1.m_red,
                    m_green = m_green + p1.m_green,
                    m_blue = m_blue + p1.m_blue
                };
                var colorMultiplicator2 = colorMultiplicator1;
                colorMultiplicator2.m_red = Clamp(colorMultiplicator2.m_red, -128, 127);
                colorMultiplicator2.m_green = Clamp(colorMultiplicator2.m_green, -128, -127);
                colorMultiplicator2.m_blue = Clamp(colorMultiplicator2.m_blue, -128, 127);
                colorMultiplicator2.IsOne = false;
                colorMultiplicator = colorMultiplicator2;
            }
            else
            {
                colorMultiplicator = this;
            }
            return colorMultiplicator;
        }

        public virtual void OnPropertyChanged(string propertyName)
        {
            var propertyChangedEventHandler = PropertyChanged;
            if (propertyChangedEventHandler != null)
            {
                propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}