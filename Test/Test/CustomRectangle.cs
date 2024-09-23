using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Test.Form1;

namespace Test
{
    internal abstract class CustomRectangle
    {
        public int ID {get;}
        public abstract string Type { get; }
        public int X { get; set; }
        public int Y { get; set; }
        public virtual int Width { get; }  // 각 클래스에서 고정된 너비를 설정
        public virtual int Height { get; } // 각 클래스에서 고정된 높이를 설정
        public virtual Color FillColor { get; } // 각 클래스에서 고정된 색상 설정
        public int BorderWidth { get; set; } = 2;
        public List<CustomRectangle> Sensor { get; set; }
        // 자식 사각형을 추가하는 추상 메서드 (선언만)
        public abstract void AddChildRectangles(int count);
        public CustomRectangle(int x, int y)
        {
            X = x;
            Y = y;
            Sensor = new List<CustomRectangle>();
        }
        public CustomRectangle(int x, int y, int iD)
        {
            X = x;
            Y = y;
            Sensor = new List<CustomRectangle>(); // 자식 사각형 리스트 초기화
            ID = iD;
        }

        // 사각형을 그리는 메서드
        public virtual void Draw(Graphics g)
        {
            // 내부 색상 채우기
            using (Brush brush = new SolidBrush(FillColor))
            {
                g.FillRectangle(brush, X, Y, Width, Height);
            }

            using (Pen pen = new Pen(Color.Black, BorderWidth))
            {
                g.DrawRectangle(pen, X, Y, Width, Height);
            }

            // 자식 사각형 그리기
            foreach (var child in Sensor)
            {
                child.Draw(g);
            }
        }


    }
    internal class Sensor : CustomRectangle
    {
        private const int FixedChildWidth = 7;
        private const int FixedChildHeight = 7;
        private static readonly Color FixedChildColor = Color.Green; // 자식 사각형 색상

        public Sensor(int x, int y) : base(x, y) { }

        // 자식 사각형의 고정된 너비, 높이 및 색상
        public override int Width => FixedChildWidth;
        public override int Height => FixedChildHeight;
        public override Color FillColor => FixedChildColor;
        public override string Type => throw new NotImplementedException();
        // 자식 사각형은 다른 자식 사각형을 추가하지 않음
        public override void AddChildRectangles(int count)
        {
            // Sensor에는 자식이 없으므로 구현하지 않음
        }
        public override void Draw(Graphics g)
        {
            // 내부 색상 채우기
            using (Brush brush = new SolidBrush(FillColor))
            {
                g.FillRectangle(brush, X, Y, Width, Height);
            }
            // 테두리를 그리지 않음
        }
    }
    internal class Interface : CustomRectangle
    {
        private const string FixedType = "Interface";
        private const int FixedWidth = 50;  // Interface의 너비 고정값
        private const int FixedHeight = 50; // Interface의 높이 고정값
        private static readonly Color FixedFillColor = Color.Blue; // Interface의 색상 고정값

        public Interface(int x, int y, int ID) : base(x, y, ID)
        {
            AddChildRectangles(3);
        }

        // Interface 클래스의 너비, 높이 및 색상을 고정
        public override string Type => FixedType;
        public override int Width => FixedWidth;
        public override int Height => FixedHeight;
        public override Color FillColor => FixedFillColor;

        public override void AddChildRectangles(int count)
        {
            
            int spacing = 20; // 자식 사각형 간격

            for (int i = 0; i < count; i++)
            {
                // 자식 사각형의 위치는 부모 사각형의 좌상단을 기준으로 왼쪽에 배치
                int childX = X + BorderWidth;
                int childY = Y + BorderWidth + (i * spacing); // 부모 사각형 아래에 자식 배치

                // 자식 사각형 생성
                var childRectangle = new Sensor(childX, childY);
                Sensor.Add(childRectangle);
            }
        }
    }
}
