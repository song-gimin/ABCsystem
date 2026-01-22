using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCsystem.Teach
{
    public class DiagramEntity  //ROI 정보를 담는 클래스
    {
        //ROI 연결된 InspWindow
        public InspWindow LinkedWindow { get; set; }
        //ROI 영역정보
        public Rectangle EntityROI { get; set; }
        //ROI 표시 칼라
        public Color EntityColor { get; set; }
        //ROI 위치 이동을 하지 못하게 할지 여부
        public bool IsHold { get; set; }

        public DiagramEntity()  //기본 생성자
        {
            LinkedWindow = null;
            EntityROI = new Rectangle(0, 0, 0, 0);
            EntityColor = Color.White;
            IsHold = false;
        }

        public DiagramEntity(Rectangle rect, Color entityColor, bool hold = false)  //매개변수 생성자
        {
            LinkedWindow = null;
            EntityROI = rect;
            EntityColor = entityColor;
            IsHold = hold;
        }
    }
}
